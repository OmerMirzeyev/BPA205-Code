using EF_core_task.DAL;
using EF_core_task.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_core_task.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Product> products = _db.Products.ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        //[HttpPost]
        //public IActionResult Create(int? id)
        //{
        //    Product product = _db.Products.Find(id);
        //    _db.Products.Remove(product);
        //    _db.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}
        [HttpPost]
        public IActionResult Create(int? id)
        {
            Product product = _db.Products.Find(id);
            product.IsDeleted = true;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Create(int? id)
        {
            Product product = _db.Products.Find(id);
            product.IsDeleted = false;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
    }
}
