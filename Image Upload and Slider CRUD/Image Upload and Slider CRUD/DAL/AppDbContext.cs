using Image_Upload_and_Slider_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Image_Upload_and_Slider_CRUD.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
    }
}
