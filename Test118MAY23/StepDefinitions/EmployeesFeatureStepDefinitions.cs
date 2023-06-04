using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V111.HeapProfiler;
using System;
using TechTalk.SpecFlow;
using Test118MAY23.Pages;
using Test118MAY23.Utilities;

namespace Test118MAY23.StepDefinitions
{
    [Binding]
    public class EmployeesFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged in to Turnup portal successfully")]
        public void GivenILoggedInToTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

        }

        [When(@"I navigate to Employees page")]
        public void WhenINavigateToEmployeesPage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeesPage(driver);
        }

        [When(@"I create a new Employee record")]
        public void WhenICreateANewEmployeeRecord()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.CreateEmployee(driver);
        }

        [Then(@"New Employee record should be ctreate successfully")]
        public void ThenNewEmployeeRecordShouldBeCtreateSuccessfully()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();

            string newName = employeesPageObj.GetName(driver);
            string NewUserName = employeesPageObj.GetUserName(driver);

            Assert.That(newName == "Smith N", "Actual name and expected name match");
            Assert.That(NewUserName == "123ABC", "Actual username and expected username  match");        
        }
    }
}
