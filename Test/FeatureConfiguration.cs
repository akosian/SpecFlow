using Frame;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public class FeatureConfiguration
    {
        private IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = Browser.GetInstance();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
        }
    }
}