using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using Test.pages;

namespace Test.steps
{
    [Binding]
    public class MainPageSteps
    {
        private readonly MainPage mainPage;

        public MainPageSteps(FeatureContext featureContext)
        {
            mainPage = featureContext.FeatureContainer.Resolve<MainPage>();
        }

        [When(@"I click Login Icon on Main page")]
        public void ClickLoginIcon()
        {
            mainPage.ClickLoginIcon();
        }

        [When(@"I logout on Main page")]
        public void Logout()
        {
            mainPage.ClickUserIcon();
            mainPage.ClickLogout();
        }

        [When(@"I click Catalog option on Main page")]
        public void ClickCatalog()
        {
            mainPage.ClickCatalog();
        }

        [Then(@"There is authorized user icon on Main page")]
        public void AssertAuthorizedUserIconPresent()
        {
            bool isAuthorizedUserIconPresent = mainPage.IsAuthorizedUserIconPresent();
            Assert.IsTrue(isAuthorizedUserIconPresent);
        }


        [Then(@"There is no authorized user icon on Main page")]
        public void AssertAuthorizedUserIconAbsent()
        {
            bool isAuthorizedUserIconPresent = mainPage.IsAuthorizedUserIconPresent();
            Assert.IsFalse(isAuthorizedUserIconPresent);
        }
    }
}