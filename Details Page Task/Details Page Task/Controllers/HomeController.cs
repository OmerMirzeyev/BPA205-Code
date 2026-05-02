using Details_Page_Task.DAL;
using Details_Page_Task.Models;
using Details_Page_Task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Details_Page_Task.Controllers
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

            List<Product> products = _db.Products.ToList();
            List<Slider> sliders = _db.Sliders.ToList();
            HomeVM vm = new HomeVM
            {
                Products = _db.Products.ToList(),
                Sliders = _db.Sliders.ToList()
            };
            return View(vm);
        }
    

            public IActionResult Details(int id)
        {
            var product = _db.Products
                .Include(x => x.Reviews)
                .FirstOrDefault(x => x.Id == id);

            return View(product);
        }
    }
}