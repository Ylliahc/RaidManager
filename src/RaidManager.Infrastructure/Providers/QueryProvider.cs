using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Options;
using RaidManager.Domain.Exceptions;
using RaidManager.Infrastructure.Configurations;

namespace RaidManager.Infrastructure.Providers
{
    /// <summary>
    /// Provide queries
    /// </summary>
    public class QueryProvider : IQueryProvider
    {
        /// <summary>
        /// Configuration for queries
        /// </summary>
        private readonly QueriesConfiguration _queriesConfiguration;
        /// <summary>
        /// Queries
        /// </summary>
        private Dictionary<string,string> _queries;

        public QueryProvider(IOptions<QueriesConfiguration> queriesConfiguration)
        {
            _queriesConfiguration = queriesConfiguration.Value;
            _queries = new Dictionary<string, string>();
            LoadAllQueries();
        }

        public void LoadAllQueries()
        {
            if(_queriesConfiguration == null)
                throw new System.NullReferenceException("QueriesConfiguration can't be null");
            
            if(string.IsNullOrWhiteSpace(_queriesConfiguration.Folder))
                throw new TechnicalException($"{nameof(QueriesConfiguration)}.{nameof(QueriesConfiguration.Folder)} can't be null or empty.");
            
            if(!Directory.Exists(_queriesConfiguration.Folder))
                throw new TechnicalException($"{nameof(QueriesConfiguration.Folder)} does not exist.");

            foreach(var fileFullName in Directory.GetFiles(_queriesConfiguration.Folder, $"*.{Constants.Files.SqlExtension}", SearchOption.AllDirectories))
            {
                var file = new FileInfo(fileFullName);
                var query = File.ReadAllText(fileFullName);
                _queries.Add(file.Name, query);
            }
        }

        /// <summary>
        /// Get the query by the query name
        /// </summary>
        /// <param name="queryName">Query name</param>
        /// <returns></returns>
        public string GetQuery(string queryName)
        {
            return _queries[queryName];
        }
    }
}