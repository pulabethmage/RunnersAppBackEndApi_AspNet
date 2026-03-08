using RunnersAppBackEndApi.Models.Dto;
using RunnersAppBackEndApi.Models.Entities;
using RunnersAppBackEndApi.Repositories;

namespace RunnersAppBackEndApi.Services
{
    public class ProfileService : IProfileService
    {

        private readonly IProfileRepository repository;

        public ProfileService(IProfileRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<Profile>> GetAllProfilesAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Profile?> GetProfileByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task<Profile> AddProfileAsync(AddProfileDto dto)
        {
            var profile = new Profile
            {
                name = dto.name,
                nic = dto.nic,
                phone = dto.phone,
                email = dto.email,
                performannceid = dto.performannceid,
                profilepic = dto.profilepic
            };

            return await repository.AddAsync(profile);
        }

    }
}
