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
    class WebsiteOrderingMex
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
            Driver.WebDriver.Navigate().GoToUrl("https://www.staging.juiceplus.com/mx/en/");
            lgac = new LoginActions(Driver);
            woac = new WebsiteOrderingActions(Driver);
            cart = new CartActions(Driver);
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]
        public void WOGuestInstallmentSingleRecurringMC()
        {
            woac.MXAddVegFruitCapsuleToCart();
            cart.MXCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestInstallmentSingleRecurringVisa()
        {
            woac.MXAddVegFruitCapsuleToCart();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestFullPayRecurSingleItemMC()
        {
            woac.AddCompleteJuicePlusBarsToCartPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestFullPayRecurSingleItemVisa()
        {
            woac.AddCompleteJuicePlusBarsToCartPayInFull();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuest2ItemsInstallmentMC()
        {
            woac.Add2ItemsToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuest2ItemsInstallmentVisa()
        {
            woac.Add2ItemsToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullMC()
        {
            woac.Add2ItemsToCartPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullVisa()
        {
            woac.Add2ItemsToCartPayInFull();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullMC()
        {
            woac.AddRecurringAndPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullVisa()
        {
            woac.AddRecurringAndPayInFull();
            cart.CheckoutWithCartItemsVisa();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }
}
