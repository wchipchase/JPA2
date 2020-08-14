using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CapsulesPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CartPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.CapsulesPage;
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

namespace AutomationTests.PageActions.staging.juiceplus.com.ie.en.MixedProductActions
{
    class MixedProductActions
    {
        Driver Driver;
        NavigationActions navac;

        public MixedProductActions(Driver driver)
        {
            Driver = driver;
            navac = new NavigationActions(Driver);
        }
        public void AddUpliftInstallmentPayCapsulePayInFullRecurringToCart()
        {
            try
            {
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
                navac.NavigateOurProductsUpliftClick();
                UpliftPageObjects upo = new UpliftPageObjects(Driver);
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
//                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                LandingPageObjects lan = new LandingPageObjects(Driver);
                Thread.Sleep(1000);
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
                NavigationHeaderPageObjects nav = new NavigationHeaderPageObjects(Driver);
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


                CartPageObjects carp = new CartPageObjects(Driver);

                carp.PayInInstallments.Click();

                navac.NavigateOurProductsCapsulesClick();
                CapsulesPageObjects caps = new CapsulesPageObjects(Driver);
                try
                {
                    Assert.IsFalse(Driver.WebDriver.PageSource.Contains("£"));
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("€"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                caps.ClickVegetablesAndFruitCapsuleShopNow();
                CapsulesOrderPageObjects cpo = new CapsulesOrderPageObjects(Driver);
                try
                {
                    Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Fruit & Vegetable Blend Capsules"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                caps.ScrollViewport();
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                cpo.IncrementArrowOrderCapsules.Click();
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
                Console.WriteLine(NumInCart);
                try
                {
                    Assert.That(NumInCart, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                Thread.Sleep(500);
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
    }
}
