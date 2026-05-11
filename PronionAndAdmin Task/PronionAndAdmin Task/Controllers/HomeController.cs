using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PronionAndAdmin_Task.DAL;
using PronionAndAdmin_Task.Models;

namespace PronionAndAdmin_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task<IActionResult> Index()
        {

            List<Product> products = await _db.Products
                .Where(p => !p.IsDeleted)
                .Include(p => p.Categories)
                .Include(p => p.Tags)
                .Include(p => p.Reviews)
                .ToListAsync();
            return View(products);
        }


        public async Task<IActionResult> Details(int id)
        {
            Product product = await _db.Products
                .Include(p => p.Categories)
                .Include(p => p.Tags)
                .Include(p => p.Reviews)
                .FirstOrDefaultAsync(p => p.Id == id);

            return View(product);
        }
    }
}
