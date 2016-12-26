using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GenList.Specs.PageObjects
{
    class LandingPage : AbstractPage
    {
        [FindsBy(How = How.ClassName, Using = "mkt-copy")]
        private IWebElement marketingCopy;

        [FindsBy(How = How.Id, Using = "cta")]
        private IWebElement cta;

        public LandingPage(IWebDriver driver) : base(driver)
        {
        }

        public string getMarketingCopy()
        {
            return marketingCopy.Text;
        }

        public Boolean isCallToActionVisible()
        {
            return cta.Displayed;
        }
    }
}
