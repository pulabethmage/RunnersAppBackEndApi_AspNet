using RunnersAppBackEndApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace RunnersAppBackEndApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions option): base(option) { 
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Performance> Performances { get; set; }
    }

    
    
    
}
