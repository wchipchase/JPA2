using AutomationTests.ConfigElements;
using AutomationTests.PageActions.PartnerPortal;
using AutomationTests.PageActions.PartnerPortalUS;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.CartCheckoutActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.IndividualCapsuleActions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.Tests
{
    [TestFixture]

    //add to TestFixture to run parallel ", Parallelizable(ParallelScope.All)"
    class PPv2Ireland
    {
        [ThreadStatic]
        static Driver Driver;
        [ThreadStatic]
        static LoginActionsUS lgac;
        [ThreadStatic]
        static DashboardActions dbac;
        [ThreadStatic]
        static TeamActions tmac;
        [ThreadStatic]
        static CustomerActions csac;
        [ThreadStatic]
        static PPCartActions ppac;
        [ThreadStatic]
        static NavigationActions nav;
        [ThreadStatic]
        static CapsuleActions cpac;
        [ThreadStatic]
        static CartActions ctac;
        [ThreadStatic]
        static ShopActions spac;
        [ThreadStatic]
        static PPCartUSActions ppusac;
        [ThreadStatic]
        static TeamActionsUS tmusac;

        [SetUp]
        public void SetUpTest()
        {
            Driver = new Driver(Driver.BrowserType.Chrome);
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.WebDriver.Manage().Window.Maximize();
            Driver.WebDriver.Navigate().GoToUrl("https://www.staging.juiceplus.com/us/en/");
            lgac = new LoginActionsUS(Driver);
            dbac = new DashboardActions(Driver);
            tmac = new TeamActions(Driver);
            tmusac = new TeamActionsUS(Driver);
            csac = new CustomerActions(Driver);
            ppac = new PPCartActions(Driver);
            nav = new NavigationActions(Driver);
            cpac = new CapsuleActions(Driver);
            ctac = new CartActions(Driver);
            spac = new ShopActions(Driver);
            ppusac = new PPCartUSActions(Driver);
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void RegistrationSharedLinkWithPartnerSignedIn()
        {
            lgac.LoginAsPartner();
            dbac.ValidatePerformanceBonusCard();
            Thread.Sleep(1000);
            dbac.ValidatePromoteOutBonusCard();
            Thread.Sleep(1000);
            dbac.ValidateComissionCard();
        }

        public void RegistrationAddTeamMemberPagePartnerSignedIn()
        {
            lgac.LoginAsPartner();
            dbac.ValidatePerformanceBonusCard();
            Thread.Sleep(1000);
            dbac.ValidatePromoteOutBonusCard();
            Thread.Sleep(1000);
            dbac.ValidateComissionCard();
        }
    }
}
