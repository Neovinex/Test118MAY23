using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test118MAY23.Pages;
using Test118MAY23.Utilities;

namespace Test118MAY23.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void SetUpAction()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginSteps(driver);

            // Home page object initialization and definition
            HomePage homePageobj = new HomePage();
            homePageobj.GoToTMPage(driver);

        }

        [Test, Order(1)]
        public void CreatTime_Test()
        {
            // TM page object initialization and definition
            TMPage tMPageobj = new TMPage();
            tMPageobj.CreatTMPage(driver);
        }

        [Test, Order(2)]
        public void EditTime_Test()
        {
            // TM page object initialization and definition
            TMPage tMPageobj = new TMPage();
            // Edit time record
            tMPageobj.EditTM(driver);

        }

        [Test, Order(3)]
        public void DeleteTime_Test()
        {
            // TM page object initialization and definition
            TMPage tMPageobj = new TMPage();
            // Delete time record
            tMPageobj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }





    }
}
