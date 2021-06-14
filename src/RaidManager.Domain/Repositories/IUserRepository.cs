using System.Threading.Tasks;
using RaidManager.Domain.Dto;

namespace RaidManager.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> CreateAsync(User user);
        Task Delete(User user);
    }
}