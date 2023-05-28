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
        private static IWebElement useNameTextBox = driver.FindElement(By.Id("UserName"));
        private static IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
        private static IWebElement remembermeCheckBox = driver.FindElement(By.Id("RememberMe"));
        private static IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

        public void LoginSteps(IWebDriver driver)
        {

            // launge turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            Wait.WaitToExit(driver, "Id", "Username", 3);
            
            try
            {
                useNameTextBox.SendKeys("hari");
            }
            catch (Exception ex)
            {
                Assert.Fail("Turnup portal page didnt not loard", ex);
            }
                
      
            useNameTextBox.SendKeys("hari");
            passwordTextBox.SendKeys("123123");
            remembermeCheckBox.Click();
            Thread.Sleep(2000);
            loginButton.Click();
            Thread.Sleep(1000);


        }












    }












}