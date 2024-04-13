using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Identity.Models;

namespace Identity.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) { }
        public DbSet<Identity.Models.Client>? Client { get; set; }
        public DbSet<Identity.Models.Reservation>? Reservation { get; set; }
        public DbSet<Identity.Models.Rooms>? Rooms { get; set; }
    }
}