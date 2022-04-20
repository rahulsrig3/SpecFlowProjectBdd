using OpenQA.Selenium;
using SpecFlowProjectBdd.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectBdd.POMPages
{
    public class LoginPage
    {
        IWebDriver driver = null;
            
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement UsernameTF => driver.FindElement(By.Name("user_name"));
        private IWebElement PasswordTF => driver.FindElement(By.Name("user_password"));
        private IWebElement SubmitButton => driver.FindElement(By.Id("submitButton"));

        public IWebElement getUsernameTF()
        {
            return UsernameTF;
        }
        public IWebElement getPasswordTF()
        {
            return PasswordTF;
        }
        public IWebElement getSubmitButton()
        {
            return SubmitButton;
        }
        public void VTigerLogin(string username, string password)
        {
            getUsernameTF().SendKeys(username);
            getPasswordTF().SendKeys(password);
            getSubmitButton().Click();
        }

    }
}
