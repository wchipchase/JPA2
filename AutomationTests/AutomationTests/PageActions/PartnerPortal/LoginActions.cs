using AutomationTests.Config;
using AutomationTests.ConfigElements;
using AutomationTests.PageObjects.PartnerPortal;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.PartnerPortal
{
    class LoginActions
 
    {
        Driver Driver;

        public LoginActions(Driver driver)
        {
            Driver = driver;
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
            try
            {
                IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
                Login lpo = new Login(Driver);
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Sign In']")));
                lpo.LoginButton.Click();
                //js.ExecuteScript("arguments[0].click();", lpo.PartnerLoginSlider);
                //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
                Thread.Sleep(1000);
                lpo.PartnerLoginSlider.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Partner Login"));
                lpo.UsernameTextBox.SendKeys(UserInfo.UserName.UserName1);
                lpo.PasswordTextBox.SendKeys(UserInfo.UserPassword.UserPassword1);
                lpo.SignInBtn.Click();

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
