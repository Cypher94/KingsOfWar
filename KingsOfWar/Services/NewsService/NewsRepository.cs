using KingsOfWar.Models;
using System.Collections.Generic;
using System.Linq;

namespace KingsOfWar.Services.NewsService
{
    public class NewsRepository : INewsRepository
    {
        private IEnumerable<News> _articleList;

        public NewsRepository()
        {
            if (_articleList is null)
            {
                Initialize();
            }
        }

        private void Initialize()
        {
            _articleList = new List<News>
            {
                new News
                {
                    Id = 1,
                    Title = "Article 1",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit...",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lectus urna duis convallis convallis tellus id interdum. In mollis nunc sed id semper risus. Eu lobortis elementum nibh tellus. Pulvinar neque laoreet suspendisse interdum consectetur libero id. Volutpat ac tincidunt vitae semper quis lectus nulla at volutpat. Morbi quis commodo odio aenean sed adipiscing. Turpis massa sed elementum tempus egestas sed. Orci porta non pulvinar neque laoreet suspendisse interdum consectetur libero. Condimentum lacinia quis vel eros donec. Proin sed libero enim sed faucibus turpis in."
                },

                new News
                {
                    Id = 2,
                    Title = "Article 2",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit...",
                    Content = "Felis eget nunc lobortis mattis aliquam faucibus purus in. Nam aliquam sem et tortor consequat id porta. Aliquam purus sit amet luctus venenatis. Neque egestas congue quisque egestas diam in arcu. Habitant morbi tristique senectus et. Viverra ipsum nunc aliquet bibendum enim facilisis gravida neque convallis. Lobortis elementum nibh tellus molestie nunc non blandit massa. Est pellentesque elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus. Porttitor massa id neque aliquam vestibulum morbi blandit cursus risus. Lobortis elementum nibh tellus molestie nunc non blandit."
                },

                new News
                {
                    Id = 3,
                    Title = "Article 3",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit...",
                    Content = "Leo urna molestie at elementum eu facilisis sed odio morbi. Accumsan lacus vel facilisis volutpat est velit egestas dui id. Ac placerat vestibulum lectus mauris. Condimentum id venenatis a condimentum vitae sapien. Commodo quis imperdiet massa tincidunt. Accumsan lacus vel facilisis volutpat est velit egestas dui id. Convallis convallis tellus id interdum. Mi eget mauris pharetra et ultrices. Libero nunc consequat interdum varius. Enim nunc faucibus a pellentesque sit amet porttitor eget. Mus mauris vitae ultricies leo integer malesuada nunc. Pretium vulputate sapien nec sagittis. Ultricies mi quis hendrerit dolor magna eget est lorem ipsum. Sem nulla pharetra diam sit amet nisl suscipit. Lobortis feugiat vivamus at augue eget arcu dictum varius duis. Volutpat sed cras ornare arcu dui vivamus arcu felis bibendum."
                },

                new News
                {
                    Id = 4,
                    Title = "Article 4",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit...",
                    Content = "Leo urna molestie at elementum eu facilisis sed odio morbi. Accumsan lacus vel facilisis volutpat est velit egestas dui id. Ac placerat vestibulum lectus mauris. Condimentum id venenatis a condimentum vitae sapien. Commodo quis imperdiet massa tincidunt. Accumsan lacus vel facilisis volutpat est velit egestas dui id. Convallis convallis tellus id interdum. Mi eget mauris pharetra et ultrices. Libero nunc consequat interdum varius. Enim nunc faucibus a pellentesque sit amet porttitor eget. Mus mauris vitae ultricies leo integer malesuada nunc. Pretium vulputate sapien nec sagittis. Ultricies mi quis hendrerit dolor magna eget est lorem ipsum. Sem nulla pharetra diam sit amet nisl suscipit. Lobortis feugiat vivamus at augue eget arcu dictum varius duis. Volutpat sed cras ornare arcu dui vivamus arcu felis bibendum."
                },

                new News
                {
                    Id = 5,
                    Title = "Article 5",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit...",
                    Content = "Leo urna molestie at elementum eu facilisis sed odio morbi. Accumsan lacus vel facilisis volutpat est velit egestas dui id. Ac placerat vestibulum lectus mauris. Condimentum id venenatis a condimentum vitae sapien. Commodo quis imperdiet massa tincidunt. Accumsan lacus vel facilisis volutpat est velit egestas dui id. Convallis convallis tellus id interdum. Mi eget mauris pharetra et ultrices. Libero nunc consequat interdum varius. Enim nunc faucibus a pellentesque sit amet porttitor eget. Mus mauris vitae ultricies leo integer malesuada nunc. Pretium vulputate sapien nec sagittis. Ultricies mi quis hendrerit dolor magna eget est lorem ipsum. Sem nulla pharetra diam sit amet nisl suscipit. Lobortis feugiat vivamus at augue eget arcu dictum varius duis. Volutpat sed cras ornare arcu dui vivamus arcu felis bibendum."
                },

                new News
                {
                    Id = 6,
                    Title = "Article 6",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit...",
                    Content = "Leo urna molestie at elementum eu facilisis sed odio morbi. Accumsan lacus vel facilisis volutpat est velit egestas dui id. Ac placerat vestibulum lectus mauris. Condimentum id venenatis a condimentum vitae sapien. Commodo quis imperdiet massa tincidunt. Accumsan lacus vel facilisis volutpat est velit egestas dui id. Convallis convallis tellus id interdum. Mi eget mauris pharetra et ultrices. Libero nunc consequat interdum varius. Enim nunc faucibus a pellentesque sit amet porttitor eget. Mus mauris vitae ultricies leo integer malesuada nunc. Pretium vulputate sapien nec sagittis. Ultricies mi quis hendrerit dolor magna eget est lorem ipsum. Sem nulla pharetra diam sit amet nisl suscipit. Lobortis feugiat vivamus at augue eget arcu dictum varius duis. Volutpat sed cras ornare arcu dui vivamus arcu felis bibendum."
                }

            };
        }

        public News GetArticle(int id)
        {
            return _articleList.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<News> GetArticles()
        {
            return _articleList;
        }
    }
}
