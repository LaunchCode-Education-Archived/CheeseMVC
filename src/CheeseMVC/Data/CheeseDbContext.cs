using Microsoft.EntityFrameworkCore;
using CheeseMVC.Models;

namespace CheeseMVC.Data
{
    public class CheeseDbContext : DbContext
    {

        public DbSet<Cheese> Cheeses { get; set; }
        public DbSet<CheeseCategory> Categories { get; set; }

        public CheeseDbContext(DbContextOptions<CheeseDbContext> options) : base(options)
        {
        }
    }
}
