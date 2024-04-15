using Dropbox.Core.DataConstants;
using Dropbox.UI.Drivers;
using TechTalk.SpecFlow;

namespace Dropbox.Tests.Steps.UI
{
    [Binding]
    public class NavigationSteps
    {
        [Given(@"I navigate to the Dropbox Main page")]
        public void GivenINavigateToTheDropboxMainPage()
        {
            DriverProvider.Driver.Navigate().GoToUrl(BaseUIConstance.BaseUrl);
            DriverHelper.WaitPageFullLoaded();
        }

        [When(@"I wait for the page to be loaded")]
        public void WhenIWaitForThePageToBeLoaded()
        {
            DriverHelper.WaitPageFullLoaded();
        }
    }
}
