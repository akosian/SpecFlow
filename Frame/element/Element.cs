using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frame.element
{
    public class Element
    {
        protected string locator;
        protected string name;

        public void WaitElement()
        {
            Browser.GetWait().Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        protected void WaitElementBeClickable()
        {
            Browser.GetWait().Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }

        public bool isElementPresent()
        {
            try
            {
               Browser.GetWait().Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
            }
            catch (WebDriverTimeoutException e)
            {
                return false;
            }
            return true;
        }

        public string GetText()
        {
            WaitElement();
            return GetElement().Text;
        }

        public IWebElement GetElement()
        {
            return Browser.GetInstance().FindElement(By.XPath(locator));
        }

        public int GetCount()
        {
            return Browser.GetInstance().FindElements(By.XPath(locator)).Count;
        }
    }
}