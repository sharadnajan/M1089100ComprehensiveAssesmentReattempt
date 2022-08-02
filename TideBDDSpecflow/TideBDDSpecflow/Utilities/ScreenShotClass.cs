using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;
using ImageMagick;
using OpenQA.Selenium.Support.Extensions;
using WDSE;
using TideBDDSpecflow.Drivers;

namespace TideBDDSpecflow.Utilities
{
    public class ScreenShotClass
    {
        public void LanguageChange()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            DriverClass.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\LanguageChange.Jpg", Format);
        }
        public void ShopProduct()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            DriverClass.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\ShopProduct.Jpg", Format);
        }
        public void Commitment()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            DriverClass.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\Commitment.Jpg");
        }
        public void HowToWash()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            DriverClass.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\HowtoWash.Jpg");
        }
        public void Cupon()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            DriverClass.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\Cupon.Jpg");
        }
        public void LiveChat()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            DriverClass.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\LiveChat.Jpg");
        }
        public void ContactUs()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            DriverClass.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\ContactUs.Jpg");
        }
        public void SearchBox()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            DriverClass.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\SearchBox.Jpg");
        }
        public void WhatsNew()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            DriverClass.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\WhatsNew.Jpg");
        }
        public void Retailer()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            DriverClass.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\Retailer.Jpg");
        }
    }
}

