using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProjectBdd.Drivers;
using SpecFlowProjectBdd.Hook;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBdd.StepDefinitions
{
    [Binding]
    public class OrgFeatureStepDefinitions:DriverHelper
    {
        public static WebDriverUtility wlib = new WebDriverUtility();

        //[Given(@"open browser and enter the url ""([^""]*)""")]
        //public void GivenOpenBrowserAndEnterTheUrl(string url)
        //{
        //    driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.Navigate().GoToUrl(url);
        //}

        //[When(@"enter the valid usename ""([^""]*)"" and password ""([^""]*)""")]
        //public void WhenEnterTheValidUsenameAndPassword(string username, string password)
        //{
        //    driver.FindElement(By.Name("user_name")).SendKeys(username);
        //    driver.FindElement(By.Name("user_password")).SendKeys(password);
        //}

        //[When(@"click on the login button")]
        //public void WhenClickOnTheLoginButton()
        //{
        //    driver.FindElement(By.Id("submitButton")).Click();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //}

        [When(@"click on the organization link")]
        public void WhenClickOnTheOrganizationLink()
        {
            driver.FindElement(By.XPath("//a[text()='Organizations']")).Click();
            wlib.WaitForPageToLoad(driver);
        }

        [When(@"click on the new organization icon")]
        public void WhenClickOnTheNewOrganizationIcon()
        {
            driver.FindElement(By.XPath("//img[@title='Create Organization...']")).Click();
            wlib.WaitForPageToLoad(driver);
        }

        [When(@"enter the organization ""([^""]*)""")]
        public void WhenEnterTheOrganization(string orgName)
        {
            driver.FindElement(By.XPath("//input[@name='accountname']")).SendKeys(orgName);
        }

        [When(@"click on the save button")]
        public void WhenClickOnTheSaveButton()
        {
            driver.FindElement(By.XPath("//input[@title='Save [Alt+S]']")).Click();
        }

        [Then(@"validate text")]
        public void ThenValidateText()
        {
            string title = driver.FindElement(By.XPath("//span[@class='dvHeaderText']")).Text;
            Console.WriteLine(title);
            wlib.WaitForPageToLoad(driver);
        }
    }
}
