using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithCSharp.Helpers;
using SeleniumWithCSharp.Implementations;

namespace SeleniumWithCSharp
{
    public class Tests : ChromeDriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Selenium_Test()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            TextBoxControl.WriteOnTextBox("Text");

            CheckBoxControl.ClickCheckBox("Cauliflower");

            ComboBoxControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");
        }
    }
}