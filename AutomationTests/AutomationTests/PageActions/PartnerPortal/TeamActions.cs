using AutomationTests.ConfigElements;
using AutomationTests.PageObjects.PartnerPortal;
using AutomationTests.PageObjects.staging.juiceplus.com.ie.en;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.PartnerPortal
{
    class TeamActions
    {
        Driver Driver;
        public TeamActions(Driver driver)
        {
            Driver = driver;
        }
        public void NavigateToTeams()
        {
            Login lpo = new Login(Driver);
            Thread.Sleep(1000);
            lpo.TeamNavTab.Click();
        }

        public void ClickFilterButton()
        {
            Team tpo = new Team(Driver);
            Thread.Sleep(2000);
            tpo.FilterControl.Click();
        }

        public void AddAndApplyFilters()
        {
            Team tpo = new Team(Driver);
            tpo.FilterControlP.Click();
            Thread.Sleep(1000);
            //tpo.FilterControlSC.Click();
            //Thread.Sleep(1000);
            tpo.FilterControlSP.Click();
            Thread.Sleep(1000);
            tpo.ApplyFilterButton.Click();
        }

        public void ValidateNameFilter()
        {
            Team tpo = new Team(Driver);
            Thread.Sleep(3000);
            tpo.FirstNameFilter.Click();
            tpo.LastNameFilterSelection.Click();
            Thread.Sleep(1000);
            tpo.LastNameFilter.Click();
            tpo.FirstNameFilterSelection.Click();
        }

        public void ClickDownloadAndSelectCSV()
        {
            Thread.Sleep(3000);
            Team tpo = new Team(Driver);
            tpo.DownloadFilter.Click();
            Thread.Sleep(1000);
            tpo.DownloadCSVSelection.Click();
            Thread.Sleep(2000);
        }

        public void ClickOnAddMemberAndCopyLink()
        {
            Team tpo = new Team(Driver);
            tpo.AddMemberButton.Click();
            tpo.CopyNewPartnerRegistrationLink.Click();
        }

        public void ClickOnAddMemberAndFillOutPersonalForm()
        {
            Team tpo = new Team(Driver);
            Thread.Sleep(3000);
            tpo.AddMemberButton.Click();
            tpo.FillOutFormButton.Click();
            tpo.FirstNameTextBox.SendKeys(Config.AddressInfo.ShippingAddress.FirstNameShipping.FirstName1);
            tpo.LastNameTextBox.SendKeys(Config.AddressInfo.ShippingAddress.LastNameShipping.LastName1);
            tpo.GenderDropdown.Click();
            tpo.MaleGenderSelection.Click();
            tpo.IRBirthdayTextBoxDay.SendKeys(Config.UserInfo.Birthday.USBirthdayDay1);
            tpo.IRBirthdayTextBoxMonth.SendKeys(Config.UserInfo.Birthday.USBirthdayMon1);
            tpo.IRBirthdayTextBoxYear.SendKeys(Config.UserInfo.Birthday.USBirthdayYear1);
            tpo.PPSNTextBox.SendKeys(Config.UserInfo.PPSN.PPSN1);
            tpo.ScrollViewport();
            Thread.Sleep(1000);
            tpo.PersonalStuffNextButton.Click();
        }

        public void FillOutContactFormAndSubmitApplication()
        {
            Team tpo = new Team(Driver);
            tpo.ContactEmail.SendKeys("tester" + new Random().Next(100000, 999999) + "@juiceplus.com");
            tpo.ContactPhoneNumber.SendKeys(Config.AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhone1);
            tpo.ContactStreeAddr1.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAdd1);
            tpo.ScrollViewport();
            tpo.ContactCity.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.City1);
            tpo.ContactCounty.SendKeys(Config.AddressInfo.ShippingAddress.CountyShipping.County);
            tpo.ContactNextButton.Click();
            tpo.IAmTheirSponsorButton.Click();
            tpo.SubmitApplicationButton.Click();
            tpo.ToTeamListButton.Click();
        }

        public void FillOutContactFormAndSubmitApplicationOtherSponsor()
        {
            Team tpo = new Team(Driver);
            tpo.ContactEmail.SendKeys("tester" + new Random().Next(100000, 999999) + "@juiceplus.com");
            tpo.ContactPhoneNumber.SendKeys(Config.AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhone1);
            tpo.ContactStreeAddr1.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAdd1);
            tpo.ScrollViewport();
            tpo.ContactCity.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.City1);
            tpo.ContactCounty.SendKeys(Config.AddressInfo.ShippingAddress.CountyShipping.County);
            tpo.ContactNextButton.Click();
            tpo.IAmNotTheirSponsorRadioButton.Click();
            tpo.SubmitApplicationButton.Click();
            tpo.ToTeamListButton.Click();
        }

        public void ClickFillOutForm()
        {
            Team tpo = new Team(Driver);
        }
    }




}
