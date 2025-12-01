using Microsoft.EntityFrameworkCore;

namespace BE_U2_W1_D1.Models.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
}
}
