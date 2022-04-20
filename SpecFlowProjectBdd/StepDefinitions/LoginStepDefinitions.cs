using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBdd.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        IWebDriver driver;

        [Given(@"I will launch the browser")]
        public void GivenIWillLaunchTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Given(@"I will enter the URL")]
        public void GivenIWillEnterTheURL()
        {
            driver.Navigate().GoToUrl("http://localhost:8888/");  
        }

        [When(@"login page is displayed I will enter username and password")]
        public void WhenLoginPageIsDisplayedIWillEnterUsernameAndPassword()
        {
            driver.FindElement(By.Name("user_name")).SendKeys("admin");
            driver.FindElement(By.Name("user_password")).SendKeys("admin");
        }

        [When(@"I will click on login")]
        public void WhenIWillClickOnLogin()
        {
            driver.FindElement(By.Id("submitButton")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Then(@"I will validate whether login page is displayed or not")]
        public void ThenIWillValidateWhetherLoginPageIsDisplayedOrNot()
        {
            string actTitle = "strator - Home - vtiger CRM 5 - Commercial Open Source CRM";
            string title = driver.Title;
            bool flag=title.Contains(actTitle);
            Assert.True(flag);
            Thread.Sleep(4000);
            driver.Quit();
        }
    }
}
