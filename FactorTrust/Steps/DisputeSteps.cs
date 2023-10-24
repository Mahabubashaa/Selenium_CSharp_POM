using FactorTrust.PageObjectReference;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FactorTrust.Steps
{
    [Binding]
    public class DisputeSteps
    {
        private readonly Dispute _page;

        public DisputeSteps(IWebDriver driver)
        {
            _page = new Dispute(driver);
        }

        [When(@"Raise Dispute")]
        public void raiseDispute()
        {
            _page.enterReportID().enterSSN();
            

            Console.WriteLine("Raise Dispute");
        }
        [Given(@"Login to Dispute Page")]
        public void logintodispute()
        {
            _page.Navigate("https://www.factortrust.com/Consumer/Disputes.aspx");
        }

    }
}
