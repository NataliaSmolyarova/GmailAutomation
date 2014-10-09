using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Automation.Pages
{
    public class LoginPage: AbstractPage
    {
        private const string BASE_URL = "https://mail.google.com/";

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement inputEmailField;

        [FindsBy(How = How.Id, Using = "Passwd")]
        private IWebElement inputPasswordField;

        [FindsBy(How = How.Id, Using = "signIn")]
        private IWebElement buttonEnter;
    
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        public override void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }
        public void Login(string userEmail, string password)
        {
            inputEmailField.SendKeys(userEmail);
            inputPasswordField.SendKeys(password);
            buttonEnter.Click();
        }
    }
}
