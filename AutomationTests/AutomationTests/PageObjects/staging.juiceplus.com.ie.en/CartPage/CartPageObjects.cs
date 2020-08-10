using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.staging.juiceplus.com.ie.en.CartPage
{
    class CartPageObjects
    {
        public CartPageObjects()
        {
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        public void ScrollToProceedToCheckoutClick()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WebDriver;
            js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(500);
            ProceedToCheckoutButton.Click();
        }

        public void NavigateToProceedToCheckoutAndClick()
        {
            CartPageObjects cpo = new CartPageObjects();
            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver.WebDriver);
            js.ExecuteScript("arguments[0].click();", cpo.ProceedToCheckoutButton);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.ClassName, Using = "o-cart-overview__title")]
        public IWebElement YourCartPageLabel { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-input-toggle__switch")]
        public IWebElement RecurringOrderSlider { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='m-input-number__increment-button']/span[@class='h-icon h-icon--chevron-down-small']")]
        public IWebElement IncrementArrowOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//button[@class='m-input-number__decrement-button']/span[@class='h-icon h-icon--chevron-down-small']")]
        public IWebElement DecrementArrowOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-cart-item__price']/span[contains(.,'€73.50')]")]
        public IWebElement PPMProductPriceCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-cart-item__price']/span[contains(.,'€286.00')]")]
        public IWebElement PPSProductPriceCart { get; set; }
        
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Id, Using = "input-number")]
        public IWebElement NumOfProductOrder { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-cart-group__total-value")]
        public IWebElement MonthlyTotalCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-order-summary__total-price")]
        public IWebElement SummaryTotalCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-input-toggle__inner-button")]
        public IWebElement PayInFullorInstallmentsSlider { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Proceed to checkout']")]
        public IWebElement ProceedToCheckoutButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[for='firstOptionSINGLE']")]
        public IWebElement PayInFull { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[for='secondOptionSINGLE']")]
        public IWebElement PayInInstallments { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[for='firstOptionRECURRING_EVERY_4_MONTHS']")]
        public IWebElement PayPerShipment { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[for='secondOptionRECURRING_EVERY_4_MONTHS']")]
        public IWebElement PayPerMonth{ get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//*[@id='app']/div/header/div[3]/div/div/div[2]/div[3]/div[2]/div/span/a/div/span")]
        public IWebElement ShoppingCartIcon { get; set; }
    }
}
