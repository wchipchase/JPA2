using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.juiceplus.com
{
    class BuyPage
    {
        public BuyPage()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "a[class='add-to-cart hidden-xs']")]
        public IWebElement AddToCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@id='tabs-1']//a[@data-title='Fruit, Vegetable and Berry Blend Capsules']")]
        public IWebElement FruitVegetableBerryBlendCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@id='tabs-1']//a[@data-title='Premium Pack']")]
        public IWebElement PremiumPackCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "product-quantity-primary")]
        public IWebElement Quantity { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='installmentPlan']//label[contains(.,'Monthly (4x)')]")]
        public IWebElement PlanType4X { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='installmentPlan']//label[contains(.,'Full payment')]")]
        public IWebElement PlanTypeFullPayment { get; set; }

    }
}
