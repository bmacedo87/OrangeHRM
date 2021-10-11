
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrangeHRM.Pages
{
    class AdminPage : CommonDriver
    {
        // Textboxes
        private static IWebElement employeeNameTextbox => driver.FindElement(By.Id("systemUser_employeeName_empName"));
        private static IWebElement selectEmployeeNameTextbox => driver.FindElement(By.XPath("/html/body/div[4]/ul/li"));
        private static IWebElement usernameTextbox => driver.FindElement(By.Id("systemUser_userName"));
        private static IWebElement passwordTextbox => driver.FindElement(By.Id("systemUser_password"));
        private static IWebElement passwordConfirmationTexbox => driver.FindElement(By.Id("systemUser_confirmPassword"));

        // Buttons
        private static IWebElement saveButton => driver.FindElement(By.Id("btnSave"));
        private static IWebElement addUserButton => driver.FindElement(By.Id("btnAdd"));
        // Tables
        private static IWebElement userCreated => driver.FindElement(By.XPath("//*[@id='resultTable']/tbody/tr[last()]/td[2]"));

        public static void CreateNewUser()
        {
            addUserButton.Click();

            // Creating variables to be able to select a USER ROLE option
            var userRole = driver.FindElement(By.Id("systemUser_userType"));
            var selectElement = new SelectElement(userRole);

            selectElement.SelectByText("Admin");
            employeeNameTextbox.SendKeys("Alice");
            selectEmployeeNameTextbox.Click();
            usernameTextbox.SendKeys("Test1");
            passwordTextbox.SendKeys("Thisismypass123!");
            passwordConfirmationTexbox.SendKeys("Thisismypass123!");
            saveButton.Click();
            Thread.Sleep(3000);
            // implement fluent wait here 
        }

        public static void CreateNewUserAssertion()
        {

            // Have to go to go to system users summary and find the new user created as assertion
            Assert.That(userCreated.Text == "Test1", "User hasn't been created successfully.");
        }
    }
}
