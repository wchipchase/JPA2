using AutomationTests.ConfigElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.PageObjects.PartnerPortal
{
    class Shop
    {
        Driver Driver;
        public Shop(Driver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver.WebDriver, this);
        }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Order Now']")]
        public IWebElement ShopButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = "[placeholder='Type to find a customer']")]
        public IWebElement FindACustomerTypeAhead{ get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.contact.firstName")]
        public IWebElement ContactFirstNameTextBpx { get; set; }
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.contact.lastName")]
        public IWebElement ContactLastNameTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.contact.email")]
        public IWebElement ContactEmailTextBox { get; set; }
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-input-select__input")]
        public IWebElement CountrySelector { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.street1")]
        public IWebElement StreetAddressTextBpx { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.street2")]
        public IWebElement AptSuiteTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.Name, Using = "shipping.address.city")]

        public IWebElement CityTextBox { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-input-checkbox__label")]

        public IWebElement BillingAddressCheckMark { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//label[contains(.,'I am their sponsor')]")]

        public IWebElement IAmSponsorRadioButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//label[contains(.,'Someone else is their sponsor')]")]

        public IWebElement SomeoneElseSPonsorRadioButton{ get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Next']")]

        public IWebElement NextButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-shop-products__content']//li[1]//span[@class='h-icon h-icon--cart-small']")]

        public IWebElement PremCapsAddToCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-shop-products__content']//li[2]//span[@class='h-icon h-icon--cart-small']")]

        public IWebElement FruitVegCapsAddToCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-shop-products__content']//li[3]//span[@class='h-icon h-icon--cart-small']")]

        public IWebElement BerryBlendCapsAddToCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-shop-products__content']//li[4]//span[@class='h-icon h-icon--cart-small']")]

        public IWebElement PremiumChewAddToCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-shop-products__content']//li[5]//span[@class='h-icon h-icon--cart-small']")]

        public IWebElement BerryChewAddToCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='m-shop-products__content']//li[6]//span[@class='h-icon h-icon--cart-small']")]

        public IWebElement FruitVegChewAddToCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//li[7]/div[@class='m-shop-products__item-variants']/div[2]//span[@class='h-icon h-icon--cart-small']")]

        public IWebElement UpliftAddToCartSingle { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//li[7]//div[1]//span[@class='h-icon h-icon--cart-small']")]

        public IWebElement UpliftAAddToCartRecurring { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//li[8]//span[@class='h-icon h-icon--cart-small']")]

        public IWebElement OmwgaAddToCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.CssSelector, Using = ".m-shop-products__footer")]

        public IWebElement ReviewOrderButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Share cart']")]

        public IWebElement ShareCartButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='h-icon h-icon--link']")]

        public IWebElement ShareCartLinkIcon{ get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='h-icon h-icon--envelope-outline']")]

        public IWebElement EmailShareCartIcon{ get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[@class='h-icon h-icon--chat']")]

        public IWebElement ChatShareCart { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='Enter another order']")]

        public IWebElement EnterAnotherOrderButton { get; set; }

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = How.XPath, Using = "//span[.='To customer list']")]

        public IWebElement CustomerListButton { get; set; }
    }
}
