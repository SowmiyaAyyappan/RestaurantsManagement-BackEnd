using Microsoft.EntityFrameworkCore;
using RestaurantsManagement.Models;

namespace RestaurantsManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
