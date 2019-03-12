using OpenQA.Selenium;
using System;

namespace KingsOfWar.Spec.PageObjects
{
    public class Rules
    {
        private const string RulesRelativeUrl = "Rules";

        private readonly IWebDriver _visitorBrowser;

        public string RulesUrl { get; set; }

        public Rules(IWebDriver visitorBrowser, Uri baseUrl)
        {
            _visitorBrowser = visitorBrowser;
            RulesUrl = baseUrl + RulesRelativeUrl;
        }

        public void NavigateToRulesPage()
        {
            _visitorBrowser.Navigate().GoToUrl(RulesUrl);
        }
    }
}
