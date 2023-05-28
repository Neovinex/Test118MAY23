using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test118MAY23.Utilities;

namespace Test118MAY23.Pages
{
    public class TMPage : commonDriver 
    {
        private static IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        private static IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
        private static IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        private static IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
        private static IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
        private static IWebElement pricetextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        private static IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        private static IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        private static IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        private static IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));

        
        private static IWebElement editPriceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        private static IWebElement editPrice = driver.FindElement(By.Id("Price"));





        public void CreateTM(IWebDriver driver)
        {
           
            createNewButton.Click();
            typeCodeDropdown.Click();
            timeOption.Click();     
            codeTextBox.SendKeys("19MAY23");  
            descriptionTextBox.SendKeys("2023");      
            pricetextBox.SendKeys("25000");   
            saveButton.Click();
            Thread.Sleep(2000);

            

            // Navigate to the last page
            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 10);
            goToLastPageButton.Click();

            // 1 Method of Assertion 

            //if (newCode.Text == "19MAY23")
            //{
            //    Assert.Pass("Time recorded created succesfully.");
            //}
            //else
            //{
            //    Assert.Pass("Time record has not been created successfully.");
            //}

            // 2 Method of Assertion

            Assert.That(newCode.Text == "22MAY24", "Time record has not been created successfully.");

        }
        public void EditTM(IWebDriver driver)
        {
          
            editButton.Click();
            Thread.Sleep(2000); 
            codeTextBox.Clear();
            codeTextBox.SendKeys("22MAY24");
            Thread.Sleep(2000);
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys("2024");
            Thread.Sleep(2000);


      
            editPriceOverlap.Clear();
            editPrice.Clear();
            editPriceOverlap.SendKeys("5000000");
            Thread.Sleep(3000);
            saveButton.Click();
            Thread.Sleep(2000);

            // Check if saved information has been created successfully
            IWebElement gotolastpagebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            gotolastpagebutton.Click();

            // If saved changed code precent in the table as  "22MAY23"
            IWebElement newcode1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newcode1.Text == "22MAY24")
            {
                Console.WriteLine("Time recorded edited succesfully");
            }
            else
            {
                Console.WriteLine("Time record did not edit succesfully");
            }

        }
        public void DeleteTM(IWebDriver driver)
        {
            // Click Delete button on last raw
            IWebElement clickdeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            clickdeleteButton.Click();

            // Click Ok Popup window 
            var alert = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            alert.Accept();

            // Check if record has been deleted successfully
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            gotolastpage.Click();

            // If record item deleted in the table "22MAY23"
            IWebElement newcode2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newcode2.Text != "22MAY24")
            {
                Console.WriteLine("Time record deleded successfully");
            }
            else
            {
                Console.WriteLine("Time record did not deleded successfully");

            }
        }

        internal void CreateTime(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }
}
