using Microsoft.AspNetCore.Mvc;
using Simulation_2.DAL;
using Simulation_2.Models;
using Simulation_2.Utilities.Extension;

namespace Simulation_2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _db.Sliders
                .ToList();
            return View(sliders);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            if(slider.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "");
                return View(slider);
            }
            if (!slider.ImageFile.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("ImageFile", "File mus be an image");
                return View();
            }

            if (!(slider.ImageFile.Length < 2 * 1024 * 1024))
            {
                ModelState.AddModelError("ImageFile", "File size must be maximum 2 MB.");
                return View();
            }

            
            slider.ImageUrl = slider.ImageFile.SaveImage(_env, "uploads/sliders");

            if(!ModelState.IsValid)    return View();
            _db.Sliders.Add(slider);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Slider slider = _db.Sliders.Find(id);
            slider.IsDeleted = true;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Restore(int id)
        {
            Slider slider = _db.Sliders.Find(id);
            slider.IsDeleted = false;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            Slider slider = _db.Sliders.Find(id);
            return View(slider);
        }
        [HttpPost]
        public IActionResult Update(Slider slider)
        {
            if (!ModelState.IsValid) return View(slider);



            Slider OldSlider = _db.Sliders.Find(slider.Id);
            OldSlider.Title = slider.Title;
            OldSlider.ImageUrl = slider.ImageUrl;
            OldSlider.Description = slider.Description;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}



