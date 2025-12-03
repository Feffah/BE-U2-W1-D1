using Microsoft.EntityFrameworkCore;

namespace BE_U2_W1_D1.Models.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Prestito> Prestiti { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prestito>()
                .HasKey(p => new { p.ProductId, p.UserId });
            modelBuilder.Entity<Prestito>()
                .HasOne(p => p.Product)
                .WithMany()
                .HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<Prestito>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId);
        }
    }
}
