using FluentAssertions;
using OpenQA.Selenium;

namespace KingsOfWar.Spec.PageObjects
{
    public class Footer
    {
        private readonly IWebDriver _visitorBrowser;

        private const string FooterBarSelector = "[data-attr-test='footer']";
        private const string ForumBtnSelector = "[data-attr-test='footer-forumBtn']";
        private const string HelpBtnSelector = "[data-attr-test='footer-helpBtn']";
        private const string SupportBtnSelector = "[data-attr-test='footer-supportBtn']";
        private const string FacebookBtnSelector = "[data-attr-test='footer-facebookBtn']";

        public IWebElement FooterBarElement { get; set; }
        public IWebElement ForumBtnElement { get; set; }
        public IWebElement HelpBtnElement { get; set; }
        public IWebElement SupportBtnElement { get; set; }
        public IWebElement FacebookBtnElement { get; set; }

        public Footer(IWebDriver visitorBrowser)
        {
            _visitorBrowser = visitorBrowser;
        }

        public void FindFooterElements()
        {
            FooterBarElement = _visitorBrowser.FindElement(By.CssSelector(FooterBarSelector));
            ForumBtnElement = _visitorBrowser.FindElement(By.CssSelector(ForumBtnSelector));
            HelpBtnElement = _visitorBrowser.FindElement(By.CssSelector(HelpBtnSelector));
            SupportBtnElement = _visitorBrowser.FindElement(By.CssSelector(SupportBtnSelector));
            FacebookBtnElement = _visitorBrowser.FindElement(By.CssSelector(FacebookBtnSelector));
        }

        public void CheckIfFooterElementsExist()
        {
            FooterBarElement.Should().NotBeNull();
            ForumBtnElement.Should().NotBeNull();
            HelpBtnElement.Should().NotBeNull();
            SupportBtnElement.Should().NotBeNull();
            FacebookBtnElement.Should().NotBeNull();
        }
    }
}
