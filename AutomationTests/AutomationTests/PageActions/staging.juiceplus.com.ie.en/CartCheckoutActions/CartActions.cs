using AutomationTests.Config;
using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.IndividualCapsuleActions;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CapsulesPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CartPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CheckoutPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.ChewablesPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.staging.juiceplus.com.ie.en.CartCheckoutActions
{
    class CartActions
    {
        Driver Driver;
        public CartActions(Driver driver)
        {
            Driver = driver;
        }
        public IWebElement WaitUntilElementVisible(By elementLocator, int timeout = 10)
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

        public void NavigateToProceedToCheckoutAndClick()
        {
            try
            {
                CartPageObjects cpo = new CartPageObjects(Driver);
                IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
                js.ExecuteScript("arguments[0].click();", cpo.ProceedToCheckoutButton);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public void CheckoutWithCartItemsVisa()
        {
            try
            {
                IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(60));
                NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
                ChewablesPageObjects cpo = new ChewablesPageObjects(Driver);
                //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
                //nav.CheckoutButton.Click();
                ////waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Proceed to checkout']")));
                //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Your Cart"));
                //CartPageObjects cpo = new CartPageObjects();
                //cpo.ProceedToCheckoutButton.Click();
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Checkout as guest']")));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("New to Juice Plus+?"));
                CheckoutPageObjects cop = new CheckoutPageObjects(Driver);
                cop.CheckoutAsGuestButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Billing Address"));
                Thread.Sleep(500);
                cop.FirstNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.FirstNameShipping.FirstName1);
                cop.LastNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.LastNameShipping.LastName1);
                cop.DaytimePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhone1);
                cop.AlternatePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.AlternatePhoneShipping.AlternatePhone1);
                cop.EmailShippingTextbox.SendKeys(AddressInfo.ShippingAddress.EmailShipping.Email1);
                cop.StreetAddressDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StreetAddShipping.StreetAdd1);
                cop.OptionalStreetAddressDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.OptionalStreetShipping.OptionalStreet);
                cop.CityDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CityShipping.City1);
                cop.CountyDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CountyShipping.County);
                js.ExecuteScript("arguments[0].click();", cop.ReferringRepNoRadioButton);
                /*js.ExecuteScript("arguments[0].click();", cop.ReferringRepYesRadioButton);
                cop.ReferringRepNameIdTextbox.SendKeys("IR002626");
                //Actions action = new Actions(Driver.WebDriver);
                //action.MoveToElement(cop.ReferringRepNameTextbox).Perform();*/
                cpo.ScrollViewport();
               /* waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(.,'Martin Deegan')]")));
                Thread.Sleep(3000);
                cop.ReferringRepNameTextbox.Click();*/
                cop.ProceedToCheckoutButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("payment.cardNumber")));
                Thread.Sleep(500);
                cop.PaymentCCNumberTextbox.SendKeys(CreditCardInfo.CreditCardNumber.VisaCCNum.ccnumberValid);
                cop.PaymentCCExpirationDateTextbox.SendKeys(CreditCardInfo.CCExpDate.VisaCCExpDate.VisaCCExpDateValid);
                cop.PaymentCVVTextbox.SendKeys(CreditCardInfo.CreditCardCCV.VisaCCV.VisaCCVValid);
                js.ExecuteScript("arguments[0].click();", cop.TOSAcceptCheckbox);
                js.ExecuteScript("arguments[0].click();", cop.ConfirmOrderButton);   
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-checkout-confirmation__title")));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Thank you! Your order is confirmed."));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }

        public void USCheckoutWithCartItemsVisa()
        {
            try
            {
                IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
                NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
                ChewablesPageObjects cpo = new ChewablesPageObjects(Driver);
                //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
                //nav.CheckoutButton.Click();
                ////waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Proceed to checkout']")));
                //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Your Cart"));
                //CartPageObjects cpo = new CartPageObjects();
                //cpo.ProceedToCheckoutButton.Click();
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Checkout as guest']")));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("New to Juice Plus+?"));
                CheckoutPageObjects cop = new CheckoutPageObjects(Driver);
                cop.CheckoutAsGuestButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Billing Address"));
                Thread.Sleep(500);
                cop.FirstNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.FirstNameShipping.FirstName1);
                cop.LastNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.LastNameShipping.LastName1);
                cop.DaytimePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhone1);
                cop.AlternatePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.AlternatePhoneShipping.AlternatePhone1);
                cop.EmailShippingTextbox.SendKeys(AddressInfo.ShippingAddress.EmailShipping.Email1);
                cop.StreetAddressDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StreetAddShipping.StreetAdd1);
                cop.CityDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CityShipping.CityUS1);
                cop.StateDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StateShipping.StateUS1);
                cop.ScrollViewport();
                cop.PostalCodeTextbox.SendKeys(AddressInfo.ShippingAddress.ZipCode.ZipcodeUS1);
                cop.CountyDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CountyShipping.CountyUS1);
                js.ExecuteScript("arguments[0].click();", cop.ReferringRepNoRadioButton);
                /*js.ExecuteScript("arguments[0].click();", cop.ReferringRepYesRadioButton);
                cop.ReferringRepNameIdTextbox.SendKeys("IR002626");
                //Actions action = new Actions(Driver.WebDriver);
                //action.MoveToElement(cop.ReferringRepNameTextbox).Perform();*/
                cpo.ScrollViewport();
                /* waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(.,'Martin Deegan')]")));
                 Thread.Sleep(3000);
                 cop.ReferringRepNameTextbox.Click();*/
                cop.ProceedToCheckoutButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("payment.cardNumber")));
                Thread.Sleep(500);
                cop.PaymentCCNumberTextbox.SendKeys(CreditCardInfo.CreditCardNumber.VisaCCNum.ccnumberValid);
                cop.PaymentCCExpirationDateTextbox.SendKeys(CreditCardInfo.CCExpDate.VisaCCExpDate.VisaCCExpDateValid);
                cop.PaymentCVVTextbox.SendKeys(CreditCardInfo.CreditCardCCV.VisaCCV.VisaCCVValid);
                js.ExecuteScript("arguments[0].click();", cop.TOSAcceptCheckbox);
                js.ExecuteScript("arguments[0].click();", cop.ConfirmOrderButton);
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-checkout-confirmation__title")));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Thank you! Your order is confirmed."));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }

        public void MXCheckoutWithCartItemsVisa()
        {
            try
            {
                IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
                NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
                ChewablesPageObjects cpo = new ChewablesPageObjects(Driver);
                //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
                //nav.CheckoutButton.Click();
                ////waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Proceed to checkout']")));
                //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Your Cart"));
                //CartPageObjects cpo = new CartPageObjects();
                //cpo.ProceedToCheckoutButton.Click();
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Checkout as guest']")));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("New to Juice Plus+?"));
                CheckoutPageObjects cop = new CheckoutPageObjects(Driver);
                cop.CheckoutAsGuestButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Billing Address"));
                Thread.Sleep(500);
                cop.FirstNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.FirstNameShipping.FirstName1);
                cop.LastNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.LastNameShipping.LastName1);
                cop.DaytimePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhoneMex1);
                cop.AlternatePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.AlternatePhoneShipping.AlternatePhoneMex1);
                cop.EmailShippingTextbox.SendKeys(UserInfo.UserEmail.UserEmailMex1);
                cop.StreetAddressDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StreetAddShipping.StreetAddMex1);
                cop.MXDeliveryNeighborhood.SendKeys(AddressInfo.ShippingAddress.NeighborhoodorColony.NeighborhoodMex1);
                cop.CityDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CityShipping.CityMex1);
                cop.StateDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StateShipping.StateMex1);
                cop.ScrollViewport();
                cop.PostalCodeTextbox.SendKeys(AddressInfo.ShippingAddress.ZipCode.ZipCodeMex1);
               // cop.CountyDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CountyShipping.CountyUS1);
                js.ExecuteScript("arguments[0].click();", cop.ReferringRepNoRadioButton);
                /*js.ExecuteScript("arguments[0].click();", cop.ReferringRepYesRadioButton);
                cop.ReferringRepNameIdTextbox.SendKeys("IR002626");
                //Actions action = new Actions(Driver.WebDriver);
                //action.MoveToElement(cop.ReferringRepNameTextbox).Perform();*/
                cpo.ScrollViewport();
                /* waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(.,'Martin Deegan')]")));
                 Thread.Sleep(3000);
                 cop.ReferringRepNameTextbox.Click();*/
                cop.ProceedToCheckoutButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("payment.cardNumber")));
                Thread.Sleep(500);
                cop.PaymentCCNumberTextbox.SendKeys(CreditCardInfo.CreditCardNumber.VisaCCNum.VisaCCNumberValidMex1);
                cop.PaymentCCExpirationDateTextbox.SendKeys(CreditCardInfo.CCExpDate.VisaCCExpDate.VisaCCExpDateValidMex1);
                cop.PaymentCVVTextbox.SendKeys(CreditCardInfo.CreditCardCCV.VisaCCV.VisaCCValidMex1);
                js.ExecuteScript("arguments[0].click();", cop.TOSAcceptCheckbox);
                js.ExecuteScript("arguments[0].click();", cop.ConfirmOrderButton);
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-checkout-confirmation__title")));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Thank you! Your order is confirmed."));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }

        public void CheckoutWithCartItemsMC()
        {
            try
            {
                IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(60));
                NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
                ChewablesPageObjects cpo = new ChewablesPageObjects(Driver);
                //nav.CheckoutButton.Click();
                //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Your Cart"));
                //CartPageObjects cpo = new CartPageObjects();
                //cpo.ProceedToCheckoutButton.Click();

                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Checkout as guest']")));
                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("New to Juice Plus+?"));
                }

                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                CheckoutPageObjects cop = new CheckoutPageObjects(Driver);
                cop.CheckoutAsGuestButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Billing Address"));
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("shipping.contact.firstName")));
                Thread.Sleep(500);
                cop.FirstNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.FirstNameShipping.FirstName1);
                cop.LastNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.LastNameShipping.LastName1);
                cop.DaytimePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhone1);
                cop.AlternatePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.AlternatePhoneShipping.AlternatePhone1);
                cop.EmailShippingTextbox.SendKeys(AddressInfo.ShippingAddress.EmailShipping.Email1);
                cop.StreetAddressDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StreetAddShipping.StreetAdd1);
                cop.OptionalStreetAddressDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.OptionalStreetShipping.OptionalStreet);
                cop.CityDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CityShipping.City1);
                cop.CountyDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CountyShipping.County);
                js.ExecuteScript("arguments[0].click();", cop.ReferringRepNoRadioButton);
                /*js.ExecuteScript("arguments[0].click();", cop.ReferringRepYesRadioButton);
                cop.ReferringRepNameIdTextbox.SendKeys("IR002626");*/
                cpo.ScrollViewport();
                /*waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(.,'Martin Deegan')]"))); 
                Actions action = new Actions(Driver.WebDriver);
                action.MoveToElement(cop.ReferringRepNameTextbox).Perform();
                cop.ReferringRepNameTextbox.Click();*/
                try
                {
                    IWebElement click1 = cop.ProceedToCheckoutButton;
                    click1.Click();
                }
                catch (Exception e)
                {
                    nav.CartIconCounter.Click();
                    IWebElement click2 = cop.ProceedToCheckoutButton;
                    click2.Click();
                }
                //cop.ProceedToCheckoutButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("payment.cardNumber")));
                Thread.Sleep(500);
                js.ExecuteScript("arguments[0].click();", cop.MCPaymentMethodButton);
                cop.PaymentCCNumberTextbox.SendKeys(CreditCardInfo.CreditCardNumber.MasterCardCCNum.ccnumberValid);
                cop.PaymentCCExpirationDateTextbox.SendKeys(CreditCardInfo.CCExpDate.MasterCardCCExpDate.MasterCardCCExpDateValid);
                cop.PaymentCVVTextbox.SendKeys(CreditCardInfo.CreditCardCCV.MasterCardCCV.MasterCardCCVValid);
                js.ExecuteScript("arguments[0].click();", cop.TOSAcceptCheckbox);
                js.ExecuteScript("arguments[0].click();", cop.ConfirmOrderButton);

                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-checkout-confirmation__title")));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Thank you! Your order is confirmed."));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }

        public void MXCheckoutWithCartItemsMC()
        {
            try
            {
                IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(60));
                NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
                ChewablesPageObjects cpo = new ChewablesPageObjects(Driver);
                //nav.CheckoutButton.Click();
                //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Your Cart"));
                //CartPageObjects cpo = new CartPageObjects();
                //cpo.ProceedToCheckoutButton.Click();

                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Checkout as guest']")));
                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("New to Juice Plus+?"));
                }

                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                CheckoutPageObjects cop = new CheckoutPageObjects(Driver);
                cop.CheckoutAsGuestButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Billing Address"));
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("shipping.contact.firstName")));
                Thread.Sleep(500);
                cop.FirstNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.FirstNameShipping.FirstName1);
                cop.LastNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.LastNameShipping.LastName1);
                cop.DaytimePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhoneMex1);
                cop.AlternatePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.AlternatePhoneShipping.AlternatePhoneMex1);
                cop.GenderDropdown.Click();
                cop.MaleSelection.Click();
                cop.EmailShippingTextbox.SendKeys(UserInfo.UserEmail.UserEmailMex1);
                cop.StreetAddressDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StreetAddShipping.StreetAddMex1);
                cop.MXDeliveryNeighborhood.SendKeys(AddressInfo.ShippingAddress.NeighborhoodorColony.NeighborhoodMex1);
                cop.CityDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CityShipping.CityMex1);
                cop.StateDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StateShipping.StateMex1);
                cop.ScrollViewport();
                cop.PostalCodeTextbox.SendKeys(AddressInfo.ShippingAddress.ZipCode.ZipCodeMex1);
                js.ExecuteScript("arguments[0].click();", cop.ReferringRepNoRadioButton);
                /*js.ExecuteScript("arguments[0].click();", cop.ReferringRepYesRadioButton);
                cop.ReferringRepNameIdTextbox.SendKeys("IR002626");*/
                cpo.ScrollViewport();
                /*waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(.,'Martin Deegan')]"))); 
                Actions action = new Actions(Driver.WebDriver);
                action.MoveToElement(cop.ReferringRepNameTextbox).Perform();
                cop.ReferringRepNameTextbox.Click();*/
                try
                {
                    IWebElement click1 = cop.ProceedToCheckoutButton;
                    click1.Click();
                }
                catch (Exception e)
                {
                    nav.CartIconCounter.Click();
                    IWebElement click2 = cop.ProceedToCheckoutButton;
                    click2.Click();
                }
                //cop.ProceedToCheckoutButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("payment.cardNumber")));
                Thread.Sleep(500);
                js.ExecuteScript("arguments[0].click();", cop.MCPaymentMethodButton);
                cop.PaymentCCNumberTextbox.SendKeys(CreditCardInfo.CreditCardNumber.MasterCardCCNum.MCCCNumberValidMex1);
                cop.PaymentCCExpirationDateTextbox.SendKeys(CreditCardInfo.CCExpDate.MasterCardCCExpDate.MCCCExpDateValidMex1);
                cop.PaymentCVVTextbox.SendKeys(CreditCardInfo.CreditCardCCV.MasterCardCCV.MXMasterCardCCVValid);
                js.ExecuteScript("arguments[0].click();", cop.TOSAcceptCheckbox);
                js.ExecuteScript("arguments[0].click();", cop.ConfirmOrderButton);

                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-checkout-confirmation__title")));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Thank you! Your order is confirmed."));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }

        public void MXCheckoutWithCartItemsAMEX()
        {
            try
            {
                IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(60));
                NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
                ChewablesPageObjects cpo = new ChewablesPageObjects(Driver);
                //nav.CheckoutButton.Click();
                //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Your Cart"));
                //CartPageObjects cpo = new CartPageObjects();
                //cpo.ProceedToCheckoutButton.Click();

                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Checkout as guest']")));
                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("New to Juice Plus+?"));
                }

                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                CheckoutPageObjects cop = new CheckoutPageObjects(Driver);
                cop.CheckoutAsGuestButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Billing Address"));
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("shipping.contact.firstName")));
                Thread.Sleep(500);
                cop.FirstNameShippingTextbox.SendKeys("APRO");
                cop.LastNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.LastNameShipping.LastName1);
                cop.DaytimePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhoneMex1);
                cop.AlternatePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.AlternatePhoneShipping.AlternatePhoneMex1);
                cop.GenderDropdown.Click();
                cop.MaleSelection.Click();
                cop.EmailShippingTextbox.SendKeys(UserInfo.UserEmail.UserEmailMex1);
                cop.StreetAddressDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StreetAddShipping.StreetAddMex1);
                cop.MXDeliveryNeighborhood.SendKeys(AddressInfo.ShippingAddress.NeighborhoodorColony.NeighborhoodMex1);
                cop.CityDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CityShipping.CityMex1);
                cop.StateDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StateShipping.StateMex1);
                cop.ScrollViewport();
                cop.PostalCodeTextbox.SendKeys(AddressInfo.ShippingAddress.ZipCode.ZipCodeMex1);
                js.ExecuteScript("arguments[0].click();", cop.ReferringRepNoRadioButton);
                /*js.ExecuteScript("arguments[0].click();", cop.ReferringRepYesRadioButton);
                cop.ReferringRepNameIdTextbox.SendKeys("IR002626");*/
                cpo.ScrollViewport();
                /*waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(.,'Martin Deegan')]"))); 
                Actions action = new Actions(Driver.WebDriver);
                action.MoveToElement(cop.ReferringRepNameTextbox).Perform();
                cop.ReferringRepNameTextbox.Click();*/
                try
                {
                    IWebElement click1 = cop.ProceedToCheckoutButton;
                    click1.Click();
                }
                catch (Exception e)
                {
                    nav.CartIconCounter.Click();
                    IWebElement click2 = cop.ProceedToCheckoutButton;
                    click2.Click();
                }
                //cop.ProceedToCheckoutButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("payment.cardNumber")));
                Thread.Sleep(500);
                js.ExecuteScript("arguments[0].click();", cop.AMEXPaymentMethodButton);
                cop.PaymentCCNumberTextbox.SendKeys(CreditCardInfo.CreditCardNumber.AmexCCNum.AmexCCNumberValidMex1);
                cop.PaymentCCExpirationDateTextbox.SendKeys(CreditCardInfo.CCExpDate.AmexCardCCExpDate.AmexCCExpDateValidMex1);
                cop.PaymentCVVTextbox.SendKeys(CreditCardInfo.CreditCardCCV.AmexCCV.AmexCardCCValidMex1);
                js.ExecuteScript("arguments[0].click();", cop.TOSAcceptCheckbox);
                js.ExecuteScript("arguments[0].click();", cop.ConfirmOrderButton);

                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-checkout-confirmation__title")));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Thank you! Your order is confirmed."));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }

        public void CheckoutWithCartItemsVisaLoggedInRep()
        {
            try
            {
                IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
                NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
                ChewablesPageObjects cpo = new ChewablesPageObjects(Driver);
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Checkout as guest']")));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("New to Juice Plus+?"));
                CheckoutPageObjects cop = new CheckoutPageObjects(Driver);
                cop.LoginUsernamePasswordButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Shipping Address"));
                Thread.Sleep(500);
                cop.FirstNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.FirstNameShipping.FirstName1);
                cop.LastNameShippingTextbox.SendKeys(AddressInfo.ShippingAddress.LastNameShipping.LastName1);
                cop.DaytimePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhone1);
                cop.AlternatePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.AlternatePhoneShipping.AlternatePhone1);
                cop.EmailShippingTextbox.SendKeys(AddressInfo.ShippingAddress.EmailShipping.Email1);
                cop.StreetAddressDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StreetAddShipping.StreetAdd1);
                cop.OptionalStreetAddressDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.OptionalStreetShipping.OptionalStreet);
                cop.CityDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CityShipping.City1);
                cop.CountyDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CountyShipping.County);
                js.ExecuteScript("arguments[0].click();", cop.ReferringRepYesRadioButton);
                cop.ReferringRepNameIdTextbox.SendKeys("IR002626");
                //Actions action = new Actions(Driver.WebDriver);
                //action.MoveToElement(cop.ReferringRepNameTextbox).Perform();
                cpo.ScrollViewport();
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(.,'Martin Deegan')]")));
                Thread.Sleep(3000);
                cop.ReferringRepNameTextbox.Click();
                cop.ProceedToCheckoutButton.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("payment.cardNumber")));
                Thread.Sleep(500);
                cop.PaymentCCNumberTextbox.SendKeys(CreditCardInfo.CreditCardNumber.VisaCCNum.ccnumberValid);
                cop.PaymentCCExpirationDateTextbox.SendKeys(CreditCardInfo.CCExpDate.VisaCCExpDate.VisaCCExpDateValid);
                cop.PaymentCVVTextbox.SendKeys(CreditCardInfo.CreditCardCCV.VisaCCV.VisaCCVValid);
                js.ExecuteScript("arguments[0].click();", cop.TOSAcceptCheckbox);
                js.ExecuteScript("arguments[0].click();", cop.ConfirmOrderButton);
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-checkout-confirmation__title")));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Thank you! Your order is confirmed."));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }

    }
}