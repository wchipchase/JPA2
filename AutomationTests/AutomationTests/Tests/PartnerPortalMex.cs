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
    class PartnerPortalMex
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
        [ThreadStatic]
        static TeamActionsMX tmmxac;
        [SetUp]
        public void SetUpTest()
        {
            Driver = new Driver(Driver.BrowserType.Chrome);
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.WebDriver.Manage().Window.Maximize();
            Driver.WebDriver.Navigate().GoToUrl("http://www.staging.juiceplus.com/mx/en");
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
            tmmxac = new TeamActionsMX(Driver);
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]

        public void ValidateDashboardCards()
        {
            lgac.MXLoginAsPartner();
            dbac.ValidatePerformanceBonusCard();
            Thread.Sleep(1000);
            dbac.ValidatePromoteOutBonusCard();
            Thread.Sleep(1000);
            dbac.ValidateComissionCard();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void TeamFilterValidation()
        {
            lgac.MXLoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ClickFilterButton();
            tmac.AddAndApplyFilters();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void ValidatingFirstAndLastNameFilters()
        {
            lgac.MXLoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ValidateNameFilter();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void ValidateDownloadCSV()
        {
            lgac.MXLoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ClickDownloadAndSelectCSV();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void CustomerFilterValidation()
        {
            lgac.MXLoginAsPartner();
            csac.NavigateToCustomers();
            csac.ClickFilterButton();
            csac.AddAndApplyFilters();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void PurchaseProductsWithInvalidCC()
        {
            ppac.MXAddProductsToCart();
            ppac.CheckoutWithItems();
            ppac.CheckoutLogin();
            ppac.MXFillInDeliveryAddressAndProceed();
            ppac.EnterInvalidPaymentInfoAndConfirmOrder();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void AddAMemberPartnerPortal()
        {
            lgac.MXLoginAsPartner();
            tmac.NavigateToTeams();
            Thread.Sleep(3000);
            tmmxac.ClickOnAddMemberAndFillOutPersonalForm();
            tmmxac.FillOutContactFormAndSubmitApplication();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void PurchaseProductsASLoggedInAssociate()
        {
            ppac.MXAddProductsToCart();
            ppac.CheckoutWithItems();
            ppac.CheckoutLogin();
            //ppac.MXFillInDeliveryAddressAndProceed();
            ctac.MXLICheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void GuestCheckoutPremiumCapsulesVisa()
        {
            ppac.MXAddProductsToCart();
            ppac.CheckoutWithItems();
            ctac.MXCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void AddAMemberPartnerPortalDifferentSponsor()
        {
            lgac.LoginAsPartner();
            tmac.NavigateToTeams();
            tmac.ClickOnAddMemberAndFillOutPersonalForm();
            tmac.FillOutContactFormAndSubmitApplicationOtherSponsor();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void SwitchCountryInCart()
        {
            ppac.MXAddProductsToCart();
            nav.MXNavigateCountryClick();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void SharedCartPortalOrders()
        {
            lgac.MXLoginAsPartner();
            csac.NavigateToCustomers();
            csac.SelectFirstCustomer();
            csac.SelectFirstCustomerDetails();
            csac.SelectFirstCustomerOrders();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void SharedCartJuicePlusOrder()
        {
            lgac.MXLoginAsPartner();
            spac.NavigateToShop();
            spac.MXFillInContactDetails();
            spac.USSelectProductsAndAddToCart();
            spac.ShareCart();

        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void ValdiateContactForm()
        {
            nav.NavigateCompany_ContactUs();
        }

        [Test]
        [Category("smoketest-mex")]
        [Category("alltest")]
        public void CustomerPortalProfile()
        {
            lgac.MexLoginAsCustomer();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }
}
