using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests
{
    class TestFooterNavigationItems
    {
        [ThreadStatic]
        static Driver Driver;
        [ThreadStatic]
        static NavigationActions nav;

        [SetUp]
        public void SetUpTest()
        {
            Driver = new Driver(Driver.BrowserType.Chrome);
            nav = new NavigationActions(Driver);
        }

        [Test]
        public void TestAllFooterNavigation()
        {

            nav.NavigateCompany_AboutUs();
            nav.NavigateCompany_GivingBack();
            nav.NavigateCompany_ContactUs();
            nav.NavigateJuicePlus_HowCapsAreMade();
            //nav.NavigateJuicePlus_ClinicalResearch();
            //NavigationActions.NavigateJuicePlus_InformedChoice();
            nav.NavigateResources_OneSimpleChange();
            nav.NavigateResources_HealthyStartforFamilies();
            //NavigationActions.NavigateResources_LetsGoBeyond();
            nav.NavigateTermsOfUse();
            nav.NavigatePrivacyPolicy();
            nav.NavigateReturnPolicy();
            nav.NavigateTermsofService();
            nav.NavigateCountrySelect();
            Driver.WebDriver.Url = "https://www.staging.juiceplus.com/ie/en/";
            nav.NavigateFacebookClick();
            Driver.WebDriver.Url = "https://www.staging.juiceplus.com/ie/en/";
            nav.NavigateInstagramClick();
            Driver.WebDriver.Url = "https://www.staging.juiceplus.com/ie/en/";
            nav.NavigateYoutubeClick();
            Driver.WebDriver.Url = "https://www.staging.juiceplus.com/ie/en/";
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }
}
