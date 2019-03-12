using OpenQA.Selenium;
using System;

namespace KingsOfWar.Spec.PageObjects
{
    public class ArmyBuilder
    {
        private const string ArmyBuilderRelativeUrl = "ArmyBuilder";

        private readonly IWebDriver _visitorBrowser;

        public string ArmyBuilderUrl { get; set; }

        public ArmyBuilder(IWebDriver visitorBrowser, Uri baseUrl)
        {
            _visitorBrowser = visitorBrowser;
            ArmyBuilderUrl = baseUrl + ArmyBuilderRelativeUrl;
        }

        public void NavigateToArmyBuilderPage()
        {
            _visitorBrowser.Navigate().GoToUrl(ArmyBuilderUrl);
        }
    }
}
