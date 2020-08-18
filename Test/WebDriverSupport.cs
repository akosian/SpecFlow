using BoDi;
using Frame;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public class WebDriverSupport
    {
        private readonly IObjectContainer container;

        public WebDriverSupport(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var webDriver = Browser.GetInstance();
            container.RegisterInstanceAs<IWebDriver>(webDriver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            IWebDriver driver = container.Resolve<IWebDriver>();
            driver.Close();
        }
    }
}