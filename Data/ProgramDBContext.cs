using ASPCoreMVCWithLogin.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreMVCWithLogin.Data
{
    public class ProgramDbContext : DbContext
    {
        public ProgramDbContext(DbContextOptions<ProgramDbContext> options)
            : base(options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().ToTable("Supplier");
            modelBuilder.Entity<Supplier>().HasData(new Supplier
            { Id = 1, Name = "Alpha Corp", Address = "Taguig", Email = "alpha@mail.com", IsActive = true });
            modelBuilder.Entity<Supplier>().HasData(new Supplier
            { Id = 2, Name = "Beta Corp", Address = "Pasig", Email = "beta@mail.com", IsActive = true });
        }
    }
}
