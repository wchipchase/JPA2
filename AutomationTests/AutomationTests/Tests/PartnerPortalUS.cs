using AutomationTests.ConfigElements;
using AutomationTests.PageActions.PartnerPortal;
using AutomationTests.PageActions.PartnerPortalUS;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.CartCheckoutActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.IndividualCapsuleActions;
using AutomationTests.PageObjects.PartnerPortal;
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
    class PartnerPortalUS
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

        public void ValidateDashboardCards()
        {
            lgac.LoginAsPartner();
            dbac.ValidatePerformanceBonusCard();
            Thread.Sleep(1000);
            dbac.ValidatePromoteOutBonusCard();
            Thread.Sleep(1000);
            dbac.ValidateComissionCard();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void ValdiateContactForm()
        {
            nav.NavigateCompany_ContactUs();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void TeamFilterValidation()
        {
            lgac.LoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ClickFilterButton();
            tmac.AddAndApplyFilters();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void ValidatingFirstAndLastNameFilters()
        {
            lgac.LoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ValidateNameFilter();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void ValidateDownloadCSV()
        {
            lgac.LoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ClickDownloadAndSelectCSV();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void CustomerFilterValidation()
        {
            lgac.LoginAsPartner();
            csac.NavigateToCustomers();
            csac.ClickFilterButton();
            csac.AddAndApplyFilters();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void PurchaseProductsWithInvalidCC()
        {
            ppusac.NavigateToJuicePlusWebsite(Driver);
            ppac.AddProductsToCart();
            ppac.CheckoutWithItems();
            ppac.CheckoutLogin();
            ppac.USFillInDeliveryAddressAndProceed();
            ppac.EnterInvalidPaymentInfoAndConfirmOrder();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void AddAMemberPartnerPortal()
        {
            lgac.LoginAsPartner();
            tmac.NavigateToTeams();
            tmusac.ClickOnAddMemberAndFillOutPersonalForm();
            tmusac.FillOutContactFormAndSubmitApplication();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void PurchaseProductsASLoggedInAssociate()
        {
            ppusac.NavigateToJuicePlusWebsite(Driver);
            ppac.AddProductsToCart();
            ppac.CheckoutWithItems();
            ppac.CheckoutLogin();
            ppac.USFillInDeliveryAddressAndProceed();
            ppac.EnterPaymentInfoAndConfirmOrder();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void GuestCheckoutPremiumCapsulesVisa()
        {
            cpac.USAddFruitsAndVegetablesCapsuleToCart();
            ctac.USCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void AddAMemberPartnerPortalDifferentSponsor()
        {
            lgac.LoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ClickOnAddMemberAndFillOutPersonalForm();
            tmac.FillOutContactFormAndSubmitApplicationOtherSponsor();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void SwitchCountryInCart()
        {
            ppac.AddProductsToCart();
            nav.USNavigateCountryClick();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void SharedCartPortalOrders()
        {
            lgac.LoginAsPartner();
            csac.NavigateToCustomers();
            csac.SelectFirstCustomer();
            csac.SelectFirstCustomerDetails();
            csac.SelectFirstCustomerOrders();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]
        public void SharedCartJuicePlusOrder()
        {
            lgac.LoginAsPartner();
            spac.NavigateToShop();
            spac.USFillInContactDetails();
            spac.USSelectProductsAndAddToCart();
            spac.ShareCart();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }
}
