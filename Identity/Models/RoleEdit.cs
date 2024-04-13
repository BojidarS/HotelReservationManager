using Microsoft.AspNetCore.Identity;

namespace Identity.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public List<AppUser> Members { get; set; }
        public List<AppUser> NonMembers { get; set; }
    }
}
