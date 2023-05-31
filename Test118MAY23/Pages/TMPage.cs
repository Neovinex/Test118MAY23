using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test118MAY23.Pages
{
    public class TMPage
    {
        public void CreatTMPage(IWebDriver driver)
        {
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //Fill out relevent fields to creat a new record 
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDropdown.Click();

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("19MAY23");

            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("2023");

            IWebElement pricetextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricetextBox.SendKeys("25000");

            //Click save button to submit those details and create a record 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //Go to last record on list page
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(2000);

            

            // Find the last record on the list page
            //IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //IWebElement newTypecode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
            //IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            //IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

            //Assert.That(newCode.Text == "19MAY23", "Actual code and expected code donot match");
            //Assert.That(newTypecode.Text == "T", "Actual Type code and expected code donot match");
            //Assert.That(newDescription.Text == "2023", "Actual New description and expected description donot match");
            //Assert.That(newPrice.Text == "$25,000.00", "Actual New Price and expected price donot match");

        }   
        public void EditTM(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(2000);

            IWebElement lastElement = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);

            if (lastElement.Text == "19MAY23")
            {
                Thread.Sleep(2000);
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
                Thread.Sleep(3000);
            }
            else
            {
                Assert.Fail("New Recorded created hasn't been found.");
            }



            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.Clear();
            codeTextBox.SendKeys("22MAY24");

            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys("2024");
            Thread.Sleep(2000);

            IWebElement editPriceOverLap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            editPriceOverLap.Click();
            
            IWebElement editPricetextBox = driver.FindElement(By.Id("Price"));
            editPricetextBox.Clear();
            Thread.Sleep(1000);
            editPriceOverLap.SendKeys("5000000");
            Thread.Sleep(2000);
            

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);

        }
        public void DeleteTM(IWebDriver driver)
        {
            // Click Delete button on last raw
            Thread.Sleep(3000);
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolastpage.Click();

            Thread.Sleep(1000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            // Click Alert Window 
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(3000);
            IWebElement editedcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(editedcode.Text != "22MAY24", "Record hasn't been deleted.");
        }





    }
}
