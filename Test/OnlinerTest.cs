using Frame;
using Frame.element;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.steps;

namespace Test
{
    /*  [TestClass]
      public class OnlinerTest
      {
          private NavigationSteps navigationSteps = new NavigationSteps();
          private LoginFormSteps loginFormSteps = new LoginFormSteps();
          private MainPageSteps mainPageSteps = new MainPageSteps();
          private TabsFormSteps tabsFormSteps = new TabsFormSteps();
          private CatalogElementPageSteps catalogElementPageSteps = new CatalogElementPageSteps();

          [TestInitialize]
          public void SetUp()
          {
            new Browser().GetDriver();
          }

          [TestCleanup]
          public void Finish()
          {
              new Browser().GetDriver().Close();
          }

          [TestMethod]
          public void TestMethod()
          {
              navigationSteps.NavigateTo("http://onliner.by/");
              mainPageSteps.ClickLoginIcon();
              loginFormSteps.WaitFormLoad();
              loginFormSteps.FillLoginForm("testmailonliner@mail.ru", "Password1.default");
              loginFormSteps.ClickLogin();
              mainPageSteps.ClickCatalog();
              string expectedTabName = tabsFormSteps.ClickRandomTabAndGetName();
              string actualValue = catalogElementPageSteps.GetCatalogElementName();
              Assert.AreEqual(expectedTabName, actualValue);
              mainPageSteps.Logout();
          }

      } */
}
