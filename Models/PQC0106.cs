using System.ComponentModel.DataAnnotations;
namespace PhuonQuocChien106.Models
{
    public class PQC0106
    {
        [Key]
        [Display (Name ="Mã")]
        public string? PQCId {get; set;} 
        [Display (Name ="Tên")]
        public string? PQCName {get; set;}
        [Display (Name ="Giới tính")]
        public string? PQCGender {get; set;}
        
}
}