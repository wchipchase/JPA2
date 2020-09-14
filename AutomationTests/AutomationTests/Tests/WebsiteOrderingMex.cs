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
            woac.MXAddOmegaToCartRecurring();
            cart.MXCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestFullPayRecurSingleItemVisa()
        {
            woac.MXAddOmegaToCartRecurring();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullMC()
        {
            woac.MXAdd2ItemsPayInFull();
            cart.MXCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullVisa()
        {
            woac.MXAdd2ItemsPayInFull();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullMC()
        {
            woac.MXAddRecurringAndPayInFull();
            cart.MXCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullVisa()
        {
            woac.MXAddRecurringAndPayInFull();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }
}
