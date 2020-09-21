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
    class Login
    {
        Driver Driver;
        public Login(Driver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Sign In']")]
        public IWebElement LoginButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "submit")]
        public IWebElement IELoginButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[for='input-toggle-option1--145546684']")]
        public IWebElement LoginSlider { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//label[contains(.,'Partner Login')]")]
        public IWebElement PartnerLoginSlider { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "username")]
        public IWebElement UsernameTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "username")]
        public IWebElement PartUsernameTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='container responsivegrid l-container l-container--narrow js-toggle__second-option l-container--no-offset section']//input[@name='username']")]
        public IWebElement USPartUsernameTextBox { get; set; }        

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "password")]
        public IWebElement PartPasswordTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='container responsivegrid l-container l-container--narrow js-toggle__second-option l-container--no-offset section']//input[@name='password']")]
        public IWebElement USPartPasswordTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='container responsivegrid l-container l-container--narrow js-toggle__first-option l-container--no-offset section']//input[@name='username']")]
        public IWebElement MXCustUsernameTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "//div[@class='container responsivegrid l-container l-container--narrow js-toggle__first-option l-container--no-offset section']//input[@name='password']")]
        public IWebElement MXCustPasswordTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='container responsivegrid l-container l-container--narrow js-toggle__first-option l-container--no-offset section']//button[@class='a-button a-button--full-width a-button--primary js-form__submit a-button--large']")]
        public IWebElement MXCustSignInBtn { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[for='rememberMe']")]
        public IWebElement PRememberMeCheckbox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "login-submit-2117444080")]
        public IWebElement PLoginButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='a-button a-button--primary a-button--small']")]
        public IWebElement CookieAlertAcceptButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".js-form__submit")]
        public IWebElement SignInBtn { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='container responsivegrid l-container l-container--narrow js-toggle__second-option l-container--no-offset section']//div[@class='login aem-GridColumn--default--none aem-GridColumn aem-GridColumn--offset--default--0 aem-GridColumn--default--2 aem-GridColumn--phone--1']//span[@class='a-button__inner']")]
        public IWebElement USSignInBtn { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='a-button a-button--left a-button--profile a-button--small']/span[@class='a-button__inner']")]
        public IWebElement SignedInAssociateBtn { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='m-usermenu__flyout-content m-flyout__content js-m-flyout__content m-flyout__content--attached m-flyout__content--dropdown']//a[contains(.,'Juice Plus+ Website')]")]
        public IWebElement SignInBtnStoreLink { get; set; }

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

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[alt='/content/ie/juiceplus/en/portal/dashboard']")]
        public IWebElement JuicePlusSiteLink { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-social-login__button--facebook")]
        public IWebElement MXFacebookSignInBtn { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-social-login__button--google")]
        public IWebElement MXGmailSignInBtn { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[alt='/content/ie/juiceplus/en/portal/dashboard']")]
        public IWebElement MXFacebookUserNameTxtBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[alt='/content/ie/juiceplus/en/portal/dashboard']")]
        public IWebElement MXFacebookPwdTxtBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "identifierId")]
        public IWebElement MXGmailUserNameTxtBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "password")]
        public IWebElement MXGmailPwdTxtBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc']/div[@class='VfPpkd-RLmnJb']")]
        public IWebElement MXGmailNextButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//*[@id='passwordNext']/div/button/div[2]")]
        public IWebElement MXGmailPwdNextButton { get; set; }
        
    }
}
