using EF_Core_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Task.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext   > options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
