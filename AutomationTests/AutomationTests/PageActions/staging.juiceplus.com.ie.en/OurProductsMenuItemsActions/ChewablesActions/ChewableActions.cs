using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CapsulesPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CartPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.ChewablesPage;
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

namespace AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.ChewablesActions
{
    class ChewableActions
    {
        Driver Driver;
        NavigationHeaderPageObjects nav;
        CapsulesPageObjects caps;
        LandingPageObjects lan;
        ChewablesPageObjects cpo;
        ChewablesOrderPageObjects copo;
        CartPageObjects carp;
        NavigationActions navac;
        public ChewableActions(Driver driver)
        {
            Driver = driver;
            nav = new NavigationHeaderPageObjects(Driver);
            caps = new CapsulesPageObjects(Driver);
            lan = new LandingPageObjects(Driver);
            cpo = new ChewablesPageObjects(Driver);
            copo = new ChewablesOrderPageObjects(Driver);
            carp = new CartPageObjects(Driver);
        }
        public void AddPremiumChewablesToCart()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
            CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
            LandingPageObjects lan = new LandingPageObjects(Driver);
            ChewablesPageObjects cpo = new ChewablesPageObjects(Driver);
            ChewablesOrderPageObjects copo = new ChewablesOrderPageObjects(Driver);
            CartPageObjects carp = new CartPageObjects(Driver);
            try
            {

                navac.NavigateOurProductsChewablesClick();
                
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
//                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                Thread.Sleep(1000);
                lan.CookieAlertAcceptButton.Click();
                Task.Delay(500).Wait(1500);
                cpo.ScrollViewport();
                cpo.ShopNowPremiumChewables.Click();
                
                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Premium Chewables"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                
                cpo.ScrollViewport();
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

                    Console.WriteLine(e);
                }
                
                copo.AddToCartOrder.Click();

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

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();
        }

        public void AddFruitsAndVegetablesChewablesToCart()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
            CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
            LandingPageObjects lan = new LandingPageObjects(Driver);
            ChewablesPageObjects cpo = new ChewablesPageObjects(Driver);
            ChewablesOrderPageObjects copo = new ChewablesOrderPageObjects(Driver);
            CartPageObjects carp = new CartPageObjects(Driver);

            try
            {
                navac.NavigateOurProductsChewablesClick();
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
                cpo.ScrollViewport();
                cpo.ShopNowFruitVegetableChewables.Click();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Fruit & Vegetable Soft Chewables"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpo.ScrollViewport();
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

                    Console.WriteLine(e); ;
                }
                
                copo.DecrementArrowOrder.Click();
                var decrProductCount = copo.NumOfProductOrder.GetAttribute("value");

                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    throw;
                }
                
                copo.AddToCartOrder.Click();
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
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void AddBerryChewablesToCart()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
            CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
            LandingPageObjects lan = new LandingPageObjects(Driver);
            ChewablesPageObjects cpo = new ChewablesPageObjects(Driver);
            ChewablesOrderPageObjects copo = new ChewablesOrderPageObjects(Driver);
            CartPageObjects carp = new CartPageObjects(Driver);

            try
            {
                navac.NavigateOurProductsChewablesClick();

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
                cpo.ScrollViewport();
                cpo.ShopNowBerryChewables.Click();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Berry Chewables"));
                }
                catch (Exception e)
                {

                    throw;
                }

                cpo.ScrollViewport();
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

                    Console.WriteLine(e); ;
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
                Thread.Sleep(500);

                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    throw;
                }
                
                nav.CartIconCounter.Click();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();
        }

        public void ClickViewRangeButtonOmegaBlend()
        {
            try
            {
                CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
                caps.OmegaViewRangeCapsules.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Omega Blend"));
                Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
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
