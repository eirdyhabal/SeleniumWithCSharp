using OpenQA.Selenium;
using SeleniumWithCSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Implementations
{
    public class CheckBoxControl : ChromeDriverHelper
    {
        public static void ClickCheckBox(string value)
        {
            Driver
                .FindElement(By.XPath($"//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='{value}']"))
                .Click();
        }
    }
}
