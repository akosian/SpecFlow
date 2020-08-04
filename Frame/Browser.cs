using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Frame
{
    public class Browser
    {
        public static IWebDriver webDriver;

        public Browser()
        {
        }

        public ChromeDriver GetDriver()
        {
            if(webDriver == null)
            {
                webDriver  =  new ChromeDriver();
            }
            return (ChromeDriver) webDriver;
        }

        public WebDriverWait GetWait(IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
        }
    }
}
