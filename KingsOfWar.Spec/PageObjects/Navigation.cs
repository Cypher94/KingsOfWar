using FluentAssertions;
using OpenQA.Selenium;

namespace KingsOfWar.Spec.PageObjects
{
    public class Navigation
    {
        private readonly IWebDriver _visitorBrowser;

        private readonly string _navigationBarSelector;
        private readonly string _logoSelector;
        private readonly string _homeBtnSelector;
        private readonly string _loreBtnSelector;
        private readonly string _rulesBtnSelector;
        private readonly string _campaignBtnSelector;
        private readonly string _armyBuilderBtnSelector;

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
            _navigationBarSelector = "[data-attr-test='navigation']";
            _logoSelector = "[data-attr-test='navigation-logo']";
            _homeBtnSelector = "[data-attr-test='navigation-homeBtn']";
            _loreBtnSelector = "[data-attr-test='navigation-loreBtn']";
            _rulesBtnSelector = "[data-attr-test='navigation-rulesBtn']";
            _campaignBtnSelector = "[data-attr-test='navigation-campaignBtn']";
            _armyBuilderBtnSelector = "[data-attr-test='navigation-armyBuilderBtn']";
        }

        public void FindNavigationElements()
        {
            NavigationBarElement = _visitorBrowser.FindElement(By.CssSelector(_navigationBarSelector));
            LogoElement = _visitorBrowser.FindElement(By.CssSelector(_logoSelector));
            HomeBtnElement = _visitorBrowser.FindElement(By.CssSelector(_homeBtnSelector));
            LoreBtnElement = _visitorBrowser.FindElement(By.CssSelector(_loreBtnSelector));
            RulesBtnElement = _visitorBrowser.FindElement(By.CssSelector(_rulesBtnSelector));
            CampaignBtnElement = _visitorBrowser.FindElement(By.CssSelector(_campaignBtnSelector));
            ArmyBuilderBtnElement = _visitorBrowser.FindElement(By.CssSelector(_armyBuilderBtnSelector));
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
