using AutomationTests.ConfigElements;
using AutomationTests.PageObjects.PartnerPortal;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.PartnerPortalUS
{
    class TeamActionsUS
    {
        Driver Driver;

        public TeamActionsUS(Driver driver)
        {
            Driver = driver;
        }
        public void ClickOnAddMemberAndFillOutPersonalForm()
        {
            Team tpo = new Team(Driver);
            Thread.Sleep(2000);
            tpo.AddMemberButton.Click();
            tpo.ScrollViewport();
            tpo.FillOutFormButton.Click();
            tpo.FirstNameTextBox.SendKeys(Config.AddressInfo.ShippingAddress.FirstNameShipping.FirstName1);
            tpo.LastNameTextBox.SendKeys(Config.AddressInfo.ShippingAddress.LastNameShipping.LastName1);
            tpo.ScrollViewport();
            tpo.GenderDropdown.SendKeys("m");
            tpo.FirstNameTextBox.Click();
            tpo.MXBirthdayTextBoxDay.SendKeys(Config.UserInfo.Birthday.USBirthdayDay1);
            tpo.MXBirthdayTextBoxMonth.SendKeys(Config.UserInfo.Birthday.USBirthdayMon1);
            tpo.MXBirthdayTextBoxYear.SendKeys(Config.UserInfo.Birthday.USBirthdayYear1);
            tpo.USBirthdayTextBoxSSN.SendKeys(Config.UserInfo.SSN.SSN1);
            tpo.ScrollViewport();
            Thread.Sleep(1000);
            tpo.PersonalStuffNextButton.Click();
        }


        public void FillOutContactFormAndSubmitApplication()
        {
            Team tpo = new Team(Driver);
            tpo.ContactEmail.SendKeys("tester" + new Random().Next(100000, 999999) + "@juiceplus.com");
            tpo.ContactPhoneNumber.SendKeys(Config.AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhoneUS1);
            tpo.ContactStreeAddr1.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAddUS1);
            tpo.ScrollViewport();
            tpo.ContactCity.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.CityUS1);
            tpo.USStateTextBox.SendKeys(Config.AddressInfo.ShippingAddress.StateShipping.StateUS1);
            tpo.USZipCodeTextBox.SendKeys(Config.AddressInfo.ShippingAddress.ZipCode.ZipcodeUS1);
            try
            {
                IWebElement click1 = tpo.ContactNextButton;
                click1.Click();
            }
            catch (Exception e)
            {
                IWebElement click2 = tpo.ContactNextButton;
                click2.Click();
            }
            tpo.IAmTheirSponsorButton.Click();
            tpo.SubmitApplicationButton.Click();
            tpo.ToTeamListButton.Click();
        }
    }
}
