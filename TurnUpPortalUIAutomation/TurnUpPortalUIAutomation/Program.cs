
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortalUIAutomation.Pages;

//open chrom browser

public class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver(); // instance of a browser


        //Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //Home page objetct initialization and definition 
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMPage(driver);

        //TM page object initialization and deninition 
        TMPage tmPageObject = new TMPage();
        tmPageObject.Create_TimeRecord(driver);

        //Edit TM
        tmPageObject.Edit_TimeRecord(driver);

        //Delete TM
        tmPageObject.Delete_TimeRecord(driver);
    }
}