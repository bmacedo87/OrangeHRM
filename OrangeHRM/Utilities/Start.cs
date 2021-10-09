using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Utilities
{


    public class Start : CommonDriver
    {
        [SetUp]
        public void Setup()
        {

            //launch the browser
            Initialize();
        }

        [TearDown]
        public void TearDown()
        {
            //Close the browser
            driver.Quit();

        }
    }
}
