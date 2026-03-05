using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace RunnersAppBackEndApi.Models.Entities
{
    public class Event
    {
        [Key]
        public int eventid { get; set; }
        public DateTime event_date { get; set; }
        public string event_location { get; set; }
        public string event_title { get; set; }
        public string event_description { get; set; }
    }
}
