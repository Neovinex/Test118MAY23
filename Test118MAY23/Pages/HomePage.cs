using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test118MAY23.Utilities;

namespace Test118MAY23.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {   
            // Navigate to time and material page
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationTab.Click();

            Wait.WaitTobeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7);
           

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();

        }
        public void GoToEmployeePage(IWebDriver driver)
        {
            // Navigate to employees page
            IWebElement adminisstrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            adminisstrationTab.Click();

            Wait.WaitTobeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a", 6);

            IWebElement employeesOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeesOption.Click();

        }

    }
}
