using OpenQA.Selenium;
using SeleniumWithCSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Controls
{
    public class ComboBoxControl
    {
        public static void SearchComboBoxItem(IWebElement webElement, string value)
        {
           webElement.Clear();
           webElement.SendKeys(value);
        }

        public static void ClickComboBoxItem(IWebElement webElement) => webElement.Click();
    }
}
