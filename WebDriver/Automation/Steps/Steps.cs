using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Automation.Steps
{
    public class Steps{

        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Automation.Driver.GetInstance();
        }

        public void CloseBrowser()
        {
            Automation.Driver.CloseBrowser();
        }

        public void LoginGmail(string userEmail, string password)
        {
            Pages.LoginPage loginPage = new Pages.LoginPage(driver);
            loginPage.OpenPage();
            loginPage.Login(userEmail, password);
        }

        public void WriteALetter(string addressee) {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.sendEmail(addressee); 
        }

        public void MarkTheLetter()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.MarkAsSpam();
        }

        public void GoToSpam(string spamFolder)
        {
            Pages.SpamPage spamPage = new Pages.SpamPage(driver);
            spamPage.GoToSpam(spamFolder); 
        }

        public bool AssertSpam(string userEMail)
        {
            Pages.SpamPage spamPage = new Pages.SpamPage(driver);
            return spamPage.FindSpamSender().Equals(userEMail);
        }

      
    }
}
