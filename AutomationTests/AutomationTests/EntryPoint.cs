using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationTests.ConfigElements;
using AutomationTests.PageActions;
using AutomationTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTests.Tests
{
    class EntryPoint
    {
        static void Main()
        {
        }

        private static object[] Messages01Cases =
        {
            new object[] {typeof(Data.Messages), "Ted", "Thompson", "ted@test.com", "555-555-0000", "206 Main St", "Suite 100", "Miami", "F", "30111", "This is a test message"},
            new object[] {typeof(Data.Messages), "Steve", "Stevens", "steve@test.com", "555-555-0001", "205 Main St", "", "Birmingham", "A", "30112", "This is a test message"},
            new object[] {typeof(Data.Messages), "Fred", "Franklin", "fred@test.com", "555-555-0002", "204 Main St", "Apt. 29", "Los Angeles", "C", "30113", "This is a test message"},
            new object[] {typeof(Data.Messages), "Chuck", "Smith", "chuck@test.com", "555-555-0003", "203 Main St", "", "Athens", "G", "30114", "This is a test message"},
            new object[] {typeof(Data.Messages), "Tom", "Trout", "tom@test.com", "555-555-0004", "202 Main St", "Unit A", "Boise", "I", "30115", "This is a test message"},
            new object[] {typeof(Data.Messages), "Susan", "Edwards", "susan@test.com", "555-555-0005", "201 Main St", "", "Witchita", "K", "30116", "This is a test message"},
            new object[] {typeof(Data.Messages), "Amy", "Jones", "amy@test.com", "555-555-0006", "200Main St", "", "Derry", "M", "30117", "This is a test message"},
            new object[] {typeof(Data.Messages), "Edna", "Thompson", "edna@test.com", "555-555-0007", "207 Main St", "P.O. Box 76", "Lincoln", "N", "30118", "This is a test message"},
            new object[] {typeof(Data.Messages), "Tess", "Anderson", "tess@test.com", "555-555-0008", "206 Main St", "", "Newport", "R", "30119", "This is a test message"},
        };

        [Test, Order(1)]
        public void AddNewMessage()
        {
            ContactUsActions.AddNewValidMessage(Data.Messages.Message1.firstName, Data.Messages.Message1.lastName, Data.Messages.Message1.email, Data.Messages.Message1.phone, Data.Messages.Message1.address1, Data.Messages.Message1.address2, Data.Messages.Message1.city, Data.Messages.Message1.state, Data.Messages.Message1.zipCode, Data.Messages.Message1.messageBox);
        }

        [Test, Order(2)]
        public void TestMessageErrorResponse()
        {
            ContactUsActions.AddNewInvalidMessage(Data.Messages.Message1.firstName);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.WebDriver.Quit();
        }
    }
}
