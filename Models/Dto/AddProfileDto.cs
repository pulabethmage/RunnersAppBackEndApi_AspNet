namespace RunnersAppBackEndApi.Models.Dto
{
    public class AddProfileDto
    {
        public string name { get; set; }
        public string nic { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public int performannceid { get; set; }
        public string? profilepic { get; set; }
    }
}
