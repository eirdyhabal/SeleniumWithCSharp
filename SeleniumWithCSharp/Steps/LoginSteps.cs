using OpenQA.Selenium;
using SeleniumWithCSharp.Helpers;
using SeleniumWithCSharp.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumWithCSharp.Steps
{

    [Binding]
    public class LoginSteps
    {
        private IWebDriver driver = DriverFactory.Chrome();

        

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com");
        }

        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            HomePage homePage = new HomePage(driver);

            homePage.ClickLoginLnk();
        }


        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            LoginPage loginPage = new LoginPage(driver);

            dynamic data = table.CreateDynamicInstance();
            loginPage.InputCredentials(data.UserName, data.Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.ClickLoginBtn();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            HomePage homePage = new HomePage(driver);

            Assert.That(homePage.IsLogOffVisible(), Is.True, "Log off button is not displayed");
        }

    }
}
