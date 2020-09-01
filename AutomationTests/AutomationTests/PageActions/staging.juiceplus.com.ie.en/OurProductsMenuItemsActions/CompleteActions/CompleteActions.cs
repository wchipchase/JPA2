using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CartPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CompletePage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.CompletePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.CompleteActions
{
    class CompleteActions
    {
        Driver Driver;
        NavigationHeaderPageObjects nav;
        CompletePageObjects cpo;
        LandingPageObjects lan;
        CompleteOrderPageObjects copo;
        CartPageObjects carp;
        NavigationActions navac;

        public CompleteActions(Driver driver)
        {
            Driver = driver;
        }
        public void AddCompleteJuicePlusShakesToCart()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            nav = new NavigationHeaderPageObjects(Driver);
            cpo = new CompletePageObjects(Driver);
            lan = new LandingPageObjects(Driver);
            copo = new CompleteOrderPageObjects(Driver);
            carp = new CartPageObjects(Driver);
            navac = new NavigationActions(Driver);

            try
            {
                navac.NavigateOurProductsCompleteClick();
                
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
                cpo.ClickShakesCompleteShopNow();
                
                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Vanilla Shake"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpo.ScrollViewport("500");
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

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void AddCompleteJuicePlusBarsToCart()
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
                lan.CookieAlertAcceptButton.Click();
                Task.Delay(500).Wait(1500);
                cpo.ClickCompleteJuiceBarsShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Chocolate Bar"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpo.ScrollViewport("500");
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

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void AddCompleteVegetableSoupToCart()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
            CompletePageObjects cpo = new CompletePageObjects(Driver);
            LandingPageObjects lan = new LandingPageObjects(Driver);
            CompleteOrderPageObjects copo = new CompleteOrderPageObjects(Driver);
            CartPageObjects carp = new CartPageObjects(Driver);
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
                lan.CookieAlertAcceptButton.Click();
                Task.Delay(500).Wait(1500);
                cpo.ClickCompleteVegetableSoupShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Vegetable Soup"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpo.ScrollViewport("500");
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

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void AddCompleteCombiBoxToCart()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
            CompletePageObjects cpo = new CompletePageObjects(Driver);
            LandingPageObjects lan = new LandingPageObjects(Driver);
            CompleteOrderPageObjects copo = new CompleteOrderPageObjects(Driver);
            CartPageObjects carp = new CartPageObjects(Driver);

            try
            {
                navac.NavigateOurProductsCompleteClick();

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
                cpo.ClickCompleteCombiBoxShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Vanilla Shake Combi Box"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpo.ScrollViewport("500");
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

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();

        }

        public void AddCompleteBoosterToCart()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
            CompletePageObjects cpo = new CompletePageObjects(Driver);
            LandingPageObjects lan = new LandingPageObjects(Driver);
            CompleteOrderPageObjects copo = new CompleteOrderPageObjects(Driver);
            CartPageObjects carp = new CartPageObjects(Driver);

            try
            {
                navac.NavigateOurProductsCompleteClick();

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
                cpo.ClickCompleteJuiceBarsShopNow();

                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Chocolate Bar"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                cpo.ScrollViewport("500");
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

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
            nav.CheckoutButton.Click();
            carp.NavigateToProceedToCheckoutAndClick();
        }
    }
}
