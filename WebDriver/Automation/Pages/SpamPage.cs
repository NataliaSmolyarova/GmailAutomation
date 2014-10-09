using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Automation.Pages
{
    public class SpamPage
    {
        [FindsBy(How = How.XPath, Using = "//input[@id = 'gbqfq']")]
        private IWebElement inputField;

        [FindsBy(How = How.XPath, Using = "//button[@class='gbqfb']")]
        private IWebElement searchSpamFolder;

        [FindsBy(How = How.XPath, Using = "//tr[@class='zA yO']")]
        private IWebElement spamLetter;

        [FindsBy(How = How.XPath, Using = "//span[text()='Natalia Mironovich']")]
        private IWebElement senderOfSpam;

        private IWebDriver driver;

        public SpamPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void GoToSpam(string spamFolder)
        {
            inputField.SendKeys(spamFolder);
            searchSpamFolder.Click();
            spamLetter.Click();
        }
        public string FindSpamSender()
        {
            return senderOfSpam.GetAttribute("email").ToLower();
        }
    }

}