using System;
using TechTalk.SpecFlow;
using Test.pages;

namespace Test.steps
{
    [Binding]
    public class TabsFormSteps
    {
        private readonly ScenarioContext scenarioContext;
        private readonly TabsForm tabsForm;

        public TabsFormSteps(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            tabsForm = featureContext.FeatureContainer.Resolve<TabsForm>();
        }

        [When(@"I click ""(.*)"" random tab on Tabs form")]
        public void ClickRandomTabAndGetName(string tabContextName)
        {
            int tabsNumber = tabsForm.GetTabsNumber();
            int locatorNumber = new Random().Next(1, tabsNumber);
            string tabName = tabsForm.GetTabName(locatorNumber);
            tabsForm.ClickTab(locatorNumber);
            scenarioContext.Add(tabContextName, tabName);
        }
    }
}