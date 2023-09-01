using CondorSult_Backend.Models;
using CondorSult_Backend.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace CondorSult_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public AuthenticationController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }


        [HttpPost("Signup")]
        public async Task<ActionResult> RegisterUser(DTOs.UserRegisterDto userRegister)
        {
            var result = await
            _repositoryManager.Authentication.RegisterUser(userRegister);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }

        [HttpPost("login")]
       // [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Authenticate(DTOs.UserAuthDto utilisateur)
       {
           var user = await _repositoryManager.Authentication.ValidateUser(utilisateur);
            if (user == null)
                return Unauthorized();
            var token = await _repositoryManager.Authentication.CreateToken();
            user.token = token;
            return Ok(user);
            
        }

    }


}
