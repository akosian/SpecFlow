using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using Test.pages;

namespace Test.steps
{
    [Binding]
    class CatalogPageSteps
    {
        [Then(@"There is (.*) header on Catalog page")]
        public void AssertPageHeader(string headerKey)
        {
            string header = new CatalogPage().GetCatalogElementHeader();
            string expectedValue = Store.get(headerKey).ToString();
            Assert.AreEqual(expectedValue, header);
        }
    }
}