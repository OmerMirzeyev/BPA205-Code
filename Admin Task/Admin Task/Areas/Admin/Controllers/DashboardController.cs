using Microsoft.AspNetCore.Mvc;

namespace Admin_Task.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
