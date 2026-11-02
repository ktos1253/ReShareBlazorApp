using Microsoft.EntityFrameworkCore;

namespace ReShareBlazorApp.Date
{
    public class ReshareDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ReshareDbContext(DbContextOptions<ReshareDbContext> options)
            : base(options)
        {
        }
    }
}
