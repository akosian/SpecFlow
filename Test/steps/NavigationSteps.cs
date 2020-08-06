using Frame;
using TechTalk.SpecFlow;

namespace Test.steps
{
    [Binding]
    public class NavigationSteps
    {
        [Given(@"I navigate to (.*) link")]
        public void NavigateTo(string url)
        {
            Browser.GetInstance().Url = url;
        }
    }
}