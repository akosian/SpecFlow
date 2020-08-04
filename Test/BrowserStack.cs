using Frame;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public class BrowserStack
    {

        private ChromeDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new Browser().GetInstance();
            ScenarioContext.Current["Driver"] = Driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
        }
    }
}
