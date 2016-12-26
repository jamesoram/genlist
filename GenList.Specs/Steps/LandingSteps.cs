using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using GenList.Specs.PageObjects;
using NUnit.Framework;

namespace GenList.Specs.Steps
{
    [Binding]
    public class LandingSteps
    {
        private IWebDriver driver;
        private AbstractPage page;

        [BeforeScenario]
        public void Before()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [AfterScenario]
        public void After()
        {
            driver.Quit();
            driver = null;
        }

        [Given(@"I have landed on the page")]
        public void GivenIHaveLandedOnThePage()
        {
            driver.Navigate().GoToUrl("http://localhost:51529/");
            page = new LandingPage(driver);
        }
        
        [When(@"I look at the page")]
        public void WhenILookAtThePage()
        {
            // no-op
        }
        
        [Then(@"I see the marketing copy")]
        public void ThenISeeTheMarketingCopy()
        {
            Assert.True(((LandingPage)page).getMarketingCopy().Length > 10);
        }
        
        [Then(@"I see a call to action")]
        public void ThenISeeACallToAction()
        {
            Assert.True(((LandingPage)page).isCallToActionVisible());
        }
    }
}
