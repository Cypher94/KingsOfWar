using FluentAssertions;
using KingsOfWar.Spec.Context;
using KingsOfWar.Spec.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KingsOfWar.Spec.Steps
{
    [Binding]
    public class NavigationSteps
    {
        private readonly WebSystem _webSystem;
        private readonly Visitor _visitor;

        private readonly Navigation _navigation;
        private readonly ArmyBuilder _armyBuilder;
        private readonly Campaign _campaign;
        private readonly Home _home;
        private readonly Lore _lore;
        private readonly Rules _rules;

        private Uri BaseUrl => _webSystem.BaseUrl;

        public IWebDriver VisitorBrowser { get; private set; }

        public NavigationSteps(Visitor visitor)
        {
            _webSystem = new WebSystem();
            _visitor = visitor;
            VisitorBrowser = _visitor.Browser();

            _navigation = new Navigation(VisitorBrowser);
            _armyBuilder = new ArmyBuilder(VisitorBrowser, BaseUrl);
            _campaign = new Campaign(VisitorBrowser, BaseUrl);
            _home = new Home(VisitorBrowser, BaseUrl);
            _lore = new Lore(VisitorBrowser, BaseUrl);
            _rules = new Rules(VisitorBrowser, BaseUrl);
        }

        #region Navigation is displayed
        [Given(@"I have entered the page with Navigation")]
        public void GivenIHaveEnteredThePageWithNavigation()
        {
            VisitorBrowser.Navigate().GoToUrl(BaseUrl);
        }

        [Then(@"I should see Navigation with following elements:")]
        public void ThenIShouldSeeNavigationWithFollowingElements(Table table)
        {
            _navigation.FindNavigationElements();
            _navigation.CheckIfNavigationElementsExist();
        }
        #endregion

        #region Navigation is redirecting to home page
        [Given(@"I am on other page than Home")]
        public void GivenIAmOnOtherPageThanHome()
        {
            _armyBuilder.NavigateToArmyBuilderPage();
        }

        [When(@"I press Navigation Home Button")]
        public void WhenIPressNavigationHomeButton()
        {
            _navigation.FindNavigationElements();
            _navigation.HomeBtnElement.Click();
        }

        [Then(@"I should be redirected to Home Page")]
        public void ThenIShouldBeRedirectedToHomePage()
        {
            VisitorBrowser.Url.Should().BeEquivalentTo(_home.HomeUrl);
        }
        #endregion

        #region Navigation is redirecting to lore page
        [Given(@"I am on other page than Lore")]
        public void GivenIAmOnOtherPageThanLore()
        {
            _armyBuilder.NavigateToArmyBuilderPage();
        }

        [When(@"I press Navigation Lore Button")]
        public void WhenIPressNavigationLoreButton()
        {
            _navigation.FindNavigationElements();
            _navigation.LoreBtnElement.Click();
        }

        [Then(@"I should be redirected to Lore Page")]
        public void ThenIShouldBeRedirectedToLorePage()
        {
            VisitorBrowser.Url.Should().BeEquivalentTo(_lore.LoreUrl);
        }
        #endregion

        #region Navigation is redirecting to rules page
        [Given(@"I am on other page than Rules")]
        public void GivenIAmOnOtherPageThanRules()
        {
            _armyBuilder.NavigateToArmyBuilderPage();
        }

        [When(@"I press Navigation Rules Button")]
        public void WhenIPressNavigationRulesButton()
        {
            _navigation.FindNavigationElements();
            _navigation.RulesBtnElement.Click();
        }

        [Then(@"I should be redirected to Rules Page")]
        public void ThenIShouldBeRedirectedToRulesPage()
        {
            VisitorBrowser.Url.Should().BeEquivalentTo(_rules.RulesUrl);
        }
        #endregion

        #region Navigation is redirecting to campaign page
        [Given(@"I am on other page than Campaign")]
        public void GivenIAmOnOtherPageThanCampaign()
        {
            _armyBuilder.NavigateToArmyBuilderPage();
        }

        [When(@"I press Navigation Campaign Button")]
        public void WhenIPressNavigationCampaignButton()
        {
            _navigation.FindNavigationElements();
            _navigation.CampaignBtnElement.Click();
        }

        [Then(@"I should be redirected to Campaign Page")]
        public void ThenIShouldBeRedirectedToCampaignPage()
        {
            VisitorBrowser.Url.Should().BeEquivalentTo(_campaign.CampaignUrl);
        }
        #endregion

        #region Navigation is redirecting to army builder page
        [Given(@"I am on other page than Army Builder")]
        public void GivenIAmOnOtherPageThanArmyBuilder()
        {
            _home.NavigateToHomePage();
        }

        [When(@"I press Navigation Army Builder Button")]
        public void WhenIPressNavigationArmyBuilderButton()
        {
            _navigation.FindNavigationElements();
            _navigation.ArmyBuilderBtnElement.Click();
        }

        [Then(@"I should be redirected to Army Builder Page")]
        public void ThenIShouldBeRedirectedToArmyBuilderPage()
        {
            VisitorBrowser.Url.Should().BeEquivalentTo(_armyBuilder.ArmyBuilderUrl);
        }
        #endregion
    }
}
