using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TideBDDSpecflow.Drivers
{
   public  class DriverClass
    {
       public static  IWebDriver driver;
       public static void DriverOpen()
        {
            driver = new ChromeDriver();
        }
        public static void DriverClose()
        {
           driver.Quit();
        }
    }
}
