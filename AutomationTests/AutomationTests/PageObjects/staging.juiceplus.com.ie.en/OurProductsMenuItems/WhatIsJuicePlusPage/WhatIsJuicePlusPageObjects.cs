using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.staging.juiceplus.com.ie.en.OurProductsMenuItems.WhatIsJuicePlusPage
{
    class WhatIsJuicePlusPageObjects
    {
        public WhatIsJuicePlusPageObjects()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-generic-content-header__title")]
        public IWebElement WhatIsJuicePlusLogo { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/products/what-is-juice-plus/how-juice-plus-capsules-are-made']//span[@class='a-button__inner']")]
        public IWebElement HowMadeLearnMoreWhatIs { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/products/what-is-juice-plus/clinical-research']//span[@class='a-button__inner']")]
        public IWebElement ClinicalResearchLearnMoreWhatIs { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/products/what-is-juice-plus/informed-choice']//span[@class='a-button__inner']")]
        public IWebElement InformedChoiceLearnMoreWhatIs { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='aem-Grid aem-Grid--default--4 aem-Grid--tablet-landscape--2 aem-Grid--tablet-portrait--2 aem-Grid--phone--1   tns-slider tns-carousel tns-subpixel tns-calc tns-horizontal']//a[@href='https://www.staging.juiceplus.com/ie/en/live-better/one-simple-change']//span[@class='a-button__inner']")]
        public IWebElement SimpleChangeLearnMoreWhatIs { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//section[@class='l-section l-section--background-a']//a[@href='https://www.staging.juiceplus.com/ie/en/products/capsules']//span[@class='a-button__inner']")]
        public IWebElement CapsulesViewRangeWhatIs { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//section[@class='l-section l-section--background-a']//a[@href='https://www.staging.juiceplus.com/ie/en/products/complete']//span[@class='a-button__inner']")]
        public IWebElement CompleteViewRangeWhatIs { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//section[@class='l-section l-section--background-a']//a[@href='https://www.staging.juiceplus.com/ie/en/products/omega/omega-blend-supplements']//span[@class='a-button__inner']")]
        public IWebElement OmegaShopNowWhatIs { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//section[@class='l-section l-section--background-a']//a[@href='https://www.staging.juiceplus.com/ie/en/products/uplift/uplift']//span[@class='a-button__inner']")]
        public IWebElement UpliftShopNowWhatIs { get; set; }
    }
}
