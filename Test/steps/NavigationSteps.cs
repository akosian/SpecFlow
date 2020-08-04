using Frame;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Test.steps
{
    [Binding]
    public class NavigationSteps
    {

        [Given(@"I navigate to (.*) link")]
        public void NavigateTo(string url)
        {
            new Browser().GetInstance().Url = url;
        }
    }
}