using DemoWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWebApi.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Dog Food", Price = 10.99m, Stock = 100 },
                new Product { Id = 2, Name = "Cat Toy", Price = 5.99m, Stock = 50 },
                new Product { Id = 3, Name = "Bird Cage", Price = 25.99m, Stock = 20 }
            );
        }
    }
}
