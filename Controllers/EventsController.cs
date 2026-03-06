using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunnersAppBackEndApi.Data;
using RunnersAppBackEndApi.Models.Dto;
using RunnersAppBackEndApi.Models.Entities;

namespace RunnersAppBackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EventsController(ApplicationDbContext dbContext) 
        {            
             this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetAllEvents() { 

            var allevents = dbContext.Events.ToList();

            return Ok(allevents);
        }


        [HttpPost]
        public IActionResult AddEvent(AddEventDto addEventDto)
        {
            var eventEntity = new Event()
            {
                event_date = addEventDto.event_date,
                event_location = addEventDto.event_location,
                event_title = addEventDto.event_title,
                event_description = addEventDto.event_description
            };

            dbContext.Events.Add(eventEntity);
            dbContext.SaveChanges();

            return Ok(eventEntity);
        }
    }
}
