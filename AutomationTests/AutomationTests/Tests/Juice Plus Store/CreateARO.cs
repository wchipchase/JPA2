using AutomationTests.ConfigElements;
using AutomationTests.PageActions.rccq.juiceplus.com;
using AutomationTests.PageActions.rccq.juiceplus.com.BuyActions;
using AutomationTests.PageActions.rccq.juiceplus.com.CartActions;
using AutomationTests.PageActions.rccq.juiceplus.com.CheckoutActions;
using AutomationTests.PageActions.rccq.juiceplus.com.NavigationsActions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.juiceplus.com
{
    class CreateAROTest
    {
        NavigationActions NavigationActions = new NavigationActions();
        BuyActions BuyActions = new BuyActions();
        CartActions CartActions = new CartActions();
        CheckoutActions CheckoutActions = new CheckoutActions();

        [Test, Category("LegacyRegression"), Description("Create ARO on US Juice Plus Store")]
        public void CreateARO_JP_US()
        {
            Driver.WebDriver.Navigate().GoToUrl(Config.Config.JuicePlusStoreUrl_US_RC);
            Thread.Sleep(1000);
            NavigationActions.NavigateBuyPage();
            Thread.Sleep(1000);
            BuyActions.ViewProduct("FruitVegetableBerryBlendCapsules");
            BuyActions.SelectPaymentType("FullPayment");
            BuyActions.AddToCart(1);
            NavigationActions.NavigateCartPage();
            CartActions.CheckOut();
            CheckoutActions.InputShippingAndBillingInfo("Test", "Tester", "9018503000", "test@testing.com", "140 Crescent DR", "38017", "0.COLLIERVILLE", "TENNESSEE", "US", true, false);
            CheckoutActions.InputPaymentMethod("Visa", "4242424242424242", "02", "2022", "189");
            CheckoutActions.CompletePurchase();
            Thread.Sleep(1000);
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Your order has been received. You will receive a confirmation email shortly. Orders may ship separately."));
        }

        [Test, Category("LegacyRegression"), Description("Create ARO on CA Juice Plus Store")]
        public void CreateARO_JP_CA()
        {
            Driver.WebDriver.Navigate().GoToUrl(Config.Config.JuicePlusStoreUrl_CA_RC);
            NavigationActions.NavigateBuyPage();
            BuyActions.ViewProduct("FruitVegetableBerryBlendCapsules");
            BuyActions.SelectPaymentType("FullPayment");
            BuyActions.AddToCart(1);
            NavigationActions.NavigateCartPage();
            CartActions.CheckOut();
            CheckoutActions.InputShippingAndBillingInfo("Test", "Tester", "9018503000", "test@testing.com", "2785 Skymark Ave", "L4W 4Y3", "Ontario", "Ontario", "CA", true, false);
            CheckoutActions.InputPaymentMethod("Visa", "4242424242424242", "02", "2022", "189");
            CheckoutActions.CompletePurchase();
            Thread.Sleep(1000);
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Your order has been received. You will receive a confirmation email shortly. Orders may ship separately."));
        }

        [Test, Category("LegacyRegression"), Description("Create ARO on AU Juice Plus Store")]
        public void CreateARO_JP_AU()
        {
            Driver.WebDriver.Navigate().GoToUrl(Config.Config.JuicePlusStoreUrl_AU_RC);
            NavigationActions.NavigateBuyPage();
            BuyActions.ViewProduct("PremiumPackCapsules");
            BuyActions.SelectPaymentType("FullPayment");
            BuyActions.AddToCart(1);
            NavigationActions.NavigateCartPage();
            CartActions.CheckOut();
            CheckoutActions.InputShippingAndBillingInfo("Test", "Tester", "9018503000", "test@testing.com", "14 Merewether St", "2291", "Merewether", "Queensland", "AU", true, false);
            CheckoutActions.InputPaymentMethod("Visa", "4242424242424242", "02", "2022", "189");
            CheckoutActions.CompletePurchase();
            Thread.Sleep(1000);
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Your order has been received. You will receive a confirmation email shortly. Orders may ship separately."));
            
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }

        [SetUp]
        public void Setup()
        {
            Driver.InitializeDriver();
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }

}
