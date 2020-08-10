using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.canada.rccq.juiceplus.com.jp
{
    class EditCart
    {
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='checkout-container col-xs-12']/a[.='Check Out']")]
        public IWebElement EditCartCheckoutButton { get; set; }
    }
}
