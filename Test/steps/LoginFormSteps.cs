using TechTalk.SpecFlow;
using Test.pages;

namespace Test.steps
{
    [Binding]
    public class LoginFormSteps
    {
        [When(@"I enter ""(.*)"" email on Login Form")]
        public void FillEmail(string email)
        {
            new LoginForm().FillEmail(email);
        }

        [When(@"I enter ""(.*)"" password on Login Form")]
        public void FillPassword(string password)
        {
            new LoginForm().FillPassword(password);
        }

        [When(@"I click login button on Login Form")]
        public void ClickLogin()
        {
            new LoginForm().ClickLogin();
        }
    }
}