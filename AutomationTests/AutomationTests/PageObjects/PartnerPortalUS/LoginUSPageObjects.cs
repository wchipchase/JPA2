using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.PartnerPortalUS
{
    class LoginUSPageObjects
    {
        Driver Driver;
        public LoginUSPageObjects(Driver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Sign In']")]
        public IWebElement LoginButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[for='input-toggle-option1-1135910086']")]
        public IWebElement LoginSlider { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//label[contains(.,'Partner Login')]")]
        public IWebElement PartnerLoginSlider { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[for='input-toggle-option2-1108069971']")]
        public IWebElement MXPartnerLoginSlider { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "login-email-635282930")]
        public IWebElement UsernameTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "login-email-1000883519")]
        public IWebElement MXUsernameTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "login-password-635282930")]
        public IWebElement PasswordTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "login-password-1000883519")]
        public IWebElement MXPasswordTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='a-button a-button--primary a-button--small']")]
        public IWebElement CookieAlertAcceptButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='container responsivegrid l-container l-container--narrow js-toggle__second-option l-container--no-offset section']//div[@class='login aem-GridColumn--default--none aem-GridColumn aem-GridColumn--offset--default--0 aem-GridColumn--default--2 aem-GridColumn--phone--1']//span[@class='a-button__inner']")]
        public IWebElement SignInBtn { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(.,'Create an account')]")]
        public IWebElement CreateAccountBtn { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Dashboard']")]
        public IWebElement DashboardNavTab { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(.,'Team')]")]
        public IWebElement TeamNavTab { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Customers']")]
        public IWebElement CustomersNavTab { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Shop']")]
        public IWebElement ShopNavTab { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[alt='/content/us/juiceplus/en/portal/dashboard']")]
        public IWebElement JuicePlusSiteLink { get; set; }
    }

}
