using Microsoft.Extensions.Logging;

namespace RaidManager.Domain.Services
{
    public class ServiceBase
    {
        protected ILogger<ServiceBase> _logger {get;set;}
        public ServiceBase(ILogger<ServiceBase> logger)
        {
            _logger = logger;
        }
    }
}