using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideBDDSpecflow.Drivers;

namespace TideBDDSpecflow.POM
{
   public  class ContactUS
    {
        public static void WebsiteLoad()
        {
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            Thread.Sleep(3000);
            DriverClass.driver.FindElement(By.CssSelector("#lilo3746-wrapper > div > a")).Click();
            Thread.Sleep(1000);
        }
        public static void Contact()
        {
            DriverClass.driver.FindElement(By.XPath("//a[contains(text(),'Contact Us')]")).Click();
            Thread.Sleep(8000);
            // BaseClass1.driver.FindElement(By.ClassName("#j_id0:j_id1:j_id2:idForm:j_id36:j_id37:opMainId:2:j_id45")).Click();
            //Thread.Sleep(3000);
        }
    }
}
