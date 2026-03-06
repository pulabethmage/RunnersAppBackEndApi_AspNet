namespace RunnersAppBackEndApi.Models.Dto
{
    public class AddActivityDto
    {
        public int profileid { get; set; }
        public string activity_name { get; set; }
        public string duration_type { get; set; }
        public string duration { get; set; }
        public int eventid { get; set; }
    }
}
