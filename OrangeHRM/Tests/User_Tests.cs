using NUnit.Framework;
using OrangeHRM.Pages;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Tests
{
    [TestFixture]
    class User_Tests : Start
    {
        [Test]
        public void Create_User()
        {
            LoginPage.LogIn();
            HomePage.AccessSystemUsers();
            AdminPage.CreateNewUser();
            AdminPage.CreateNewUserAssertion();
        }

        [Test]
        public void Edit_User()
        {

        }

        [Test]
        public void Delete_User()
        {

        }


    }
}
