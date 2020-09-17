using AutomationTests.ConfigElements;
using AutomationTests.PageObjects.PartnerPortal;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.PartnerPortal
{
    class CustomerActions
    {
        Driver Driver;
        public CustomerActions(Driver driver)
        {
            Driver = driver;
        }
        public void NavigateToCustomers()
        {
            Login lpo = new Login(Driver);
            Thread.Sleep(2000);
            lpo.CustomersNavTab.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Customer"));
        }

        public void ClickFilterButton()
        {
            Customers cpo = new Customers(Driver);
            Thread.Sleep(3000);
            cpo.FilterCustomers.Click();
            Thread.Sleep(3000);
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Filter customers"));
        }

        public void AddAndApplyFilters()
        {
            Customers cpo = new Customers(Driver);
            cpo.FilterSelectCountryUSA.Click();
            Thread.Sleep(1000);
            Driver.ScrollToElement(cpo.FilterSelectCountryUK, true);
            cpo.FilterSelectCountryUK.ClickWithRetry();
            Thread.Sleep(1000);
            Driver.ScrollToElement(cpo.FilterSelectCountryEIR, true);
            cpo.FilterSelectCountryEIR.ClickWithRetry();
            Thread.Sleep(1000);
            cpo.FilterSelectApply.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Reset"));
        }

        public void ValidateNameFilter()
        {
            Team tpo = new Team(Driver);
            tpo.FirstNameFilter.Click();
            tpo.LastNameFilterSelection.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Reset"));
            tpo.LastNameFilter.Click();
            tpo.FirstNameFilterSelection.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Reset"));
            Thread.Sleep(1000);
        }

        public void SelectFirstCustomer()
        {
            Customers cpo = new Customers(Driver);
            cpo.FirstCustomer.Click();
            //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Active orders"));
        }

        public void SelectFirstCustomerDetails()
        {
            Customers cpo = new Customers(Driver);
            cpo.DetailsTab.ClickWithRetry();
        }

        public void SelectFirstCustomerOrders()
        {
            Customers cpo = new Customers(Driver);
            cpo.OrdersTab.Click();
            //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Active orders"));
        }
    }
}
