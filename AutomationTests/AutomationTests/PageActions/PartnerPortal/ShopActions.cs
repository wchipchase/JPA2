﻿using AutomationTests.Config;
using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.PartnerPortal;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageActions.PartnerPortal
{
    class ShopActions
    {
        Driver Driver;
        NavigationActions navac;
        Shop shop;
        Dashboard dash;
        Login lgin;

        public ShopActions(Driver driver)
        {
            Driver = driver;
            navac = new NavigationActions(Driver);
            shop = new Shop(Driver);
            dash = new Dashboard(Driver);
            lgin = new Login(Driver);
        }
        public void NavigateToShop()
        {
            lgin.ShopNavTab.ClickWithRetry();
            shop.ShopButton.Click();
        }

        public void FillInContactDetails()
        {
            shop.ContactFirstNameTextBox.SendKeys(Config.UserInfo.FirstName.FirstName1);
            shop.ContactLastNameTextBox.SendKeys(Config.UserInfo.LastName.LastName1);
            shop.ContactEmailTextBox.SendKeys(Config.UserInfo.UserEmail.UserEmail1);
            shop.ContactPhoneTextBox.SendKeys(Config.AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhone1);
            shop.StreetAddressTextBox.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAdd1);
            shop.CityTextBox.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.City1);
            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            js.ExecuteScript("arguments[0].click();", shop.NextButton);
        }

        public void USFillInContactDetails()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            Thread.Sleep(1000);
            shop.ContactFirstNameTextBox.SendKeys(Config.UserInfo.FirstName.FirstName1);
            shop.ContactLastNameTextBox.SendKeys(Config.UserInfo.LastName.LastName1);
            shop.ContactEmailTextBox.SendKeys(Config.UserInfo.UserEmail.UserEmail1);
            shop.ContactPhoneTextBox.SendKeys(Config.AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhoneUS1);
            ScrollViewport("500");
            shop.CountryOfResidenceDropDown.Click();
            shop.CountryOfResidenceDropDown.SendKeys("u");
            shop.CountryOfResidenceDropDown.Click();
            shop.StreetAddressTextBox.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAddUS1);
            shop.CityTextBox.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.CityUS1);
            shop.StateDropdown.SendKeys(AddressInfo.ShippingAddress.StateShipping.StateUS1);
            ScrollViewport("500");
            //shop.StateDropdown.Click();
            //shop.StateDropdown.SendKeys("t");
            //shop.StateDropdown.Click();
            shop.PostalCodeTextBox.SendKeys(Config.AddressInfo.ShippingAddress.ZipCode.ZipcodeUS1);
            shop.IAmSponsorRadioButton.Click();
            Thread.Sleep(3000);
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Next']")));
            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            js.ExecuteScript("arguments[0].click();", shop.NextButton);
            
            //shop.NextButton.Click();
        }

        public void MXFillInContactDetails()
        {
            WebDriverWait waitForElement = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(30));
            Thread.Sleep(500);
            shop.ContactFirstNameTextBox.SendKeys(Config.UserInfo.FirstName.FirstName1);
            shop.ContactLastNameTextBox.SendKeys(Config.UserInfo.LastName.LastName1);
            shop.ContactEmailTextBox.SendKeys(Config.UserInfo.UserEmail.UserEmail1);
            shop.ContactGenderTextBox.ClickWithRetry();
            shop.ContactMaleGenderTextBox.Click();
            shop.ContactPhoneTextBox.SendKeys(Config.AddressInfo.ShippingAddress.PrimaryPhoneShipping.PrimaryPhoneUS1);
            ScrollViewport("500");
            shop.CountryOfResidenceDropDown.Click();
            shop.CountryOfResidenceDropDown.SendKeys("m");
            shop.CountryOfResidenceDropDown.Click();
            shop.StreetAddressTextBox.SendKeys(Config.AddressInfo.ShippingAddress.StreetAddShipping.StreetAddMex1);
            shop.NeighborhoodTextBox.SendKeys(Config.AddressInfo.ShippingAddress.NeighborhoodorColony.NeighborhoodMex1);
            shop.CityTextBox.SendKeys(Config.AddressInfo.ShippingAddress.CityShipping.CityMex1);
            shop.StateDropdown.SendKeys(Config.AddressInfo.ShippingAddress.StateShipping.StateMex1);
            ScrollViewport("500");
            //shop.StateDropdown.Click();
            //shop.StateDropdown.SendKeys("t");
            //shop.StateDropdown.Click();
            shop.PostalCodeTextBox.SendKeys(Config.AddressInfo.ShippingAddress.ZipCode.ZipCodeMex1);
            Thread.Sleep(3000);
            shop.IAmSponsorRadioButton.ClickWithRetry();
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[.='Next']")));
            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            js.ExecuteScript("arguments[0].click();", shop.NextButton);

            //shop.NextButton.Click();
        }

        public void ScrollViewport(string scrollDist)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,"+scrollDist+")");
            Thread.Sleep(500);
        }

        public void SelectProductsAndAddToCart()
        {
            Driver.ScrollToElement(shop.PremCapsAddToCart);
            shop.PremCapsAddToCart.Click();
            ScrollViewport("500");
            //shop.ReviewOrderButton.Click();
            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            //js.ExecuteScript("arguments[0].click();", shop.PremCapsAddToCart);
            //js.ExecuteScript("arguments[0].click()", shop.UpliftAddToCartSingle);
            
            js.ExecuteScript("arguments[0].click()", shop.ReviewOrderButton);
        }

        public void USSelectProductsAndAddToCart()
        {
            Thread.Sleep(2000);
            shop.FruitVegCapsAddToCart.ClickWithRetry();
            ScrollViewport("1500");
            //shop.ReviewOrderButton.Click();
            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            //js.ExecuteScript("arguments[0].click();", shop.PremCapsAddToCart);
            //js.ExecuteScript("arguments[0].click()", shop.UpliftAddToCartSingle);

            js.ExecuteScript("arguments[0].click()", shop.ReviewOrderButton);
        }

        public void ShareCart()
        {
            ScrollViewport("900");
            shop.ShareCartButton.ClickWithRetry();
            shop.ShareCartLinkIcon.ClickWithRetry();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Successfully copied to clipboard!"));
        }

    }
}
