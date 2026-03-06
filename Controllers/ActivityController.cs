using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunnersAppBackEndApi.Data;
using RunnersAppBackEndApi.Models.Dto;
using RunnersAppBackEndApi.Models.Entities;

namespace RunnersAppBackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ActivityController(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }



        [HttpPost]
        public IActionResult AddActivity(AddActivityDto addActivityDto) {

            var activityEntity = new Activity()
            {
                profileid = addActivityDto.profileid,
                activity_name = addActivityDto.activity_name,
                duration_type = addActivityDto.duration_type,
                duration = addActivityDto.duration,
                eventid = addActivityDto.eventid

            };

            dbContext.Activities.Add(activityEntity);
            dbContext.SaveChanges();

            return Ok(activityEntity);
        }

        [HttpGet]
        public IActionResult GetAllActivities() {

            var allActivities = dbContext.Activities.ToList();

            return Ok(allActivities);
        }




    }
}
