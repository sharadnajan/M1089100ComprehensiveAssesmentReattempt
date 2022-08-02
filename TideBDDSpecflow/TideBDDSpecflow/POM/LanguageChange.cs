using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideBDDSpecflow.Drivers;

namespace TideBDDSpecflow.POM
{
    public class LanguageChange
    {
        public static void OpenWebsite()
        {
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            Thread.Sleep(3000);
            DriverClass.driver.FindElement(By.CssSelector("#lilo3746-wrapper > div > a")).Click();
            Thread.Sleep(1000);
        }
        public static void LaguageChange_()
        {
            DriverClass.driver.FindElement(By.CssSelector("#site-header > div.header-top-bar > div > div > div > div.header-top-bar-right-side.d-flex.align-items-center > button > svg")).Click();
            Thread.Sleep(2000);


        }
        public static void SelectLang()
        {
            DriverClass.driver.FindElement(By.XPath("//a[@href='https://tide.com/es-us']")).Click();
            Thread.Sleep(2000);
        }

    }
}
