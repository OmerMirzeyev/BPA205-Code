using EF_core_task.DAL;
using EF_core_task.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_core_task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public IActionResult Index()
        {

            List<Product> products = _db.Products
                .Where<Product>(p => !p.IsDeleted)
                .ToList();

            return View(products);

        }
    }
}
