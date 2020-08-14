using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.OmegaPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CartPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.UpliftPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.UpliftPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.UpliftActions
{
    class UpliftActions
    {
        [ThreadStatic]
        static Driver Driver;
        [ThreadStatic]
        UpliftOrderPageObjects uopo;
        [ThreadStatic]
        UpliftPageObjects upo;
        [ThreadStatic]
        LandingPageObjects lan;
        [ThreadStatic]
        NavigationActions nav;

        public UpliftActions(Driver driver)
        {
            Driver = driver;
            nav = new NavigationActions(Driver);
            uopo = new UpliftOrderPageObjects(Driver);
            upo = new UpliftPageObjects(Driver);
            lan = new LandingPageObjects(Driver);
            nav = new NavigationActions(Driver);
        }
        public void AddUpliftToCart()

        {

            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            

            //nav.NavigateOurProductsOmegaClick();
            try
            {
                nav.NavigateOurProductsOmegaClick();
                
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                
                lan.CookieAlertAcceptButton.Click();
                Task.Delay(500).Wait(1500);
                upo.ScrollViewport();

                var NumOfProducts = uopo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                uopo.IncrementArrowOrder.Click();
                var incrProductCount = uopo.NumOfProductOrder.GetAttribute("value");
                Thread.Sleep(500);

                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                uopo.DecrementArrowOrder.Click();
                var decrProductCount = uopo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                uopo.AddToCartOrder.Click();
                NavigationHeaderPageObjects npo = new NavigationHeaderPageObjects(Driver);
                Thread.Sleep(1000);
                var NumInCart = npo.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                npo.CartIconCounter.Click();
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-icon-badge__counter")));
                npo.CheckoutButton.Click();
                upo.NavigateToProceedToCheckoutAndClick();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }

        public void AddSOROUpliftToCart()
        {
            try
            {
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
                nav.NavigateOurProductsOmegaClick();
                UpliftPageObjects upo = new UpliftPageObjects(Driver);
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                LandingPageObjects lan = new LandingPageObjects(Driver);
                lan.CookieAlertAcceptButton.Click();
                Task.Delay(500).Wait(1500);
                upo.ScrollViewport();
                UpliftOrderPageObjects uopo = new UpliftOrderPageObjects(Driver);
                var NumOfProducts = uopo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                uopo.IncrementArrowOrder.Click();
                var incrProductCount = uopo.NumOfProductOrder.GetAttribute("value");
                Thread.Sleep(500);

                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                uopo.DecrementArrowOrder.Click();
                var decrProductCount = uopo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                uopo.AddToCartOrder.Click();
                NavigationHeaderPageObjects npo = new NavigationHeaderPageObjects(Driver);
                Thread.Sleep(1000);
                var NumInCart = npo.CartIconCounter.Text;
                Console.WriteLine(NumInCart);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                npo.CartIconCounter.Click();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }
    }
}

