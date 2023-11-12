﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TurnUpPortalUIAutomation.Utilities
{
    public class Wait
    {
        public static void WaitToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int secounds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }

            if (locatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }

            if (locatorType == "Class")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName(locatorValue)));
            }
        }


        public static void WaitToExist(IWebDriver driver, string locatorType, string locatorValue, int secounds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }

            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }

            if (locatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
            }

            if (locatorType == "Class")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName(locatorValue)));
            }
        }


    }
}