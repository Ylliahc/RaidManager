using Microsoft.Extensions.Options;
using RaidManager.Domain.Exceptions;
using RaidManager.Infrastructure.Configurations;

namespace RaidManager.Infrastructure.Providers
{
    public class QueryProvider
    {
        private readonly QueriesConfiguration _queriesConfiguration;

        public QueryProvider(IOptions<QueriesConfiguration> queriesConfiguration)
        {
            _queriesConfiguration = queriesConfiguration.Value;
        }

        public void LoadAllQueries()
        {
            if(_queriesConfiguration == null)
                throw new System.NullReferenceException("QueriesConfiguration can't be null");
            
            if(string.IsNullOrWhiteSpace(_queriesConfiguration.Folder))
                throw new TechnicalException($"{nameof(QueriesConfiguration)}.{nameof(QueriesConfiguration.Folder)} can't be null or empty.");
        }
    }
}