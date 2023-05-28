using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test118MAY23.Utilities;

namespace Test118MAY23.Pages
{   
    public class LoginPage : commonDriver
    {
        
        public void LoginSteps(IWebDriver driver)
        {

            // launge turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            Wait.WaitToExit(driver, "Id", "Username", 3);
            
            try
            {
                IWebElement usernameTextBox = driver.FindElement(By.Id("username"));
                usernameTextBox.SendKeys("hari");

            }
            catch (Exception ex)
            {
                Assert.Fail("Turnup portal page didnt not loard", ex);
            }

            IWebElement passwordTextBox = driver.FindElement(By.Id("password"));
            passwordTextBox.SendKeys("123123");

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(3000);

            
                
      
            


        }












    }












}