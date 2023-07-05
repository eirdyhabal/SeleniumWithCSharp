using OpenQA.Selenium;
using SeleniumWithCSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Implementations
{
    public class ComboBoxControl : ChromeDriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboDriver = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));

            comboDriver.Clear();
            comboDriver.SendKeys("Almonds");

            Driver
                .FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']"))
                .Click();
        }
    }
}
