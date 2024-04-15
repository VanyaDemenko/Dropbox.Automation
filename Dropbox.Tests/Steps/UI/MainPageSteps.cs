using Dropbox.Core.Enums;
using Dropbox.Tests.Contexts;
using Dropbox.UI.PageObjects.Pages.Main;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Dropbox.Tests.Steps.UI
{
    [Binding]
    public class MainPageSteps
    {
        private readonly ComponentContext<MainPage> _mainPageComponentContext = new();

        [When(@"I set '(.*)' value to '(.*)' control at the '(.*)' container on the Main page")]
        public void WhenISetValueToControlAtTheContainerOnTheMainPage(string value, string controlName, string containerName)
        {
            _mainPageComponentContext.SetValue(value, controlName, containerName);
        }

        [When(@"I click on '(.*)' control at the '(.*)' container on the Main page")]
        public void WhenIClickOnControlAtTheContainerOnTheMainPage(string controlName, string containerName)
        {
            _mainPageComponentContext.ClickComponentAtTheContainer(controlName, containerName);
        }

        /* Actions Validation */

        [Then(@"'(.*)' control at the '(.*)' container (is|is not) '(.*)' on the Main page")]
        public void ThenControlAtTheContainerIsOnTheMainPage(string controlName, string containerName, bool expectedState, ElementState stateToCheck)
        {
            var actualState = _mainPageComponentContext.GetControlStateAtTheContainer(controlName, containerName, stateToCheck);
            actualState.Should().Be(expectedState);
        }

        [Then(@"'(.*)' control at the '(.*)' container has '(.*)' value on the Main page")]
        [Then(@"'(.*)' control at the '(.*)' container has value on the Main page")]
        public void ThenControlAtTheContainerHasValueOnTheMainPage(string controlName, string containerName, string expectedValue)
        {
            var actualValue = _mainPageComponentContext.GetValue(controlName, containerName);
            actualValue.Should().Be(expectedValue);
        }
    }
}
