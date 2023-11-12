using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using TurnUpPortalUIAutomation.Utilities;

namespace TurnUpPortalUIAutomation.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver) 
        
        {

            //Creat a new Time record
            // Click on Administration button

            IWebElement administrationOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));

            administrationOption.Click();

            //wait
            Wait.WaitToBeClickable(driver,"XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a",3);


            // Navigate to Time and Materials module

            IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterial.Click();
        }
    }
}
