using BoDi;
using Frame;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Test.pages;

namespace Test.steps
{
    [Binding]
    public class LoginFormSteps
    {
        private readonly LoginForm loginForm;

        public LoginFormSteps(FeatureContext featureContext)
        {
            loginForm = featureContext.FeatureContainer.Resolve<LoginForm>();
        }

        [When(@"I enter ""(.*)"" email on Login Form")]
        public void FillEmail(string email)
        {
            loginForm.FillEmail(email);
        }

        [When(@"I enter ""(.*)"" password on Login Form")]
        public void FillPassword(string password)
        {
            loginForm.FillPassword(password);
        }

        [When(@"I click login button on Login Form")]
        public void ClickLogin()
        {
            loginForm.ClickLogin();
        }
    }
}