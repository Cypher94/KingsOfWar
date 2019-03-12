using FluentAssertions;
using OpenQA.Selenium;

namespace KingsOfWar.Spec.PageObjects
{
    public class Footer
    {
        private readonly IWebDriver _visitorBrowser;

        private readonly string _footerBarSelector;
        private readonly string _forumBtnSelector;
        private readonly string _helpBtnSelector;
        private readonly string _supportBtnSelector;
        private readonly string _facebookBtnSelector;

        public IWebElement FooterBarElement { get; set; }
        public IWebElement ForumBtnElement { get; set; }
        public IWebElement HelpBtnElement { get; set; }
        public IWebElement SupportBtnElement { get; set; }
        public IWebElement FacebookBtnElement { get; set; }

        public Footer(IWebDriver visitorBrowser)
        {
            _visitorBrowser = visitorBrowser;
            _footerBarSelector = "[data-attr-test='footer']";
            _forumBtnSelector = "[data-attr-test='footer-forumBtn']";
            _helpBtnSelector = "[data-attr-test='footer-helpBtn']";
            _supportBtnSelector = "[data-attr-test='footer-supportBtn']";
            _facebookBtnSelector = "[data-attr-test='footer-facebookBtn']";
        }

        public void FindFooterElements()
        {
            FooterBarElement = _visitorBrowser.FindElement(By.CssSelector(_footerBarSelector));
            ForumBtnElement = _visitorBrowser.FindElement(By.CssSelector(_forumBtnSelector));
            HelpBtnElement = _visitorBrowser.FindElement(By.CssSelector(_helpBtnSelector));
            SupportBtnElement = _visitorBrowser.FindElement(By.CssSelector(_supportBtnSelector));
            FacebookBtnElement = _visitorBrowser.FindElement(By.CssSelector(_facebookBtnSelector));
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
