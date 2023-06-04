using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Test118MAY23.Pages;
using Test118MAY23.Utilities;

namespace Test118MAY23.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
    

        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();

            
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginSteps(driver);
        }

        [When(@"I navigate Time and Material record")]
        public void WhenINavigateTimeAndMaterialRecord()
        {
            HomePage homePageobj = new HomePage();
            homePageobj.GoToTMPage(driver);

        }

        [When(@"I create a new Time and Material reocrd")]
        public void WhenICreateANewTimeAndMaterialReocrd()
        {
            
            TMPage tMPageobj = new TMPage();
            tMPageobj.CreatTMPage(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tMPageObj = new TMPage();

            string newCode = tMPageObj.GetCode(driver);
            string newDescription = tMPageObj.GetDescription(driver);
            string newPrice = tMPageObj.GetPrice(driver);

            Assert.AreEqual("19MAY23", newCode, "Actual code and expected code donot match");
            Assert.AreEqual("2023", newDescription, "Actual New description and expected description donot match");
            Assert.AreEqual("$25,000.00", newPrice, "Actual New Price and expected price donot match");

        }



        [When(@"I update '([^']*)', '([^']*)' and '([^']*)' on an existing Time and Material record")]
        public void WhenIUpdateAndOnAnExistingTimeAndMaterialRecord(string description, string code, string price)
        {
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTM(driver, description, code, price);

        }

        [Then(@"The record should be updated '([^']*)', '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldBeUpdatedAnd(string description, string code, string price)
        {
            TMPage tMPageObj = new TMPage();

            string editedDescription = tMPageObj.GetEditedDescription(driver);
            string editedCode = tMPageObj.GetEditedCode(driver);
            string editedPrice = tMPageObj.GetEditedPrice(driver);

            Assert.AreEqual(description, editedDescription, "Actual edited descreption and expected edited description donot match");
            Assert.AreEqual(code, editedCode, "Actual edited code and expected edited code donot match");
            Assert.AreEqual(price,editedPrice, "Actual edited price and expected edited price donot match");



        }





    }
}
