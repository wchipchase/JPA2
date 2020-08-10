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
    class Dashboard

    {
        public Dashboard()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        public void ScrollViewport()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,1200)");
            Thread.Sleep(500);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='#purchaseVolume']/h2[@class='m-dashboard-performance-tabs__title']")]
        public IWebElement ComissionsCard { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='#performanceBonus']")]
        public IWebElement PerformanceBonusCard { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//a[@href='#promoteOutBonus']")]
        public IWebElement PromoteOutBonusCard { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@id='purchaseVolume']//div[@class='l-grid__column l-grid__column--tablet-portrait--12 l-grid__column--phone--12 l-grid__column--default--6']")]
        public IWebElement CommisionPersVolCard { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//h3[@class='m-dashboard-overview-box__title']")]
        public IWebElement TeamCard { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='l-grid__container l-grid__container--12']/div[@class='l-grid__column l-grid__column--default--6 l-grid__column--tablet-portrait--12 l-grid__column--phone--12']/article[@class='m-widget m-dashboard-overview-box m-widget__card--portal']//span[@class='h-icon m-action-tile__icon h-icon--arrow-right']")]
        public IWebElement TeamCardArrow { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-dashboard-customers-overview-box__header']")]
        public IWebElement CustomerCard { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[for='customer-search-type-all']")]
        public IWebElement CustomerCardAll { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "[for='customer-search-type-direct']")]
        public IWebElement CustomerCardDirect { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-portal-list-action-tiles__item tns-item']//span[@class='h-icon m-action-tile__icon h-icon--arrow-right']")]
        public IWebElement ArrowToGoToCustomer { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-dashboard-customers-overview-box']//div[@class='m-portal-list-action-tiles__item tns-item tns-slide-active']//span[@class='h-icon m-action-tile__icon h-icon--arrow-right']")]
        public IWebElement ArrowToPaymentIssues { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-dashboard-customers-overview-box']//div[2]//span[@class='h-icon m-action-tile__icon h-icon--arrow-right']")]
        public IWebElement ArrowToAnniversaries { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-dashboard-customers-overview-box']//span[@class='h-icon m-action-tile__icon h-icon--arrow-right']")]
        public IWebElement ArrowToANewOrders{ get; set; }
    }
}
