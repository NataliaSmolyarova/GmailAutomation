using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace Automation.Pages
{
    public abstract class AbstractPage
    {
        public abstract void OpenPage();

        public bool IsElementPresent(By locator)
        {
            return Automation.Driver.GetInstance().FindElements(locator).Count > 0;
        }

    }
 
}
