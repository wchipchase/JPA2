using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CheckoutPage
{
    class CheckoutPageObjects
    {

        public CheckoutPageObjects()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        public void ScrollViewport()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(500);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//h2[contains(.,'New to Juice Plus+?')]")]
        public IWebElement CheckoutPageLabel { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(.,'Sign in')]")]
        public IWebElement SignInPath { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(.,'Address')]")]
        public IWebElement AddressPath { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(.,'Sign in')]")]
        public IWebElement PaymentPath { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "button[data-test-id='login-submit']")]
        public IWebElement LoginButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "username")]
        public IWebElement UsernameInput { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "password")]
        public IWebElement PasswordInput { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//label[contains(.,'Remember Me')]")]
        public IWebElement RememberMeCheckBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(.,'Forgot Password?')]")]
        public IWebElement ForgotPasswordLink { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//article[@class='m-widget m-login-widget m-checkout__login-widget']//a[contains(.,'Login')]")]
        public IWebElement LoginUsernamePasswordButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-social-login__button--google")]
        public IWebElement GoogleLoginButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-social-login__button--facebook")]
        public IWebElement FacebookLoginButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Create an account']")]
        public IWebElement CreateAnAccountButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-error-container js-m-error-container m-credit-card-selection__card-field js-input-container m-error-container--active']//p[contains(.,'This field has the wrong pattern')]")]
        public IWebElement CCErrorMessage { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Checkout as guest']")]
        public IWebElement CheckoutAsGuestButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.contact.firstName")]
        public IWebElement FirstNameShippingTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.contact.lastName")]
        public IWebElement LastNameShippingTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.contact.phoneNumber")]
        public IWebElement DaytimePhoneNumberShippingTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.contact.alternativePhoneNumber")]
        public IWebElement AlternatePhoneNumberShippingTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.contact.email")]
        public IWebElement EmailShippingTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.street1")]
        public IWebElement StreetAddressDeliveryTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.street2")]
        public IWebElement AptSuiteDeliveryTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.street3")]
        public IWebElement OptionalStreetAddressDeliveryTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.city")]
        public IWebElement CityDeliveryTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.state")]
        public IWebElement StateDeliveryTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.county")]
        public IWebElement CountyDeliveryTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[for='input-checkbox-k0ao2axo5']")]
        public IWebElement BillingAddressCheckbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//label[contains(.,'Yes')]")]
        public IWebElement ReferringRepYesRadioButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//label[contains(.,'No')]")]
        public IWebElement ReferringRepNoRadioButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@name='referral.partnerName']//input[@class='m-typeahead__input']")]
        public IWebElement ReferringRepNameIdTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(.,'Martin Deegan')]")]
        public IWebElement ReferringRepNameTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "m-order-summary__item-price")]
        public IWebElement OrderSummaryItemPrice { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "m-order-summary__option-total-value")]
        public IWebElement OrderSummaryPerShipmentPrice { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "m-order-summary__total-price")]
        public IWebElement OrderSummaryTotalPrice { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Proceed to checkout']")]
        public IWebElement ProceedToCheckoutButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//input[@value='visa']")]
        public IWebElement VisaPaymentMethodButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//input[@value='mc']")]
        public IWebElement MCPaymentMethodButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "payment.cardNumber")]
        public IWebElement PaymentCCNumberTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "payment.expiration")]
        public IWebElement PaymentCCExpirationDateTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "payment.cvv")]
        public IWebElement PaymentCVVTextbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//input[@name='termsAndConditionsAccepted']")]
        public IWebElement TOSAcceptCheckbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//label[.='I would like to receive promotions, offers and communication from Juice Plus+.']")]
        public IWebElement OptInAcceptCheckbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Confirm order']")]
        public IWebElement ConfirmOrderButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-checkout-confirmation__title")]
        public IWebElement OrderConfirmationVerbiage { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.street1")]
        public IWebElement DeliveryAddress1 { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.street2")]
        public IWebElement DeliveryAddress2 { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.city")]
        public IWebElement DeliveryCity { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.county")]
        public IWebElement DeliveryCounty { get; set; }
    }
}
