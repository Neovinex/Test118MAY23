using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test118MAY23.Pages;
using Test118MAY23.Utilities;
using NUnit.Framework;

namespace Test118MAY23.Tests
{
    [TestFixture]
    public class TM_Test : commonDriver
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

        [Test]
        public void CreatTime_Test()
        {
            // TM page object initialization and definition
            TMPage tMPageobj = new TMPage();
            tMPageobj.CreateTM(driver);
        }

        [Test]
        public void EditTime_Test()
        {
            // Edit time record
            TMPage tMPageobj = new TMPage();
            tMPageobj.EditTM(driver);

        }

        [Test]
        public void DeleteTime_Test()
        {
            // Delete time record
            TMPage tMPageobj = new TMPage();
            tMPageobj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }


        







        

        

        
        
    }
}
