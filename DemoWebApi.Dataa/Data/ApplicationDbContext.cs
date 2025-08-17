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

    }
}
