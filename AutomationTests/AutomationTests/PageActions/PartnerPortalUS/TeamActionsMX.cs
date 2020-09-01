using AutomationTests.Config;
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
    class TeamActionsMX
    {
        Driver Driver;

        public TeamActionsMX(Driver driver)
        {
            Driver = driver;
        }
        public void ClickOnAddMemberAndFillOutPersonalForm()
        {
            Team tpo = new Team(Driver);
            Thread.Sleep(2000);
            tpo.AddMemberButton.Click();
            Thread.Sleep(1000);
            tpo.FillOutFormButton.Click();
            tpo.FirstNameTextBox.SendKeys(Config.AddressInfo.ShippingAddress.FirstNameShipping.FirstName1);
            tpo.LastNameTextBox.SendKeys(Config.AddressInfo.ShippingAddress.LastNameShipping.LastName1);
            tpo.ScrollViewport();
            tpo.GenderDropdown.Click();
            tpo.MaleGenderSelection.Click();
            //tpo.MaleGenderSelection.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            tpo.MXBirthdayTextBoxDay.SendKeys(Config.UserInfo.Birthday.USBirthdayDay1);
            tpo.MXBirthdayTextBoxMonth.SendKeys(Config.UserInfo.Birthday.USBirthdayMon1);
            tpo.MXBirthdayTextBoxYear.SendKeys(Config.UserInfo.Birthday.USBirthdayYear1);
            tpo.USBirthdayTextBoxSSN.SendKeys(Config.UserInfo.SSN.CURP1);
            tpo.ScrollViewport();
            Thread.Sleep(1000);
            tpo.PersonalStuffNextButton.Click();
        }

        public void FillOutContactFormAndSubmitApplication()
        {
            Team tpo = new Team(Driver);
            tpo.RFCTaxID.SendKeys(UserInfo.SSN.RFC1);
            tpo.ContactEmail.SendKeys("tester" + new Random().Next(100000, 999999) + "@juiceplus.com");
            tpo.ContactPhoneNumber.SendKeys(Config.AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhoneMex1);
            tpo.ContactStreeAddr1.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAddMex1);
            tpo.ScrollViewport();
            tpo.ContactCity.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.CityMex1);
            tpo.USStateTextBox.SendKeys(Config.AddressInfo.ShippingAddress.StateShipping.StateMex1);
            tpo.MXNeighborhoodTextBox.SendKeys(AddressInfo.ShippingAddress.NeighborhoodorColony.NeighborhoodMex1);
            tpo.USZipCodeTextBox.SendKeys(Config.AddressInfo.ShippingAddress.ZipCode.ZipCodeMex1);
            tpo.ContactNextButton.Click();
            tpo.IAmTheirSponsorButton.Click();
            tpo.SubmitApplicationButton.Click();
            tpo.ToTeamListButton.Click();
        }
    }
}
