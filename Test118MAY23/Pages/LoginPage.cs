using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test118MAY23.Utilities;

namespace Test118MAY23.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            // launge turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            Wait.WaitToExit(driver, "Id", "Username", 3);

            // identify username textbox and enter valid username
            IWebElement usenameTextbox = driver.FindElement(By.Id("UserName"));
            usenameTextbox.SendKeys("hari");

            // identify password textbox and enter valid password 
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // tick remember checkbox  
            IWebElement RemembermeCheckbox = driver.FindElement(By.Id("RememberMe"));
            RemembermeCheckbox.Click();
            Thread.Sleep(2000);

            // click login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(1000);

        }
                                        
    }
}
