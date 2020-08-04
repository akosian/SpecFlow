using Frame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Test.steps;

namespace Test
{
    [TestClass]
    public class Test
    {
        private NavigationSteps navigationSteps = new NavigationSteps();
        private LoginFormSteps loginFormSteps = new LoginFormSteps();
        private MainPageSteps mainPageSteps = new MainPageSteps();
        private TabsFormSteps tabsFormSteps = new TabsFormSteps();
        private CatalogPageSteps catalogElementPageSteps = new CatalogPageSteps();

        [TestMethod]
        public void TestMethod()
        {
            navigationSteps.NavigateTo("http://onliner.by/");
            mainPageSteps.ClickLoginIcon();
            loginFormSteps.FillEmail("testmailonliner@mail.ru");
            loginFormSteps.FillPassword("Password1.default");
            loginFormSteps.ClickLogin();
            mainPageSteps.ClickCatalog();
            tabsFormSteps.ClickRandomTabAndGetName("key");
            catalogElementPageSteps.AssertPageHeader("key");
            mainPageSteps.Logout();
        }
    }
}
