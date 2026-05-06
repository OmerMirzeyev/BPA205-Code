using Microsoft.EntityFrameworkCore;
using Simulation_2.Models;

namespace Simulation_2.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Slider> Sliders { get; set; }
    }
}
