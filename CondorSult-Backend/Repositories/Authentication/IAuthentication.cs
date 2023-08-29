using CondorSult_Backend.Models;
using Microsoft.AspNetCore.Identity;

namespace CondorSult_Backend.Repositories
{
    public interface IAuthentication
    {
        Task<IdentityResult> RegisterUser(DTOs.UserRegisterDto userForRegistration);
        Task<DTOs.UserToSend?> ValidateUser(DTOs.UserAuthDto userAuth);
        Task<string> CreateToken();
    }
}
