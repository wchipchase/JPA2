using AutomationTests.Config;
using AutomationTests.ConfigElements;
using AutomationTests.PageObjects.PartnerPortalUS;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.PartnerPortalUS
{
    class LoginActionsUS
    {
        Driver Driver;
        LoginUSPageObjects lpo;
        public LoginActionsUS(Driver driver)
        {
            Driver = driver;
            lpo = new LoginUSPageObjects(Driver);
        }
        public IWebElement WaitUntilElementVisible(By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found.");
                throw;
            }
        }

        public void LoginAsPartner()
        {

            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Sign In']")));
            LoginUSPageObjects lpo = new LoginUSPageObjects(Driver);
            lpo.CookieAlertAcceptButton.Click();
            lpo.LoginButton.Click();
            //js.ExecuteScript("arguments[0].click();", lpo.PartnerLoginSlider);
            //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
            Thread.Sleep(1000);
            lpo.PartnerLoginSlider.Click();
            Thread.Sleep(5000);
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Partner Login"));
            lpo.MXUsernameTextBox.SendKeys(UserInfo.UserName.UserName1);
            lpo.MXPasswordTextBox.SendKeys(UserInfo.UserPassword.UserPassword1);
            lpo.SignInBtn.Click();
        }

        public void MXLoginAsPartner()
        {

            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Sign In']")));
            LoginUSPageObjects lpo = new LoginUSPageObjects(Driver);
            lpo.CookieAlertAcceptButton.Click();
            lpo.LoginButton.Click();
            //js.ExecuteScript("arguments[0].click();", lpo.PartnerLoginSlider);
            //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
            Thread.Sleep(1000);
            lpo.MXPartnerLoginSlider.Click();
            Thread.Sleep(5000);
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Partner Login"));
            lpo.MXUsernameTextBox.SendKeys(UserInfo.UserName.UserName1);
            lpo.MXPasswordTextBox.SendKeys(UserInfo.UserPassword.UserPassword1);
            lpo.SignInBtn.Click();
        }
    }
}
