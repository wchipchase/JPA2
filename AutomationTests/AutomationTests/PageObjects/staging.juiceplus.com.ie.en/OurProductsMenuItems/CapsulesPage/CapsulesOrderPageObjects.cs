using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.CapsulesPage
{
    class CapsulesOrderPageObjects
    {
        public CapsulesOrderPageObjects()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-product-detail-header__title")]
        public IWebElement PremiumCapsulesLogo { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-product-detail-header__title")]
        public IWebElement FruitsAndVegetablesCapsulesLogo { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-product-detail-header__title")]
        public IWebElement BerryCapsulesLogo { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//ul[@class='m-product-flavors__items']//a[@href='https://www.staging.juiceplus.com/ie/en/products/capsules/fruit-and-vegetable-capsules']/span[@class='a-button__inner']")]
        public IWebElement ButtonFruitsAndVegetablesOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='https://www.staging.juiceplus.com/ie/en/products/capsules/berry-capsules']/span[@class='a-button__inner']")]
        public IWebElement ButtonBerryOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='https://www.staging.juiceplus.com/ie/en/products/capsules/premium-capsules']/span[@class='a-button__inner']")]
        public IWebElement ButtonPremiumOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "m-product-order-type-selector__item-price")]
        public IWebElement PriceOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Add to cart']")]
        public IWebElement AddToCartOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='m-input-number__increment-button']/span[@class='h-icon h-icon--chevron-down-small']")]
        public IWebElement IncrementArrowOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='m-input-number__decrement-button']/span[@class='h-icon h-icon--chevron-down-small']")]
        public IWebElement DecrementArrowOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "input-number")]
        public IWebElement NumOfProductOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "a-button a-button--download a-button--right")]
        public IWebElement BerryDownloadIngredientsOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "a-button a-button--download a-button--right")]
        public IWebElement VegetableDownloadIngredientsOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "a-button a-button--download a-button--right")]
        public IWebElement CompleteDownloadIngredientsOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "m-accordion__trigger-icon")]
        public IWebElement IngredientsDownArrowOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "m-accordion__trigger-icon")]
        public IWebElement FAQDownArrowOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-icon-badge__counter")]
        public IWebElement ShoppingCartCounterCapsules { get; set; }
    }
}
