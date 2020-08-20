using AutomationTests.ConfigElements;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.CartCheckoutActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.MixedProductActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.ChewablesActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.CompleteActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.IndividualCapsuleActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.OmegaActions;
using AutomationTests.PageActions.staging.juiceplus.com.ie.en.OurProductsMenuItemsActions.UpliftActions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests
{
    [TestFixture]
    class ProductCheckout
    {
        [ThreadStatic]
        static Driver Driver;
        [ThreadStatic]
        static CapsuleActions caps;
        [ThreadStatic]
        static CartActions cart;
        [ThreadStatic]
        static ChewableActions chew;
        [ThreadStatic]
        static OmegaActions omega;
        [ThreadStatic]
        static UpliftActions upla;
        [ThreadStatic]
        static CompleteActions comp;
        [ThreadStatic]
        static MixedProductActions mpa;


        [SetUp]
        public void SetUpTest()
        {
            Driver = new Driver(Driver.BrowserType.Chrome);
            Driver.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.WebDriver.Manage().Window.Maximize();
            Driver.WebDriver.Navigate().GoToUrl("https://www.staging.juiceplus.com/ie/en/");
            Driver = new Driver(Driver.BrowserType.Chrome);
            caps = new CapsuleActions(Driver);
            cart = new CartActions(Driver);
            chew = new ChewableActions(Driver);
            omega = new OmegaActions(Driver);
            upla = new UpliftActions(Driver);
            comp = new CompleteActions(Driver);
            mpa = new MixedProductActions(Driver);
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutPremiumCapsulesVisa()
        {
            caps.AddPremiumCapsuleToCart();
            cart.CheckoutWithCartItemsVisa();
            
            
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutFruitsAndVegetablesCapsulesVisa()
        {
            caps.AddFruitsAndVegetablesCapsuleToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutBerryCapsulesVisa()
        {
            caps.AddBerryCapsuleToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutPremiumChewablesVisa()
        {
            chew.AddPremiumChewablesToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutFruitsAndVegetableChewablesVisa()
        {
            chew.AddFruitsAndVegetablesChewablesToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutBerryChewablesVisa()
        {
            chew.AddBerryChewablesToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutOmegaBlendVisa()
        {
            omega.AddOmegaBlendToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutUpliftVisa()
        {
            upla.AddUpliftToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteShakesVisa()
        {
            comp.AddCompleteJuicePlusShakesToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteJuiceBarsVisa()
        {
            comp.AddCompleteJuicePlusBarsToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteVegetableSoupVisa()
        {
            comp.AddCompleteVegetableSoupToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteCombiBoxVisa()
        {
            comp.AddCompleteCombiBoxToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteBoosterVisa()
        {
            comp.AddCompleteBoosterToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutPremiumCapsulesMC()
        {
            caps.AddPremiumCapsuleToCart();
            cart.CheckoutWithCartItemsMC();


        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutFruitsAndVegetablesCapsulesMC()
        {
            caps.AddFruitsAndVegetablesCapsuleToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutBerryCapsulesMC()
        {
            caps.AddBerryCapsuleToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutPremiumChewablesMC()
        {
            chew.AddPremiumChewablesToCart();
            cart.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutFruitsAndVegetableChewablesMC()
        {
            chew.AddFruitsAndVegetablesChewablesToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutBerryChewablesMC()
        {
            chew.AddBerryChewablesToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutOmegaBlendMC()
        {
            omega.AddOmegaBlendToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutUpliftMC()
        {
            upla.AddUpliftToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteShakesMC()
        {
            comp.AddCompleteJuicePlusShakesToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteJuiceBarsMC()
        {
            comp.AddCompleteJuicePlusBarsToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteVegetableSoupMC()
        {
            comp.AddCompleteVegetableSoupToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteCombiBoxMC()
        {
            comp.AddCompleteCombiBoxToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteBoosterMC()
        {
            comp.AddCompleteBoosterToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutMixedProductUplifSinglePayRecurringOrderCapsulesSingleOrderInstallmentsVisa()
        {
            mpa.AddUpliftInstallmentPayCapsulePayInFullRecurringToCart();
            cart.CheckoutWithCartItemsVisa();
        }


        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutMixedProductUplifSinglePayRecurringOrderCapsulesSingleOrderInstallmentsMC()
        {
            mpa.AddUpliftInstallmentPayCapsulePayInFullRecurringToCart();
            cart.CheckoutWithCartItemsMC();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }

    }
}
