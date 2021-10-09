using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OrangeHRM.Pages;
using OrangeHRM.Utilities;

namespace OrangeHRM
{
    [TestFixture]
    public class Login_Test : Start
    {
        [Test]
        public void LoginTest()
        {
            LoginPage.LogIn();
            HomePage.LogInAssertion();

        }
    }
}
