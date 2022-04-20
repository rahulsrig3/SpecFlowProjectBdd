using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using SpecFlowProjectBdd.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBdd.Hook
{
    [Binding]
    public class Hooks1: DriverHelper
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static FileUtility flib = new FileUtility();
        public static WebDriverUtility wlib = new WebDriverUtility();
        
        // [BeforeTestRun] //connect to database
        [BeforeFeature]
        public static void BeforeFeature()
        {
            string Browser = flib.ReadDataFromRunsettings("browser");
            string URL = flib.ReadDataFromRunsettings("url");

            if(Browser.Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else if(Browser.Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }

            wlib.MaximizeWindow(driver);
            wlib.WaitForPageToLoad(driver);

            driver.Navigate().GoToUrl(URL);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            string UserName = flib.ReadDataFromRunsettings("username");
            string Password = flib.ReadDataFromRunsettings("password");

            driver.FindElement(By.Name("user_name")).SendKeys(UserName);
            driver.FindElement(By.Name("user_password")).SendKeys(Password);
            driver.FindElement(By.Id("submitButton")).Click();
            wlib.WaitForPageToLoad(driver);
        }
        // [BeforeStep]
        // [AfterStep]
        [AfterScenario]
        public void AfterScenario()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//img[@src='themes/softed/images/user.PNG']"))).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[text()='Sign Out']")).Click();
            wlib.WaitForPageToLoad(driver);
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Quit();
        }
        
        // [AfterTestRun] 

        //[BeforeScenario("@tag1")]
        //public void BeforeScenarioWithTag()
        //{

        //}

        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    //TODO: implement logic that has to run after executing each scenario
        //}
    }
}