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
    internal class Employyes_Tests : CommonDriver
    {
        [SetUp]
        public void SetUpActions()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeesPage(driver);

        }

        [Test, Order(1)]
        public void CreatNewEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.CreateEmployee(driver);
        }

        [Test, Order(2)]
        public void EditEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.EditEmployee(driver);
        }

        [Test, Order(3)]
        public void DeleteEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.DeleteEmployee(driver);
        }

        [TearDown]
        public void TearDownActions()
        {
            driver.Quit();
        }




    }
}
