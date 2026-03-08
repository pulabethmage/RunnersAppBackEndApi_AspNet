using RunnersAppBackEndApi.Models.Dto;
using RunnersAppBackEndApi.Models.Entities;

namespace RunnersAppBackEndApi.Services
{
    public interface IProfileService
    {
        Task<List<Profile>> GetAllProfilesAsync();
        Task<Profile?> GetProfileByIdAsync(int id);
        Task<Profile> AddProfileAsync(AddProfileDto dto);
    }
}
