using Microsoft.AspNetCore.Mvc;

namespace KingsOfWar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}