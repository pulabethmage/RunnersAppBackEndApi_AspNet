using System.ComponentModel.DataAnnotations;

namespace RunnersAppBackEndApi.Models.Entities
{
    public class Performance
    {
        [Key]
        public int performannceid { get; set; }
        public string vo2max { get; set; }
    }
}
