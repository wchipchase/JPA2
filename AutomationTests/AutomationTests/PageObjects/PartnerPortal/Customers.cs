using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.PartnerPortal
{
    class Customers
    {
        Driver Driver;
        public Customers(Driver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Filter']")]
        public IWebElement FilterCustomers { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Filter']")]
        public IWebElement FilterSelectCountry { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='United States of America']")]
        public IWebElement FilterSelectCountryUSA { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Canada']")]
        public IWebElement FilterSelectCountryCanada { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='United Kingdom']")]
        public IWebElement FilterSelectCountryUK{ get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Ireland']")]
        public IWebElement FilterSelectCountryEIR { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Apply Filter']")]
        public IWebElement FilterSelectApply { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='First name']")]
        public IWebElement FirstNameFilter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='m-flyout__content js-m-flyout__content m-flyout__content--attached m-flyout__content--select m-flyout__content--dropdown']//a[contains(.,'Last name')]")]
        public IWebElement LastNameSelectFilter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Last name']")]
        public IWebElement LastNameFilter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='m-flyout__content js-m-flyout__content m-flyout__content--attached m-flyout__content--select m-flyout__content--dropdown']//a[contains(.,'First name')]")]
        public IWebElement FirstNameSelectFilter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Download']")]
        public IWebElement DownloadFilter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "[for='all-customers']")]
        public IWebElement AllCustomersToggle { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "[for='direct-customers']")]
        public IWebElement DirectCustomersToggle { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//tbody[1]/tr[1]//span[@class='h-icon h-icon--chevron-right']")]
        public IWebElement ArrowToOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(.,'Details')]")]
        public IWebElement DetailsTab { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//tbody[1]/tr[1]//span[@class='h-icon h-icon--chevron-right']")]
        public IWebElement FirstCustomer { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(.,'Orders')]")]
        public IWebElement OrdersTab { get; set; }

        
    }
}
