using OpenQA.Selenium;
using System;

namespace KingsOfWar.Spec.PageObjects
{
    public class Lore
    {
        private const string LoreRelativeUrl = "Lore";

        private readonly IWebDriver _visitorBrowser;

        public string LoreUrl { get; set; }

        public Lore(IWebDriver visitorBrowser, Uri baseUrl)
        {
            _visitorBrowser = visitorBrowser;
            LoreUrl = baseUrl + LoreRelativeUrl;
        }

        public void NavigateToLorePage()
        {
            _visitorBrowser.Navigate().GoToUrl(LoreUrl);
        }
    }
}
