using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Test118MAY23.Utilities;

namespace Test118MAY23.Pages
{
    public class EmployeesPage : CommonDriver
    {
        private object goToLastPageButton;

        public void CreateEmployee(IWebDriver driver)
        {
            //Create New Employee
            IWebElement createButtton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButtton.Click();

            //Filling Out New Employee Information
            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("Smith N");
            Thread.Sleep(1000);
            
            IWebElement userNameTextBox = driver.FindElement(By.Id("Username"));
            userNameTextBox.SendKeys("123ABC");
            Thread.Sleep(1000);

            IWebElement contactDisplayTextBox = driver.FindElement(By.XPath("//*[@id=\"ContactDisplay\"]"));
            contactDisplayTextBox.SendKeys("04123456");
            Thread.Sleep(1000);

            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("Smith123");
            Thread.Sleep(1000);

            IWebElement retypePasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextBox.SendKeys("Smith123");
            Thread.Sleep(2000);

            IWebElement isAdminCheckBox = driver.FindElement(By.XPath("//*[@id=\"IsAdmin\"]"));
            isAdminCheckBox.Click();
            Thread.Sleep(1000);

            IWebElement vehicleIdTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleIdTextBox.SendKeys("LPO123");
            Thread.Sleep(1000);

            IWebElement editGroupOverlap = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            editGroupOverlap.Click();

            IWebElement editGroup = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]/input"));
            editGroup.SendKeys("Main");
            Thread.Sleep(3000);

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //Go to last page
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(1000);

            //Find New Employee Profile on last Page
            IWebElement name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
            

            Assert.That(name.Text == "Smith N", "Actual name and expected name match");
            Assert.That(username.Text == "123ABC", "Actual username and expected username  match");


        }
        public void EditEmployee(IWebDriver driver)
        {   
            //Locate New Employee Profile from last raw
            Thread.Sleep(2000);
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editButton.Click();

            //Change Employee Profile Informaton
            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.Clear();
            nameTextBox.SendKeys("Smith NN");
            Thread.Sleep(1000);

            IWebElement userNameTextBox = driver.FindElement(By.Id("Username"));
            userNameTextBox.Clear();
            userNameTextBox.SendKeys("XXXXXX");
            Thread.Sleep(1000);

            IWebElement contactDisplayTextBox = driver.FindElement(By.XPath("//*[@id=\"ContactDisplay\"]"));
            userNameTextBox.Clear();
            contactDisplayTextBox.SendKeys("04123555");
            Thread.Sleep(1000);

            IWebElement isAdminCheckBox = driver.FindElement(By.XPath("//*[@id=\"IsAdmin\"]"));
            isAdminCheckBox.Click();
            Thread.Sleep(1000);

            IWebElement vehicleIdTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            userNameTextBox.Clear();
            vehicleIdTextBox.SendKeys("ZXY123");
            Thread.Sleep(1000);

            IWebElement editGroupOverlap = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            editGroupOverlap.Click();

            IWebElement editGroup = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]/input"));
            userNameTextBox.Clear();
            Thread.Sleep(500);
            editGroup.SendKeys("Primary");
            Thread.Sleep(3000);

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);

     
        }

        public void DeleteEmployee(IWebDriver driver)
        {
            //Go to last page
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();
            Thread.Sleep(2000);

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(2000);
            

            // Click Alert Window 
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);
            IWebElement editeName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            
            Assert.That(editeName.Text != "Smith NN", "Record hasn't been deleted.");

        }

    }
}
