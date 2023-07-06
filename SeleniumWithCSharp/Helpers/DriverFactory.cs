using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Helpers
{
    public static class DriverFactory
    {
        public static IWebDriver Chrome()
        {
            return new ChromeDriver();
        }
    }
}
