namespace RaidManager.Infrastructure.Configurations
{
    /// <summary>
    /// Model for database configuration
    /// </summary>
    public class DataBaseConfiguration
    {
        /// <summary>
        /// Connection string
        /// </summary>
        /// <value></value>
        public string ConnectionString {get;set;}
        /// <summary>
        /// Queries configuration
        /// </summary>
        /// <value></value>
        public QueriesConfiguration QueriesConfiguration {get;set;}
    }
}