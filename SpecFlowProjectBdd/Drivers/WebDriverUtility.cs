using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace SpecFlowProjectBdd.Drivers
{
    public class WebDriverUtility:DriverHelper
    {
        //IWebDriver driver = null;
        /*
         * method to maximize the window
         */
        public void MaximizeWindow(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }
        /*
         * method to wait for the page to load
         */
        public void WaitForPageToLoad(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        /*
         * method to wait for the element to be clickable
         */
        public void WaitForElementToBeClickable(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
        /*
         * method to wait for the element to be visible
         */
        public void WaitForElementToBeVisible(IWebDriver driver, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
        /*
         * method to wait for the element to be present
         */
        public void WaitForAlertToBePresent(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }
        /*
         * mehtod to implement Custom Wait
         */
        public void WaitAndClick(IWebElement element)
        {
            int count = 0;
            while (count < 20)
            {
                try
                {
                    element.Click();
                    break;
                }
                catch (Exception e)
                {
                    Thread.Sleep(1000);
                    count++;
                }
            }
        }
        /*
         * method to access dropdown using index
         */
        public void SelectDropDown(IWebElement element, int index)
        {
            SelectElement sel = new SelectElement(element);
            sel.SelectByIndex(index);
        }
        /*
         * method to handle dropdown using value
         */
        public void SelectDropDown(IWebElement element, string value)
        {
            SelectElement sel = new SelectElement(element);
            sel.SelectByValue(value);
        }
        /* 
         * method to handle dropdown using visible text
         */
        public void SelectDropDown(string visibleText, IWebElement element)
        {
            SelectElement sel = new SelectElement(element);
            sel.SelectByText(visibleText);
        }
        /*
         * mehtod to perform double click using mouse action
         */
        public void DoubleClickOnElement(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.DoubleClick(element).Build().Perform();
        }
        /*
         * method to perform right click action using mouse action
         */
        public void RightClickOnElement(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.ContextClick(element).Build().Perform();
        }
        /*
         * method to hover over an element using mouse action
         */
        public void MouseHoverToElement(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
        }
        /*
         * method to hover over an element using offset
         */
        public void MouseHoverToElement(IWebDriver driver, IWebElement element, int offsetX, int offsetY)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element, offsetX, offsetY).Build().Perform();
        }
        /*
         * method to perform drag and drop operation using mouse
         */
        public void DragAndDropElement(IWebDriver driver, IWebElement source, IWebElement destination)
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(source, destination).Build().Perform();
        }
        /*
         * method to perform drag and drop operation using offset
         */
        public void DragAndDropElement(IWebDriver driver, IWebElement source, int offsetX, int offsetY)
        {
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(source, offsetX, offsetY).Build().Perform();
        }
        /*
         * mehtod to accept popup alert
         */
        public void AcceptAlert(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();
        }
        /*
         * method to dissmiss popup alert
         */
        public void DismissAlert(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Dismiss();
        }
        /*
         * method to get text from the alert popup
         */
        public string GetText(IWebDriver driver)
        {
            return driver.SwitchTo().Alert().Text;
        }
        /*
         * method to send text to alert popup
         */
        public void SendKeysToAlertPopUp(IWebDriver driver, string text)
        {
            driver.SwitchTo().Alert().SendKeys(text);
        }
        /*
         * method to scroll a webpage
         */
        public void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.srollBy(0,500)");
        }
        /*
         * method to scroll on a webpage using scrollTo
         */
        public void ScrollToElement(IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.srollTo(0,500");
        }
        /*
         * method to switch to a window
         */
        public void SwitchToWindow()
        {
            ReadOnlyCollection<string> allWindow = driver.WindowHandles;
        }
    }
}
