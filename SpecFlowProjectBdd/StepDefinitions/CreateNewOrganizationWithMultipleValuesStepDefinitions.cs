using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProjectBdd.Drivers;
using SpecFlowProjectBdd.Hook;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBdd.StepDefinitions
{
    [Binding]
    public class CreateNewOrganizationWithMultipleValuesStepDefinitions:DriverHelper
    {
        //IWebDriver driver;

        //[Given(@"open the browser and enter the url ""([^""]*)""")]
        //public void GivenOpenTheBrowserAndEnterTheUrl(string url)
        //{
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.Navigate().GoToUrl(url);
        //}

        //[When(@"enter valid usename ""([^""]*)"" and password ""([^""]*)""")]
        //public void WhenEnterValidUsenameAndPassword(string username, string password)
        //{
            //driver.FindElement(By.Name("user_name")).SendKeys(username);
            //driver.FindElement(By.Name("user_password")).SendKeys(password);
        //}

        //[When(@"click on login button")]
        //public void WhenClickOnLoginButton()
        //{
            //driver.FindElement(By.Id("submitButton")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //}

        [When(@"click on organization link")]
        [Scope(Feature = "Create new organization with multiple values")]
        public void WhenClickOnOrganizationLink()
        {
            driver.FindElement(By.XPath("//a[text()='Organizations']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [When(@"click on new organization icon")]
        [Scope(Feature = "Create new organization with multiple values")]
        public void WhenClickOnNewOrganizationIcon()
        {
            driver.FindElement(By.XPath("//img[@title='Create Organization...']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [When(@"enter organization as ""([^""]*)""")]
        public void WhenEnterOrganizationAs(string orgName)
        {
            driver.FindElement(By.XPath("//input[@name='accountname']")).SendKeys(orgName);
        }

        [When(@"click on save button")]
        public void WhenClickOnSaveButton()
        {
            driver.FindElement(By.XPath("//input[@title='Save [Alt+S]']")).Click();
        }

        [Then(@"validate the text")]
        public void ThenValidateTheText()
        {
            string title = driver.FindElement(By.XPath("//span[@class='dvHeaderText']")).Text;
            Console.WriteLine(title);
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            //driver.Close();
        }

        [When(@"enter organization ""([^""]*)""")]
        public void WhenEnterOrganization(string orgName)
        {
            driver.FindElement(By.XPath("//input[@name='accountname']")).SendKeys(orgName);
        }
    }
}
