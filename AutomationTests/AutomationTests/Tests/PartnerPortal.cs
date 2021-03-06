﻿using AutomationTests.ConfigElements;
using AutomationTests.PageActions.PartnerPortal;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.CartCheckoutActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.NavigationsActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.IndividualCapsuleActions;
using NUnit.Framework;
using System;
using System.Threading;

namespace AutomationTests
{
    [TestFixture]

    //add to TestFixture to run parallel ", Parallelizable(ParallelScope.All)"
    class PartnerPortal
    {
        [ThreadStatic]
        static Driver Driver;
        [ThreadStatic]
        static LoginActions lgac;
        [ThreadStatic]
        static DashboardActions dbac;
        [ThreadStatic]
        static TeamActions tmac;
        [ThreadStatic]
        static CustomerActions csac;
        [ThreadStatic]
        static PPCartActions ppac;
        [ThreadStatic]
        static NavigationActions nav;
        [ThreadStatic]
        static CapsuleActions cpac;
        [ThreadStatic]
        static CartActions ctac;
        [ThreadStatic]
        static ShopActions spac;

        //Add to setup when cloudflare is acting up
        //Driver = new Driver(Driver.BrowserType.Chrome);
        //Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //    Driver.WebDriver.Manage().Window.Maximize();
        //    var dateString = "5/1/2030 8:30:52 AM";
        //DateTime date1 = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);
        //OpenQA.Selenium.Cookie cfCookie = new OpenQA.Selenium.Cookie("CF_Authorization", "eyJraWQiOiJhNmFjOGFhZGZkN2JiZGY3OWU5YWFlOThkZWQwZDA3YWY1MzhhZTYzMjVlMjIxMzRjZDE2MjgxZGJhOGM2YWZjIiwiYWxnIjoiUlMyNTYiLCJ0eXAiOiJKV1QifQ.eyJhdWQiOiJiNzM2MWZiZTBlMWIwOGMzMjM0MWUwMzFlNzQzZTRmNDRjYTFmZTM5NjUwMGViMWYyZDI1NTY4MDU3M2UzZDhiIiwiZXhwIjoxNjAxNjg3MTA0LCJpc3MiOiJodHRwczpcL1wvanVpY2VwbHVzLmNsb3VkZmxhcmVhY2Nlc3MuY29tIiwiY29tbW9uX25hbWUiOiI5OGE2MzM0MjJiMDBmMDEzYTFiYmJiZTFjMTg0YzgxYi5hY2Nlc3MiLCJpYXQiOjE1OTkwNTkxMDQsInN1YiI6IiJ9.M-qnRFlSBclMBI2QwBaaKaZOgsSneOr8EljkHOvuhN-1ol-6bNrqga5LRY-jyOCxXb8qxyO1b5zaCFRTIkKjL_UoJ00hIIyz2VwcWdGg_xkDeeS5-MpLF3Z6LTwLhpxk0_W2mxW_WezRK0ryTgF3EEOBWazlzYMjM_3UPNjdAnEDck-EvqDZNPi8wxdFwxfc7XKoobQroyg5aUmM91EsNI7udkaXl0BgaX_XaW9UYFkgRSAzamg9FAjtLuO1wpoayg4amLVv1_yUcKdVZIvZZbO80CU57VbnaBTOi3ShTB4PckGvJUTDoQDOyNtv9WoOb2WyA6RTDOZlHpLEvT3wXg", "www.prod.juiceplus.com", "/", date1);
        //Driver.WebDriver.Navigate().GoToUrl("https://www.prod.juiceplus.com/mx/en");
        //Thread.Sleep(1000);
        //    Driver.WebDriver.Manage().Cookies.AddCookie(cfCookie);
        //    Thread.Sleep(1000);
        //    Driver.WebDriver.Navigate().GoToUrl("https://www.prod.juiceplus.com/mx/en");
        [SetUp]
        public void SetUpTest()
        {
            Driver = new Driver(Driver.BrowserType.Chrome);
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.WebDriver.Manage().Window.Maximize();
            Driver.WebDriver.Navigate().GoToUrl("https://www.staging.juiceplus.com/ie/en/");
            lgac = new LoginActions(Driver);
            dbac = new DashboardActions(Driver);
            tmac = new TeamActions(Driver);
            csac = new CustomerActions(Driver);
            ppac = new PPCartActions(Driver);
            nav = new NavigationActions(Driver);
            cpac = new CapsuleActions(Driver);
            ctac = new CartActions(Driver);
            spac = new ShopActions(Driver);
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void ValidateDashboardCards()
        {
            lgac.IELoginAsPartner2();
            dbac.ValidatePerformanceBonusCard();
            Thread.Sleep(2000);
            dbac.ValidatePromoteOutBonusCard();
            Thread.Sleep(2000);
            dbac.ValidateComissionCard();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void TeamFilterValidation()
        {
            lgac.IELoginAsPartner2();
            tmac.NavigateToTeams();
            tmac.ClickFilterButton();
            tmac.AddAndApplyFilters();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void ValidatingFirstAndLastNameFilters()
        {
            lgac.IELoginAsPartner2();
            tmac.NavigateToTeams();
            tmac.ValidateNameFilter();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void ValidateDownloadCSV()
        {
            lgac.IELoginAsPartner2();
            tmac.NavigateToTeams();
            tmac.ClickDownloadAndSelectCSV();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void CustomerFilterValidation()
        {
            lgac.IELoginAsPartner2();
            csac.NavigateToCustomers();
            csac.ClickFilterButton();
            csac.AddAndApplyFilters();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void PurchaseProductsWithInvalidCC()
        {
            ppac.NavigateToJuicePlusWebsite();
            ppac.AddProductsToCart();
            ppac.CheckoutWithItems();
            ppac.CheckoutLogin();
            ppac.FillInDeliveryAddressAndProceed();
            ppac.EnterInvalidPaymentInfoAndConfirmOrder();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void AddAMemberPartnerPortal()
        {
            lgac.IELoginAsPartner2();
            tmac.NavigateToTeams();
            tmac.ClickOnAddMemberAndFillOutPersonalForm();
            tmac.FillOutContactFormAndSubmitApplication();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void PurchaseProductsASLoggedInAssociate()
        {
            ppac.NavigateToJuicePlusWebsite();
            ppac.AddProductsToCart();
            ppac.CheckoutWithItems();
            ppac.CheckoutLogin();
            ppac.FillInDeliveryAddressAndProceed();
            //ppac.EnterPaymentInfoAndConfirmOrder();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void GuestCheckoutPremiumCapsulesVisa()
        {
            cpac.AddPremiumCapsuleToCart();
            ctac.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void AddAMemberPartnerPortalDifferentSponsor()
        {
            lgac.IELoginAsPartner2();
            tmac.NavigateToTeams();
            tmac.ClickOnAddMemberAndFillOutPersonalForm();
            tmac.FillOutContactFormAndSubmitApplicationOtherSponsor();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void ValdiateContactForm()
        {
            nav.NavigateCompany_ContactUs();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void SwitchCountryInCart()
        {
            //ppac.NavigateToJuicePlusWebsite();
            ppac.AddProductsToCart();
            ppac.ChangeCountry();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void SharedCartPortalOrders()
        {
            lgac.IELoginAsPartner2();
            csac.NavigateToCustomers();
            csac.SelectFirstCustomer();
            csac.SelectFirstCustomerDetails();
            csac.SelectFirstCustomerOrders();
        }

        [Test]
        [Category("smoketest-ie")]
        [Category("alltest")]
        public void SharedCartJuicePlusOrder()
        {
            lgac.IELoginAsPartner2();
            spac.NavigateToShop();
            spac.FillInContactDetails();
            spac.SelectProductsAndAddToCart();
            spac.ShareCart();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }

    }
}
