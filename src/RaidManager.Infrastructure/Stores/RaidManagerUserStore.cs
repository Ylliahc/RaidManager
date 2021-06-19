using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RaidManager.Domain.Dto;
using Dapper;
using Microsoft.Extensions.Options;
using RaidManager.Infrastructure.Configurations;
using RaidManager.Infrastructure.Providers;
using System.Data.SqlClient;
using RaidManager.Domain.Exceptions;

namespace RaidManager.Infrastructure.Stores
{
    /// <summary>
    /// User store for RaidManager
    /// </summary>
    public class RaidManagerUserStore : IUserStore<User>
    {
        private readonly IQueryProvider _queryProvider;
        private readonly UserQueriesConfiguration _userQueriesConfiguration;
        private readonly DataBaseConfiguration _databaseConfiguration;

        public RaidManagerUserStore(
            IQueryProvider queryProvider,
            IOptions<UserQueriesConfiguration> userQueriesConfiguration,
            IOptions<DataBaseConfiguration> databaseConfiguration)
        {
            _queryProvider = queryProvider;
            _userQueriesConfiguration = userQueriesConfiguration.Value;
            _databaseConfiguration = databaseConfiguration.Value;
        }

        public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
        {
            var query = _queryProvider.GetQuery(_userQueriesConfiguration.InsertQuery);
            
            using(var connection = new SqlConnection(_databaseConfiguration.ConnectionString))
            {
                await connection.QueryAsync<User>(query, user);
            }

            return IdentityResult.Success;
        }

        public Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken) 
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            var query = _queryProvider.GetQuery(_userQueriesConfiguration.FindByIdQuery);
            
            using(var connexion = new SqlConnection(_databaseConfiguration.ConnectionString))
            {
                return await connexion.QueryFirstOrDefaultAsync<User>(query, new {Id = userId});
            }
        }

        public Task<User> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}