using AutomationTests.Config;
using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.PartnerPortal;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CapsulesPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CartPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CheckoutPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.ChewablesPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.CapsulesPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.ChewablesPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.PartnerPortal
{


    class PPCartActions
    {
        Driver Driver;
        NavigationActions navac;
        public PPCartActions(Driver driver)
        {
            Driver = driver;
            navac = new NavigationActions(Driver);
        }

        public void NavigateToJuicePlusWebsite()
        {
            LandingPageObjects lan = new LandingPageObjects(Driver);
            CheckoutPageObjects cpo = new CheckoutPageObjects(Driver);
            Driver.WebDriver.Navigate().GoToUrl("https://sculpt.staging.juiceplus.com/ie/en");
            lan.CookieAlertAcceptButton.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Healthy Living Made Easier"));
        }

        public void USNavigateToJuicePlusWebsite()
        {
            LandingPageObjects lan = new LandingPageObjects(Driver);
            CheckoutPageObjects cpo = new CheckoutPageObjects(Driver);
            Driver.WebDriver.Navigate().GoToUrl("https://sculpt.staging.juiceplus.com/us/en");
            lan.CookieAlertAcceptButton.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Healthy Living Made Easier"));
        }

        public void AddProductsToCart()
        {
            CapsulesPageObjects cpo = new CapsulesPageObjects(Driver);
            
            CapsulesOrderPageObjects copo = new CapsulesOrderPageObjects(Driver);
            navac.NavigateOurProductsCapsulesClick();
            Task.Delay(500).Wait(1500);
            
            cpo.ScrollViewport("500");
            cpo.ShopNowFruitVegetableCapsules.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Juice Plus+"));
            cpo.ScrollViewport("1200");
            copo.AddToCartOrderCapsules.Click();
            Thread.Sleep(1000);
        }

        public void USAddProductsToCart()
        {
            CapsulesPageObjects cpo = new CapsulesPageObjects(Driver);

            CapsulesOrderPageObjects copo = new CapsulesOrderPageObjects(Driver);
            navac.NavigateOurProductsCapsulesClick();
            Task.Delay(500).Wait(1500);

            cpo.ScrollViewport("500");
            cpo.USShopNowFruitVegetableCapsules.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Juice Plus+"));
            cpo.ScrollViewport("1200");
            copo.AddToCartOrderCapsules.Click();
            Thread.Sleep(1000);
        }

        public void MXAddProductsToCart()
        {
            CapsulesPageObjects cpo = new CapsulesPageObjects(Driver);

            CapsulesOrderPageObjects copo = new CapsulesOrderPageObjects(Driver);
            navac.NavigateOurProductsCapsulesClick();
            Task.Delay(500).Wait(1500);

            cpo.ScrollViewport("500");
            cpo.MXShopNowFruitVegBerryCapsules.Click();
            //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Fruit, Vegetable & Berry Capsules"));
            cpo.ScrollViewport("1500");
            copo.AddToCartOrderCapsules.Click();
            Thread.Sleep(1000);
        }

        public void CheckoutWithItems()
        {
            NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
            CartPageObjects carp = new CartPageObjects(Driver);
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            nav.CartIconCounter.Click();
            //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='m-product-count-container__flyout-content m-flyout__content js-m-flyout__content m-flyout__content--attached m-flyout__content--dropdown']//span[@class='a-button__inner']")));
            try
            {
                IWebElement click1 = nav.CheckoutButton;
                click1.Click();
            }
            catch (Exception e)
            {
                nav.CartIconCounter.Click();
                IWebElement click2 = nav.CheckoutButton;
                click2.Click();
            }
            //nav.CheckoutButton.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Your Cart"));
            carp.NavigateToProceedToCheckoutAndClick();
            //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Login"));
        }

        public void CheckoutLogin()
        {
            CheckoutPageObjects cpo = new CheckoutPageObjects(Driver);
            Thread.Sleep(2000);
            cpo.UsernameInput.SendKeys("wddot");
            cpo.PasswordInput.SendKeys("wddot");
            cpo.LoginButton.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Delivery Address"));
        }

        public void FillInDeliveryAddressAndProceed()
        {
            CheckoutPageObjects cpo = new CheckoutPageObjects(Driver);
            Thread.Sleep(1000);
            cpo.ScrollViewport();
            cpo.DeliveryAddress1.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAdd1);
            cpo.DeliveryCity.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.City1);
            cpo.DeliveryCounty.SendKeys(Config.AddressInfo.ShippingAddress.CountyShipping.County);
            cpo.ProceedToCheckoutButton.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
        }

        public void USFillInDeliveryAddressAndProceed()
        {
            CheckoutPageObjects cpo = new CheckoutPageObjects(Driver);
            Thread.Sleep(1000);
            cpo.ScrollViewport();
            //cpo.DeliveryAddress1.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAddUS1);

            Thread.Sleep(3000);
            //cpo.DeliveryCity.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.CityUS1);
            cpo.StateDeliveryTextbox.SendKeys(Config.AddressInfo.ShippingAddress.StateShipping.StateUS1);
            cpo.CountyDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.CountyShipping.CountyUS1);
            cpo.ProceedToCheckoutButton.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
        }

        public void MXFillInDeliveryAddressAndProceed()
        {
            CheckoutPageObjects cpo = new CheckoutPageObjects(Driver);
            Thread.Sleep(1000);
            cpo.GenderDropdown.Click();
            cpo.MaleSelection.Click();
            cpo.DaytimePhoneNumberShippingTextbox.Clear();
            cpo.DaytimePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhoneMex1);
            cpo.AlternatePhoneNumberShippingTextbox.Clear();
            cpo.AlternatePhoneNumberShippingTextbox.SendKeys(AddressInfo.ShippingAddress.AlternatePhoneShipping.AlternatePhoneMex1);
            cpo.EmailShippingTextbox.Clear();
            cpo.EmailShippingTextbox.SendKeys(UserInfo.UserEmail.UserEmailMex1);
            cpo.ScrollViewport();
            cpo.DeliveryAddress1.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAddMex1);
            cpo.DeliveryCity.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.CityMex1);
            cpo.MXDeliveryNeighborhood.SendKeys(AddressInfo.ShippingAddress.NeighborhoodorColony.NeighborhoodMex1);
            cpo.StateDeliveryTextbox.SendKeys(AddressInfo.ShippingAddress.StateShipping.StateMex1);
            cpo.PostalCodeTextbox.SendKeys(AddressInfo.ShippingAddress.ZipCode.ZipCodeMex1);
            cpo.ProceedToCheckoutButton.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
        }

        public void EnterPaymentInfoAndConfirmOrder()
        {
            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            CheckoutPageObjects cpo = new CheckoutPageObjects(Driver);
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("payment.cardNumber")));
            Thread.Sleep(500);
            cpo.PaymentCCNumberTextbox.SendKeys(CreditCardInfo.CreditCardNumber.VisaCCNum.ccnumberValid);
            cpo.PaymentCCExpirationDateTextbox.SendKeys(CreditCardInfo.CCExpDate.VisaCCExpDate.VisaCCExpDateValid);
            cpo.PaymentCVVTextbox.SendKeys(CreditCardInfo.CreditCardCCV.VisaCCV.VisaCCVValid);
            js.ExecuteScript("arguments[0].click();", cpo.TOSAcceptCheckbox);
            js.ExecuteScript("arguments[0].click();", cpo.ConfirmOrderButton);
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-checkout-confirmation__title")));
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Thank you! Your order is confirmed."));
        }

        public void MXEnterPaymentInfoAndConfirmOrder()
        {
            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            CheckoutPageObjects cpo = new CheckoutPageObjects(Driver);
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("payment.cardNumber")));
            Thread.Sleep(500);
            cpo.PaymentCCNumberTextbox.SendKeys(CreditCardInfo.CreditCardNumber.VisaCCNum.VisaCCNumberValidMex1);
            cpo.PaymentCCExpirationDateTextbox.SendKeys(CreditCardInfo.CCExpDate.VisaCCExpDate.VisaCCExpDateValidMex1);
            cpo.PaymentCVVTextbox.SendKeys(CreditCardInfo.CreditCardCCV.VisaCCV.VisaCCValidMex1);
            js.ExecuteScript("arguments[0].click();", cpo.TOSAcceptCheckbox);
            js.ExecuteScript("arguments[0].click();", cpo.ConfirmOrderButton);
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-checkout-confirmation__title")));
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Thank you! Your order is confirmed."));
        }

        public void EnterInvalidPaymentInfoAndConfirmOrder()
        {
            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            CheckoutPageObjects cpo = new CheckoutPageObjects(Driver);
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Secure Payment"));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Name("payment.cardNumber")));
            Thread.Sleep(500);
            cpo.PaymentCCNumberTextbox.SendKeys("1234 5678 9012 3456");
            cpo.PaymentCCExpirationDateTextbox.SendKeys(CreditCardInfo.CCExpDate.VisaCCExpDate.VisaCCExpDateValid);
            cpo.PaymentCVVTextbox.SendKeys(CreditCardInfo.CreditCardCCV.VisaCCV.VisaCCVValid);
            js.ExecuteScript("arguments[0].click();", cpo.TOSAcceptCheckbox);
            js.ExecuteScript("arguments[0].click();", cpo.ConfirmOrderButton);
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("This field has the wrong pattern"));
        }
        


        public void ChangeCountry()
        {
            navac.NavigateCountryClick();
        }
    }
}
