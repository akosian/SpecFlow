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
        public static IWebDriver webDriver;

        public Browser()
        {
        }

        public ChromeDriver GetInstance()
        {
            if(webDriver == null)
            {
                webDriver  =  new Chrome().GetChrome();
            }
            return (ChromeDriver) webDriver;
        }

        public WebDriverWait GetWait()
        {
            return new WebDriverWait(webDriver, TimeSpan.FromSeconds(GetTimeOut()));
        }

        private int GetTimeOut()
        {
            JObject value = JsonManager.GetConfiguration();
            return int.Parse(value.GetValue("timeout").ToString());
        }
    }
}