using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.staging.juiceplus.com.ie.en
{
    class LandingPageObjects
    {
        Driver Driver;
        public LandingPageObjects(Driver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div[2]/button")]
        public IWebElement CookieAlertAcceptButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Read More']")]
        public IWebElement ReadMoreLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/look-and-feel-your-best']//span[@class='a-button__inner']")]
        public IWebElement HealthyLifestyleLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/healthy-family']//span[@class='a-button__inner']")]
        public IWebElement HealthyFamilyLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/active-lifestyle']//span[@class='a-button__inner']")]
        public IWebElement ActiveLifestyleLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/one-simple-change']//span[@class='a-button__inner']")]
        public IWebElement OneSimpleChoiceLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(.,'View all products')]")]
        public IWebElement ViewAllProductsLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//section[@class='l-section l-section--background-b l-section--has-background-shape']//a[@href='https://www.staging.juiceplus.com/ie/en/products/capsules']//span[@class='a-button__inner']")]
        public IWebElement CapsulesLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//section[@class='l-section l-section--background-b l-section--has-background-shape']//a[@href='https://www.staging.juiceplus.com/ie/en/products/chewables']//div[@class='a-button a-button--outline-secondary a-button--large']")]
        public IWebElement ChewablesLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//section[@class='l-section l-section--background-b l-section--has-background-shape']//a[@href='https://www.staging.juiceplus.com/ie/en/products/omega/omega-blend-supplements']//div[@class='a-button a-button--outline-secondary a-button--large']")]
        public IWebElement OmegaBlendLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//section[@class='l-section l-section--background-b l-section--has-background-shape']//a[@href='https://www.staging.juiceplus.com/ie/en/products/complete']//span[@class='a-button__inner']")]
        public IWebElement CompleteLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//section[@class='l-section l-section--background-b l-section--has-background-shape']//a[@href='https://www.staging.juiceplus.com/ie/en/products/uplift/uplift']//span[@class='a-button__inner']")]
        public IWebElement UpliftLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(.,'Learn more')]")]
        public IWebElement CapsulesLearnMoreLanding { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(.,'More Articles')]")]
        public IWebElement MoreArticlesLanding { get; set; }


        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//section[@class='m-base-list m-article-list']//span[@class='h-icon h-icon--arrow-left']")]
        public IWebElement LeftArrowScrollLanding { get; set; }


        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//section[@class='m-base-list m-article-list']//span[@class='h-icon h-icon--arrow-right']")]
        public IWebElement RightArrowScrollLanding { get; set; }
       

    }
}
