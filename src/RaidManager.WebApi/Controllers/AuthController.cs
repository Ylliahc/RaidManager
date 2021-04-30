using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaidManager.Domain.Dto.Authentication;

namespace RaidManager.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            return new LoginResponse();
        }
    }
}