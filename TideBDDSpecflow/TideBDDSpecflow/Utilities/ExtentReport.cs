using System;
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

namespace TideBDDSpecflow.Utilities
{
    public class ExtentReport
    {
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;
        public void beforFeatureextent(FeatureContext featureContext)
        {
            feature = extents.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }
        public void beforeScenarioExtent(ScenarioContext scenarioContext)
        {
            scenario = feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }
        public void ExtentRepo()
        {
            var htmlReport = new ExtentHtmlReporter(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\\Report.html");
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extents = new ExtentReports();
            extents.AttachReporter(htmlReport);
        }
        public void ExtentRepoAfterStep(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError == null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);

            }
            if (scenarioContext.TestError != null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
            }

        }
       public void etentReportFlush()
        {
            extents.Flush();
        }
    }
}
