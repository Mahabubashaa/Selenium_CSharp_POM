
using FactorTrust.PageObjectReference;
using OpenQA.Selenium;
using System.Diagnostics.Metrics;
using TechTalk.SpecFlow;

namespace StepDefs

{
    [Binding]
    public class ConsumerPortalSteps
    {
        private readonly CreateReport _page;

        public ConsumerPortalSteps(IWebDriver driver)
        {
            _page = new CreateReport(driver);
        }
        [Then(@"Click Next Button")]
        public void GivenINavigateToAppliacation()
        {
            Console.WriteLine("Hello");
        }

        [Given(@"Login to Consumer portal")]
        public void GivenIEnterFollowingLoginDetails()
        {
            _page.Navigate("https://www.factortrust.com/Consumer/ReportRequest.aspx");
        }

        [When(@"Enter the Consumer FirstName and LastName")]
        public void ThenISeeEmployeeLists()
        {
            _page.FillPIIDetails();
        }

        [When(@"Enter the Consumer SSN")]
        public void enterSSN()
        {
            _page.FillSSN();
        }


    }
}

