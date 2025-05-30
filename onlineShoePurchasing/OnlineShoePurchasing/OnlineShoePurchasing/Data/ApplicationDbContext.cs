using Microsoft.EntityFrameworkCore;
using OnlineShoePurchasing.Models;

namespace OnlineShoePurchasing.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Logdetails> logindetails { get; set; }
        public DbSet<shoeorderDtl> Shoesdetails { get; set; }
        public DbSet<shoeorderDtl> shoeorderDetails { get; set; }

    }
}
