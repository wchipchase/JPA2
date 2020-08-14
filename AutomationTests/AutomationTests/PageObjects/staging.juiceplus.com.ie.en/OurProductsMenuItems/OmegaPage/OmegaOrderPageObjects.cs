using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.OmegaPage
{
    class OmegaOrderPageObjects
    {
        Driver Driver;
        public OmegaOrderPageObjects(Driver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-product-detail-header__title")]
        public IWebElement OmegaBlendLogo { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-product-order-type-selector__item-price")]
        public IWebElement PriceOrderOmega { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Add to cart']")]
        public IWebElement AddToCartOrder{ get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='m-input-number__increment-button']/span[@class='h-icon h-icon--chevron-down-small']")]
        public IWebElement IncrementArrowOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='m-input-number__decrement-button']/span[@class='h-icon h-icon--chevron-down-small']")]
        public IWebElement DecrementArrowOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "input-number")]
        public IWebElement NumOfProductOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".h-icon--download")]
        public IWebElement IngredientsDownloadOmega { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='m-accordion__trigger-icon']/span[@class='h-icon h-icon--chevron-down']")]
        public IWebElement FAQDownArrowOrderOmega { get; set; }
    }
}
