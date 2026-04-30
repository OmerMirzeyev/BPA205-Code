using EF_core_task.Models;
using Microsoft.EntityFrameworkCore;
namespace EF_core_task.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
