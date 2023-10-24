using OpenQA.Selenium;

namespace FactorTrust.PageObjectReference
{
    public abstract class PageObject
    {
        private readonly IWebDriver _driver;
        public PageObject(IWebDriver driver)
        {
            _driver = driver;
        }
        public void Navigate(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
