using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests
{
    [TestFixture]
    class TestHeaderNavigationItems
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
        public void TestAllHeaderNavigation()
        {
            
            nav.NavigateLiveBetterOverviewClick();
            nav.NavigateLiveBetterHealthyFamilyClick();
            nav.NavigateLiveBetterActiveLifestyleClick();
            nav.NavigateLiveBetterFeelGoodLookGoodClick();
            nav.NavigateLiveBetterOneSimpleChangeClick();
            nav.NavigateOurProductsOverViewClick();
            nav.NavigateOurProductsCapsulesClick();
            nav.NavigateOurProductsChewablesClick();
            nav.NavigateOurProductsOmegaClick();
            nav.NavigateOurProductsCompleteClick();
            nav.NavigateOurProductsUpliftClick();
            nav.NavigateOurProductsWhatIsJuicePlusClick();
            nav.NavigateOurCommunityOverviewClick();
            nav.NavigateOurCommunityBlogClick();
            nav.NavigateOurCommunityGivingBackClick();
            //NavigationActions.NavigateOurCommunityGoBeyondClick();
            nav.NavigateJoinUsClick();
            nav.NavCartIconClick();
            nav.NavLoginButtonClick();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }

}
