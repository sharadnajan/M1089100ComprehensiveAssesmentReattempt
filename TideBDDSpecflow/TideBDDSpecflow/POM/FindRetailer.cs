using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideBDDSpecflow.Drivers;

namespace TideBDDSpecflow.POM
{
    public class FindRetailer
    {
        public static void WebsiteLoad()
        {
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            Thread.Sleep(3000);
            DriverClass.driver.FindElement(By.CssSelector("#lilo3746-wrapper > div > a")).Click();
            Thread.Sleep(1000);
        }
        public static void FindRetailerHover()
        {
            Thread.Sleep(3000);
            Actions actions = new Actions(DriverClass.driver);
            IWebElement shopProducts = DriverClass.driver.FindElement(By.XPath("//a[@data-action-detail='Shop Products']"));
            actions.MoveToElement(shopProducts).Perform();
            Thread.Sleep(3000);
        }
        public static void FindRetailerPacs()
        {
            Thread.Sleep(2000);
            DriverClass.driver.FindElement(By.XPath("//span[text()='Pacs'][1]")).Click();
            Thread.Sleep(2000);
        }
        public static void FindRetaile()
        {
            Thread.Sleep(4000);
            DriverClass.driver.FindElement(By.XPath("//span[text()='Find Retailers'][1]")).Click();
            Thread.Sleep(2000);
            DriverClass.driver.FindElement(By.XPath("//input[@class='ps-map-location-textbox']")).SendKeys("New York");
            Thread.Sleep(2000);
        }
    }
}
