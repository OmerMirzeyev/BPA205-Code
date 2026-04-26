using Microsoft.AspNetCore.Mvc;

namespace MVC_Intro_Task.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
