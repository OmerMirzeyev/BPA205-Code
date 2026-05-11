using EF_core_task.DAL;
using EF_core_task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_core_task.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly AppDbContext _db;
        public BrandController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Brand> brands = await _db.Brands.ToListAsync();
            return View(brands);
        }
    }
}
