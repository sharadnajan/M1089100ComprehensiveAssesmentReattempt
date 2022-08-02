using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideBDDSpecflow.Drivers;

namespace TideBDDSpecflow.POM
{
    public class ShopProduct
    {
        public static void WebLoad()
        {
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            Thread.Sleep(3000);
            DriverClass.driver.FindElement(By.CssSelector("#lilo3746-wrapper > div > a")).Click();
            Thread.Sleep(1000);
        }
        public static void ShopProducts()
        {
            Thread.Sleep(3000);
            Actions actions = new Actions(DriverClass.driver);
            IWebElement shopProducts = DriverClass.driver.FindElement(By.XPath("//a[@data-action-detail='Shop Products']"));
            actions.MoveToElement(shopProducts).Perform();
            Thread.Sleep(3000);

        }
        public static void ShopProductsClick()
        {
            DriverClass.driver.FindElement(By.XPath("//span[text()='Pacs'][1]")).Click();
            Thread.Sleep(3000);
        }
    }
}
