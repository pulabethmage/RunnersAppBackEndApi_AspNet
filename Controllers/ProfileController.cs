using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunnersAppBackEndApi.Data;
using RunnersAppBackEndApi.Models.Dto;
using RunnersAppBackEndApi.Models.Entities;
using RunnersAppBackEndApi.Services;

namespace RunnersAppBackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService profileService;

        public ProfileController(IProfileService profileService)
        {
            this.profileService = profileService;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllProfiles()
        {
            var profiles = await profileService.GetAllProfilesAsync();
            return Ok(profiles);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetProfile(int id)
        {
            var profile = await profileService.GetProfileByIdAsync(id);

            if (profile == null)
                return NotFound();

            return Ok(profile);
        }

        [HttpPost]
        public async Task<IActionResult> AddProfile(AddProfileDto dto)
        {
            var profile = await profileService.AddProfileAsync(dto);
            return Ok(profile);
        }
    }
}
