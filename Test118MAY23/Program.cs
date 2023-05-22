using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    public static void Main(string[] args)
    {

        // open chrome browser
        IWebDriver driver = new ChromeDriver();

        // launge turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        driver.Manage().Window.Maximize();
        Thread.Sleep(3000);

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

        // check if user has logged in successfully 
        IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (hellohari.Text == "Hello hari!")
        {
            Console.WriteLine("user has loggged in succefully.");
        }
        else
        {
            Console.WriteLine("User has NOT logged in.");
        }

        // Create new record

        // Navigate to time and material page
        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
        administrationTab.Click();

        IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        tmOption.Click();

        // Click on create new buttton
        IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createnewbutton.Click();

        // Select time from dropdown list
        IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
        typecodeDropdown.Click();

        IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        timeOption.Click();

        // Input code
        IWebElement codetextBox = driver.FindElement(By.Id("Code"));
        codetextBox.SendKeys("19MAY23");

        // Input description
        IWebElement descriptiontextBox = driver.FindElement(By.Id("Description"));
        descriptiontextBox.SendKeys("2023");

        // Input price per unit 
        IWebElement pricetextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        pricetextBox.SendKeys("25000");

        // Click on save button
        IWebElement saveButtton = driver.FindElement(By.Id("SaveButton"));
        saveButtton.Click();
        Thread.Sleep(2000);

        // Check if new time record has been created successfully

        // Navigate to the last page 
        IWebElement gotolastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        gotolastpageButton.Click();
       
        // Check if record is precent in the table
        IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        
        if(newcode.Text == "19MAY23")
        {
            Console.WriteLine("Time recorded created succesfully.");
        }
        else
        { 
           Console.WriteLine("Time record has not created successfully.");
        }

        
        // Click edit button on last raw
        IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
        editButton.Click();
        Thread.Sleep(2000);

        // Clear Code textbox and Change Text Box
        IWebElement codetextbox = driver.FindElement(By.Id("Code"));
        codetextbox.Clear(); 
        codetextbox.SendKeys("22MAY24");
        Thread.Sleep(2000);


        // Clear Descreption and change description "2024"
        IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
        descriptiontextbox.Clear();
        descriptiontextbox.SendKeys("2024");
        Thread.Sleep(2000);


        // Clear Price text box and change price per unit "5000000"
        //IWebElement pricetextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        //pricetextBox.Clear();
        //pricetextBox.SendKeys("100");

        // Save Changers

        IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
        savebutton.Click();
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
            Console.WriteLine("Time record did not edited succesfully");
        }

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

        if (newcode2.Text == "22MAY24")
        {
            Console.WriteLine("Time record deleded successfully");
        }
        else
        {
            Console.WriteLine("Time record did not deleded successfully");

        }
        // Finish
        // Second test

       


























    }
}


