using AutomationTests.ConfigElements;
using AutomationTests.PageActions.PartnerPortal;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.CartCheckoutActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.IndividualCapsuleActions;
using NUnit.Framework;
using System.Threading;

namespace AutomationTests
{
    [TestFixture]
    class PartnerPortal
    {

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void ValidateDashboardCards()
        {
            LoginActions.LoginAsPartner();
            DashboardActions.ValidatePerformanceBonusCard();
            Thread.Sleep(2000);
            DashboardActions.ValidatePromoteOutBonusCard();
            Thread.Sleep(2000);
            DashboardActions.ValidateComissionCard();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void TeamFilterValidation()
        {
            LoginActions.LoginAsPartner();
            TeamActions.NavigateToTeams();
            TeamActions.ClickFilterButton();
            TeamActions.AddAndApplyFilters();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void ValidatingFirstAndLastNameFilters()
        {
            LoginActions.LoginAsPartner();
            TeamActions.NavigateToTeams();
            TeamActions.ValidateNameFilter();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void ValidateDownloadCSV()
        {
            LoginActions.LoginAsPartner();
            TeamActions.NavigateToTeams();
            TeamActions.ClickDownloadAndSelectCSV();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void CustomerFilterValidation()
        {
            LoginActions.LoginAsPartner();
            CustomerActions.NavigateToCustomers();
            CustomerActions.ClickFilterButton();
            CustomerActions.AddAndApplyFilters();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void PurchaseProductsWithInvalidCC()
        {
            PPCartActions.NavigateToJuicePlusWebsite();
            PPCartActions.AddProductsToCart();
            PPCartActions.CheckoutWithItems();
            PPCartActions.CheckoutLogin();
            PPCartActions.FillInDeliveryAddressAndProceed();
            PPCartActions.EnterInvalidPaymentInfoAndConfirmOrder();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void AddAMemberPartnerPortal()
        {
            LoginActions.LoginAsPartner();
            TeamActions.NavigateToTeams();
            TeamActions.ClickOnAddMemberAndFillOutPersonalForm();
            TeamActions.FillOutContactFormAndSubmitApplication();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void PurchaseProductsASLoggedInAssociate()
        {
            PPCartActions.NavigateToJuicePlusWebsite();
            PPCartActions.AddProductsToCart();
            PPCartActions.CheckoutWithItems();
            PPCartActions.CheckoutLogin();
            PPCartActions.FillInDeliveryAddressAndProceed();
            PPCartActions.EnterPaymentInfoAndConfirmOrder();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void GuestCheckoutPremiumCapsulesVisa()
        {
            CapsuleActions.AddPremiumCapsuleToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void AddAMemberPartnerPortalDifferentSponsor()
        {
            LoginActions.LoginAsPartner();
            TeamActions.NavigateToTeams();
            TeamActions.ClickOnAddMemberAndFillOutPersonalForm();
            TeamActions.FillOutContactFormAndSubmitApplicationOtherSponsor();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void ValdiateContactForm()
        {
            NavigationActions.NavigateCompany_ContactUs();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void SwitchCountryInCart()
        {
            PPCartActions.NavigateToJuicePlusWebsite();
            PPCartActions.AddProductsToCart();
            PPCartActions.CartIcon1();
            PPCartActions.ChangeCountry();
            PPCartActions.CartIcon0();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void SharedCartPortalOrders()
        {
            LoginActions.LoginAsPartner();
            CustomerActions.NavigateToCustomers();
            CustomerActions.SelectFirstCustomer();
            CustomerActions.SelectFirstCustomerDetails();
            CustomerActions.SelectFirstCustomerOrders();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }

    }
}
