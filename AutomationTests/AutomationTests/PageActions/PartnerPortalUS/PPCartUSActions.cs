using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CheckoutPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.PartnerPortalUS
{
    class PPCartUSActions
    {
        Driver Driver;
        NavigationActions navac;

        public PPCartUSActions(Driver driver)
        {
            Driver = driver;
            navac = new NavigationActions(Driver);
        }
        public void NavigateToJuicePlusWebsite(Driver driver)
        {
            LandingPageObjects lan = new LandingPageObjects(Driver);
            CheckoutPageObjects cpo = new CheckoutPageObjects(Driver);
            Driver.WebDriver.Navigate().GoToUrl("https://sculpt.staging.juiceplus.com/us/en");
            lan.CookieAlertAcceptButton.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Healthy Living Made Easier"));

            //WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            //Login lpo = new Login();
            //waitForElement.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[alt='/content/ie/juiceplus/en/portal/dashboard']")));
            //lpo.JuicePlusSiteLink.Click();
        }
    }
}
