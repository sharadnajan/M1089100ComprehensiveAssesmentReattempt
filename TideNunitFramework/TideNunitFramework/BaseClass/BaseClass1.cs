using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TideNunitFramework.Utilities;
using TideNunitFramework.Test_Methods;
using AventStack.ExtentReports;

namespace TideNunitFramework.BaseClass
{
   public class BaseClass1
    {
        public static IWebDriver driver;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }
        [OneTimeSetUp]
        public void extentReport()
        {
           ExtentReportClass.ExtentRepo();
        }

        [Test]
        public void SearchBox()
        {
           ExtentReportClass.test = ExtentReportClass.extents.CreateTest("Search Box Feature");
          TestClass.WebsiteLoad();
            TestClass.SearchBox_();
            ScreenshotClass.ScrnShotSearch();
            ExtentReportClass.test.Log(Status.Info, "Website Loaded");
            log.Info("Website Loaded");
            log.Info("Enter Hygenic Clean Powder in the search Box ");
             ExtentReportClass.test.Log(Status.Pass, "Test Pass");
        }
        [Test]
        public void RegisterUser()
        {
            ExtentReportClass.test = ExtentReportClass.extents.CreateTest("User Registartion feature");
           TestClass.WebsiteLoad();
            TestClass.RegisterUser_();
            ScreenshotClass.ScrnShotRegister();
            ExtentReportClass.test.Log(Status.Info, "Website Loaded");        
         log.Info("Website Loaded");
            log.Info("Clicked on Register");
         ExtentReportClass.test.Log(Status.Pass,"User Registered Successfully");
        }
        [Test]
        public void WashClothes()
        {
           ExtentReportClass.test = ExtentReportClass.extents.CreateTest("How To Wash Clothes").Info("Test Strarted");
          TestClass.WebsiteLoad();
            TestClass.WashClothes_();
            ScreenshotClass.ScrnShotWash();
            ExtentReportClass.test.Log(Status.Info, "Website Loaded");
            log.Info("Website Loaded");
            ExtentReportClass.test.Log(Status.Info, "Click on How to Wash Clothes");
            log.Info("Click on How to Wash Clothes");
           ExtentReportClass.test.Log(Status.Pass, "Information searched successfully");

        }
        [Test]
        public void Cupons()
        {
            ExtentReportClass.test = ExtentReportClass.extents.CreateTest("Cupons and Rrewards for users Feature");
            TestClass.WebsiteLoad();
            TestClass.Cupons_();
            ScreenshotClass.ScrnShotCupon();
            ExtentReportClass.test.Log(Status.Info, "Website Loaded");
            log.Info("Website Loaded");
            ExtentReportClass.test.Log(Status.Info, "Clicked on Cupons and Rewards");
            log.Info("Clicked on Cupons and Rewards");
            ExtentReportClass.test.Log(Status.Pass, "Cupon Collected");
        }
        [Test]
        public void LiveChat()
        {
            ExtentReportClass.test = ExtentReportClass.extents.CreateTest("Live chat Feature");
            TestClass.WebsiteLoad();
            TestClass.LiveChat_();
            ScreenshotClass.ScrnShotLiveChat();
            ExtentReportClass.test.Log(Status.Info, "Website Loaded");
            log.Info("Website Loaded");
            ExtentReportClass.test.Log(Status.Info, "Clicked on Live chat");
            log.Info("Clicked on Live chat");
            ExtentReportClass.test.Log(Status.Pass,"Chat successfully");
        }
        [Test]
        public void Contact()
        {
            ExtentReportClass.test = ExtentReportClass.extents.CreateTest("Contact Us feature");
            TestClass.WebsiteLoad();
            TestClass.Contact_();
            ScreenshotClass.ScrnShotContact();
            ExtentReportClass.test.Log(Status.Info, "Website Loaded");
            log.Info("Website Loaded");
            ExtentReportClass.test.Log(Status.Info, "Clicked on Contact us");
            log.Info("Clicked on Contact us");
            ExtentReportClass.test.Log(Status.Pass, "Test Pass");
        }
        [Test]
        public void LaguageChange()
        {
            ExtentReportClass.test = ExtentReportClass.extents.CreateTest("Language Change of website");
            TestClass.WebsiteLoad();
            TestClass.LaguageChange_();
            ScreenshotClass.ScrnShotLanguage();
            ExtentReportClass.test.Log(Status.Info, "Website Loaded");
            log.Info("Website Loaded");
            ExtentReportClass.test.Log(Status.Info, "clicked on website language dropdown ");
            log.Info("clicked on website language dropdown");
            ExtentReportClass.test.Log(Status.Pass, "Website Language Changed");
        }
        [Test]
        public void ShopProducts()
        {
            ExtentReportClass.test = ExtentReportClass.extents.CreateTest("Shop Products");
            TestClass.WebsiteLoad();
            TestClass.ShopProducts_();
            ScreenshotClass.ScrnShotShop();
            ExtentReportClass.test.Log(Status.Info, "Website Loaded");
            log.Info("Website Loaded");
            ExtentReportClass.test.Log(Status.Info, "clicked on shop Products");
            log.Info("clicked on shop Products");
            ExtentReportClass.test.Log(Status.Pass, " Test Pass");
            
        }
        [Test]
        public void OurCommitment()
        {
            ExtentReportClass.test = ExtentReportClass.extents.CreateTest("Our Commitments");
            TestClass.WebsiteLoad();
            TestClass.OurCommitment_();
            ScreenshotClass.ScrnShotCommit();
            ExtentReportClass.test.Log(Status.Info, "Website Loaded");
            log.Info("Website Loaded");
            ExtentReportClass.test.Log(Status.Info, "clicked on our commitment");
            log.Info("clicked on our commitment");
            ExtentReportClass.test.Log(Status.Pass, " Test Pass");

        }
        [Test]
        public void FindRetailer()
        {
            ExtentReportClass.test = ExtentReportClass.extents.CreateTest("Findretailer Feature");
            TestClass.WebsiteLoad();
            TestClass.FindRetailer_();
            ScreenshotClass.ScrnShotFindRetailer();
            ExtentReportClass.test.Log(Status.Info, "Website Loaded");
            log.Info("Website Loaded");
            ExtentReportClass.test.Log(Status.Info, "clicked on our commitment");
            log.Info("clicked on our commitment");
            ExtentReportClass.test.Log(Status.Pass, " Test Pass");
            
        }
        [TearDown]
        public static void Close()
        {
            driver.Close();
         ExtentReportClass.ExtentFlush();

        }

    }
}
