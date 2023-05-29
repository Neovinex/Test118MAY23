using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.WebAuthn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test118MAY23.Utilities;

namespace Test118MAY23.Pages
{
    public class LoginPage : CommonDriver
    {   
        public void LoginSteps(IWebDriver driver)
        {
            //Launch Turnup Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            Wait.WaitToExist(driver, "Id", "UserName", 5);

            try
            {
                IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
                usernameTextBox.SendKeys("hari");

            }
            catch (Exception ex) 
            {
                Assert.Fail("TurnUp Potal page didnt not load");
            }
            
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            IWebElement RemembermeCheckbox = driver.FindElement(By.Id("RememberMe"));
            RemembermeCheckbox.Click();
            Thread.Sleep(2000);

            IWebElement loginButtton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButtton.Click();
            Thread.Sleep(2000);
        }








    }
}
