using AutomationTests.ConfigElements;
using AutomationTests.PageActions.PartnerPortalUS;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Tests
{
    class PartnerPortalUS
    {
        [ThreadStatic]
        static Driver Driver;
        [ThreadStatic]
        static LoginActionsUS lgac;

        [SetUp]
        public void SetUpTest()
        {
            Driver = new Driver(Driver.BrowserType.Chrome);
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.WebDriver.Manage().Window.Maximize();
            Driver.WebDriver.Navigate().GoToUrl("https://www.staging.juiceplus.com/us/en/");
            lgac = new LoginActionsUS(Driver);
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void ValidateDashboardCards()
        {
            lgac.LoginAsPartner();
        }

        public void TearDown()
        {
            Driver.Teardown();
        }

    }
}
