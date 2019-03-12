using OpenQA.Selenium;
using System;

namespace KingsOfWar.Spec.PageObjects
{
    public class Campaign
    {
        private const string CampaignRelativeUrl = "Campaign";

        private readonly IWebDriver _visitorBrowser;

        public string CampaignUrl { get; set; }

        public Campaign(IWebDriver visitorBrowser, Uri baseUrl)
        {
            _visitorBrowser = visitorBrowser;
            CampaignUrl = baseUrl + CampaignRelativeUrl;
        }

        public void NavigateToCampaignPage()
        {
            _visitorBrowser.Navigate().GoToUrl(CampaignUrl);
        }
    }
}
