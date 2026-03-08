using Microsoft.EntityFrameworkCore;
using RunnersAppBackEndApi.Data;
using RunnersAppBackEndApi.Models.Entities;

namespace RunnersAppBackEndApi.Repositories
{
    public class ProfileRepository : IProfileRepository
    {

        private readonly ApplicationDbContext dbContext;

        public ProfileRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Profile>> GetAllAsync()
        {
            return await dbContext.Profiles.ToListAsync();
        }

        public async Task<Profile?> GetByIdAsync(int id)
        {
            return await dbContext.Profiles.FindAsync(id);
        }

        public async Task<Profile> AddAsync(Profile profile)
        {
            await dbContext.Profiles.AddAsync(profile);
            await dbContext.SaveChangesAsync();
            return profile;
        }

    }
}
