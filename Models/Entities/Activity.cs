using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace RunnersAppBackEndApi.Models.Entities
{
    public class Activity
    {
        [Key]
        public int activityid { get; set; }
        public int profileid { get; set; }
        public string activity_name { get; set; }
        public string duration_type { get; set; }
        public string duration { get; set; }
        public int eventid { get; set; }
    }
}