using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CapsulesPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CartPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.CapsulesPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.IndividualCapsuleActions
{
    class CapsuleActions
    {
        Driver Driver;
        CartPageObjects carp;
        NavigationHeaderPageObjects nav;
        CapsulesPageObjects caps;
        LandingPageObjects lan;
        CapsulesOrderPageObjects cpo;
        NavigationActions navac;
        public CapsuleActions(Driver driver)
        {
            Driver = driver;
            nav = new NavigationHeaderPageObjects(Driver);
            caps = new CapsulesPageObjects(Driver);
            lan = new LandingPageObjects(Driver);
            cpo = new CapsulesOrderPageObjects(Driver);
            carp = new CartPageObjects(Driver);
            navac = new NavigationActions(Driver);
        }

        public void AddPremiumCapsuleToCart()
        {

            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));


            try {
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
                
                caps.ScrollViewport();
                var NumOfProducts = cpo.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                
                cpo.IncrementArrowOrderCapsules.Click();
                var incrProductCount = cpo.NumOfProductOrderCapsules.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                
                cpo.DecrementArrowOrderCapsules.Click();
                var decrProductCount = cpo.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                
                cpo.AddToCartOrderCapsules.Click();

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
                Console.WriteLine( e);
            }

            //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            try
            {
                IWebElement click1 = nav.CheckoutButton;
                click1.Click();
            }
            catch (Exception e){
                nav.CartIconCounter.Click();
                IWebElement click2 = nav.CheckoutButton;
                click2.Click();
            }

            //nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void AddFruitsAndVegetablesCapsuleToCart()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
            CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
            LandingPageObjects lan = new LandingPageObjects(Driver);
            CapsulesOrderPageObjects cpo = new CapsulesOrderPageObjects(Driver);
            CartPageObjects carp = new CartPageObjects(Driver);

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
                Task.Delay(1000).Wait(1500);
                caps.ClickVegetablesAndFruitCapsuleShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Fruit & Vegetable Blend Capsules"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                
                caps.ScrollViewport();
                var NumOfProducts = cpo.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                
                cpo.IncrementArrowOrderCapsules.Click();
                var incrProductCount = cpo.NumOfProductOrderCapsules.GetAttribute("value");
                Thread.Sleep(500);
                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                cpo.DecrementArrowOrderCapsules.Click();
                var decrProductCount = cpo.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                
                cpo.AddToCartOrderCapsules.Click();

                Thread.Sleep(1000);
                var NumInCart = nav.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                
                nav.CartIconCounter.Click();

                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
                nav.CheckoutButton.Click();
                carp.NavigateToProceedToCheckoutAndClick();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }

        public void AddBerryCapsuleToCart()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
            CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
            LandingPageObjects lan = new LandingPageObjects(Driver);
            CapsulesOrderPageObjects cpo = new CapsulesOrderPageObjects(Driver);
            CartPageObjects carp = new CartPageObjects(Driver);
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
                caps.ClickBerryCapsuleShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Berry"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                
                caps.ScrollViewport();
                var NumOfProducts = cpo.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                
                cpo.IncrementArrowOrderCapsules.Click();
                var incrProductCount = cpo.NumOfProductOrderCapsules.GetAttribute("value");
                Thread.Sleep(500);

                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                
                cpo.DecrementArrowOrderCapsules.Click();
                var decrProductCount = cpo.NumOfProductOrderCapsules.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                
                cpo.AddToCartOrderCapsules.Click();
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

                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
                nav.CheckoutButton.Click();
                carp.NavigateToProceedToCheckoutAndClick();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }

        public void ClickViewRangeButtonOmegaBlend()
        {
            try
            {
                CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
                caps.OmegaViewRangeCapsules.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Omega Blend"));
            }

            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }

        public void ClickLearnMoreHealthyLifestyle()
            {
            try
            {
                CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
                caps.HealthyLifestyleCapsules.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Feel Good, Look Your Best"));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

         }

        public void ClickLearnMoreLookYourBest()
        {
            try
            {
                CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
                caps.LookingYourBestCapsules.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("One Simple Change"));
            }

            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }

        public void ClickLearnMoreHealthyFamily()
        {
            try
            {
                CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
                caps.HealthyFamilyCapsules.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Healthy Family"));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }

        public void ClickLearnMoreActiveLifestyle()
        {
            try
            {
                CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
                caps.ActiveLifestyleCapsules.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Active Lifestyle"));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }

    }
}
