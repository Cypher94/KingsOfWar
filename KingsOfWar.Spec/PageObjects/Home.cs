using OpenQA.Selenium;
using System;

namespace KingsOfWar.Spec.PageObjects
{
    public class Home
    {
        private readonly IWebDriver _visitorBrowser;

        public string HomeUrl { get; set; }

        public Home(IWebDriver visitorBrowser, Uri baseUrl)
        {
            _visitorBrowser = visitorBrowser;
            HomeUrl = baseUrl.ToString();
        }

        public void NavigateToHomePage()
        {
            _visitorBrowser.Navigate().GoToUrl(HomeUrl);
        }
    }
}
