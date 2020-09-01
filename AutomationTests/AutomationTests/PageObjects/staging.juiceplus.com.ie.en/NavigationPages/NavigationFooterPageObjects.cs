using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.staging.juiceplus.com.ie.en.Navigation
{
    class NavigationFooterPageObjects
    {
        Driver Driver;
        public NavigationFooterPageObjects(Driver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='o-footer__logo']//img[@alt='/content/ie/juiceplus/en/home']")]
        public IWebElement JuicePlusFooterLogo { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".h-icon--facebook")]
        public IWebElement FacebookIcon { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".h-icon--instagram")]
        public IWebElement InstagramIcon { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".h-icon--youtube")]
        public IWebElement YoutubeIcon { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='About Us']")]
        public IWebElement AboutUsFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='Giving Back']")]
        public IWebElement GivingBackFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='Contact Us']")]
        public IWebElement ContactUsFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='How Capsules are Made']")]
        public IWebElement HowCapsulesAreMadeFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='Clinical Research']")]
        public IWebElement ClinicalResearchFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='Informed-Choice']")]
        public IWebElement InformedChoicesFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='One Simple Change']")]
        public IWebElement OneSimpleChangeFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/ie/en/live-better/healthy-family/healthy-starts-for-families']")]
        public IWebElement HealthyStartsLink { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//*[@id='app']/div/footer/div/div[2]/div/div/div[4]/nav/div/div/ul/li[3]/a")]
        public IWebElement GoBeyondFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='Tower Garden']")]
        public IWebElement TowerGardenFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".a-link--footer-meta-location")]
        public IWebElement CountryLocationFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='Terms of Use']")]
        public IWebElement TermsOfUseFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='Privacy Policy']")]
        public IWebElement PrivacyPolicyFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='Return Policy']")]
        public IWebElement ReturnPolicyFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[.='Terms of Service']")]
        public IWebElement TermsOfServiceFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[src='https://juiceplus.scene7.com/is/image/juiceplus/informed-choice-horizontal-logo-rgb?wid=100&fmt=png-alpha&_ck=1584374125768']")]
        public IWebElement InformedChoiceFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "[src='https://juiceplus.scene7.com/is/image/juiceplus/jjuice-olus-fresenius-mit-fundstellenverweis-e?wid=100&fmt=png-alpha&_ck=1584374052421']")]
        public IWebElement FerseniusFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(.,'Ireland')]")]
        public IWebElement IrelandFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/gb/en']")]
        public IWebElement CountrySelectionUnitedKingdom { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/ca/en']")]
        public IWebElement CountrySelectionCanada { get; set; }
        

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(.,'United States')]")]
        public IWebElement USFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(.,'Mexico')]")]
        public IWebElement MXFooter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='/mx/en/products/capsules/fruit-vegetable-and-berry-capsules']")]
        public IWebElement CountrySelectionMexico { get; set; }

        //li[14]//div[@class='m-language-navigation__country-name']

    }
}
