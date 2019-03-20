using KingsOfWar.Spec.Context;
using KingsOfWar.Spec.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KingsOfWar.Spec.Steps
{
    [Binding]
    public class HomePageSteps
    {
        private readonly WebSystem _webSystem;
        private readonly Visitor _visitor;

        private readonly Home _home;

        private Uri BaseUrl => _webSystem.BaseUrl;

        public IWebDriver VisitorBrowser { get; set; }

        public HomePageSteps(Visitor visitor)
        {
            _webSystem = new WebSystem();
            _visitor = visitor;
            VisitorBrowser = _visitor.Browser();

            _home = new Home(VisitorBrowser, BaseUrl);
        }

        #region Background
        [Given(@"I am on Home Page")]
        public void GivenIAmOnHomePage()
        {
            _home.NavigateToHomePage();
        }
        #endregion

        #region Home Page is displayed correctly
        [Then(@"I should see following elements displayed")]
        public void ThenIShouldSeeFollowingElementsDisplayed(Table table)
        {
            _home.FindHomePageElements();
            _home.CheckIfHomePageElementsExist();
        }
        #endregion

        #region Articles are displayed correctly
        [Then(@"I should see Articles with following elements displayed")]
        public void ThenIShouldSeeArticlesWithFollowingElementsDisplayed(Table table)
        {
            _home.FindArticleElements();
            _home.CheckIfArticleElementsExist();
        }
        #endregion
    }
}
