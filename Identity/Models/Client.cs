using System.ComponentModel.DataAnnotations;
namespace Identity.Models
{
    public class Client
    {
        [Required]
        public string FirstName { get; set; }
        [Required] 
        public string LastName { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool IsOfAge { get; set; }
    }
}
