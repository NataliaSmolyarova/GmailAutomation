using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Automation.Pages
{
    public class MainPage
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='T-I J-J5-Ji T-I-KE L3']")]
        private IWebElement writeEMailButton;

        [FindsBy(How = How.XPath, Using = "//textarea[@class='vO']")]
        private IWebElement recipient;

        [FindsBy(How = How.XPath, Using = "//input[@class='aoT']")]
        private IWebElement topic;

        [FindsBy(How = How.XPath, Using = "//div[@class='Am Al editable LW-avf']")]
        private IWebElement letter;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'T-I J-J5-Ji aoO T-I-atl L3']")]
        private IWebElement sendButton;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'T-Jo-auh'][1]")]
        private IWebElement checkbox;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'asl T-I-J3 J-J5-Ji']")]
        private IWebElement mark;

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void sendEmail(string addressee)
        {
            writeEMailButton.Click();
            recipient.SendKeys(addressee);
            topic.SendKeys(Utils.RandomGeneration.GetRandomString(12));
            letter.SendKeys(Utils.RandomGeneration.GetRandomString(123));
            sendButton.Click();
        }

        public void MarkAsSpam()
        {
            checkbox.Click();
            mark.Click();
        }
    }  
}
