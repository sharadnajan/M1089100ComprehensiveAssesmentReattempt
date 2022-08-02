using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using TideBDDSpecflow.Hooks;


namespace TideBDDSpecflow.POM
{
    public class DriverClass
    {
        public void WebsiteLoad()
        {
            HooksFile.driver.Manage().Window.Maximize();
            HooksFile.driver.Navigate().GoToUrl("https://tide.com/en-us");
            Thread.Sleep(3000);
            HooksFile.driver.FindElement(By.CssSelector("#lilo3746-wrapper > div > a")).Click();
            Thread.Sleep(1000);
        }
        public void LaguageChange_()
        {
            HooksFile.driver.FindElement(By.CssSelector("#site-header > div.header-top-bar > div > div > div > div.header-top-bar-right-side.d-flex.align-items-center > button > svg")).Click();
            Thread.Sleep(2000);
          

        }
        public void SelectLang()
        {
            HooksFile.driver.FindElement(By.XPath("//a[@href='https://tide.com/es-us']")).Click();
            Thread.Sleep(2000);
        }
        public  void ShopProducts()
        {
            Thread.Sleep(3000);
            Actions actions = new Actions(HooksFile.driver);
            IWebElement shopProducts = HooksFile.driver.FindElement(By.XPath("//a[@data-action-detail='Shop Products']"));
            actions.MoveToElement(shopProducts).Perform();
            Thread.Sleep(3000);          
            //string pacs= BaseClass1.driver.FindElement(By.XPath("//a[@data-action-detail='Shop Products']")).Text;
            //  Assert.IsTrue(pacs.Contains("Pacs"));
        }
        public  void ShopProductsClick()
        {
            HooksFile.driver.FindElement(By.XPath("//span[text()='Pacs'][1]")).Click();
            Thread.Sleep(3000);           
        }
        public void OurCommitmentHover()
        {
            Thread.Sleep(3000);
            Actions actions = new Actions(HooksFile.driver);
            IWebElement ourCommit = HooksFile.driver.FindElement(By.XPath("//a[@data-action-detail='Our Commitment']"));
            actions.MoveToElement(ourCommit).Perform();
            Thread.Sleep(3000);          
           
        }
        public void OurCommitment()
        {
            HooksFile.driver.FindElement(By.XPath("//a[@data-action-detail='Our Ambition']")).Click();
            Thread.Sleep(1000);

        }
        public void OurCommitmentAssert()
        {
            string ourAmbition = HooksFile.driver.FindElement(By.XPath("//h2[text()='Our Ambition']")).Text;
            Thread.Sleep(2000);

            Assert.That(ourAmbition, Is.EqualTo("Our Ambition"));
        }
        public void WashClothes()
        {
            Thread.Sleep(3000);
            Actions actions = new Actions(HooksFile.driver);
            IWebElement howToWash = HooksFile.driver.FindElement(By.XPath("//a[@href='/en-us/how-to-wash-clothes']"));
            actions.MoveToElement(howToWash).Perform();
            Thread.Sleep(3000);
        }
        public void WashClothe()
        {
            HooksFile.driver.FindElement(By.XPath("//span[text()='How to Remove Stains'][1]")).Click();
            Thread.Sleep(1000);
            //HooksFile.driver.FindElement(By.XPath("//a[text()='Acne Cream']")).Click();
            //Thread.Sleep(2000);

        }
        public  void Cupons()
        {
            Thread.Sleep(1000);
            HooksFile.driver.FindElement(By.XPath("//a[@data-action-detail='Coupons and Rewards']")).Click();
         
            Thread.Sleep(1000);
        }
        public void CuponsSelect()
        {
            HooksFile.driver.FindElement(By.XPath("//a[@href='https://www.pggoodeveryday.com/signup/tide-coupons/']")).Click();
            Thread.Sleep(1000);
        }
        public  void LiveChat()
        {
            HooksFile.driver.FindElement(By.XPath("//a[@href='/en-us/live-chat']")).Click();
            Thread.Sleep(2000);
        }
        public  void LaguageChange()
        {
            HooksFile.driver.FindElement(By.CssSelector("#site-header > div.header-top-bar > div > div > div > div.header-top-bar-right-side.d-flex.align-items-center > button > svg")).Click();
            Thread.Sleep(2000);
            HooksFile.driver.FindElement(By.XPath("//a[@href='https://tide.com/es-us']")).Click();
            Thread.Sleep(2000);

        }
        public void LaguageChangeClick()
        {
            HooksFile.driver.FindElement(By.XPath("//a[@href='https://tide.com/es-us']")).Click();
            Thread.Sleep(2000);
        }
        public void SearchBox()
        {
            HooksFile.driver.FindElement(By.XPath("//input[@aria-label='Search']")).SendKeys("Hygenic Clean Powder");
           
            Thread.Sleep(2000);
        }
        public void SearchIcon()
        {
            HooksFile.driver.FindElement(By.XPath("//button[@aria-label='Sumbit Search']")).Click();
            Thread.Sleep(2000);
        }
    }
}
