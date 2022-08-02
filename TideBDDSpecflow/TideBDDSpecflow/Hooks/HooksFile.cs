using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using TideBDDSpecflow.Utilities;
using TideBDDSpecflow.Drivers;

namespace TideBDDSpecflow.Hooks
{
    [Binding]
    public sealed class HooksFile
    {
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;
        public static ExtentReport extentRepo = new ExtentReport();
        public static LogFile log = new LogFile();
        [BeforeFeature]
        public static void featureBrowser(FeatureContext featureContext)
        {
            extentRepo.beforFeatureextent(featureContext);
            log.beforeFeaturelog(featureContext);
        }
        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            extentRepo.beforeScenarioExtent(scenarioContext);
            log.BeforeScenarioLog(scenarioContext);
            DriverClass.DriverOpen();
        }
        [BeforeTestRun]
        public static void Report()
        {
            extentRepo.ExtentRepo();
            log.BeforeTestrunlog();
        }
        [AfterTestRun]
        public static void etentReportFlush()
        {
            extentRepo.etentReportFlush();
        }
        [AfterStep]
        public static void reportSteps(ScenarioContext scenarioContext)
        {
            extentRepo.ExtentRepoAfterStep(scenarioContext);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverClass.DriverClose();
        }
    }

}
