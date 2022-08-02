using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideBDDSpecflow.Drivers;

namespace TideBDDSpecflow.POM
{
    public class WashClothe
    {
        public static void WebsiteLoad()
        {
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            Thread.Sleep(3000);
            DriverClass.driver.FindElement(By.CssSelector("#lilo3746-wrapper > div > a")).Click();
            Thread.Sleep(1000);
        }
        public static void WashClothes()
        {
            Thread.Sleep(3000);
            Actions actions = new Actions(DriverClass.driver);
            IWebElement howToWash = DriverClass.driver.FindElement(By.XPath("//a[@href='/en-us/how-to-wash-clothes']"));
            actions.MoveToElement(howToWash).Perform();
            Thread.Sleep(3000);
        }
        public static void WashClotheSelect()
        {
            DriverClass.driver.FindElement(By.XPath("//span[text()='How to Remove Stains'][1]")).Click();
            Thread.Sleep(1000);
        }
    }
}
