using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Automation.Utils;

namespace Automation.Tests   
{
     [TestFixture]
 public   class SmokeTest{

        private Steps.Steps steps = new Steps.Steps();
        private const string USEREMAIL = "nataliauser1@gmail.com";
        private const string USEREMAIL2 = "nataliauser2@gmail.com";
        private const string USERPASSWORD = "79864513";
        private const string ADDRESSEE = "nataliauser2@gmail.com";
        private const string SPAMFOLDER = "in:spam";


        [SetUp]
        public void Init()
        {
            steps.InitBrowser();  
        }

       [TearDown]
       public void CleanUp()
       {
           steps.CloseBrowser();
       }

       [Test]
        public void UserLoginsGmail()
       {
            steps.LoginGmail(USEREMAIL, USERPASSWORD);
            steps.WriteALetter(ADDRESSEE);
            steps.CloseBrowser();
            steps.InitBrowser();
            steps.LoginGmail(USEREMAIL2, USERPASSWORD);
            steps.MarkTheLetter();
            steps.CloseBrowser();
            steps.InitBrowser();
            steps.LoginGmail(USEREMAIL, USERPASSWORD);
            steps.WriteALetter(ADDRESSEE);
            steps.CloseBrowser();
            steps.InitBrowser();
            steps.LoginGmail(USEREMAIL2, USERPASSWORD);
            steps.GoToSpam(SPAMFOLDER);
            Assert.True(steps.AssertSpam(USEREMAIL), "all right");
      
          
        }  
       
     }
    }
    

