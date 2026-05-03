using Admin_Task.DAL;
using Admin_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Product> products = _db.Products
                .Where(p => !p.IsDeleted)
                .ToList();

            return View(products);
        }
    }
}
