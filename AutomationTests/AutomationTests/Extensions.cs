using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationTests.ConfigElements;

namespace AutomationTests
{
    public static class Extension
    {
        public static void ClickWithRetry(this IWebElement element)
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    if (i > 0)
                    {
                        Console.WriteLine("Click Retry # " + i);
                    }
                    element.Click();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Thread.Sleep(1000);
                    if (i == 4)
                    {
                        throw e;
                    }
                }
            }
        }

        public static bool isElementDisplayed(this IWebElement webElement)
        {
            bool isElementDisplayed = false;
            try
            {
                if (webElement.Displayed)
                {
                    isElementDisplayed = true;
                }
            }
            catch (Exception e)
            {
                isElementDisplayed = false;
            }
            return isElementDisplayed;
        }
    }
}