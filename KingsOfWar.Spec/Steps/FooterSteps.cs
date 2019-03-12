using FluentAssertions;
using KingsOfWar.Spec.Context;
using KingsOfWar.Spec.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KingsOfWar.Spec.Steps
{
    [Binding]
    public class FooterSteps
    {
        private readonly WebSystem _webSystem;
        private readonly Visitor _visitor;
        private readonly Footer _footer;
        private readonly Home _home;

        private Uri BaseUrl => _webSystem.BaseUrl;

        public IWebDriver VisitorBrowser { get; private set; }

        public FooterSteps(Visitor visitor)
        {
            _webSystem = new WebSystem();
            _visitor = visitor;
            VisitorBrowser = _visitor.Browser();
            _footer = new Footer(VisitorBrowser);
            _home = new Home(VisitorBrowser, BaseUrl);
        }

        #region Background
        [Given(@"I am on a page with Footer")]
        public void GivenIAmOnAPageWithFooter()
        {
            _home.NavigateToHomePage();
            _footer.FindFooterElements();
        }
        #endregion

        #region Footer is displayed
        [Then(@"I should see Footer with following elements:")]
        public void ThenIShouldSeeFooterWithFollowingElements(Table table)
        {
            _footer.CheckIfFooterElementsExist();
        }
        #endregion

        #region Footer is redirecting to forum page
        [When(@"I press Footer Forum Button")]
        public void WhenIPressFooterForumButton()
        {
            _footer.ForumBtnElement.Click();
        }

        [Then(@"I should be redirected to Forum Page")]
        public void ThenIShouldBeRedirectedToForumPage()
        {
            VisitorBrowser.Url.Should().BeEquivalentTo(ExternalPagesLinks.ForumUrl);
        }
        #endregion

        #region Footer is redirecting to help page
        [When(@"I press Footer Help Button")]
        public void WhenIPressFooterHelpButton()
        {
            _footer.HelpBtnElement.Click();
        }

        [Then(@"I should be redirected to Help Page")]
        public void ThenIShouldBeRedirectedToHelpPage()
        {
            VisitorBrowser.Url.Should().BeEquivalentTo(ExternalPagesLinks.HelpUrl);
        }
        #endregion

        #region Footer is redirecting to support page
        [When(@"I press Footer Support Button")]
        public void WhenIPressFooterSupportButton()
        {
            _footer.SupportBtnElement.Click();
        }

        [Then(@"I should be redirected to Support Page")]
        public void ThenIShouldBeRedirectedToSupportPage()
        {
            VisitorBrowser.Url.Should().BeEquivalentTo(ExternalPagesLinks.SupportUrl);
        }
        #endregion

        #region Footer is redirecting to facebook page
        [When(@"I press Footer Facebook Button")]
        public void WhenIPressFooterFacebookButton()
        {
            _footer.FacebookBtnElement.Click();
        }

        [Then(@"I should be redirected to Facebook Page")]
        public void ThenIShouldBeRedirectedToFacebookPage()
        {
            VisitorBrowser.Url.Should().BeEquivalentTo(ExternalPagesLinks.FacebookUrl);
        }
        #endregion
    }
}
