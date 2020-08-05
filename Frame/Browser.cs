using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace Frame
{
    public class Browser
    {
        private static IWebDriver webDriver;
        private const string TimeOutKey = "timeout";

        private Browser()
        {
        }

        public static ChromeDriver GetInstance()
        {
            if(webDriver == null)
            {
                webDriver  =  new Chrome().GetChrome();
            }
            return (ChromeDriver) webDriver;
        }

        public static WebDriverWait GetWait()
        {
            return new WebDriverWait(webDriver, TimeSpan.FromSeconds(GetTimeOut()));
        }

        private static int GetTimeOut()
        {
            JObject value = JsonManager.GetConfiguration();
            return int.Parse(value.GetValue(TimeOutKey).ToString());
        }
    }
}