using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Configuration;

namespace KingsOfWar.Spec.Context
{
    public partial class Visitor
    {
        private IWebDriver _browser;
        private readonly string _type;

        public Visitor()
        {
            _type = ConfigurationManager.AppSettings["Context.Visitor.Browser.Name"];
        }

        public IWebDriver Browser()
        {
            IWebDriver driver;
            switch (_type)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "InternetExplorer":
                    driver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    throw new NotSupportedException(string.Format("Browser {0} is not supported", _type));
            }

            _browser = driver;
            return _browser;
        }

        partial void DisposeManaged()
        {
            _browser?.Dispose();
        }
    }
}
