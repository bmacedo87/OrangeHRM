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
    public class HomePage : CommonDriver
    {
        // Tags
        private static IWebElement welcomeTag => driver.FindElement(By.Id("welcome"));
      
        // Tabs, menus and dropdowns
        private static IWebElement adminTab => driver.FindElement(By.Id("menu_admin_viewAdminModule"));
            
       
        
       
       


       public static void LogInAssertion()
       {
            Assert.That(welcomeTag.Text == "Welcome Paul", "Login not executed. Test failed.");
       }

        public static void AccessSystemUsers()
        {
            adminTab.Click();
            Thread.Sleep(3000);
        }

      
    }
}
