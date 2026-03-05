using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunnersAppBackEndApi.Data;
using RunnersAppBackEndApi.Models.Dto;
using RunnersAppBackEndApi.Models.Entities;

namespace RunnersAppBackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ProfileController(ApplicationDbContext dbContext) { 
           this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllProfiles()
        {
            var allProfiles = dbContext.Profiles.ToList();

            return Ok(allProfiles);

        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetProfile(int id)
        {
            var profile = dbContext.Profiles.Find(id);

            return Ok(profile);
        }

        [HttpPost]
        public IActionResult AddProfile(AddProfileDto addProfileDto)
        {
            var profileEntity = new Profile()
            {
                name = addProfileDto.name,
                nic = addProfileDto.nic,
                phone = addProfileDto.phone,
                email = addProfileDto.email,
                performannceid = addProfileDto.performannceid,
                profilepic = addProfileDto.profilepic

            };


            dbContext.Add(profileEntity);
            dbContext.SaveChanges();
            return Ok(profileEntity);

        }
    }
}
