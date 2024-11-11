using Microsoft.EntityFrameworkCore;
using ABC_Retail_POE_3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ABC_Retail_POE_3.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; } 

    }
}
