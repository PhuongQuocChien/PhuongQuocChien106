using System.ComponentModel.DataAnnotations;
namespace PhuonQuocChien106.Models
{
    public class PQC0106
    {
        [Key]
        public string? PQCId {get; set;} 
        public string? PQCName {get; set;}
        public string? PQCGender {get; set;}
        
}
}