using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideBDDSpecflow.Drivers;

namespace TideBDDSpecflow.POM
{
   public  class Commitment
    {
        public static void WebsiteLoad()
        {
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            Thread.Sleep(3000);
            DriverClass.driver.FindElement(By.CssSelector("#lilo3746-wrapper > div > a")).Click();
            Thread.Sleep(1000);
        }
        public static void OurCommitmentHover()
        {
            Thread.Sleep(3000);
            Actions actions = new Actions(DriverClass.driver);
            IWebElement ourCommit = DriverClass.driver.FindElement(By.XPath("//a[@data-action-detail='Our Commitment']"));
            actions.MoveToElement(ourCommit).Perform();
            Thread.Sleep(3000);

        }
        public static void OurCommitment()
        {
            DriverClass.driver.FindElement(By.XPath("//a[@data-action-detail='Our Ambition']")).Click();
            Thread.Sleep(1000);

        }
        public static void OurCommitmentAssert()
        {
            string ourAmbition = DriverClass.driver.FindElement(By.XPath("//h2[text()='Our Ambition']")).Text;
            Thread.Sleep(2000);

            Assert.That(ourAmbition, Is.EqualTo("Our Ambition"));
        }
    }
}
