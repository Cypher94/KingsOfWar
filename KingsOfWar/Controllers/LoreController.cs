using Microsoft.AspNetCore.Mvc;

namespace KingsOfWar.Controllers
{
    public class LoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
