using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Xml.Linq;

namespace RunnersAppBackEndApi.Models.Entities
{
    public class Profile
    {
        [Key]
        public int profileid { get; set; }
        public string name { get; set; }
        public string nic { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public int performannceid { get; set; }

        public string? profilepic { get; set; }

    }
}
