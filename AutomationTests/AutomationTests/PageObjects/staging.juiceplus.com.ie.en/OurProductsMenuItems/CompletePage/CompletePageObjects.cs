using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CompletePage
{
    class CompletePageObjects
    {
        Driver Driver;
        public CompletePageObjects(Driver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        public void ClickShakesCompleteShopNow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,600)");
            Thread.Sleep(500);
            ShakesShopNowComplete.Click();
        }

        public void ClickCompleteJuiceBarsShopNow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,600)");
            Thread.Sleep(500);
            JuiceBarsShopNowComplete.Click();
        }

        public void USClickCompleteJuiceBarsShopNow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,600)");
            Thread.Sleep(500);
            USJuiceBarsShopNowComplete.Click();
        }

        public void MXClickOmegaShopNow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,600)");
            Thread.Sleep(500);
            MXJuiceBarsShopNowComplete.Click();
        }

        public void ClickCompleteVegetableSoupShopNow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,1250)");
            Thread.Sleep(500);
            VegetableSoupShopNowComplete.Click();
        }

        public void USClickCompleteShakeShopNow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,1250)");
            Thread.Sleep(500);
            USShakeShopNowComplete.Click();
        }

        public void ClickCompleteCombiBoxShopNow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(500);
            CombiBoxShopNowComplete.Click();
        }

        public void ClickCompletBoosterShopNow()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,1400)");
            Thread.Sleep(500);
            BoosterShopNowComplete.Click();
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-product-category-header__title")]
        public IWebElement JuicePlusCompleteLogo { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='€45.75']")]
        public IWebElement ShakesPriceComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='https://www.staging.juiceplus.com/ie/en/products/complete/bars/chocolate-bars']//span[@class='a-product-price__price']")]
        public IWebElement JuiceBarsPriceComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='https://www.staging.juiceplus.com/ie/en/products/complete/vegetable-soup']//span[@class='a-product-price__price']")]
        public IWebElement VegetableSoupPriceComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='€50.25']")]
        public IWebElement CombiBoxrPriceComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='€20.53']")]
        public IWebElement BoosterPriceComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/ie/en/products/complete/shakes/vanilla-shakes']//span[@class='a-button__inner']")]
        public IWebElement ShakesShopNowComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/ie/en/products/complete/bars/chocolate-bars']//span[@class='a-button__inner']")]
        public IWebElement JuiceBarsShopNowComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/us/en/products/complete/bars/dark-chocolate-and-fig-bars']//span[@class='a-button__inner']")]
        public IWebElement USJuiceBarsShopNowComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/mx/en/products/complete/bars/chocolate-bars']//span[@class='a-button__inner']")]
        public IWebElement MXJuiceBarsShopNowComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/ie/en/products/complete/vegetable-soup']//span[@class='a-button__inner']")]
        public IWebElement VegetableSoupShopNowComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/us/en/products/complete/shakes/french-vanilla-shakes']//span[@class='a-button__inner']")]
        public IWebElement USShakeShopNowComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/ie/en/products/complete/complete-combi-box/vanilla-shake-combi-box']//span[@class='a-button__inner']")]
        public IWebElement CombiBoxShopNowComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/ie/en/products/complete/booster']//span[@class='a-button__inner']")]
        public IWebElement BoosterShopNowComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--3 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1 ']//a[@href='https://www.staging.juiceplus.com/ie/en/products/uplift/uplift']//span[@class='a-button__inner']")]
        public IWebElement UpliftViewRangeComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--3 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1 ']//a[@href='https://www.staging.juiceplus.com/ie/en/products/omega/omega-blend-supplements']//span[@class='a-button__inner']")]
        public IWebElement OmegaViewRangeComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--3 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1 ']//a[@href='https://www.staging.juiceplus.com/ie/en/products/chewables']//span[@class='a-button__inner']")]
        public IWebElement ChewablesViewRangeComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/one-simple-change']//span[@class='a-button__inner']")]
        public IWebElement HealthyLifestyleLearnMoreComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/healthy-family']//span[@class='a-button__inner']")]
        public IWebElement HealthyFamilyLearnMoreComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/active-lifestyle']//span[@class='a-button__inner']")]
        public IWebElement ActiveLifestyleLearnMoreComplete { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/look-and-feel-your-best']//div[@class='a-button a-button--outline-secondary a-button--large']")]
        public IWebElement LookAndFeelLearnMoreComplete { get; set; }

        public void ScrollViewport(string scrollDist)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,"+ scrollDist +")");
            Thread.Sleep(500);
        }

    }
}
