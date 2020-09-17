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
    class WebsiteOrderingIE
    {
        [ThreadStatic]
        static Driver Driver;
        [ThreadStatic]
        static LoginActions lgac;
        [ThreadStatic]
        static WebsiteOrderingActions woac;
        [ThreadStatic]
        static CartActions cart;

        [SetUp]
        public void SetUpTest()
        {
            Driver = new Driver(Driver.BrowserType.Chrome);
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.WebDriver.Manage().Window.Maximize();
            Driver.WebDriver.Navigate().GoToUrl("https://www.staging.juiceplus.com/ie/en/");
            lgac = new LoginActions(Driver);
            woac = new WebsiteOrderingActions(Driver);
            cart = new CartActions(Driver);
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestInstallmentSingleRecurringMC()
        {
            lgac.GuestCookieAccept();
            woac.AddPremiumCapsuleToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void WOGuestInstallmentSingleRecurringVisa()
        {
            lgac.GuestCookieAccept();
            woac.AddPremiumCapsuleToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void WOGuestFullPayRecurSingleItemMC()
        {
            lgac.GuestCookieAccept();
            woac.AddCompleteJuicePlusBarsToCartPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void WOGuestFullPayRecurSingleItemVisa()
        {
            lgac.GuestCookieAccept();
            woac.AddCompleteJuicePlusBarsToCartPayInFull();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void WOGuest2ItemsInstallmentMC()
        {
            lgac.GuestCookieAccept();
            woac.Add2ItemsToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void WOGuest2ItemsInstallmentVisa()
        {
            lgac.GuestCookieAccept();
            woac.Add2ItemsToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullMC()
        {
            lgac.GuestCookieAccept();
            woac.Add2ItemsToCartPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullVisa()
        {
            lgac.GuestCookieAccept();
            woac.Add2ItemsToCartPayInFull();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullMC()
        {
            lgac.GuestCookieAccept();
            woac.AddRecurringAndPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullVisa()
        {
            lgac.GuestCookieAccept();
            woac.AddRecurringAndPayInFull();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void LIPartInstallmentSingleRecurringMC()
        {
            lgac.LoginAsPartner();
            woac.LICustAddPremiumCapsuleToCart();
            cart.IEPartnerCheckoutWithCartItemsMC();

        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void LIPartInstallmentSingleRecurringVisa()
        {
            lgac.LoginAsPartner();
            woac.LICustAddPremiumCapsuleToCart();
            cart.IEPartnerCheckoutWithCartItemsVisa();
        }


        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void LIPartFullPayRecurSingleItemMC()
        {
            lgac.LoginAsPartner();
            woac.AddCompleteJuicePlusBarsToCartPayInFull();
            cart.IEPartnerCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void LIPartFullPayRecurSingleItemVisa()
        {
            lgac.LoginAsPartner();
            woac.AddCompleteJuicePlusBarsToCartPayInFull();
            cart.IEPartnerCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void LIPart2ItemsInstallmentMC()
        {
            lgac.LoginAsPartner();
            woac.Add2ItemsToCart();
            cart.IEPartnerCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void LIPart2ItemsInstallmentVisa()
        {
            lgac.LoginAsPartner();
            woac.Add2ItemsToCart();
            cart.IEPartnerCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void LIPart2ItemsPayInFullMC()
        {
            lgac.LoginAsPartner();
            woac.Add2ItemsToCartPayInFull();
            cart.IEPartnerCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void LIPart2ItemsPayInFullVisa()
        {
            lgac.LoginAsPartner();
            woac.Add2ItemsToCartPayInFull();
            cart.IEPartnerCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void LIPartRecurringAndPayInFullMC()
        {
            lgac.LoginAsPartner();
            woac.AddRecurringAndPayInFull();
            cart.IEPartnerCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]

        public void LIPartRecurringAndPayInFullVisa()
        {
            lgac.LoginAsPartner();
            woac.AddRecurringAndPayInFull();
            cart.IEPartnerCheckoutWithCartItemsVisa();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }
}
