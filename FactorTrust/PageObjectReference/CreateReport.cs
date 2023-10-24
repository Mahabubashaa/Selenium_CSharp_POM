using OpenQA.Selenium;

namespace FactorTrust.PageObjectReference
{
    public class CreateReport : PageObject
    {
        private readonly IWebDriver _driver;
        public CreateReport(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void FillPIIDetails()
        {
            FirstName.SendKeys("Mahabu Basha");
            Thread.Sleep(3000);
            LastName.SendKeys("Ansar");
            
        }
        public void ClickNextButton()
        {
            NextButton.Click();
        }

        internal void FillSSN()
        {
            SSN3.SendKeys("321");
            SSN2.SendKeys("45");
            SSN1.SendKeys("6789");
            Thread.Sleep(3000);
        }

        public IWebElement FirstName => _driver.FindElement(By.Id("ContentPlaceHolder1_txtFirstName"));
        public IWebElement LastName => _driver.FindElement(By.Id("ContentPlaceHolder1_txtLastName"));
        public IWebElement NextButton => _driver.FindElement(By.Id("ContentPlaceHolder1_btnNext"));
        public IWebElement SSN3 => _driver.FindElement(By.Id("ContentPlaceHolder1_ctlSsn_txtThree"));
        public IWebElement SSN2 => _driver.FindElement(By.Id("ContentPlaceHolder1_ctlSsn_txtTwo"));
        public IWebElement SSN1 => _driver.FindElement(By.Id("ContentPlaceHolder1_ctlSsn_txtFour"));

    }
}
