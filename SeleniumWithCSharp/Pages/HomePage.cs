using OpenQA.Selenium;
using SeleniumWithCSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement linkLogin => _driver.FindElement(By.LinkText("Login"));

        IWebElement linkLogoff => _driver.FindElement(By.LinkText("Hello admin!"));

        public void ClickLoginLnk() => linkLogin.Click();

        public bool IsLogOffVisible() => linkLogoff.Displayed;
    }
}
