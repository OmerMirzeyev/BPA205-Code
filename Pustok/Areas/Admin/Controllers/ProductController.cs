using EF_core_task.DAL;
using EF_core_task.Models;
using EF_core_task.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;

namespace EF_core_task.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public ProductController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
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
            if (!product.ImageFile.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("ImageFile", "File must be image...");
                return View();
            }
            if (!(product.ImageFile.Length < 2 * 1024 * 1024))
            {
                ModelState.AddModelError("ImageFile", "File size must be less than 2MB...");
                return View();
            }
            product.Image = product.ImageFile.SaveImage(_env, "uploads/products");
            if (!ModelState.IsValid) return View();

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
        public IActionResult Delete(int? id)
        {
            Product product = _db.Products.Find(id);
            product.IsDeleted = true;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Restore(int? id)
        {
            Product product = _db.Products.Find(id);
            product.IsDeleted = false;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            Product product = _db.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            Product oldProduct = _db.Products.Find(product.Id);
            oldProduct.Title = product.Title;
            oldProduct.Price = product.Price;
            oldProduct.Image = product.Image;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}