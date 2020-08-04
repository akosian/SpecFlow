using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
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
            string header = new CatalogElementPage().GetCatalogElementHeader();
            string expectedValue = Store.get(headerKey).ToString();
            Assert.AreEqual(expectedValue, header);
        }
    }
}