using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.juiceplus.com
{
    class CheckoutPage
    {
        public CheckoutPage()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "customerOrder.orderShipment.shippingPerson.firstName")]
        public IWebElement FirstName { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "customerOrder.orderShipment.shippingPerson.lastName")]
        public IWebElement LastName { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "customerOrder.orderShipment.shippingPhone.dialNumber")]
        public IWebElement PhoneNumber { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "customerOrder.orderShipment.shippingEmail.addrLine")]
        public IWebElement EmailAddress { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "customerOrder.orderShipment.shippingAddress.line1")]
        public IWebElement AddressLine1 { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "customerOrder.orderShipment.shippingAddress.postalCode")]
        public IWebElement Zip { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "chkSameAsShipping")]
        public IWebElement BillingInformationYesRadio { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "chkNotSameAsShipping")]
        public IWebElement BillingInformationNoRadio { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "rdoReferredYes")]
        public IWebElement RefferingRepInfoYesRadio { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "rdoReferredNo")]
        public IWebElement RefferingRepInfoNoRadio { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "a[onclick='nextStep();']")]
        public IWebElement ShippingBillingContinueButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "btnShippingZipLookup")]
        public IWebElement ZipLookupButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "citySelectBox")]
        public IWebElement CitySelect { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "selectCity")]
        public IWebElement CitySelectGoButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "customerOrder.orderShipment.shippingAddress.city")]
        public IWebElement City { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "customerOrder.orderShipment.shippingAddress.state")]
        public IWebElement StateSelect { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "selPaymentType")]
        public IWebElement CreditCardType { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "customerOrder.orderPayment.creditcardPayment.cardNumber")]
        public IWebElement CreditCardNumber { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "selExpMonth")]
        public IWebElement CreditCardExpMonth { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "selExpYear")]
        public IWebElement CreditCardExpYear { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "customerOrder.orderPayment.creditcardPayment.cvv")]
        public IWebElement CreditCardCVV { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "continue-btn")]
        public IWebElement PaymentMethodContinueButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "next-button")]
        public IWebElement PurchaseButton { get; set; }
    }
}
