using Microsoft.AspNetCore.Mvc;

namespace KingsOfWar.Controllers
{
    public class RulesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
