using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace Frame
{
    class Chrome
    {
        private ChromeDriver driver;

        public ChromeDriver GetChrome()
        {
            ChromeOptions options = GetChromeOptions();
            ChromeDriver driver = new ChromeDriver(options);
            return driver;
        }

        private ChromeOptions GetChromeOptions()
        {
            List<string> value = JsonManager.GetChromeJsonValue("configuration.json");
            ChromeOptions options = new ChromeOptions();
            value.ForEach(arg => options.AddArguments(arg));
            return options;
        }
    }
}