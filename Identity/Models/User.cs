using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondaryName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EGN {  get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string NominationDate { get; set; }
        
        public bool IsAccountActive { get; set; }

        public string? DismissalDate { get; set; }

    }
}
