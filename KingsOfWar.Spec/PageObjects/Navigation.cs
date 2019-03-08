using FluentAssertions;
using OpenQA.Selenium;

namespace KingsOfWar.Spec.PageObjects
{
    public class Navigation
    {
        private readonly IWebDriver _visitorBrowser;

        private readonly string _navigationBarSelector;
        private readonly string _logoSelector;
        private readonly string _homeBttSelector;
        private readonly string _loreBttSelector;
        private readonly string _rulesBttSelector;
        private readonly string _campaignBttSelector;
        private readonly string _armyBuilderBttSelector;

        public IWebElement NavigationBarElement { get; set; }
        public IWebElement LogoElement { get; set; }
        public IWebElement HomeBttElement { get; set; }
        public IWebElement LoreBttElement { get; set; }
        public IWebElement RulesBttElement { get; set; }
        public IWebElement CampaignBttElement { get; set; }
        public IWebElement ArmyBuilderBttElement { get; set; }

        public Navigation(IWebDriver visitorBrowser)
        {
            _visitorBrowser = visitorBrowser;
            _navigationBarSelector = "[data-attr-test='navigation']";
            _logoSelector = "[data-attr-test='navigation-logo']";
            _homeBttSelector = "[data-attr-test='navigation-homeBtt']";
            _loreBttSelector = "[data-attr-test='navigation-loreBtt']";
            _rulesBttSelector = "[data-attr-test='navigation-rulesBtt']";
            _campaignBttSelector = "[data-attr-test='navigation-campaignBtt']";
            _armyBuilderBttSelector = "[data-attr-test='navigation-armyBuilderBtt']";
        }

        public void Init()
        {
            NavigationBarElement = _visitorBrowser.FindElement(By.CssSelector(_navigationBarSelector));
            LogoElement = _visitorBrowser.FindElement(By.CssSelector(_logoSelector));
            HomeBttElement = _visitorBrowser.FindElement(By.CssSelector(_homeBttSelector));
            LoreBttElement = _visitorBrowser.FindElement(By.CssSelector(_loreBttSelector));
            RulesBttElement = _visitorBrowser.FindElement(By.CssSelector(_rulesBttSelector));
            CampaignBttElement = _visitorBrowser.FindElement(By.CssSelector(_campaignBttSelector));
            ArmyBuilderBttElement = _visitorBrowser.FindElement(By.CssSelector(_armyBuilderBttSelector));
        }

        public void CheckIfNavigationElementsExist()
        {
            NavigationBarElement.Should().NotBeNull();
            LogoElement.Should().NotBeNull();
            HomeBttElement.Should().NotBeNull();
            LoreBttElement.Should().NotBeNull();
            RulesBttElement.Should().NotBeNull();
            CampaignBttElement.Should().NotBeNull();
            ArmyBuilderBttElement.Should().NotBeNull();
        }

        public void ClickNavigationButton(IWebElement button)
        {
            button.Click();
        }

    }
}
