using System.ComponentModel.DataAnnotations;

namespace wodapi.Models
{
    public class Exercise
    {
        [Key]
        public int exeId { get; set; }
        public string exeName { get; set; }
        public string VideoUrl { get; set; }
        public string MobileUrl { get; set; }
    }
}
