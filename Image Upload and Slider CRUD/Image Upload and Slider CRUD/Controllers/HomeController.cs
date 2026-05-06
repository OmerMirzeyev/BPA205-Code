using Image_Upload_and_Slider_CRUD.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Image_Upload_and_Slider_CRUD.Controllers
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
            return View();
        }
    }
}
