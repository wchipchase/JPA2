using AutomationTests.ConfigElements;
using AutomationTests.PageActions.PartnerPortal;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.CartCheckoutActions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Tests
{
    [TestFixture]
    class WebsiteOrderingUS
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
            Driver.WebDriver.Navigate().GoToUrl("https://www.staging.juiceplus.com/us/en/");
            lgac = new LoginActions(Driver);
            woac = new WebsiteOrderingActions(Driver);
            cart = new CartActions(Driver);
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void WOGuestInstallmentSingleRecurringMC()
        {
            lgac.GuestCookieAccept();
            woac.USAddFruitVegCapsuleToCart();
            cart.USCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void WOGuestInstallmentSingleRecurringVisa()
        {
            lgac.GuestCookieAccept();
            woac.USAddFruitVegCapsuleToCart();
            cart.USCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void WOGuestFullPayRecurSingleItemMC()
        {
            lgac.GuestCookieAccept();
            woac.USAddCompleteJuicePlusBarsToCartPayInFull();
            cart.USCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void WOGuestFullPayRecurSingleItemVisa()
        {
            lgac.GuestCookieAccept();
            woac.USAddCompleteJuicePlusBarsToCartPayInFull();
            cart.USCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void WOGuest2ItemsInstallmentMC()
        {
            lgac.GuestCookieAccept();
            woac.USAdd2ItemsToCart();
            cart.USCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void WOGuest2ItemsInstallmentVisa()
        {
            lgac.GuestCookieAccept();
            woac.USAdd2ItemsToCart();
            cart.USCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullMC()
        {
            lgac.GuestCookieAccept();
            woac.USAdd2ItemsToCartPayInFull();
            cart.USCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullVisa()
        {
            lgac.GuestCookieAccept();
            woac.USAdd2ItemsToCartPayInFull();
            cart.USCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullMC()
        {
            lgac.GuestCookieAccept();
            woac.USAddRecurringAndPayInFull();
            cart.USCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullVisa()
        {
            lgac.GuestCookieAccept();
            woac.USAddRecurringAndPayInFull();
            cart.USCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void LIPartInstallmentSingleRecurringMC()
        {
            lgac.USLoginAsPartner();
            woac.USAddFruitVegCapsuleToCart();
            cart.USPartnerCheckoutWithCartItemsMC();

        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void LIPartInstallmentSingleRecurringVisa()
        {
            lgac.USLoginAsPartner();
            woac.USAddFruitVegCapsuleToCart();
            cart.USPartnerCheckoutWithCartItemsVisa();
        }


        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void LIPartFullPayRecurSingleItemMC()
        {
            lgac.USLoginAsPartner();
            woac.USAddCompleteJuicePlusBarsToCartPayInFull();
            cart.USPartnerCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void LIPartFullPayRecurSingleItemVisa()
        {
            lgac.USLoginAsPartner();
            woac.USAddCompleteJuicePlusBarsToCartPayInFull();
            cart.USPartnerCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void LIPart2ItemsInstallmentMC()
        {
            lgac.USLoginAsPartner();
            woac.USAdd2ItemsToCart();
            cart.USPartnerCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void LIPart2ItemsInstallmentVisa()
        {
            lgac.USLoginAsPartner();
            woac.USAdd2ItemsToCart();
            cart.USPartnerCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void LIPart2ItemsPayInFullMC()
        {
            lgac.USLoginAsPartner();
            woac.USAdd2ItemsToCartPayInFull();
            cart.USPartnerCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void LIPart2ItemsPayInFullVisa()
        {
            lgac.USLoginAsPartner();
            woac.USAdd2ItemsToCartPayInFull();
            cart.USPartnerCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void LIPartRecurringAndPayInFullMC()
        {
            lgac.USLoginAsPartner();
            woac.USAddRecurringAndPayInFull();
            cart.USPartnerCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest-us")]
        [Category("alltest")]

        public void LIPartRecurringAndPayInFullVisa()
        {
            lgac.USLoginAsPartner();
            woac.USAddRecurringAndPayInFull();
            cart.USPartnerCheckoutWithCartItemsVisa();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }
}
