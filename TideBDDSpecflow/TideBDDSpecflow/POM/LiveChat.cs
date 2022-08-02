using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideBDDSpecflow.Drivers;

namespace TideBDDSpecflow.POM
{
   public  class LiveChat
    {
        public static void WebsiteLoad()
        {
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            Thread.Sleep(3000);
            DriverClass.driver.FindElement(By.CssSelector("#lilo3746-wrapper > div > a")).Click();
            Thread.Sleep(1000);
        }
        public static void LiveChatCall()
        {
            DriverClass.driver.FindElement(By.XPath("//a[@href='/en-us/live-chat']")).Click();
            Thread.Sleep(2000);
        }
    }
}
