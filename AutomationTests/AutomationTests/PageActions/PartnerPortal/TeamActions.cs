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
        public static void NavigateToTeams()
        {
            Login lpo = new Login();
            Thread.Sleep(1000);
            lpo.TeamNavTab.Click();
        }

        public static void ClickFilterButton()
        {
            Team tpo = new Team();
            tpo.FilterControl.Click();
        }

        public static void AddAndApplyFilters()
        {
            Team tpo = new Team();
            tpo.FilterControlP.Click();
            Thread.Sleep(1000);
            tpo.FilterControlSC.Click();
            Thread.Sleep(1000);
            tpo.FilterControlSP.Click();
            Thread.Sleep(1000);
            tpo.ApplyFilterButton.Click();
        }

        public static void ValidateNameFilter()
        {
            Team tpo = new Team();
            tpo.FirstNameFilter.Click();
            tpo.LastNameFilterSelection.Click();
            tpo.LastNameFilter.Click();
            tpo.FirstNameFilterSelection.Click();
        }

        public static void ClickDownloadAndSelectCSV()
        {
            Team tpo = new Team();
            tpo.DownloadFilter.Click();
            Thread.Sleep(1000);
            tpo.DownloadCSVSelection.Click();
            Thread.Sleep(2000);
        }

        public static void ClickOnAddMemberAndCopyLink()
        {
            Team tpo = new Team();
            tpo.AddMemberButton.Click();
            tpo.CopyNewPartnerRegistrationLink.Click();
        }

        public static void ClickOnAddMemberAndFillOutPersonalForm()
        {
            Team tpo = new Team();
            Thread.Sleep(2000);
            tpo.AddMemberButton.Click();
            tpo.FillOutFormButton.Click();
            tpo.FirstNameTextBox.SendKeys(Config.AddressInfo.ShippingAddress.FirstNameShipping.FirstName);
            tpo.LastNameTextBox.SendKeys(Config.AddressInfo.ShippingAddress.LastNameShipping.LastName);
            tpo.GenderDropdown.Click();
            tpo.MaleGenderSelection.Click();
            tpo.BirthdayTextBox.SendKeys(Config.UserInfo.Birthday.Birthday1);
            tpo.PPSNTextBox.SendKeys(Config.UserInfo.PPSN.PPSN1);
            tpo.ScrollViewport();
            Thread.Sleep(1000);
            tpo.PersonalStuffNextButton.Click();
        }

        public static void FillOutContactFormAndSubmitApplication()
        {
            Team tpo = new Team();
            tpo.ContactEmail.SendKeys("tester" + new Random().Next(100000, 999999) + "@juiceplus.com");
            tpo.ContactPhoneNumber.SendKeys(Config.AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhone);
            tpo.ContactStreeAddr1.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAdd);
            tpo.ScrollViewport();
            tpo.ContactCity.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.City);
            tpo.ContactCounty.SendKeys(Config.AddressInfo.ShippingAddress.CountyShipping.County);
            tpo.ContactNextButton.Click();
            tpo.IAmTheirSponsorButton.Click();
            tpo.SubmitApplicationButton.Click();
            tpo.ToTeamListButton.Click();
        }

        public static void FillOutContactFormAndSubmitApplicationOtherSponsor()
        {
            Team tpo = new Team();
            tpo.ContactEmail.SendKeys("tester" + new Random().Next(100000, 999999) + "@juiceplus.com");
            tpo.ContactPhoneNumber.SendKeys(Config.AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhone);
            tpo.ContactStreeAddr1.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAdd);
            tpo.ScrollViewport();
            tpo.ContactCity.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.City);
            tpo.ContactCounty.SendKeys(Config.AddressInfo.ShippingAddress.CountyShipping.County);
            tpo.ContactNextButton.Click();
            tpo.IAmNotTheirSponsorRadioButton.Click();
            tpo.SubmitApplicationButton.Click();
            tpo.ToTeamListButton.Click();
        }

        public static void ClickFillOutForm()
        {
            Team tpo = new Team();
        }
    }




}
