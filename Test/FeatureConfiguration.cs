using Frame;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public class FeatureConfiguration
    {
        private ChromeDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new Browser().GetInstance();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
        }
    }
}