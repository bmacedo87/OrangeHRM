using OpenQA.Selenium;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Pages
{
    public class LoginPage : CommonDriver
    {
        // Page Elements

        private static IWebElement usernameTextbox => driver.FindElement(By.Id("txtUsername"));
        private static IWebElement passwordTextbox => driver.FindElement(By.Id("txtPassword"));
        private static IWebElement loginButton => driver.FindElement(By.Id("btnLogin"));

        public static void LogIn()
        {
            usernameTextbox.SendKeys("Admin");
            passwordTextbox.SendKeys("admin123");
            loginButton.Click();
        }


    }
}
