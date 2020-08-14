using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.PartnerPortal
{
    class Team
    {
        Driver Driver;
        public Team(Driver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Filter']")]
        public IWebElement FilterControl { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='SC']")]
        public IWebElement FilterControlSC { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='SP']")]
        public IWebElement FilterControlSP { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='P']")]
        public IWebElement FilterControlP { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='SDD']")]
        public IWebElement FilterControlSDD { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='QSSC']")]
        public IWebElement FilterControlQSSC { get; set; }
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='SSC']")]
        public IWebElement FilterControlSSC { get; set; }
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='QNMD']")]
        public IWebElement FilterControlQNMD { get; set; }
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='NMD']")]
        public IWebElement FilterControlNMD { get; set; }
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='NULL']")]
        public IWebElement FilterControlNULL { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='First Name']")]
        public IWebElement FirstNameFilter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Last Name']")]
        public IWebElement LastNameFilter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='m-flyout__content js-m-flyout__content m-flyout__content--attached m-flyout__content--select m-flyout__content--dropdown']//a[contains(.,'Last Name')]")]
        public IWebElement LastNameFilterSelection { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='m-flyout__content js-m-flyout__content m-flyout__content--attached m-flyout__content--select m-flyout__content--dropdown']//a[contains(.,'First Name')]")]
        public IWebElement FirstNameFilterSelection { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='m-flyout__content js-m-flyout__content m-flyout__content--attached m-flyout__content--select m-flyout__content--dropdown']//a[contains(.,'Last name')]")]
        public IWebElement LastNameSelectFilter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Download']")]
        public IWebElement DownloadFilter { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Apply Filter']")]
        public IWebElement ApplyFilterButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='m-flyout__content js-m-flyout__content m-flyout__content--attached m-flyout__content--dropdown']//a[contains(.,'CSV')]")]
        public IWebElement DownloadCSVSelection { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Add member']")]
        public IWebElement AddMemberButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Copy Link']")]
        public IWebElement CopyNewPartnerRegistrationLink { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Fill out form']")]
        public IWebElement FillOutFormButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "registration.member.firstName")]
        public IWebElement FirstNameTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "registration.member.lastName")]
        public IWebElement LastNameTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "registration.member.gender")]
        public IWebElement GenderDropdown { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//option[contains(.,'Female')]")]
        public IWebElement FemaleGenderSelection { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//option[contains(.,'Male')]")]
        public IWebElement MaleGenderSelection { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "registration.member.dateOfBirth")]
        public IWebElement BirthdayTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "registration.member.socialSecurityNumber")]
        public IWebElement PPSNTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-partner-registration-personal']//span[@class='a-button__inner']")]
        public IWebElement PersonalStuffNextButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "registration.contact.email")]
        public IWebElement ContactEmail { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "registration.contact.phoneNumber")]
        public IWebElement ContactPhoneNumber { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "registration.contact.street1")]
        public IWebElement ContactStreeAddr1 { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "registration.contact.city")]
        public IWebElement ContactCity { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "registration.contact.county")]
        public IWebElement ContactCounty { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//form[@class='m-form']/div[@class='m-stepper__content']/section[@class='l-section l-section--transparent m-partner-registration-step']//span[.='Next']")]
        public IWebElement ContactNextButton{ get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//form[@class='m-form']/div[@class='m-stepper__content']/section[@class='l-section l-section--transparent m-partner-registration-step']//span[.='Next']")]
        public IWebElement IAmNotTheirSponsorRadioButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Submit application']")]
        public IWebElement SubmitApplicationButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//label[contains(.,'I am their sponsor')]")]
        public IWebElement IAmTheirSponsorButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='To Team List']")]
        public IWebElement ToTeamListButton { get; set; }

        public void ScrollViewport()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(500);
        }
    }
}
