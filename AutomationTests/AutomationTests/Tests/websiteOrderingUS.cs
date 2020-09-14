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
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestInstallmentSingleRecurringMC()
        {
            woac.USAddFruitVegCapsuleToCart();
            cart.USCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestInstallmentSingleRecurringVisa()
        {
            woac.USAddFruitVegCapsuleToCart();
            cart.USCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestFullPayRecurSingleItemMC()
        {
            woac.USAddCompleteJuicePlusBarsToCartPayInFull();
            cart.USCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestFullPayRecurSingleItemVisa()
        {
            woac.USAddCompleteJuicePlusBarsToCartPayInFull();
            cart.USCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuest2ItemsInstallmentMC()
        {
            woac.USAdd2ItemsToCart();
            cart.USCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuest2ItemsInstallmentVisa()
        {
            woac.USAdd2ItemsToCart();
            cart.USCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullMC()
        {
            woac.USAdd2ItemsToCartPayInFull();
            cart.USCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullVisa()
        {
            woac.USAdd2ItemsToCartPayInFull();
            cart.USCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullMC()
        {
            woac.USAddRecurringAndPayInFull();
            cart.USCheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullVisa()
        {
            woac.USAddRecurringAndPayInFull();
            cart.USCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LICustInstallmentSingleRecurringMC()
        {
            lgac.LoginAsCustomer();
            woac.LICustAddPremiumCapsuleToCart();
            cart.CheckoutWithCartItemsMC();

        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LICustInstallmentSingleRecurringVisa()
        {
            lgac.LoginAsCustomer();
            woac.AddPremiumCapsuleToCart();
            cart.CheckoutWithCartItemsVisa();
        }


        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LICustFullPayRecurSingleItemMC()
        {
            lgac.LoginAsCustomer();
            woac.AddCompleteJuicePlusBarsToCartPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LICustFullPayRecurSingleItemVisa()
        {
            lgac.LoginAsCustomer();
            woac.AddCompleteJuicePlusBarsToCartPayInFull();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LICust2ItemsInstallmentMC()
        {
            lgac.LoginAsCustomer();
            woac.Add2ItemsToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LICust2ItemsInstallmentVisa()
        {
            lgac.LoginAsCustomer();
            woac.Add2ItemsToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LICust2ItemsPayInFullMC()
        {
            lgac.LoginAsCustomer();
            woac.Add2ItemsToCartPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LICust2ItemsPayInFullVisa()
        {
            lgac.LoginAsCustomer();
            woac.Add2ItemsToCartPayInFull();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LICustRecurringAndPayInFullMC()
        {
            lgac.LoginAsCustomer();
            woac.AddRecurringAndPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LICustRecurringAndPayInFullVisa()
        {
            woac.AddRecurringAndPayInFull();
            lgac.LoginAsCustomer();
            //cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LIPartInstallmentSingleRecurringMC()
        {
            woac.LICustAddPremiumCapsuleToCart();
            lgac.LoginAsPartner2();
            cart.CheckoutWithCartItemsMC();

        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LIPartInstallmentSingleRecurringVisa()
        {
            lgac.LoginAsCustomer();
            woac.AddPremiumCapsuleToCart();
            cart.CheckoutWithCartItemsVisa();
        }


        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LIPartFullPayRecurSingleItemMC()
        {
            lgac.LoginAsCustomer();
            woac.AddCompleteJuicePlusBarsToCartPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LIPartFullPayRecurSingleItemVisa()
        {
            lgac.LoginAsCustomer();
            woac.AddCompleteJuicePlusBarsToCartPayInFull();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LIPart2ItemsInstallmentMC()
        {
            lgac.LoginAsCustomer();
            woac.Add2ItemsToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LIPart2ItemsInstallmentVisa()
        {
            lgac.LoginAsCustomer();
            woac.Add2ItemsToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LIPart2ItemsPayInFullMC()
        {
            lgac.LoginAsCustomer();
            woac.Add2ItemsToCartPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LIPart2ItemsPayInFullVisa()
        {
            lgac.LoginAsCustomer();
            woac.Add2ItemsToCartPayInFull();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LIPartRecurringAndPayInFullMC()
        {
            lgac.LoginAsCustomer();
            woac.AddRecurringAndPayInFull();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("smoketest")]
        [Category("alltest")]

        public void LIPartRecurringAndPayInFullVisa()
        {
            woac.AddRecurringAndPayInFull();
            lgac.LoginAsCustomer();
            //cart.CheckoutWithCartItemsVisa();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }
}
