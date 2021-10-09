using NUnit.Framework;
using OpenQA.Selenium;
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
       private static  IWebElement welcomeTag => driver.FindElement(By.Id("welcome"));

       public static void LogInAssertion()
       {
            Assert.That(welcomeTag.Text == "Welcome Paul", "Login not executed. Test failed.");
       }
    }
}
