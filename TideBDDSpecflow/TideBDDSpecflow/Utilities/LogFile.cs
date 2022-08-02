using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Serilog;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Serilog.Core;
using Gherkin.Ast;
using Scenario = AventStack.ExtentReports.Gherkin.Model.Scenario;
using Feature = AventStack.ExtentReports.Gherkin.Model.Feature;
using TideBDDSpecflow.Utilities;

namespace TideBDDSpecflow.Utilities
{
   public  class LogFile
    {
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;
        public void beforeFeaturelog(FeatureContext featureContext)
        {
            Log.Information("selecting feature file {0} to run", featureContext.FeatureInfo.Title);
        }
        public void BeforeScenarioLog(ScenarioContext scenarioContext)
        {
            Log.Information("selecting scenario file {0} to run", scenarioContext.ScenarioInfo.Title);
        }
        public void BeforeTestrunlog()
        {
            LoggingLevelSwitch loggingLevel = new LoggingLevelSwitch(Serilog.Events.LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(levelSwitch: loggingLevel).WriteTo.File(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\Logs", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message} {NewLine}", rollingInterval: RollingInterval.Day).CreateLogger();
        }
    }
}
