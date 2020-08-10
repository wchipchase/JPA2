using AutomationTests.ConfigElements;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CartPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.staging.juiceplus.com.ie.en.UpliftPage
{
    class UpliftPageObjects
    {
        public UpliftPageObjects()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        public void NavigateToProceedToCheckoutAndClick()
        {
            CartPageObjects cpo = new CartPageObjects();
            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            js.ExecuteScript("arguments[0].click();", cpo.ProceedToCheckoutButton);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-product-detail-header__title")]
        public IWebElement JuicePlusUpliftLogo { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//li[@class='m-product-order-type-selector__item m-product-order-type-selector__item--monthly']//div[@class='m-product-order-type-selector__item-price']")]
        public IWebElement UpliftdPriceUplift{ get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Add to cart']")]
        public IWebElement AddToCartUplift { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='m-input-number__increment-button']/span[@class='h-icon h-icon--chevron-down-small']")]
        public IWebElement IncrementOrderUplift { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='m-input-number__decrement-button']/span[@class='h-icon h-icon--chevron-down-small']")]
        public IWebElement DecrementOrderUplife { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Download']")]
        public IWebElement IngredientsDownloadrUplift { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='m-accordion__trigger-icon']/span[@class='h-icon h-icon--chevron-down']")]
        public IWebElement FaqDownArrowUplift { get; set; }

        public void ScrollViewport()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(500);
        }
    }
}
