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

        private Uri BaseUrl => _webSystem.BaseUrl;

        public IWebDriver VisitorBrowser { get; private set; }

        public NavigationSteps(Visitor visitor)
        {
            _webSystem = new WebSystem();
            _visitor = visitor;
            VisitorBrowser = _visitor.Browser();
            _navigation = new Navigation(VisitorBrowser);
        }

        [Given(@"I have entered the page with Navigation")]
        public void GivenIHaveEnteredThePageWithNavigation()
        {
            VisitorBrowser.Navigate().GoToUrl(BaseUrl);
            _navigation.Init();
        }

        [When(@"I press Navigation button")]
        public void WhenIPressNavigationButton()
        {
            _navigation.ClickNavigationButton(_navigation.LoreBttElement);
        }

        [Then(@"I should be redirected to other page")]
        public void ThenIShouldBeRedirectedToOtherPage()
        {
            BaseUrl.Should().NotBeSameAs(VisitorBrowser.Url);
        }

        [Then(@"I should see Navigation with following elements:")]
        public void ThenIShouldSeeNavigationWithFollowingElements(Table table)
        {
            _navigation.CheckIfNavigationElementsExist();
        }
    }
}
