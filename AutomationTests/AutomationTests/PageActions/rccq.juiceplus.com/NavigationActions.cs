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

namespace AutomationTests.PageActions.rccq.juiceplus.com.NavigationsActions
{
    class NavigationActions
    {
        public static void NavigateBuyPage()
        {
            Header Header = new Header();

            Actions builder = new Actions(Driver.WebDriver);
            IAction action = builder.MoveToElement(Header.BuyLink, Header.BuyLink.Size.Width / 2, (Header.BuyLink.Size.Height * 75) / 100).Click().Build();
            action.Perform();

            // Header.BuyLink.Click();
        }

        public static void NavigateCartPage()
        {
            Header Header = new Header();
            Header.CartLink.Click();
        }
    }
}
