using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithCSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Controls
{
    public class TextBoxControl
    {
        public static void WriteOnTextBox(IWebElement webElement, string value) => webElement.SendKeys(value);
    }
}
