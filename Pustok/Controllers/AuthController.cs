using Microsoft.AspNetCore.Mvc;

namespace EF_core_task.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
