using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.staging.juiceplus.com.ie.en.ChewablesPage
{
    class ChewablesPageObjects
    {
        Driver Driver;
        public ChewablesPageObjects(Driver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-product-category-header__title")]
        public IWebElement JuicePlusChewablesLogo { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='€55.00']")]
        public IWebElement PremiumCapsulePriceChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='https://www.staging.juiceplus.com/ie/en/products/chewables/fruit-and-vegetable-chewables']//p[@class='a-product-price']")]
        public IWebElement FruitVegetableCapsulePriceChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='https://www.staging.juiceplus.com/ie/en/products/chewables/berry-chewables']//span[@class='a-product-price__price']")]
        public IWebElement BerryCapsulePriceChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/ie/en/products/chewables/premium-soft-chewables']//span[@class='a-button__inner']")]
        public IWebElement ShopNowPremiumChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/ie/en/products/chewables/fruit-and-vegetable-chewables']//span[@class='a-button__inner']")]
        public IWebElement ShopNowFruitVegetableChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/ie/en/products/chewables/berry-chewables']//span[@class='a-button__inner']")]
        public IWebElement ShopNowBerryChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/look-and-feel-your-best']//span[@class='a-button__inner']")]
        public IWebElement HealthyLifestyleChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/healthy-family']//span[@class='a-button__inner']")]
        public IWebElement HealthyFamilyChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/active-lifestyle']//span[@class='a-button__inner']")]
        public IWebElement ActiveLifestyleChewables { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/one-simple-change']//span[@class='a-button__inner']")]
        public IWebElement LookingYourBestChewables { get; set; }

        public void ScrollViewport()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,1200)");
            Thread.Sleep(500);
        }
    }

}
