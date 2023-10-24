using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Edge;

namespace FactorTrust.Factories
{
    public class DriverFactory
    {
        public IWebDriver CreateDriver()
        {
            string browser = Environment.GetEnvironmentVariable("BROWSER") ?? "CLOUD";

            switch (browser.ToUpperInvariant())
            {
                case "CHROME":
                    return new ChromeDriver();
                case "EDGE":
                    return new EdgeDriver();
                case "CLOUD":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.PlatformName = "Any";
                    chromeOptions.BrowserVersion = "118";
                    return new RemoteWebDriver(new Uri("http://18.191.175.133:4444/wd/hub"), chromeOptions);
                default:
                    throw new ArgumentException($"Browser not yet implemented: {browser}");
            }
        }
    }
}
