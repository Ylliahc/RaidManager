using Microsoft.Extensions.Logging;
using RaidManager.Domain.Repositories;

namespace RaidManager.Domain.Services
{
    public class AuthenticationService : ServiceBase
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationService(ILogger<AuthenticationService> logger, IUserRepository userRepository) : base(logger)
        {
            _userRepository = userRepository;
        }
    }
}