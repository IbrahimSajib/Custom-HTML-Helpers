using Microsoft.AspNetCore.Mvc;

namespace Project_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
