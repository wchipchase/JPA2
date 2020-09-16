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
                lpo.CookieAlertAcceptButton.Click();
                lpo.LoginButton.Click();
                //js.ExecuteScript("arguments[0].click();", lpo.PartnerLoginSlider);
                //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
                Thread.Sleep(1000);
                lpo.PartnerLoginSlider.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Partner Login"));
                lpo.PartUsernameTextBox.SendKeys(UserInfo.UserName.UserName1);
                lpo.PartPasswordTextBox.SendKeys(UserInfo.UserPassword.UserPassword1);
                lpo.SignInBtn.Click();
                Thread.Sleep(1000);
                lpo.SignedInAssociateBtn.Click();
                lpo.SignInBtnStoreLink.Click();


            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void LoginAsCustomer()
        {
            try
            {
                IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
                Login lpo = new Login(Driver);
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Sign In']")));
                lpo.CookieAlertAcceptButton.Click();
                lpo.LoginButton.Click();

                Thread.Sleep(1000);
                Driver.WebDriver.SwitchTo().Frame(0);
                Thread.Sleep(1000);
                lpo.UsernameTextBox.SendKeys(UserInfo.CustomerEmail.CustEmailIE);
                Thread.Sleep(1000);
                lpo.PasswordTextBox.SendKeys(UserInfo.CustomerPWIE.CustPW);

                lpo.IELoginButton.Click();
                //try
                //{
                ////Driver.WebDriver.SwitchTo().Window(Driver.WebDriver.WindowHandles[1]);
                //Driver.WebDriver.SwitchTo().Frame(0);
                //Thread.Sleep(3000);
                //lpo.UsernameTextBox.SendKeys(UserInfo.CustomerEmailIE.CustEmail);
                //lpo.PasswordTextBox.SendKeys(UserInfo.CustomerPWIE.CustPW);
                //Driver.WebDriver.SwitchTo().Frame(0);
                ////Driver.WebDriver.SwitchTo().Window(Driver.WebDriver.WindowHandles[0]);
                //lpo.PLoginButton.Click();
                //    Thread.Sleep(1000);
                //    Driver.WebDriver.SwitchTo().Frame(0);
                //    Thread.Sleep(1000);
                //    lpo.UsernameTextBox.SendKeys(UserInfo.CustomerEmailIE.CustEmail);
                //    Thread.Sleep(1000);
                //    lpo.PasswordTextBox.SendKeys(UserInfo.CustomerPWIE.CustPW);
                //}

                //catch (Exception e)
                //{
                //    Console.WriteLine(e);
                //}


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void USLoginAsPartner()
        {
            try
            {
                IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
                WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
                Login lpo = new Login(Driver);
                waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Sign In']")));
                lpo.CookieAlertAcceptButton.Click();
                lpo.LoginButton.Click();
                //js.ExecuteScript("arguments[0].click();", lpo.PartnerLoginSlider);
                //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
                Thread.Sleep(1000);
                lpo.PartnerLoginSlider.Click();
                Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Partner Login"));
                lpo.USPartUsernameTextBox.SendKeys(UserInfo.UserName.UserName1);
                lpo.USPartPasswordTextBox.SendKeys(UserInfo.UserPassword.UserPassword1);
                lpo.USSignInBtn.Click();
                Thread.Sleep(1000);
                lpo.SignedInAssociateBtn.Click();
                lpo.SignInBtnStoreLink.Click();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
