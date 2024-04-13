using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class Login
    {
        

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        
        public string ReturnUrl { get; set; }

        public bool Remember { get; set; }
    }
}
