using Microsoft.AspNetCore.Mvc;

namespace MVC_Intro_Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
