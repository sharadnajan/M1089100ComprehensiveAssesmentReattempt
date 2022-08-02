using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TideNunitFramework.BaseClass;
using System.Threading;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using ServiceStack;

namespace TideNunitFramework.Test_Methods
{
    public class TestClass
    {
        public static Actions actions = new Actions(BaseClass1.driver);
        private static IJavaScriptExecutor js;

        public static void WebsiteLoad()
        {
            BaseClass1.driver.Manage().Window.Maximize();
            BaseClass1.driver.Navigate().GoToUrl("https://tide.com/en-us");
            Thread.Sleep(3000);
            BaseClass1.driver.FindElement(By.CssSelector("#lilo3746-wrapper > div > a")).Click();
            Thread.Sleep(1000);
            //BaseClass1.driver.FindElement(By.ClassName("sticker_close")).Click();
        }
        public static void SearchBox_()
        {
            BaseClass1.driver.FindElement(By.XPath("//input[@aria-label='Search']")).SendKeys("Hygenic Clean Powder");
            BaseClass1.driver.FindElement(By.XPath("//button[@aria-label='Sumbit Search']")).Click();
            Thread.Sleep(2000);
        }

        public static void RegisterUser_()
        {
            BaseClass1.driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();
            BaseClass1.driver.FindElement(By.XPath("//a[@href='https://www.pggoodeveryday.com/signup/tide-coupons/']")).Click();
            // Thread.Sleep(5000);
            //BaseClass1.driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Sharad");
            // BaseClass1.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("Sharad"); 
            //   BaseClass1.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Sharad");
            Thread.Sleep(2000);
        }
        public static void WashClothes_()
        {
            Thread.Sleep(3000);
            Actions actions = new Actions(BaseClass1.driver);
            IWebElement howToWash = BaseClass1.driver.FindElement(By.XPath("//a[@href='/en-us/how-to-wash-clothes']"));
            actions.MoveToElement(howToWash).Perform();
            Thread.Sleep(3000);
             BaseClass1.driver.FindElement(By.XPath("//span[text()='How to Remove Stains'][1]")).Click();
                     Thread.Sleep(1000);
            BaseClass1.driver.FindElement(By.XPath("//a[text()='Acne Cream']")).Click();
            Thread.Sleep(2000);
        }

        public static void Cupons_()
        {
            Thread.Sleep(1000);
            BaseClass1.driver.FindElement(By.XPath("//a[@data-action-detail='Coupons and Rewards']")).Click();
            Thread.Sleep(1000);
            BaseClass1.driver.FindElement(By.XPath("//a[@href='https://www.pggoodeveryday.com/signup/tide-coupons/']")).Click();
            Thread.Sleep(1000);
        }
        public static void LiveChat_()
        {
            BaseClass1.driver.FindElement(By.XPath("//a[@href='/en-us/live-chat']")).Click();
            Thread.Sleep(2000);
            
        }
        public static void Contact_()
        {
            BaseClass1.driver.FindElement(By.XPath("//a[contains(text(),'Contact Us')]")).Click();
            Thread.Sleep(8000);
           // BaseClass1.driver.FindElement(By.ClassName("#j_id0:j_id1:j_id2:idForm:j_id36:j_id37:opMainId:2:j_id45")).Click();
            //Thread.Sleep(3000);
        }
         public static void LaguageChange_()
        {
            BaseClass1.driver.FindElement(By.CssSelector("#site-header > div.header-top-bar > div > div > div > div.header-top-bar-right-side.d-flex.align-items-center > button > svg")).Click();
            Thread.Sleep(2000);
                 BaseClass1.driver.FindElement(By.XPath("//a[@href='https://tide.com/es-us']")).Click();
            Thread.Sleep(2000);
            
        }
        public static void ShopProducts_()
        {
            Thread.Sleep(3000);
            Actions actions = new Actions(BaseClass1.driver);
            IWebElement shopProducts = BaseClass1.driver.FindElement(By.XPath("//a[@data-action-detail='Shop Products']"));
            actions.MoveToElement(shopProducts).Perform();
            Thread.Sleep(3000);
            BaseClass1.driver.FindElement(By.XPath("//span[text()='Pacs'][1]")).Click();
            Thread.Sleep(3000);
           //string pacs= BaseClass1.driver.FindElement(By.XPath("//a[@data-action-detail='Shop Products']")).Text;
          //  Assert.IsTrue(pacs.Contains("Pacs"));

        }
        public static void FindRetailer_()
        {
            Thread.Sleep(3000);
            IWebElement shopProducts = BaseClass1.driver.FindElement(By.XPath("//a[@data-action-detail='Shop Products']"));
            actions.MoveToElement(shopProducts).Perform();
            Thread.Sleep(3000);
            BaseClass1.driver.FindElement(By.XPath("//span[text()='Pacs'][1]")).Click();
            Thread.Sleep(1000);
            BaseClass1.driver.FindElement(By.XPath("//span[text()='Find Retailers'][1]")).Click();
            Thread.Sleep(2000);
            BaseClass1.driver.FindElement(By.XPath("//input[@class='ps-map-location-textbox']")).SendKeys("New York");
            Thread.Sleep(2000);

        }

            public static void OurCommitment_()
        {
            Thread.Sleep(3000);
            Actions actions = new Actions(BaseClass1.driver);
            IWebElement ourCommit = BaseClass1.driver.FindElement(By.XPath("//a[@data-action-detail='Our Commitment']"));
            actions.MoveToElement(ourCommit).Perform();
            Thread.Sleep(3000);
            BaseClass1.driver.FindElement(By.XPath("//a[@data-action-detail='Our Ambition']")).Click();
            Thread.Sleep(1000);
             string ourAmbition = BaseClass1.driver.FindElement(By.XPath("//h2[text()='Our Ambition']")).Text;
            Thread.Sleep(2000);
            
            Assert.That(ourAmbition, Is.EqualTo("Our Ambition"));

        }
        public static void WhatsNew_()
        {
           BaseClass1.driver.FindElement(By.XPath("//a[@data-action-detail='What’s New']")).Click();
            Thread.Sleep(3000);
            BaseClass1.driver.FindElement(By.XPath("//a[@data-action-detail='Our Ambition']")).Click();
            Thread.Sleep(1000);
            string ourAmbition = BaseClass1.driver.FindElement(By.XPath("//h2[text()='Our Ambition']")).Text;
            

            Assert.That(ourAmbition, Is.EqualTo("Our Ambition"));

        }
    }
}
