using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideBDDSpecflow.Hooks;
using TideBDDSpecflow.Drivers;

namespace TideBDDSpecflow.POM
{
    public class SearchBox
    {
        public static void WebsiteLoad()
        {
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            Thread.Sleep(3000);
            DriverClass.driver.FindElement(By.CssSelector("#lilo3746-wrapper > div > a")).Click();
            Thread.Sleep(1000);
        }
        public static void SearchBoxclick()
        {
            DriverClass.driver.FindElement(By.XPath("//input[@aria-label='Search']")).SendKeys("Hygenic Clean Powder");

            Thread.Sleep(2000);
        }
        public static void SearchIcon()
        {
            DriverClass.driver.FindElement(By.XPath("//button[@aria-label='Sumbit Search']")).Click();
            Thread.Sleep(2000);
        }
    }
}
