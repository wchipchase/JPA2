using AutomationTests.ConfigElements;
using AutomationTests.PageObjects.juiceplus.com;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AutomationTests.PageActions.rccq.juiceplus.com.BuyActions
{
    class BuyActions
    {
        public static void ViewProduct(String product)
        {
            BuyPage BuyPage = new BuyPage();

            if (product.Equals("FruitVegetableBerryBlendCapsules"))
            {
                BuyPage.FruitVegetableBerryBlendCapsules.Click();
            }
            else if (product.Equals("PremiumPackCapsules"))
            {
                BuyPage.PremiumPackCapsules.Click();
            }
            else
            {
                BuyPage.FruitVegetableBerryBlendCapsules.Click();
            }

        }
        public static void AddToCart(int quantity)
        {
            BuyPage BuyPage = new BuyPage();
            BuyPage.Quantity.Clear();
            BuyPage.Quantity.SendKeys("" + quantity);
            BuyPage.AddToCart.Click();
            Thread.Sleep(1000);
        }

        public static void SelectPaymentType(String paymentType)
        {
            BuyPage BuyPage = new BuyPage();

            if (paymentType.Equals("Monthly4x"))
            {
                BuyPage.PlanType4X.Click();
            }
            else if (paymentType.Equals("FullPayment"))
            {
                BuyPage.PlanTypeFullPayment.Click();
            }
        }
    }
}
