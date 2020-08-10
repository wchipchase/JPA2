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
        NavigationActions nav = new NavigationActions();

        [Test]
        public void TestAllFooterNavigation()
        {
            
            NavigationActions.NavigateCompany_AboutUs();
            NavigationActions.NavigateCompany_GivingBack();
            NavigationActions.NavigateCompany_ContactUs();
            NavigationActions.NavigateJuicePlus_HowCapsAreMade();
            //NavigationActions.NavigateJuicePlus_ClinicalResearch();
            //NavigationActions.NavigateJuicePlus_InformedChoice();
            NavigationActions.NavigateResources_OneSimpleChange();
            NavigationActions.NavigateResources_HealthyStartforFamilies();
            //NavigationActions.NavigateResources_LetsGoBeyond();
            NavigationActions.NavigateTermsOfUse();
            NavigationActions.NavigatePrivacyPolicy();
            NavigationActions.NavigateReturnPolicy();
            NavigationActions.NavigateTermsofService();
            NavigationActions.NavigateCountrySelect();
            Driver.WebDriver.Url = "https://www.staging.juiceplus.com/ie/en/";
            NavigationActions.NavigateFacebookClick();
            Driver.WebDriver.Url = "https://www.staging.juiceplus.com/ie/en/";
            NavigationActions.NavigateInstagramClick();
            Driver.WebDriver.Url = "https://www.staging.juiceplus.com/ie/en/";
            NavigationActions.NavigateYoutubeClick();
            Driver.WebDriver.Url = "https://www.staging.juiceplus.com/ie/en/";
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }
}
