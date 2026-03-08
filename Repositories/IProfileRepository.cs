using RunnersAppBackEndApi.Models.Entities;

namespace RunnersAppBackEndApi.Repositories
{
    public interface IProfileRepository
    {
        Task<List<Profile>> GetAllAsync();
        Task<Profile?> GetByIdAsync(int id);
        Task<Profile> AddAsync(Profile profile);
    }
}
