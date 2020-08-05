using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using Test.pages;

namespace Test.steps
{
    [Binding]
    public class MainPageSteps
    {

        [When(@"I click Login Icon on Main page")]
        public void ClickLoginIcon()
        {
            new MainPage().ClickLoginIcon();
        }

        [When(@"I logout on Main page")]
        public void Logout()
        {
            MainPage mainPage = new MainPage();
            mainPage.ClickUserIcon();
            mainPage.ClickLogout();
        }

        [When(@"I click Catalog option on Main page")]
        public void ClickCatalog()
        {
            new MainPage().ClickCatalog();
        }

        [Then(@"There is authorized user icon on Main page")]
        public void AssertAuthorizedUserIconPresent()
        {
            bool isAuthorizedUserIconPresent = new MainPage().IsAuthorizedUserIconPresent();
            Assert.IsTrue(isAuthorizedUserIconPresent);
        }


        [Then(@"There is no authorized user icon on Main page")]
        public void AssertAuthorizedUserIconAbsent()
        {
            bool isAuthorizedUserIconPresent = new MainPage().IsAuthorizedUserIconPresent();
            Assert.IsFalse(isAuthorizedUserIconPresent);
        }
    }
}