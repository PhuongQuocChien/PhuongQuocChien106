using System.ComponentModel.DataAnnotations;
namespace PhuonQuocChien106.Models
{
    public class UniversityPQC106
    {
        [Key]
        public string? UniversityId {get; set;} 
        public string? UniversityName {get; set;}
        
}
}