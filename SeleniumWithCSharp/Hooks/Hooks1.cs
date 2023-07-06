using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumWithCSharp.Helpers;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace SeleniumWithCSharp.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks


        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
    }
}