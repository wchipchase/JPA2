using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTests.ConfigElements;
using AutomationTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTests.PageActions
{
    class ContactUsActions
    {
        public static void AddNewValidMessage(string firstName, string lastName, string email, string phone,
            string address1, string address2, string city, string state, string zipcode, string message)
        {
            ContactUsPageObjects contact = new ContactUsPageObjects();
            contact.FirstName.SendKeys(firstName);
            contact.LastName.SendKeys(lastName);
            contact.Email.SendKeys(email);
            contact.Phone.SendKeys(phone);
            contact.Address1.SendKeys(address1);
            contact.Address2.SendKeys(address2);
            contact.City.SendKeys(city);
            contact.State.SendKeys(state);
            contact.ZipCode.SendKeys(firstName);
            contact.HowHear_Web_Add.Click();
            contact.Ex_Cust_No.Click();
            contact.Message_TextBox.SendKeys(message);
            contact.Send_Message_Btn.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Thank you! We have received your message."));
        }

        public static void AddNewInvalidMessage(string firstName)
        {
            ContactUsPageObjects contact = new ContactUsPageObjects();
            contact.FirstName.SendKeys(firstName);
            contact.Send_Message_Btn.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Oops! You did not complete the form properly"));

        }
    }
}
