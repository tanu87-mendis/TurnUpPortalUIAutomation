using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TurnUpPortalUIAutomation.Utilities;

namespace TurnUpPortalUIAutomation.Pages
{
    public class TMPage
    {
        public void Create_TimeRecord(IWebDriver driver)
        {
            //Explicit wait creat new button to load

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"container\"]/p/a", 5);

            //Click on create new button

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();


            //Select Time from Typecode drop down 

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            //*[@id="TimeMaterialEditForm"]/div/div[1]/div/span[1]/span/span[1]

            typeCodeDropdown.Click();

            //Entre code in to the code textbox

            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("tanuTestCode");


            // Entre description into description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("test");

            //Entre price per unit into price per unit textbox 
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));

            priceTextbox.SendKeys("100");


            //Click on Save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(4000);

            //Check if new record has been created sucessfully 
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));


            if (newCode.Text == "tanuTestCode")

            {
                Console.WriteLine("new record has been created sucessfully");
            }
            else
            {
                Console.WriteLine("record has not been created");

            }


            Thread.Sleep(10000);

        }

        public void Edit_TimeRecord(IWebDriver driver) 
        {
            //Edit record

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[5]/a[1]"));

            //*[@id=\"tmsGrid]/div[3]/table/tbody/tr[last()]/td[5]/a[1]
            //*[@id="tmsGrid"]/div[3]/table/tbody/tr[2]/td[5]/a[1]
            editButton.Click();

            Thread.Sleep(6000);

            //Edit code in the code text box
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("tanuEdit");


            //Edit discription in discription text box
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("testEditDis");

            //Edit price per unit in price per unit textbox

            Thread.Sleep(6000);

            IWebElement editPriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            //editPriceTextbox.Clear();
            editPriceTextbox.SendKeys("200");

            Thread.Sleep(6000);

            //Save edit data by clicking Save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();

            Thread.Sleep(6000);
            //Check if record has been edited sucessfully (change the xpath according to the record we created)

            IWebElement goToLastPageButtonEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonEdit.Click();


            Thread.Sleep(6000);

            IWebElement newEditCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newEditCode.Text == "tanuEdit")
            {

                Console.WriteLine("The record has been sucessfullu edited");
            }
            else
            {
                Console.WriteLine("The record edit function is unsucussfull");

            }

        }

        public void Delete_TimeRecord(IWebDriver driver)
        {
            //Delete record from Time and Material page

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();


            //IWebElement deleteRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]"));
            //deleteRecord.Click();

        }
    }
}
