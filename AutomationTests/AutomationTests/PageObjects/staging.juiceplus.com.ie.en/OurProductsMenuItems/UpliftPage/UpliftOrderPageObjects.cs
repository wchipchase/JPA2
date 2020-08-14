using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.UpliftPage
{
    class UpliftOrderPageObjects
    {
        Driver Driver;
        public UpliftOrderPageObjects(Driver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver.WebDriver, this);
        }


        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//h1[@class='m-product-detail-header__title']")]
        public IWebElement UpliftLogo { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-product-order-type-selector__item-price")]
        public IWebElement PriceOrderUplift { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Add to cart']")]
        public IWebElement AddToCartOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='m-input-number__increment-button']/span[@class='h-icon h-icon--chevron-down-small']")]
        public IWebElement IncrementArrowOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='m-input-number__decrement-button']/span[@class='h-icon h-icon--chevron-down-small']")]
        public IWebElement DecrementArrowOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "input-number")]
        public IWebElement NumOfProductOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "article[data-accordion-id='/content/ie/juiceplus/en/products/chewables/premium-soft-chewables/jcr:content/twoColumnsSection/leftParsys/section/containers/container/accordion_623030157_/item_1'] .h-icon")]
        public IWebElement IngredientsFruitBlendChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "article[data-accordion-id='/content/ie/juiceplus/en/products/chewables/premium-soft-chewables/jcr:content/twoColumnsSection/leftParsys/section/containers/container/accordion_623030157_/item_2'] .h-icon")]
        public IWebElement IngredientsVegetableBlendChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "article[data-accordion-id='/content/ie/juiceplus/en/products/chewables/premium-soft-chewables/jcr:content/twoColumnsSection/leftParsys/section/containers/container/accordion_623030157_/item_3'] .h-icon")]
        public IWebElement IngredientsBerryBlendChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='m-accordion__trigger-icon']/span[@class='h-icon h-icon--chevron-down']")]
        public IWebElement FAQDownArrowOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "a-button a-button--download a-button--right")]
        public IWebElement DownloadIngredientsOrderChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "m-accordion__trigger-icon")]
        public IWebElement IngredientsDownArrowOrderCapsules { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "m-accordion__trigger-icon")]
        public IWebElement FruitBlendOrderChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "m-accordion__trigger-icon")]
        public IWebElement VegetableBlendOrderChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "m-accordion__trigger-icon")]
        public IWebElement FAQDownArrowOrderChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//li[@class='m-product-order-type-selector__item m-product-order-type-selector__item--monthly']//div[@class='m-product-order-type-selector__item-name']")]
        public IWebElement RecurringOrderSelection { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//li[@class='m-product-order-type-selector__item']//div[@class='m-product-order-type-selector__item-price']")]
        public IWebElement SingleOrderSelection { get; set; }


    }
}
