﻿using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageObjects.PartnerPortal;
using NUnit.Framework;
using OpenQA.Selenium;
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
            lgin.ShopNavTab.Click();
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

        public void ScrollViewport()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,5000)");
            Thread.Sleep(500);
        }

        public void SelectProductsAndAddToCart()
        {
            shop.PremCapsAddToCart.Click();
            ScrollViewport();
            //shop.ReviewOrderButton.Click();
            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            //js.ExecuteScript("arguments[0].click();", shop.PremCapsAddToCart);
            //js.ExecuteScript("arguments[0].click()", shop.UpliftAddToCartSingle);
            
            js.ExecuteScript("arguments[0].click()", shop.ReviewOrderButton);
        }

        public void ShareCart()
        {
            shop.ShareCartButton.Click();
            shop.ShareCartLinkIcon.Click();
            Assert.IsTrue(Driver.WebDriver.PageSource.Contains("Successfully copied to clipboard!"));
        }
    }
}
