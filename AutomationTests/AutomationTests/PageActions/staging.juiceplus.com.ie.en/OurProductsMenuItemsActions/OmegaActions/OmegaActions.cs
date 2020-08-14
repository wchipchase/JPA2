using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.OmegaPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CapsulesPage;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CartPage;
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

namespace AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.OmegaActions
{
    class OmegaActions
    {
        Driver Driver;
        NavigationActions nav;
        public OmegaActions(Driver driver)
        {
            Driver = driver;
            nav = new NavigationActions(Driver);
        }
        public void AddOmegaBlendToCart()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            nav.NavigateOurProductsOmegaClick();
            OmegaPageObjects opo = new OmegaPageObjects(Driver);
            CartPageObjects carp = new CartPageObjects(Driver);
            try
            {

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
                opo.ScrollViewport();
                OmegaOrderPageObjects oopo = new OmegaOrderPageObjects(Driver);
                var NumOfProducts = oopo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(NumOfProducts, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }

                oopo.IncrementArrowOrder.Click();
                var incrProductCount = oopo.NumOfProductOrder.GetAttribute("value");
                Thread.Sleep(500);

                try
                {
                    Assert.That(incrProductCount, Is.EqualTo("2"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                oopo.DecrementArrowOrder.Click();
                var decrProductCount = oopo.NumOfProductOrder.GetAttribute("value");
                try
                {
                    Assert.That(decrProductCount, Is.EqualTo("1"));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

                oopo.AddToCartOrder.Click();
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
