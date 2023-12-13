using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace wodapi.Models
{
    public class Workout
    {
        [Key]
        public int id { get; set; }
        public string wodCat { get; set; }
        public int styleId { get; set; }
        public int rounds { get; set; }
        public int mpr { get; set; }
        public string r1m1 { get; set; } 
        public string? r1m2 { get; set; } 
        public string? r1m3 { get; set; } 
        public int r1sets { get; set; }
        public int r1move { get; set; }
        public int r1rest { get; set; }
        public string? r2m1 { get; set; } 
        public string? r2m2 { get; set; } 
        public string? r2m3 { get; set; } 
        public int? r2sets { get; set; }
        public int? r2move { get; set; }
        public int? r2rest { get; set; }
        public string? r3m1 { get; set; } 
        public string? r3m2 { get; set; } 
        public string? r3m3 { get; set; } 
        public int? r3sets { get; set; }
        public int? r3move { get; set; }
        public int? r3rest { get; set; }
        public string? r4m1 { get; set; } 
        public string? r4m2 { get; set; }
        public string? r4m3 { get; set; }
        public int? r4sets { get; set; }
        public int? r4move { get; set; }
        public int? r4rest { get; set; }
        public DateTime daDate { get; set; }

    }

    public class Style
    {
        public int styleId { get; set; }
        public string styleName { get; set; }
        public string styleDescription { get; set; }
    }
}
