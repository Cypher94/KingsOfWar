using Microsoft.AspNetCore.Mvc;

namespace KingsOfWar.Controllers
{
    public class CampaignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
