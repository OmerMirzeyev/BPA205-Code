using Details_Page_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace Details_Page_Task.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }



        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}

