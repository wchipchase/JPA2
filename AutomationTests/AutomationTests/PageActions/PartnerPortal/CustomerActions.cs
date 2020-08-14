﻿using AutomationTests.ConfigElements;
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
            lpo.CustomersNavTab.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Customer"));
        }

        public void ClickFilterButton()
        {
            Customers cpo = new Customers(Driver);
            cpo.FilterCustomers.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Filter customers"));
        }

        public void AddAndApplyFilters()
        {
            Customers cpo = new Customers(Driver);
            cpo.FilterSelectCountryUSA.Click();
            Thread.Sleep(1000);
            cpo.FilterSelectCountryUK.Click();
            Thread.Sleep(1000);
            cpo.FilterSelectCountryEIR.Click();
            Thread.Sleep(1000);
            cpo.FilterSelectApply.Click();
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
            cpo.DetailsTab.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Customer information"));
        }

        public void SelectFirstCustomerOrders()
        {
            Customers cpo = new Customers(Driver);
            cpo.OrdersTab.Click();
            //Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Active orders"));
        }
    }
}
