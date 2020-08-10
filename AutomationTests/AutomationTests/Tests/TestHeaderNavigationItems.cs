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
    class TestHeaderNavigationItems
    {
        NavigationActions nav = new NavigationActions();

        [Test]
        public void TestAllHeaderNavigation()
        {
            NavigationActions.NavigateLiveBetterOverviewClick();
            NavigationActions.NavigateLiveBetterHealthyFamilyClick();
            NavigationActions.NavigateLiveBetterActiveLifestyleClick();
            NavigationActions.NavigateLiveBetterFeelGoodLookGoodClick();
            NavigationActions.NavigateLiveBetterOneSimpleChangeClick();
            NavigationActions.NavigateOurProductsOverViewClick();
            NavigationActions.NavigateOurProductsCapsulesClick();
            NavigationActions.NavigateOurProductsChewablesClick();
            NavigationActions.NavigateOurProductsOmegaClick();
            NavigationActions.NavigateOurProductsCompleteClick();
            NavigationActions.NavigateOurProductsUpliftClick();
            NavigationActions.NavigateOurProductsWhatIsJuicePlusClick();
            NavigationActions.NavigateOurCommunityOverviewClick();
            NavigationActions.NavigateOurCommunityBlogClick();
            NavigationActions.NavigateOurCommunityGivingBackClick();
            //NavigationActions.NavigateOurCommunityGoBeyondClick();
            NavigationActions.NavigateJoinUsClick();
            NavigationActions.NavCartIconClick();
            NavigationActions.NavLoginButtonClick();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }

}
