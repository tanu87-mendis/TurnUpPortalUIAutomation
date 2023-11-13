using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TurnUpPortalUIAutomation.Pages;
using TurnUpPortalUIAutomation.Utilities;

namespace TurnUpPortalUIAutomation.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void TimeSetUo()
        {
             driver = new ChromeDriver(); // instance of a browser


            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Home page objetct initialization and definition 
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

        }
        [Test]
        public void CreateTime_Test()
        {
            //TM page object initialization and deninition 
            TMPage tmPageObject = new TMPage();
            tmPageObject.Create_TimeRecord(driver);

        }
        [Test]
        public void EditTime_Test()
        {
            //Edit TM
            TMPage tmPageObject = new TMPage();
            tmPageObject.Edit_TimeRecord(driver);
        }
           [Test]
        public void DeleteTime_Test() 
        {


            //Delete TM
            TMPage tmPageObject = new TMPage();
            tmPageObject.Delete_TimeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {

            driver.Quit();
        }


    }
}
