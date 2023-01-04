using System.ComponentModel.DataAnnotations;
namespace PhuonQuocChien106.Models
{
    public class UniversityPQC106
    {
        [Key]
        [Display (Name ="Mã")]
        public string? UniversityId {get; set;} 
        [Display (Name ="Tên")]
        public string? UniversityName {get; set;}
        
}
}