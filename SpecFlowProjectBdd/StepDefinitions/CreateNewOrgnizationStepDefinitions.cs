using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBdd.StepDefinitions
{
    [Binding]
    public class CreateNewOrgnizationStepDefinitions
    {
        IWebDriver driver;

        [Given(@"launch ""([^""]*)"" browser")]
        public void GivenLaunchBrowser(string browser)
        {
            if(browser == "chrome")
            {
                driver = new ChromeDriver();
            }
            
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Given(@"enter the URL ""([^""]*)""")]
        public void GivenEnterTheURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [Given(@"in login page enter username ""([^""]*)"" and password ""([^""]*)""")]
        public void GivenInLoginPageEnterUsernameAndPassword(string username, string password)
        {
            driver.FindElement(By.Name("user_name")).SendKeys("admin");
            driver.FindElement(By.Name("user_password")).SendKeys("admin");
        }

        [Given(@"click on login")]
        public void GivenClickOnLogin()
        {
            driver.FindElement(By.Id("submitButton")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [When(@"Home page is displayed click on create organization")]
        public void WhenHomePageIsDisplayedClickOnCreateOrganization()
        {
            
        }

        [When(@"click on create organization image icon")]
        public void WhenClickOnCreateOrganizationImageIcon()
        {
            throw new PendingStepException();
        }

        [When(@"enter organization name as ""([^""]*)""")]
        public void WhenEnterOrganizationNameAs(string google)
        {
            throw new PendingStepException();
        }

        [Then(@"validate whether organization is created with the name ""([^""]*)""")]
        public void ThenValidateWhetherOrganizationIsCreatedWithTheName(string google)
        {
            throw new PendingStepException();
        }
    }
}
