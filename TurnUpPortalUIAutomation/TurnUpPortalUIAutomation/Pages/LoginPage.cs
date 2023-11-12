using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TurnUpPortalUIAutomation.Utilities;

namespace TurnUpPortalUIAutomation.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver) 
        {
            driver.Manage().Window.Maximize();

            //Lunch Turnup portal and navigate to the website login page 

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

            //wait

            Wait.WaitToExist(driver, "Id", "UserName", 8);

            //Identify username text box and entre validate username 

            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");

            //Identify password text box and entre validate password

            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");
            //Identify login button and click on the button

            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            LoginButton.Click();

        }
    }
}
