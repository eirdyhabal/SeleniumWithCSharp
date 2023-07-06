using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace SeleniumWithCSharp.Helpers
{
    public static class DriverFactory
    {
        public static IWebDriver Chrome()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");

            new DriverManager().SetUpDriver(new ChromeConfig());
            Console.WriteLine("Setup");

            return new ChromeDriver(option);
        }
    }
}
