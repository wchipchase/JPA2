using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.canada.rccq.juiceplus.com.jp
{
    class OrchardandGardenBlendscs
    {
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='buttons hidden-xs col-sm-12']/a[.='Add to Cart']")]
        public IWebElement AddToCartButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='Shopping Cart']")]
        public IWebElement ShoppingCartIcon { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='checkout-container']/a[.='Check Out']")]
        public IWebElement ShoppingCartIconCheckoutButton { get; set; }
        
    }
}
