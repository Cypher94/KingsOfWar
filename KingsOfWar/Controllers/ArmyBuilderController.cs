using Microsoft.AspNetCore.Mvc;

namespace KingsOfWar.Controllers
{
    public class ArmyBuilderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
