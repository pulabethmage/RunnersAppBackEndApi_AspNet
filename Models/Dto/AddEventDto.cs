namespace RunnersAppBackEndApi.Models.Dto
{
    public class AddEventDto
    {

        public DateTime event_date { get; set; }
        public string event_location { get; set; }
        public string event_title { get; set; }
        public string event_description { get; set; }


    }
}
