using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectBdd.POMPages
{
    public class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement organizationButton => driver.FindElement(By.LinkText("Organizations"));
        private IWebElement logoutButton => driver.FindElement(By.XPath("//img[@src='themes/softed/images/user.PNG']"));
        private IWebElement signOutLink => driver.FindElement(By.LinkText("Sign Out"));

        public IWebElement getOrganizationButton()
        {
            return organizationButton;
        }
        public IWebElement getLogoutButton()
        {
            return logoutButton;
        }
        public IWebElement getSignOutLink()
        {
            return signOutLink;
        }
    }
}
