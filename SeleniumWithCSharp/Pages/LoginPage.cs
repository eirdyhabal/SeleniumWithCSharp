using OpenQA.Selenium;
using SeleniumWithCSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Pages
{
    public class LoginPage 
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;   
        }

        IWebElement txtUserName => _driver.FindElement(By.XPath("//input[@id='UserName']"));
        IWebElement txtPassword => _driver.FindElement(By.XPath("//input[@id='Password']"));
        IWebElement btnLogin => _driver.FindElement(By.CssSelector(".btn-default"));


        public void InputCredentials(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }


        public void ClickLoginBtn() => btnLogin.Click();
    }
}
