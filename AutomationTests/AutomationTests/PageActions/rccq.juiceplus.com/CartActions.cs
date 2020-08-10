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

namespace AutomationTests.PageActions.rccq.juiceplus.com.CartActions
{
    class CartActions
    {
        public static void CheckOut()
        {
            CartPage CartPage = new CartPage();
            CartPage.CheckOutButton.Click();
        }
    }
}
