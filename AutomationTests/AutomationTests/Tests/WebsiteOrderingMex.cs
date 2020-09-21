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
        [Category("smoketest-mx")]
        [Category("alltest")]
        public void WOGuestInstallmentSingleRecurringAMEX()
        {
            lgac.GuestCookieAccept();
            woac.MXAddVegFruitCapsuleToCart();
            cart.MXCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void WOGuestInstallmentSingleRecurringVisa()
        {
            lgac.GuestCookieAccept();
            woac.MXAddVegFruitCapsuleToCart();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void WOGuestFullPayRecurSingleItemAMEX()
        {
            lgac.GuestCookieAccept();
            woac.MXAddOmegaToCartRecurring();
            cart.MXCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void WOGuestFullPayRecurSingleItemVisa()
        {
            lgac.GuestCookieAccept();
            woac.MXAddOmegaToCartRecurring();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void WOGuest2ItemsInstallmentAMEX()
        {
            lgac.GuestCookieAccept();
            woac.MXAdd2ItemsToCart();
            cart.MXCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void WOGuest2ItemsInstallmentVisa()
        {
            lgac.GuestCookieAccept();
            woac.MXAdd2ItemsToCart();
            cart.MXCheckoutWithCartItemsVisa();
        }
        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullAMEX()
        {
            lgac.GuestCookieAccept();
            woac.MXAdd2ItemsPayInFull();
            cart.MXCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void WOGuest2ItemsPayInFullVisa()
        {
            lgac.GuestCookieAccept();
            woac.MXAdd2ItemsPayInFull();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullAMEX()
        {
            lgac.GuestCookieAccept();
            woac.MXAddRecurringAndPayInFull();
            cart.MXCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void WOGuestRecurringAndPayInFullVisa()
        {
            lgac.GuestCookieAccept();
            woac.MXAddRecurringAndPayInFull();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]
        public void PartnerInstallmentSingleRecurringAMEX()
        {
            lgac.MXLoginAsPartner();
            woac.MXAddVegFruitCapsuleToCart();
            cart.MXPartnerCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void PartnerInstallmentSingleRecurringVisa()
        {
            lgac.MXLoginAsPartner();
            woac.MXAddVegFruitCapsuleToCart();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void PartnerFullPayRecurSingleItemAMEX()
        {
            lgac.MXLoginAsPartner();
            woac.MXAddOmegaToCartRecurring();
            cart.MXPartnerCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void PartnerFullPayRecurSingleItemVisa()
        {
            lgac.MXLoginAsPartner();
            woac.MXAddOmegaToCartRecurring();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Partner2ItemsInstallmentAMEX()
        {
            lgac.MXLoginAsPartner();
            woac.MXAdd2ItemsToCart();
            cart.MXPartnerCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Partner2ItemsInstallmentVisa()
        {
            lgac.MXLoginAsPartner();
            woac.MXAdd2ItemsToCart();
            cart.MXCheckoutWithCartItemsVisa();
        }
        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Partner2ItemsPayInFullAMEX()
        {
            lgac.MXLoginAsPartner();
            woac.MXAdd2ItemsPayInFull();
            cart.MXPartnerCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Partner2ItemsPayInFullVisa()
        {
            lgac.MXLoginAsPartner();
            woac.MXAdd2ItemsPayInFull();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void PartnerRecurringAndPayInFullAMEX()
        {
            lgac.MXLoginAsPartner();
            woac.MXAddRecurringAndPayInFull();
            cart.MXPartnerCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void PartnerRecurringAndPayInFullVisa()
        {
            lgac.MXLoginAsPartner();
            woac.MXAddRecurringAndPayInFull();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]
        public void CustomerInstallmentSingleRecurringAMEX()
        {
            lgac.MXLoginAsGuest();
            woac.MXAddVegFruitCapsuleToCart();
            cart.MXCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void CustomerInstallmentSingleRecurringVisa()
        {
            lgac.GuestCookieAccept();
            woac.MXAddVegFruitCapsuleToCart();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void CustomerFullPayRecurSingleItemAMEX()
        {
            lgac.GuestCookieAccept();
            woac.MXAddOmegaToCartRecurring();
            cart.MXCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void CustomerFullPayRecurSingleItemVisa()
        {
            lgac.GuestCookieAccept();
            woac.MXAddOmegaToCartRecurring();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Customer2ItemsInstallmentAMEX()
        {
            lgac.GuestCookieAccept();
            woac.MXAdd2ItemsToCart();
            cart.MXCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Customer2ItemsInstallmentVisa()
        {
            lgac.GuestCookieAccept();
            woac.MXAdd2ItemsToCart();
            cart.MXCheckoutWithCartItemsVisa();
        }
        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Customer2ItemsPayInFullAMEX()
        {
            lgac.GuestCookieAccept();
            woac.MXAdd2ItemsPayInFull();
            cart.MXCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Customer2ItemsPayInFullVisa()
        {
            lgac.GuestCookieAccept();
            woac.MXAdd2ItemsPayInFull();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void CustomerRecurringAndPayInFullAMEX()
        {
            lgac.GuestCookieAccept();
            woac.MXAddRecurringAndPayInFull();
            cart.MXCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void CustomertRecurringAndPayInFullVisa()
        {
            lgac.GuestCookieAccept();
            woac.MXAddRecurringAndPayInFull();
            cart.MXCheckoutWithCartItemsVisa();
        }

        public void GmailInstallmentSingleRecurringVisa()
        {
            lgac.GuestCookieAccept();
            woac.MXAddVegFruitCapsuleToCart();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void GmailFullPayRecurSingleItemAMEX()
        {
            lgac.MXLoginGmail();
            woac.MXAddOmegaToCartRecurring();
            cart.MXPartnerCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void GmailFullPayRecurSingleItemVisa()
        {
            lgac.MXLoginGmail();
            woac.MXAddOmegaToCartRecurring();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Gmail2ItemsInstallmentAMEX()
        {
            lgac.MXLoginGmail();
            woac.MXAdd2ItemsToCart();
            cart.MXPartnerCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Gmail2ItemsInstallmentVisa()
        {
            lgac.MXLoginGmail();
            woac.MXAdd2ItemsToCart();
            cart.MXCheckoutWithCartItemsVisa();
        }
        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Gmail2ItemsPayInFullAMEX()
        {
            lgac.MXLoginGmail();
            woac.MXAdd2ItemsPayInFull();
            cart.MXPartnerCheckoutWithCartItemsAMEX();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void Gmail2ItemsPayInFullVisa()
        {
            lgac.MXLoginGmail();
            woac.MXAdd2ItemsPayInFull();
            cart.MXCheckoutWithCartItemsVisa();
        }


        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void GMailRecurringAndPayInFullVisa()
        {
            lgac.MXLoginGmail();
            woac.MXAddRecurringAndPayInFull();
            cart.MXCheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]

        public void GMailRecurringAndPayInFullAMEX()
        {
            lgac.MXLoginGmail();
            woac.MXAddRecurringAndPayInFull();
            cart.MXPartnerCheckoutWithCartItemsAMEX();
        }




        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]
        public void OfflineShipmentOxxo()
        {
            lgac.GuestCookieAccept();
            woac.MXAddOmegaToCartShipment();
            cart.MXOfflineCheckoutWithCartItems();
            cart.OtherOxxo();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]
        public void OfflineShipmentBnamex()
        {
            lgac.GuestCookieAccept();
            woac.MXAddOmegaToCartShipment();
            cart.MXOfflineCheckoutWithCartItems();
            cart.OtherBnamex();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]
        public void OfflineShipmentSerfin()
        {
            lgac.GuestCookieAccept();
            woac.MXAddOmegaToCartShipment();
            cart.MXOfflineCheckoutWithCartItems();
            cart.OtherSerfin();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]
        public void OfflineShipmentBancomer()
        {
            lgac.GuestCookieAccept();
            woac.MXAddOmegaToCartShipment();
            cart.MXOfflineCheckoutWithCartItems();
            cart.OtherBancomer();
        }

        [Test]
        [Category("smoketest-mx")]
        [Category("alltest")]
        public void OfflineShipmentPlsUseCC()
        {
            lgac.GuestCookieAccept();
            woac.MXAddOmegaToCartRecurring();
            cart.MXOfflineCheckoutWithCartItems();
            cart.OtherPlsUseCC();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }
    }
}
