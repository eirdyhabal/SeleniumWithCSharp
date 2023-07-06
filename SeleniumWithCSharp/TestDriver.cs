using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithCSharp.Controls;
using SeleniumWithCSharp.Helpers;
using SeleniumWithCSharp.Pages;

namespace SeleniumWithCSharp
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = DriverFactory.Chrome();
        }

        [Test]
        public void Selenium_Test()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            TextBoxControl.WriteOnTextBox(driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$Meal']")), "Text");

            CheckBoxControl.ClickCheckBox(driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")));

            //ComboBoxControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");
            ComboBoxControl.SearchComboBoxItem(driver.FindElement(By.XPath($"//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']")), "Almonds");
            ComboBoxControl.ClickComboBoxItem(driver.FindElement(By.XPath($"//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almonds']")));

            DropDownControl.SelectByText(driver.FindElement(By.XPath("//select[@id='ContentPlaceHolder1_Add1-awed']")), "Artichoke");
        }

        [Test]
        public void Login_Test()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com");

            HomePage homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);

            homePage.ClickLoginLnk();
            loginPage.InputCredentials("admin", "password");
            loginPage.ClickLoginBtn();
            Assert.That(homePage.IsLogOffVisible(), Is.True, "Log off button is not displayed");
        }
    }
}