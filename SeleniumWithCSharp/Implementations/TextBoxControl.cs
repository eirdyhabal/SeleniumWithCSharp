using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithCSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Implementations
{
    public class TextBoxControl : ChromeDriverHelper
    {
        public static void WriteOnTextBox(string value)
        {
            //Driver.FindElement(By.Id("ContentPlaceHolder1_Meal"))
            //    .SendKeys("Test");

            //Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_Meal']"))
            //    .SendKeys("Test");

            Driver
                .FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$Meal']"))
                .SendKeys(value);
        }
    }
}
