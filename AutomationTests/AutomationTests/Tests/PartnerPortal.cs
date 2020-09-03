using AutomationTests.ConfigElements;
using AutomationTests.PageActions.PartnerPortal;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.CartCheckoutActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.IndividualCapsuleActions;
using NUnit.Framework;
using System;
using System.Threading;

namespace AutomationTests
{
    [TestFixture]

    //add to TestFixture to run parallel ", Parallelizable(ParallelScope.All)"
    class PartnerPortal
    {
        [ThreadStatic]
        static Driver Driver;
        [ThreadStatic]
        static LoginActions lgac;
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

        [SetUp]
        public void SetUpTest()
        {
            Driver = new Driver(Driver.BrowserType.Chrome);
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.WebDriver.Manage().Window.Maximize();
            Driver.WebDriver.Navigate().GoToUrl("https://www.juiceplus.com/ie/en/");
            lgac = new LoginActions(Driver);
            dbac = new DashboardActions(Driver);
            tmac = new TeamActions(Driver);
            csac = new CustomerActions(Driver);
            ppac = new PPCartActions(Driver);
            nav = new NavigationActions(Driver);
            cpac = new CapsuleActions(Driver);
            ctac = new CartActions(Driver);
            spac = new ShopActions(Driver);
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void ValidateDashboardCards()
        {
            lgac.LoginAsPartner();
            dbac.ValidatePerformanceBonusCard();
            Thread.Sleep(2000);
            dbac.ValidatePromoteOutBonusCard();
            Thread.Sleep(2000);
            dbac.ValidateComissionCard();
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void TeamFilterValidation()
        {
            lgac.LoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ClickFilterButton();
            tmac.AddAndApplyFilters();
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void ValidatingFirstAndLastNameFilters()
        {
            lgac.LoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ValidateNameFilter();
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void ValidateDownloadCSV()
        {
            lgac.LoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ClickDownloadAndSelectCSV();
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void CustomerFilterValidation()
        {
            lgac.LoginAsPartner();
            csac.NavigateToCustomers();
            csac.ClickFilterButton();
            csac.AddAndApplyFilters();
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void PurchaseProductsWithInvalidCC()
        {
            ppac.NavigateToJuicePlusWebsite();
            ppac.AddProductsToCart();
            ppac.CheckoutWithItems();
            ppac.CheckoutLogin();
            ppac.FillInDeliveryAddressAndProceed();
            ppac.EnterInvalidPaymentInfoAndConfirmOrder();
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void AddAMemberPartnerPortal()
        {
            lgac.LoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ClickOnAddMemberAndFillOutPersonalForm();
            tmac.FillOutContactFormAndSubmitApplication();
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void PurchaseProductsASLoggedInAssociate()
        {
            ppac.NavigateToJuicePlusWebsite();
            ppac.AddProductsToCart();
            ppac.CheckoutWithItems();
            ppac.CheckoutLogin();
            ppac.FillInDeliveryAddressAndProceed();
            //ppac.EnterPaymentInfoAndConfirmOrder();
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void GuestCheckoutPremiumCapsulesVisa()
        {
            cpac.AddPremiumCapsuleToCart();
            ctac.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void AddAMemberPartnerPortalDifferentSponsor()
        {
            lgac.LoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ClickOnAddMemberAndFillOutPersonalForm();
            tmac.FillOutContactFormAndSubmitApplicationOtherSponsor();
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void ValdiateContactForm()
        {
            nav.NavigateCompany_ContactUs();
        }

        [Test]
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void SwitchCountryInCart()
        {
            //ppac.NavigateToJuicePlusWebsite();
            ppac.AddProductsToCart();
            ppac.ChangeCountry();
        }

        [Test]
        [Category("smoketest-ireland")]
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
        [Category("smoketest-ireland")]
        [Category("alltest")]
        public void SharedCartJuicePlusOrder()
        {
            lgac.LoginAsPartner();
            spac.NavigateToShop();
            spac.FillInContactDetails();
            spac.SelectProductsAndAddToCart();
            spac.ShareCart();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }

    }
}
