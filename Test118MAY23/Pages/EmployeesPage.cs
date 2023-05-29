using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test118MAY23.Pages
{
    public class EmployeesPage
    {
        public void creatEmployee(IWebDriver driver)
        {   //Create New Employee
            IWebElement createButtton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButtton.Click();

            //Filling Out New Employee Information
            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("Smith N");

            IWebElement userNameTextBox = driver.FindElement(By.Id("Username"));
            userNameTextBox.SendKeys("123ABC");

            IWebElement contactDisplayTextBox = driver.FindElement(By.XPath("//*[@id=\"ContactDisplay\"]"));
            contactDisplayTextBox.SendKeys("04123456");

            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("Smith123");

            IWebElement retypePasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextBox.SendKeys("Smith123");
            Thread.Sleep(2000);

            IWebElement isAdminCheckBox = driver.FindElement(By.XPath("//*[@id=\"IsAdmin\"]"));
            isAdminCheckBox.Click();
            Thread.Sleep(2000);

            IWebElement vehicleIdTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleIdTextBox.SendKeys("LPO123");

            IWebElement groupTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            groupTextBox.SendKeys("Main");

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

        }


        public void editEmployee(IWebDriver driver)
        {

        }

        public void deleteEmployee(IWebDriver driver)
        {


        }
        





        
    }   
  
    



}
