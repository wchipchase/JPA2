using AutomationTests.ConfigElements;
using AutomationTests.PageObjects.juiceplus.com;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AutomationTests.PageActions.rccq.juiceplus.com.CheckoutActions
{
    class CheckoutActions
    {

        public static void InputShippingAndBillingInfo(String firstName, String lastName, String phoneNumber, String emailAddress, String address, String zip, String city, String state, String country, Boolean sameBillingInformation, Boolean hasRefferingRep)
        {
            CheckoutPage CheckoutPage = new CheckoutPage();
            CheckoutPage.FirstName.SendKeys(firstName);
            CheckoutPage.LastName.SendKeys(lastName);
            CheckoutPage.PhoneNumber.SendKeys(phoneNumber);
            CheckoutPage.EmailAddress.SendKeys(emailAddress);
            CheckoutPage.AddressLine1.SendKeys(address);

            if (country.Equals("US"))
            {
                ZipLookup(zip, city);
            }
            else
            {
                SelectElement StateSelect = new SelectElement(CheckoutPage.StateSelect);
                CheckoutPage.City.SendKeys(city);
                StateSelect.SelectByText(state);
                CheckoutPage.Zip.SendKeys(zip);
            }            

            if (sameBillingInformation)
            {
                CheckoutPage.BillingInformationYesRadio.Click();
            }
            else
            {
                CheckoutPage.BillingInformationNoRadio.Click();
            }
                
            if (hasRefferingRep)
            {
                CheckoutPage.RefferingRepInfoYesRadio.Click();
            }
            else
            {
                CheckoutPage.RefferingRepInfoNoRadio.Click();
            }

            Thread.Sleep(1000);

            CheckoutPage.ShippingBillingContinueButton.Click();
        }

        public static void InputPaymentMethod(String creditCardType, String creditCardNumber, String expMonth, String expYear, String cvv)
        {
            CheckoutPage CheckoutPage = new CheckoutPage();

            WaitUntilElementVisible(By.XPath("//p[contains(text(),'How would you like to pay?')]"), 15);

            SelectElement CreditCardType = new SelectElement(CheckoutPage.CreditCardType);
            SelectElement CreditCardExpMonth = new SelectElement(CheckoutPage.CreditCardExpMonth);
            SelectElement CreditCardExpYear = new SelectElement(CheckoutPage.CreditCardExpYear);

            CreditCardType.SelectByText(creditCardType);
            CheckoutPage.CreditCardNumber.SendKeys(creditCardNumber);
            CreditCardExpMonth.SelectByValue(expMonth);
            CreditCardExpYear.SelectByValue(expYear);

            try
            {
                CheckoutPage.CreditCardCVV.SendKeys(cvv);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            CheckoutPage.PaymentMethodContinueButton.Click();
        }

        public static void CompletePurchase()
        {
            CheckoutPage CheckoutPage = new CheckoutPage();
            CheckoutPage.PurchaseButton.Click();
        }
        public static void ZipLookup(String zip, String city)
        {
            CheckoutPage CheckoutPage = new CheckoutPage();

            CheckoutPage.Zip.SendKeys(zip);
            CheckoutPage.ZipLookupButton.Click();

            Thread.Sleep(1000);

            SelectElement CitySelect = new SelectElement(CheckoutPage.CitySelect);
            CitySelect.SelectByValue(city);
            CheckoutPage.CitySelectGoButton.Click();
        }

        public static IWebElement WaitUntilElementVisible(By elementLocator, int timeout)
        {
            try
            {
                var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found.");
                throw;
            }
        }

    }
}
