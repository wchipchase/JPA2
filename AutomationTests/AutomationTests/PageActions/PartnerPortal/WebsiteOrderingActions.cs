using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.OmegaPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CapsulesPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CartPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CompletePage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.CapsulesPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.CompletePage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.OmegaPage;
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
    class WebsiteOrderingActions
    {
        Driver Driver;
        CartPageObjects carp;
        NavigationHeaderPageObjects nav;
        CapsulesPageObjects caps;
        LandingPageObjects lan;
        CapsulesOrderPageObjects cpop;
        NavigationActions navac;
        CompletePageObjects cpob;
        CompleteOrderPageObjects copo;
        OmegaPageObjects opo;
        OmegaOrderPageObjects oopo;

        public WebsiteOrderingActions(Driver driver)
        {
            Driver = driver;
            nav = new NavigationHeaderPageObjects(Driver);
            caps = new CapsulesPageObjects(Driver);
            lan = new LandingPageObjects(Driver);
            cpop = new CapsulesOrderPageObjects(Driver);
            carp = new CartPageObjects(Driver);
            navac = new NavigationActions(Driver);
            cpob = new CompletePageObjects(Driver);
            copo = new CompleteOrderPageObjects(Driver);
            opo = new OmegaPageObjects(Driver);
            oopo = new OmegaOrderPageObjects(Driver);
        }

        public void AddPremiumCapsuleToCart()
        {
            //Waits for an element to be rendered before allowing the test to proceed
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));


            try
            {
                //From the navigation menu, attempts to click the Capsules product nav selection
                navac.NavigateOurProductsCapsulesClick();
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                Thread.Sleep(1000);
                //Accepts the cookie closing the modal
                //lan.CookieAlertAcceptButton.Click();
                Task.Delay(500).Wait(1500);
                //From the capsule page, clicks teh Premium Capsule Shop Now button
                caps.ClickPremiumCapsuleShopNow();

                try
                {
                    //Makes sure you're on the Premium Capsules page
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Premium Capsules"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                //Scrolls the window so the control is in the view of the user
                caps.ScrollViewport("1500");

                //Gets the number of products displayed in the counter
                var NumOfProducts = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    //Makes sure the product counter starts at 1
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                //Clicks the increment arrow next to the product counter
                cpop.IncrementArrowOrderCapsules.Click();
                //Gets the value of the product counter again after increase
                var incrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    //Verify the product counter has incremented
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                //Clicks the decrement arrow next to product counter
                cpop.DecrementArrowOrderCapsules.Click();

                //Gets the value of the product counter
                var decrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    //Validates the number of product counter has decreased
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                //Clicks on "Add To Order"
                cpop.AddToCartOrderCapsules.Click();

                Thread.Sleep(1000);
                //Variable for number of items in cart
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    //Validates the number of cart items
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                //Clicks on the cart counter icon
                nav.CartIconCounter.Click();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            //Attempts to click on checkout button, if it receives a dead element reference it will click again
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
            //clicks teh "Proceed To Checkout" button
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void AddPremiumCapsuleToCartPayPerShipment()
        {

            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));


            try
            {
                navac.NavigateOurProductsCapsulesClick();
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                Thread.Sleep(1000);
                lan.CookieAlertAcceptButton.Click();
                Task.Delay(500).Wait(1500);
                caps.ClickPremiumCapsuleShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Premium Capsules"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                caps.ScrollViewport("1500");
                var NumOfProducts = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                cpop.IncrementArrowOrderCapsules.Click();
                var incrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpop.DecrementArrowOrderCapsules.Click();
                var decrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                cpop.AddToCartOrderCapsules.Click();

                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                nav.CartIconCounter.Click();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
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

            carp.PayPerMonth.Click();
            //nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void AddCompleteJuicePlusBarsToCartPayInFull()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));

            try
            {
                navac.NavigateOurProductsCompleteClick();

                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                Thread.Sleep(1000);
                Task.Delay(500).Wait(1500);
                cpob.ClickCompleteJuiceBarsShopNow();

                try
                {
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Chocolate Bar"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpob.ScrollViewport("500");
                var NumOfProducts = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.IncrementArrowOrder.Click();
                var incrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                copo.DecrementArrowOrder.Click();
                var decrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                nav.CartIconCounter.Click();

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


            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            //nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void Add2ItemsToCart()
        {

            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));


            try
            {
                navac.NavigateOurProductsCapsulesClick();
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                Thread.Sleep(1000);
                Task.Delay(500).Wait(1500);
                caps.ClickPremiumCapsuleShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Premium Capsules"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                caps.ScrollViewport("1500");
                var NumOfProducts = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                cpop.IncrementArrowOrderCapsules.Click();
                var incrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpop.DecrementArrowOrderCapsules.Click();
                var decrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                cpop.AddToCartOrderCapsules.Click();

                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                navac.NavigateOurProductsCapsulesClick();
                caps.ClickVegetablesAndFruitCapsuleShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Premium Capsules"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                caps.ScrollViewport("1500");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                cpop.IncrementArrowOrderCapsules.Click();
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpop.DecrementArrowOrderCapsules.Click();
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                cpop.AddToCartOrderCapsules.Click();

                Thread.Sleep(1000);
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);

                nav.CartIconCounter.Click();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
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
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void Add2ItemsToCartPayInFull()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));

            try
            {
                navac.NavigateOurProductsCompleteClick();

                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                Thread.Sleep(1000);
                Task.Delay(500).Wait(1500);
                cpob.ClickCompleteJuiceBarsShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Chocolate Bar"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpob.ScrollViewport("500");
                var NumOfProducts = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.IncrementArrowOrder.Click();
                var incrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                copo.DecrementArrowOrder.Click();
                var decrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                navac.NavigateOurProductsCompleteClick();
                cpob.ScrollViewport("500");
                cpob.ClickCompleteVegetableSoupShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Vegetable Soup"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpob.ScrollViewport("500");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.IncrementArrowOrder.Click();
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                copo.DecrementArrowOrder.Click();
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                nav.CartIconCounter.Click();

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


            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            //nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void AddRecurringAndPayInFull()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));

            try
            {
                navac.NavigateOurProductsCompleteClick();

                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                Thread.Sleep(1000);
                //lan.CookieAlertAcceptButton.Click();
                Task.Delay(500).Wait(1500);
                cpob.ClickCompleteJuiceBarsShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Chocolate Bar"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpob.ScrollViewport("500");
                var NumOfProducts = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.IncrementArrowOrder.Click();
                var incrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                copo.DecrementArrowOrder.Click();
                var decrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                navac.NavigateOurProductsCompleteClick();
                cpob.ScrollViewport("500");
                cpob.ClickCompleteVegetableSoupShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Vegetable Soup"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpob.ScrollViewport("500");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.IncrementArrowOrder.Click();
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                copo.DecrementArrowOrder.Click();
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                navac.NavigateOurProductsCapsulesClick();
                cpob.ScrollViewport("500");
                caps.ClickPremiumCapsuleShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Premium Capsules"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpob.ScrollViewport("500");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.IncrementArrowOrder.Click();
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                copo.DecrementArrowOrder.Click();
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }


                nav.CartIconCounter.Click();

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
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            //nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }
        public void LICustAddPremiumCapsuleToCart()
        {
            //Waits for an element to be rendered before allowing the test to proceed
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));


            try
            {
                //From the navigation menu, attempts to click the Capsules product nav selection
                navac.NavigateOurProductsCapsulesClick();
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                Thread.Sleep(1000);
                //Accepts the cookie closing the modal
                //lan.CookieAlertAcceptButton.Click();
                Task.Delay(500).Wait(1500);
                //From the capsule page, clicks teh Premium Capsule Shop Now button
                caps.ClickPremiumCapsuleShopNow();

                try
                {
                    //Makes sure you're on the Premium Capsules page
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Premium Capsules"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                //Scrolls the window so the control is in the view of the user
                caps.ScrollViewport("1500");

                //Gets the number of products displayed in the counter
                var NumOfProducts = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    //Makes sure the product counter starts at 1
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                //Clicks the increment arrow next to the product counter
                cpop.IncrementArrowOrderCapsules.Click();
                //Gets the value of the product counter again after increase
                var incrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    //Verify the product counter has incremented
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                //Clicks the decrement arrow next to product counter
                cpop.DecrementArrowOrderCapsules.Click();

                //Gets the value of the product counter
                var decrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    //Validates the number of product counter has decreased
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                //Clicks on "Add To Order"
                cpop.AddToCartOrderCapsules.Click();

                Thread.Sleep(1000);
                //Variable for number of items in cart
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    //Validates the number of cart items
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                //Clicks on the cart counter icon
                nav.CartIconCounter.Click();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            //Attempts to click on checkout button, if it receives a dead element reference it will click again
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
            //clicks teh "Proceed To Checkout" button
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void MXAddVegFruitCapsuleToCart()
        {
            //Waits for an element to be rendered before allowing the test to proceed
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));


            try
            {
                //From the navigation menu, attempts to click the Capsules product nav selection
                navac.NavigateOurProductsCapsulesClick();
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                Task.Delay(500).Wait(1500);

                //From the capsule page, clicks teh Premium Capsule Shop Now button
                try
                {
                    IWebElement click1 = caps.MXShopNowFruitVegCapsules;
                    click1.Click();
                }
                catch (Exception e)
                {
                    nav.CartIconCounter.Click();
                    IWebElement click2 = caps.MXShopNowFruitVegCapsules;
                    click2.Click();
                }

                try
                {
                    //Makes sure you're on the Premium Capsules page
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Fruit & Vegetable Blend Capsules"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                //Scrolls the window so the control is in the view of the user
                caps.ScrollViewport("1500");

                //Gets the number of products displayed in the counter
                var NumOfProducts = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    //Makes sure the product counter starts at 1
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                //Clicks the increment arrow next to the product counter
                cpop.IncrementArrowOrderCapsules.Click();
                //Gets the value of the product counter again after increase
                var incrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    //Verify the product counter has incremented
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                //Clicks the decrement arrow next to product counter
                cpop.DecrementArrowOrderCapsules.Click();

                //Gets the value of the product counter
                var decrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    //Validates the number of product counter has decreased
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                //Clicks on "Add To Order"
                cpop.AddToCartOrderCapsules.Click();

                Thread.Sleep(1000);
                //Variable for number of items in cart
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    //Validates the number of cart items
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                //Clicks on the cart counter icon
                nav.CartIconCounter.Click();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            //Attempts to click on checkout button, if it receives a dead element reference it will click again
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
            //clicks teh "Proceed To Checkout" button
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void MXAddOmegaToCartRecurring()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));

            try
            {
                navac.NavigateOurProductsOmegaClick();

                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                Task.Delay(500).Wait(1500);

                cpob.ScrollViewport("500");
                var NumOfProducts = oopo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                nav.CartIconCounter.Click();

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


            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void MXAddOmegaToCartShipment()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));

            try
            {
                navac.NavigateOurProductsOmegaClick();

                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                Task.Delay(500).Wait(1500);

                cpob.ScrollViewport("500");
                var NumOfProducts = oopo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                nav.CartIconCounter.Click();

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


            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            carp.PayPerShipment.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void MXAddRecurringAndPayInFull()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));

            try
            {
                navac.NavigateOurProductsOmegaClick();

                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                Task.Delay(500).Wait(1500);

                cpob.ScrollViewport("500");
                var NumOfProducts = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);

                navac.NavigateOurProductsCapsulesClick();
                cpob.ScrollViewport("500");
                caps.MXClickVegetablesAndFruitCapsuleShopNow();
                cpob.ScrollViewport("500");
                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);

                nav.CartIconCounter.Click();

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
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            //nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }
        public void MXAdd2ItemsPayInFull()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));

            try
            {
                navac.NavigateOurProductsCapsulesClick();
                Task.Delay(500).Wait(1500);
                navac.NavigateOurProductsCapsulesClick();
                cpob.ScrollViewport("500");
                caps.MXShopNowFruitVegBerryCapsules.Click();
                cpob.ScrollViewport("500");
                copo.AddToCartOrder.Click();
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                Thread.Sleep(1000);

                cpob.ScrollViewport("500");
              
                //copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                navac.NavigateOurProductsCapsulesClick();
                cpob.ScrollViewport("500");
                caps.MXClickVegetablesAndFruitCapsuleShopNow();
                cpob.ScrollViewport("500");
                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                nav.CartIconCounter.Click();

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
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            //nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }
        public void USAddCompleteJuicePlusBarsToCartPayInFull()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));

            try
            {
                navac.NavigateOurProductsCompleteClick();

                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                Thread.Sleep(1000);
                Task.Delay(500).Wait(1500);
                cpob.USClickCompleteJuiceBarsShopNow();

                cpob.ScrollViewport("500");
                var NumOfProducts = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.IncrementArrowOrder.Click();
                var incrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                copo.DecrementArrowOrder.Click();
                var decrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                nav.CartIconCounter.Click();

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


            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            //nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void USAddFruitVegCapsuleToCart()
        {
            //Waits for an element to be rendered before allowing the test to proceed
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));


            try
            {
                //From the navigation menu, attempts to click the Capsules product nav selection
                navac.NavigateOurProductsCapsulesClick();
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                Thread.Sleep(1000);
                //Accepts the cookie closing the modal
                Task.Delay(500).Wait(1500);
                //From the capsule page, clicks teh Premium Capsule Shop Now button
                caps.USClickVegetablesAndFruitCapsuleShopNow();

                try
                {
                    //Makes sure you're on the Premium Capsules page
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Fruit & Vegetable Blend Capsules"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                //Scrolls the window so the control is in the view of the user
                caps.ScrollViewport("1500");

                //Gets the number of products displayed in the counter
                var NumOfProducts = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    //Makes sure the product counter starts at 1
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                //Clicks the increment arrow next to the product counter
                cpop.IncrementArrowOrderCapsules.Click();
                //Gets the value of the product counter again after increase
                var incrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    //Verify the product counter has incremented
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                //Clicks the decrement arrow next to product counter
                cpop.DecrementArrowOrderCapsules.Click();

                //Gets the value of the product counter
                var decrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    //Validates the number of product counter has decreased
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                //Clicks on "Add To Order"
                cpop.AddToCartOrderCapsules.Click();

                Thread.Sleep(1000);
                //Variable for number of items in cart
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    //Validates the number of cart items
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                //Clicks on the cart counter icon
                nav.CartIconCounter.Click();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            //Attempts to click on checkout button, if it receives a dead element reference it will click again
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
            //clicks teh "Proceed To Checkout" button
            carp.NavigateToProceedToCheckoutAndClick();

        }
        public void USAddRecurringAndPayInFull()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));

            try
            {
                navac.NavigateOurProductsCompleteClick();

                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                Thread.Sleep(1000);
                //lan.CookieAlertAcceptButton.Click();
                Task.Delay(500).Wait(1500);
                cpob.USClickCompleteJuiceBarsShopNow();

                try
                {
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Chocolate Bar"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpob.ScrollViewport("500");
                var NumOfProducts = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.IncrementArrowOrder.Click();
                var incrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                copo.DecrementArrowOrder.Click();
                var decrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                //navac.NavigateOurProductsCompleteClick();
                //cpob.ScrollViewport("500");
                //cpob.USClickCompleteShakeShopNow();

                //try
                //{
                //    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("French Vanilla Shake"));
                //}
                //catch (Exception e)
                //{

                //    Console.WriteLine(e);
                //}

                //cpob.ScrollViewport("500");
                //try
                //{
                //    Assert.That(NumOfProducts, Is.EqualTo("1"));
                //}
                //catch (Exception e)
                //{

                //    Console.WriteLine(e); ;
                //}

                //copo.IncrementArrowOrder.Click();
                //Thread.Sleep(500);
                //try
                //{
                //    Assert.That(incrProductCount, Is.EqualTo("2"));
                //}
                //catch (Exception e)
                //{

                //    Console.WriteLine(e);
                //}

                //copo.DecrementArrowOrder.Click();
                //try
                //{
                //    Assert.That(decrProductCount, Is.EqualTo("1"));
                //}
                //catch (Exception e)
                //{

                //    Console.WriteLine(e); ;
                //}

                //copo.AddToCartOrder.Click();
                //Thread.Sleep(1000);
                //Console.WriteLine(NumInCart);
                //Thread.Sleep(1000);
                //try
                //{
                //    Assert.That(NumInCart, Is.EqualTo("1"));
                //}
                //catch (Exception e)
                //{

                //    Console.WriteLine(e); ;
                //}

                navac.NavigateOurProductsCapsulesClick();
                cpob.ScrollViewport("500");
                try
                {
                    IWebElement click1 = caps.USShopNowFruitVegetableCapsules;
                    click1.Click();
                }
                catch
                {
                    IWebElement click2 = caps.USShopNowFruitVegetableCapsules;
                    click2.Click();
                }

                try
                {
                    //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Premium Capsules"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpob.ScrollViewport("500");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.IncrementArrowOrder.Click();
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                copo.DecrementArrowOrder.Click();
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }


                nav.CartIconCounter.Click();

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
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            //nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void USAdd2ItemsToCartPayInFull()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));

            try
            {
                navac.NavigateOurProductsCompleteClick();
                Thread.Sleep(1000);
                Task.Delay(500).Wait(1500);
                cpob.USClickCompleteJuiceBarsShopNow();

               cpob.ScrollViewport("500");
                var NumOfProducts = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.IncrementArrowOrder.Click();
                var incrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                copo.DecrementArrowOrder.Click();
                var decrProductCount = copo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                copo.AddToCartOrder.Click();
                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                navac.NavigateOurProductsCompleteClick();
                cpob.ScrollViewport("1000");
                try
                {
                    IWebElement click1 = cpob.USShakeShopNowComplete;
                    click1.Click();
                }

                catch
                {
                    IWebElement click2 = cpob.USShakeShopNowComplete;
                    click2.Click();
                }
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                try
                {
                    IWebElement click1 = copo.AddToCartOrder;
                    click1.Click();
                }
                catch
                {
                    IWebElement click2 = copo.AddToCartOrder;
                    click2.Click();
                }

                Thread.Sleep(1000);
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                nav.CartIconCounter.Click();

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


            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            //nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void USAdd2ItemsToCart()
        {

            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));


            try
            {
                navac.NavigateOurProductsCapsulesClick();
                Thread.Sleep(1000);
                Task.Delay(500).Wait(1500);
                caps.USClickVegetablesAndFruitCapsuleShopNow();

                caps.ScrollViewport("1500");
                var NumOfProducts = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                cpop.IncrementArrowOrderCapsules.Click();
                var incrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpop.DecrementArrowOrderCapsules.Click();
                var decrProductCount = cpop.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                try
                {
                    IWebElement click1 = cpop.AddToCartOrderCapsules;
                    click1.Click();
                }
                catch (Exception e)
                {
                    IWebElement click2 = cpop.AddToCartOrderCapsules;
                    click2.Click();
                }

                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                navac.NavigateOurProductsCapsulesClick();
                try
                {
                    IWebElement click1 = caps.USShopNowBerryCapsules;
                    click1.Click();
                }
                catch
                {
                    IWebElement click1 = caps.USShopNowBerryCapsules;
                    click1.Click();
                }
                
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                try
                {
                    IWebElement click1 = cpop.AddToCartOrderCapsules;
                    click1.Click();
                }
                catch (Exception e)
                {
                    IWebElement click2 = cpop.AddToCartOrderCapsules;
                    click2.Click();
                }

                Thread.Sleep(1000);
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                nav.CartIconCounter.Click();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
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
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void MXAdd2ItemsToCart()
        {

            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));


            try
            {
                navac.NavigateOurProductsCapsulesClick();
                Thread.Sleep(1000);
                Task.Delay(500).Wait(1500);
                caps.MXClickVegetablesAndFruitCapsuleShopNow();

                caps.ScrollViewport("1500");
                try
                {
                    IWebElement click1 = cpop.AddToCartOrderCapsules;
                    click1.Click();
                }
                catch (Exception e)
                {
                    IWebElement click2 = cpop.AddToCartOrderCapsules;
                    click2.Click();
                }

                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                navac.NavigateOurProductsCapsulesClick();
                cpob.ScrollViewport("1500");
                try
                {
                    IWebElement click1 = caps.MXShopNowBerryCapsules;
                    click1.Click();
                }
                catch
                {
                    IWebElement click1 = caps.MXShopNowBerryCapsules;
                    click1.Click();
                }

                cpob.ScrollViewport("1000");

                try
                {
                    IWebElement click1 = cpop.AddToCartOrderCapsules;
                    click1.Click();
                }
                catch (Exception e)
                {
                    IWebElement click2 = cpop.AddToCartOrderCapsules;
                    click2.Click();
                }

                Thread.Sleep(1000);
                Console.WriteLine(NumInCart);
                Thread.Sleep(1000);
                nav.CartIconCounter.Click();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
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
            carp.NavigateToProceedToCheckoutAndClick();

        }
    }
}
