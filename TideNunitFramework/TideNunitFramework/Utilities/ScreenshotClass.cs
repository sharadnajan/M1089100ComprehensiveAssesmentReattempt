using System;
using System.Collections.Generic;
using System.Text;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;
using ImageMagick;
using OpenQA.Selenium.Support.Extensions;
using WDSE;
using TideNunitFramework.BaseClass;

namespace TideNunitFramework.Utilities
{
    public class ScreenshotClass
    {
        public static void ScrnShotSearch()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            BaseClass1.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideNunitFramework\TideNunitFramework\Utilities\Scr8.Jpg", Format);
        }
        public static void ScrnShotCupon()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            BaseClass1.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideNunitFramework\TideNunitFramework\Utilities\Scr9.Jpg", Format);
        }
        public static void ScrnShotRegister()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            BaseClass1.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideNunitFramework\TideNunitFramework\Utilities\Scr10.Jpg", Format);
        }
        public static void ScrnShotWash()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            BaseClass1.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideNunitFramework\TideNunitFramework\Utilities\Scr1.Jpg", Format);
        }
        public static void ScrnShotLiveChat()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            BaseClass1.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideNunitFramework\TideNunitFramework\Utilities\Scr2.Jpg", Format);
        }
        public static void ScrnShotContact()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            BaseClass1.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideNunitFramework\TideNunitFramework\Utilities\Scr3.Jpg", Format);
        }
        public static void ScrnShotLanguage()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            BaseClass1.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideNunitFramework\TideNunitFramework\Utilities\Scr4.Jpg", Format);
        }
        public static void ScrnShotShop()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            BaseClass1.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideNunitFramework\TideNunitFramework\Utilities\Scr5.Jpg", Format);
        }
        public static void ScrnShotCommit()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            BaseClass1.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideNunitFramework\TideNunitFramework\Utilities\Scr6.Jpg", Format);
        }
        public static void ScrnShotFindRetailer()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            BaseClass1.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideNunitFramework\TideNunitFramework\Utilities\Scr7.Jpg", Format);
        }

    }
}
