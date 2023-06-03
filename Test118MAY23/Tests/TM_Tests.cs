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
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        //private object homePageObj  
        HomePage homePageObj = new HomePage();
        TMPage tMPageObj = new TMPage();
        //private object tmPageObj;
        
        [SetUp]
        public void SetUpAction()
        {
            //// Open Chrome Browser
            //driver = new ChromeDriver();

            //// Login page object initialization and definition
            //LoginPage loginPageobj = new LoginPage();
            //loginPageobj.LoginSteps(driver);

            //// Home page object initialization and definition
            //HomePage homePageobj = new HomePage();
            //homePageobj.GoToTMPage(driver);

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
            //TMPage tMPageobj = new TMPage();
            homePageObj.GoToTMPage(driver);
            // Edit time record
            //tMPageobj.EditTM(driver);
            
            

        }

        [Test, Order(3)]
        public void DeleteTime_Test()
        {
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            //TMPage tMPageobj = new TMPage();
            // Delete time record
            //tMPageobj.DeleteTM(driver);
            tMPageObj.DeleteTM(driver);

        }

        




    }
}
