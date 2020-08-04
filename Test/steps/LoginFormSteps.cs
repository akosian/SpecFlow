using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Test.pages;

namespace Test.steps
{
    [Binding]
    public class LoginFormSteps
    {
        [Given(@"I enter (.*) email on Login Form")]
        public void FillEmail(string email)
        {
            new LoginForm().FillEmail(email);
        }

        [Given(@"I enter (.*) password on Login Form")]
        public void FillPassword(string password)
        {
            new LoginForm().FillPassword(password);//todo add wait page
        }

        [Given(@"I click login button on Login Form")]
        public void ClickLogin()
        {
            new LoginForm().ClickLogin();
        }
    }
}