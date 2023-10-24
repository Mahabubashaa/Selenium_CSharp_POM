using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorTrust.PageObjectReference
{
    public class Dispute : PageObject
    {
        private readonly IWebDriver _driver;

        public Dispute(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public Dispute enterSSN()
        {
            SSN3.SendKeys("321");
            SSN2.SendKeys("45");
            SSN1.SendKeys("6789");
            return this;
        }
        public Dispute enterReportID()
        {
            ReportNo.SendKeys("12345");
            return this;
        }
        public IWebElement ReportNo => _driver.FindElement(By.Id("ContentPlaceHolder1_txtReportNumber"));
        public IWebElement SSN3 => _driver.FindElement(By.Id("ContentPlaceHolder1_ctlSsn_txtThree"));
        public IWebElement SSN2 => _driver.FindElement(By.Id("ContentPlaceHolder1_ctlSsn_txtTwo"));
        public IWebElement SSN1 => _driver.FindElement(By.Id("ContentPlaceHolder1_ctlSsn_txtFour"));
                                                              
    }
}