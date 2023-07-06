using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Controls
{
    /// <summary>
    /// You need to add Selenium.Support as reference before you can use the SelectElement class
    /// </summary>
    public class DropDownControl
    {
        public static void SelectByValue(IWebElement webElement, string value)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(value);
        }

        public static void SelectByText(IWebElement webElement, string value)
        {
            SelectElement select = new SelectElement(webElement);
            select.SelectByText(value);
        }
    }
}
