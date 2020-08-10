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
        public static void NavigateToCustomers()
        {
            Login lpo = new Login();
            lpo.CustomersNavTab.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Customer"));
        }

        public static void ClickFilterButton()
        {
            Customers cpo = new Customers();
            cpo.FilterCustomers.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Filter customers"));
        }

        public static void AddAndApplyFilters()
        {
            Customers cpo = new Customers();
            cpo.FilterSelectCountryUSA.Click();
            Thread.Sleep(1000);
            cpo.FilterSelectCountryUK.Click();
            Thread.Sleep(1000);
            cpo.FilterSelectCountryEIR.Click();
            Thread.Sleep(1000);
            cpo.FilterSelectApply.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Reset"));
        }

        public static void ValidateNameFilter()
        {
            Team tpo = new Team();
            tpo.FirstNameFilter.Click();
            tpo.LastNameFilterSelection.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Reset"));
            tpo.LastNameFilter.Click();
            tpo.FirstNameFilterSelection.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Reset"));
        }

        public static void SelectFirstCustomer()
        {
            Customers cpo = new Customers();
            cpo.FirstCustomer.Click();
            //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Active orders"));
        }

        public static void SelectFirstCustomerDetails()
        {
            Customers cpo = new Customers();
            cpo.DetailsTab.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Customer information"));
        }

        public static void SelectFirstCustomerOrders()
        {
            Customers cpo = new Customers();
            cpo.OrdersTab.Click();
            //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Active orders"));
        }
    }
}
