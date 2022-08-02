using TechTalk.SpecFlow;
using TideBDDSpecflow.POM;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TideBDDSpecflow.Hooks;
using System.Threading;
using TideBDDSpecflow.Utilities;
using TechTalk.SpecFlow;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace TideBDDSpecflow.Steps
{
    [Binding]
    public class TideStepDefinitions
    {
      
        ScreenShotClass ScrObject = new ScreenShotClass();

        [Given(@"Load the website")]
        public void GivenLoadTheWebsite()
       {
           LanguageChange.OpenWebsite();
       }

        [Given(@"user click on language")]
        public void GivenUserClickOnLanguage()
        {
            LanguageChange.LaguageChange_();
        }

        [When(@"user select language")]
        public void WhenUserSelectLanguage()
        {
            LanguageChange.SelectLang();
        }

        [Then(@"websites language changed")]
        public void ThenWebsitesLanguageChanged()
        {
            ScrObject .LanguageChange();
        }
        [Given(@"Lunch the tide website")]
        public void GivenLunchTheTideWebsite()
        {
           ShopProduct.WebLoad();
        }

        [Given(@"hover mouse pointer on the shop product")]
        public void GivenHoverMousePointerOnTheShopProduct()
        {
            ShopProduct.ShopProducts();
        }

        [When(@"click on pacs  product")]
        public void WhenClickOnPacsProduct()
        {
            ShopProduct.ShopProductsClick();
        }

        [Then(@"result for pacs product displayed")]
        public void ThenResultForPacsProductDisplayed()
        {
            ScrObject.ShopProduct();
        }

        [Given(@"Open browser and open Website")]
        public void GivenOpenBrowserAndOpenWebsite()
        {
            Commitment.WebsiteLoad();
        }

        [Given(@"hover mouse pointer on the our commitment")]
        public void GivenHoverMousePointerOnTheOurCommitment()
        {
            Commitment.OurCommitmentHover();
        }

        [When(@"click on our ambition")]
        public void WhenClickOnOurAmbition()
        {
            Commitment.OurCommitment();
        }

        [Then(@"our ambtion displayed")]
        public void ThenOurAmbtionDisplayed()
        {
            Commitment.OurCommitmentAssert();
            ScrObject.Commitment();

        }
        [Given(@"Open  The Website")]
        public void GivenOpenTheWebsite()
        {
            WashClothe.WebsiteLoad();
        }

        [Given(@"hover mouse pointer on the how to wash clothes")]
        public void GivenHoverMousePointerOnTheHowToWashClothes()
        {
            WashClothe.WashClothes();
        }

        [When(@"click on how to remove stains")]
        public void WhenClickOnHowToRemoveStains()
        {
            WashClothe.WashClotheSelect();
        }

        [Then(@"Information for How to remove stain dispalyed")]
        public void ThenInformationForHowToRemoveStainDispalyed()
        {
            ScrObject.HowToWash();
        }
       
        [Given(@"open the web")]
        public void GivenOpenTheWeb()
        {
            CouponsRewards.WebsiteLoad();
        }

        [Given(@"click on Coupons and rewards")]
        public void GivenClickOnCouponsAndRewards()
        {
           CouponsRewards.Cupons();
        }

        [When(@"click on save now")]
        public void WhenClickOnSaveNow()
        {
            CouponsRewards.CuponsSelect();
        }

        [Then(@"page redirected on log in page")]
        public void ThenPageRedirectedOnLogInPage()
        {
            ScrObject.Cupon();
        }
        [Given(@"Open  the Tide Website")]
        public void GivenOpenTheTideWebsite()
        {
            LiveChat.WebsiteLoad();
        }

        [When(@"Click on Live Chat")]
        public void WhenClickOnLiveChat()
        {
            LiveChat.LiveChatCall();
        }

        [Then(@"Page redirected on Live chat page")]
        public void ThenPageRedirectedOnLiveChatPage()
        {
            ScrObject. LiveChat();
        }
        [Given(@"Open the Tidecom website")]
        public void GivenOpenTheTidecomWebsite()
        {
            ContactUS.WebsiteLoad();
        }
        [When(@"Click on contact us")]
        public void WhenClickOnContactUs()
        {
            ContactUS.Contact();
        }

        [Then(@"Contact option displayed")]
        public void ThenContactOptionDisplayed()
        {
            ScrObject.ContactUs();
        }

        [Given(@"load the tidecom website")]
        public void GivenLoadTheTidecomWebsite()
        {
            SearchBox.WebsiteLoad();
        }

        [Given(@"Enter the product name in the search box")]
        public void GivenEnterTheProductNameInTheSearchBox()
        {
            SearchBox.SearchBoxclick();
        }

        [When(@"click on the search icon")]
        public void WhenClickOnTheSearchIcon()
        {
            SearchBox.SearchIcon();
        }

        [Then(@"result for Searched product displayed")]
        public void ThenResultForSearchedProductDisplayed()
        {
            ScrObject.SearchBox();
        }
        [Given(@"Open the tide web")]
        public void GivenOpenTheTideWeb()
        {
            WhatsNew.WebsiteLoad();
        }

        [When(@"click on Whats new")]
        public void WhenClickOnWhatsNew()
        {
            WhatsNew.WhatsNewTide();
        }

        [Then(@"Tide Program Displayed")]
        public void ThenTideProgramDisplayed()
        {
            ScrObject.WhatsNew();
        }
        [Given(@"Load the tide Website")]
        public void GivenLoadTheTideWebsite()
        {
            FindRetailer.WebsiteLoad();
        }

        [Given(@"Hover Mouse pointer over Shop Product")]
        public void GivenHoverMousePointerOverShopProduct()
        {
            FindRetailer.FindRetailerHover();
        }

        [When(@"Click on Pacs from dropdown")]
        public void WhenClickOnPacsFromDropdown()
        {
            FindRetailer.FindRetailerPacs();
        }

        [When(@"click on Find Retailer Enter City name and click on search icon")]
        public void WhenClickOnFindRetailerEnterCityNameAndClickOnSearchIcon()
        {
            FindRetailer.FindRetaile();
        }

        [Then(@"Near Retailer displayed")]
        public void ThenNearRetailerDisplayed()
        {
            ScrObject.Retailer();
            ExelClass.ExcelRead();
        }
    }
}











