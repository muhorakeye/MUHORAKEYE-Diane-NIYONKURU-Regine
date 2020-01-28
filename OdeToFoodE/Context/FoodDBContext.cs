using Microsoft.EntityFrameworkCore;
using OdeToFoodE.Models;

namespace OdeToFoodE.Context
{
    public class FoodDbContext : DbContext
    {

        public DbSet<Food> Foods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=FoodServer.db");
        }
    }
}