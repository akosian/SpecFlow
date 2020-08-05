using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frame
{
    class BrowserFactory
    {

        public static IWebDriver GetBrowser(BrowserType browserType)
        { if (browserType == BrowserType.CHROME)
            {
                return new Chrome().GetChrome();
            }
            else
            {
                return null;
            }
        }
    }
}