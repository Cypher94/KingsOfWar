using KingsOfWar.Services.NewsService;
using Microsoft.AspNetCore.Mvc;

namespace KingsOfWar.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsRepository _newsRepository;

        public HomeController(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public IActionResult Index()
        {
            var articleList = _newsRepository.GetArticles();
            return View(articleList);
        }

        public IActionResult ArticleDetails(int id)
        {
            var article = _newsRepository.GetArticle(id);
            return View(article);
        }
    }
}
