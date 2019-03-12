using FluentAssertions;
using OpenQA.Selenium;

namespace KingsOfWar.Spec.PageObjects
{
    public class Navigation
    {
        private readonly IWebDriver _visitorBrowser;

        private const string NavigationBarSelector = "[data-attr-test='navigation']";
        private const string LogoSelector = "[data-attr-test='navigation-logo']";
        private const string HomeBtnSelector = "[data-attr-test='navigation-homeBtn']";
        private const string LoreBtnSelector = "[data-attr-test='navigation-loreBtn']";
        private const string RulesBtnSelector = "[data-attr-test='navigation-rulesBtn']";
        private const string CampaignBtnSelector = "[data-attr-test='navigation-campaignBtn']";
        private const string ArmyBuilderBtnSelector = "[data-attr-test='navigation-armyBuilderBtn']";

        public IWebElement NavigationBarElement { get; set; }
        public IWebElement LogoElement { get; set; }
        public IWebElement HomeBtnElement { get; set; }
        public IWebElement LoreBtnElement { get; set; }
        public IWebElement RulesBtnElement { get; set; }
        public IWebElement CampaignBtnElement { get; set; }
        public IWebElement ArmyBuilderBtnElement { get; set; }

        public Navigation(IWebDriver visitorBrowser)
        {
            _visitorBrowser = visitorBrowser;
        }

        public void FindNavigationElements()
        {
            NavigationBarElement = _visitorBrowser.FindElement(By.CssSelector(NavigationBarSelector));
            LogoElement = _visitorBrowser.FindElement(By.CssSelector(LogoSelector));
            HomeBtnElement = _visitorBrowser.FindElement(By.CssSelector(HomeBtnSelector));
            LoreBtnElement = _visitorBrowser.FindElement(By.CssSelector(LoreBtnSelector));
            RulesBtnElement = _visitorBrowser.FindElement(By.CssSelector(RulesBtnSelector));
            CampaignBtnElement = _visitorBrowser.FindElement(By.CssSelector(CampaignBtnSelector));
            ArmyBuilderBtnElement = _visitorBrowser.FindElement(By.CssSelector(ArmyBuilderBtnSelector));
        }

        public void CheckIfNavigationElementsExist()
        {
            NavigationBarElement.Should().NotBeNull();
            LogoElement.Should().NotBeNull();
            HomeBtnElement.Should().NotBeNull();
            LoreBtnElement.Should().NotBeNull();
            RulesBtnElement.Should().NotBeNull();
            CampaignBtnElement.Should().NotBeNull();
            ArmyBuilderBtnElement.Should().NotBeNull();
        }
    }
}
