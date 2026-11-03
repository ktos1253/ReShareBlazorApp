using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ReShareBlazorApp.Date
{
    public class ReshareDbContext : IdentityDbContext<User,IdentityRole<int>,int>
    {
        public DbSet<User> Users { get; set; }
        public ReshareDbContext(DbContextOptions<ReshareDbContext> options)
            : base(options)
        {
        }
    }
}
