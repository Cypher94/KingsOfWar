using FluentAssertions;
using OpenQA.Selenium;
using System;

namespace KingsOfWar.Spec.PageObjects
{
    public class Home
    {
        private readonly IWebDriver _visitorBrowser;

        private const string NavigationBarSelector = "[data-attr-test='navigation']";
        private const string AboutSectionSelector = "[data-attr-test='homePage-aboutSection']";
        private const string GameInfoSectionSelector = "[data-attr-test='homePage-gameInfoSection']";
        private const string ArticlesSectionSelector = "[data-attr-test='homePage-articlesSection']";
        private const string ArticleTitleSelector = "[data-attr-test='homePage-articlesSection-articleTitle']";
        private const string ArticleDescriptionSelector = "[data-attr-test='homePage-articlesSection-articleDescription']";
        private const string ArticleReadMoreSelector = "[data-attr-test='homePage-articlesSection-articleReadMore']";
        private const string FooterBarSelector = "[data-attr-test='footer']";

        public IWebElement NavigationBarElement { get; set; }
        public IWebElement AboutSectionElement { get; set; }
        public IWebElement GameInfoSectionElement { get; set; }
        public IWebElement ArticlesSectionElement { get; set; }
        public IWebElement ArticleTitleElement { get; set; }
        public IWebElement ArticleDescriptionElement { get; set; }
        public IWebElement ArticleReadMoreElement { get; set; }
        public IWebElement FooterBarElement { get; set; }

        public string HomeUrl { get; set; }

        public Home(IWebDriver visitorBrowser, Uri baseUrl)
        {
            _visitorBrowser = visitorBrowser;
            HomeUrl = baseUrl.ToString();
        }

        public void FindHomePageElements()
        {
            NavigationBarElement = _visitorBrowser.FindElement(By.CssSelector(NavigationBarSelector));
            AboutSectionElement = _visitorBrowser.FindElement(By.CssSelector(AboutSectionSelector));
            GameInfoSectionElement = _visitorBrowser.FindElement(By.CssSelector(GameInfoSectionSelector));
            ArticlesSectionElement = _visitorBrowser.FindElement(By.CssSelector(ArticlesSectionSelector));
            FooterBarElement = _visitorBrowser.FindElement(By.CssSelector(FooterBarSelector));
        }

        public void FindArticleElements()
        {
            ArticleTitleElement = _visitorBrowser.FindElement(By.CssSelector(ArticleTitleSelector));
            ArticleDescriptionElement = _visitorBrowser.FindElement(By.CssSelector(ArticleDescriptionSelector));
            ArticleReadMoreElement = _visitorBrowser.FindElement(By.CssSelector(ArticleReadMoreSelector));
        }

        public void CheckIfHomePageElementsExist()
        {
            NavigationBarElement.Should().NotBeNull();
            AboutSectionElement.Should().NotBeNull();
            GameInfoSectionElement.Should().NotBeNull();
            ArticlesSectionElement.Should().NotBeNull();
            FooterBarElement.Should().NotBeNull();
        }

        public void CheckIfArticleElementsExist()
        {
            ArticleTitleElement.Should().NotBeNull();
            ArticleDescriptionElement.Should().NotBeNull();
            ArticleReadMoreElement.Should().NotBeNull();
        }

        public void NavigateToHomePage()
        {
            _visitorBrowser.Navigate().GoToUrl(HomeUrl);
        }
    }
}
