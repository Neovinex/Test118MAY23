using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Test118MAY23.Pages;

internal class Program
{
    public static void Main(string[] args)
    {

        // Open Chrome Browser
        IWebDriver driver = new ChromeDriver();
        
        // Login page object initialization and definition
        LoginPage loginPageobj = new LoginPage(); 
        loginPageobj.LoginSteps(driver);

        // Home page object initialization and definition
        HomePage homePageobj = new HomePage();
        homePageobj.GoToTMPage(driver);

        // TM page object initialization and definition
        TMPage tMPageobj = new TMPage();
        tMPageobj.CreateTM(driver);

        // Edit time record
        tMPageobj.EditTM(driver);

        // Delete time record 
        tMPageobj.DeleteTM(driver);

        

        

        








































    }
}


