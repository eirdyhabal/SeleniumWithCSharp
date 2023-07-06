using OpenQA.Selenium;
using SeleniumWithCSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Controls
{
    public class CheckBoxControl
    {
        public static void ClickCheckBox(IWebElement webElement) => webElement.Click();
    }
}
