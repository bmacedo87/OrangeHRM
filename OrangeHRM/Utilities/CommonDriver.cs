using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Utilities
{
    public class CommonDriver : ConstantHelpers
    {
        //Initialize the browser
        public static IWebDriver driver { get; set; }

        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();       

            //Maximise the window
            driver.Manage().Window.Maximize();

            //Navigate to home page
            driver.Navigate().GoToUrl(Url);
        }
    }
}
