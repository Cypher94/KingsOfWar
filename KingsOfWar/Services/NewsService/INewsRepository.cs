using KingsOfWar.Models;
using System.Collections.Generic;

namespace KingsOfWar.Services.NewsService
{
    public interface INewsRepository
    {
        News GetArticle(int id);
        IEnumerable<News> GetArticles();
    }
}
