using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PronionSimulation.DAL;
using PronionSimulation.Models;
using PronionSimulation.ViewModels;

namespace PronionSimulation.Controllers
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
            List<Slider> sliders = _db.Sliders.ToList();
            List<Product> products = _db.Products
                .Include(p => p.Images)
                .ToList();

            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                Products = products
            };

            return View(homeVM);
        }
        public IActionResult Details(int id)
        {
            Product singleProduct = _db.Products
                .Include(p => p.Images)
                .Include(p => p.Reviews)
                .Include(p => p.Categories)
                .Include(p => p.Tags)
                .FirstOrDefault(p => p.Id == id);
            return View(singleProduct);
        }
    }
}
