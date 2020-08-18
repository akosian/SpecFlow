using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using Test.pages;

namespace Test.steps
{
    [Binding]
    class CatalogPageSteps
    {
        private readonly ScenarioContext scenarioContext;
        private readonly CatalogPage catalogPage;

        public CatalogPageSteps(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            catalogPage = featureContext.FeatureContainer.Resolve<CatalogPage>();
        }

        [Then(@"There is (.*) header on Catalog page")]
        public void AssertPageHeader(string headerKey)
        {
            string header = catalogPage.GetCatalogElementHeader();
            string expectedValue =scenarioContext.Get<string>(headerKey);
            Assert.AreEqual(expectedValue, header);
        }
    }
}