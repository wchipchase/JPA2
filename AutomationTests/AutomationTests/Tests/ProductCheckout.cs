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

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutPremiumCapsulesVisa()
        {
            CapsuleActions.AddPremiumCapsuleToCart();
            CartActions.CheckoutWithCartItemsVisa();
            
            
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutFruitsAndVegetablesCapsulesVisa()
        {
            CapsuleActions.AddFruitsAndVegetablesCapsuleToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutBerryCapsulesVisa()
        {
            CapsuleActions.AddBerryCapsuleToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutPremiumChewablesVisa()
        {
            ChewableActions.AddPremiumChewablesToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutFruitsAndVegetableChewablesVisa()
        {
            ChewableActions.AddFruitsAndVegetablesChewablesToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutBerryChewablesVisa()
        {
            ChewableActions.AddBerryChewablesToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutOmegaBlendVisa()
        {
            OmegaActions.AddOmegaBlendToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutUpliftVisa()
        {
            UpliftActions.AddUpliftToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteShakesVisa()
        {
            CompleteActions.AddCompleteJuicePlusShakesToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteJuiceBarsVisa()
        {
            CompleteActions.AddCompleteJuicePlusBarsToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteVegetableSoupVisa()
        {
            CompleteActions.AddCompleteVegetableSoupToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteCombiBoxVisa()
        {
            CompleteActions.AddCompleteCombiBoxToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteBoosterVisa()
        {
            CompleteActions.AddCompleteBoosterToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutPremiumCapsulesMC()
        {
            CapsuleActions.AddPremiumCapsuleToCart();
            CartActions.CheckoutWithCartItemsMC();


        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutFruitsAndVegetablesCapsulesMC()
        {
            CapsuleActions.AddFruitsAndVegetablesCapsuleToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutBerryCapsulesMC()
        {
            CapsuleActions.AddBerryCapsuleToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutPremiumChewablesMC()
        {
            ChewableActions.AddPremiumChewablesToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutFruitsAndVegetableChewablesMC()
        {
            ChewableActions.AddFruitsAndVegetablesChewablesToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutBerryChewablesMC()
        {
            ChewableActions.AddBerryChewablesToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutOmegaBlendMC()
        {
            OmegaActions.AddOmegaBlendToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutUpliftMC()
        {
            UpliftActions.AddUpliftToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteShakesMC()
        {
            CompleteActions.AddCompleteJuicePlusShakesToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteJuiceBarsMC()
        {
            CompleteActions.AddCompleteJuicePlusBarsToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteVegetableSoupMC()
        {
            CompleteActions.AddCompleteVegetableSoupToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteCombiBoxMC()
        {
            CompleteActions.AddCompleteCombiBoxToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutCompleteBoosterMC()
        {
            CompleteActions.AddCompleteBoosterToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutMixedProductUplifSinglePayRecurringOrderCapsulesSingleOrderInstallmentsVisa()
        {
            MixedProductActions.AddUpliftInstallmentPayCapsulePayInFullRecurringToCart();
            CartActions.CheckoutWithCartItemsVisa();
        }


        [Test]
        [Category("productcheckout")]
        [Category("alltest")]
        public void CheckoutMixedProductUplifSinglePayRecurringOrderCapsulesSingleOrderInstallmentsMC()
        {
            MixedProductActions.AddUpliftInstallmentPayCapsulePayInFullRecurringToCart();
            CartActions.CheckoutWithCartItemsMC();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Teardown();
        }

    }
}
