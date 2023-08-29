using Microsoft.AspNetCore.Identity;
using CondorSult_Backend.Models;
using System.Xml.Linq;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;

namespace CondorSult_Backend.Repositories
{
    public class Authentication :IAuthentication
    {
       
        private readonly UserManager<Utilisateur> _userManager;
        private readonly IConfiguration _configuration;
        private Utilisateur? _utilisateur;

        public Authentication(UserManager<Utilisateur> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        

        public async Task<IdentityResult> RegisterUser(DTOs.UserRegisterDto userRegister)
        {
            var user = new Utilisateur { 
              UserName = userRegister.UserName,
              Email = userRegister.Email,
              PhoneNumber = userRegister.PhoneNumber,
              Addresse = userRegister.Addresse,
              AnneeNaissance = userRegister.AnneeNaissance,
            };
            
            var result = await _userManager.CreateAsync(user,userRegister.Password);
            if (result.Succeeded)
                await _userManager.AddToRolesAsync(user, userRegister.Roles);

            return result;
        }

        public async Task<DTOs.UserToSend?> ValidateUser(DTOs.UserAuthDto userAuth)
        {
            _utilisateur = await _userManager.FindByNameAsync(userAuth.UserName);
            var result = (_utilisateur != null && await _userManager.CheckPasswordAsync(_utilisateur,userAuth.Password));
            // if (!result)
            //_logger.LogWarn($"{nameof(ValidateUser)}: Authentication failed. Wrong username or password.");
            
            var user = new DTOs.UserToSend
            {
                userId = _utilisateur.Id, userName = _utilisateur.UserName, token = "",
                roles = await _userManager.GetRolesAsync(_utilisateur)
            };
            return result ? user : null;
        }

        public async Task<string> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        private static SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET_KEY"));
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }


        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _utilisateur.UserName)
            };
            var roles = await _userManager.GetRolesAsync(_utilisateur);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }


        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials,List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var tokenOptions = new JwtSecurityToken
            (
            issuer: jwtSettings["validIssuer"],
            audience: jwtSettings["validAudience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])),
            signingCredentials: signingCredentials
            );
            return tokenOptions;
        }

    }
}
