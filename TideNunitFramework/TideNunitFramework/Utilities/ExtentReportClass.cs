using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;

namespace TideNunitFramework.Utilities
{
   public class ExtentReportClass
    {
        public static ExtentReports extents;
        public static ExtentTest test;
        public static void ExtentRepo()
        {
            var htmlReport = new ExtentHtmlReporter(@"C:\Users\mindc1may134\source\repos\TideNunitFramework\TideNunitFramework\Utilities\Report.html");
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extents = new ExtentReports();
            extents.AttachReporter(htmlReport);
        }
        public static void ExtentFlush()
        {
            extents.Flush();
        }

    }
}
