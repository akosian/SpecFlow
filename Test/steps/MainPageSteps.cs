using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
