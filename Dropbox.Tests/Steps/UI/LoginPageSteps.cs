using Dropbox.Core.Enums;
using Dropbox.Tests.Contexts;
using Dropbox.UI.PageObjects.Pages.Login;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Dropbox.Tests.Steps.UI
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly ComponentContext<LoginPage> _mainPageComponentContext = new();

        [When(@"I set '(.*)' value to '(.*)' control at the '(.*)' container on the Login page")]
        public void WhenISetValueToControlAtTheContainerOnTheLoginPage(string value, string controlName, string containerName)
        {
            _mainPageComponentContext.SetValue(value, controlName, containerName);
        }

        [When(@"I click on '(.*)' control at the '(.*)' container on the Login page")]
        public void WhenIClickOnControlAtTheContainerOnTheLoginPage(string controlName, string containerName)
        {
            _mainPageComponentContext.ClickComponentAtTheContainer(controlName, containerName);
        }

        /* Actions Validation */

        [Then(@"'(.*)' control at the '(.*)' container (is|is not) '(.*)' on the Login page")]
        public void ThenControlAtTheContainerIsOnTheLoginPage(string controlName, string containerName, bool expectedState, ElementState stateToCheck)
        {
            var actualState = _mainPageComponentContext.GetControlStateAtTheContainer(controlName, containerName, stateToCheck);
            actualState.Should().Be(expectedState);
        }

        [Then(@"'(.*)' control at the '(.*)' container has '(.*)' value on the Login page")]
        [Then(@"'(.*)' control at the '(.*)' container has value on the Login page")]
        public void ThenControlAtTheContainerHasValueOnTheLoginPage(string controlName, string containerName, string expectedValue)
        {
            var actualValue = _mainPageComponentContext.GetValue(controlName, containerName);
            actualValue.Should().Be(expectedValue);
        }
    }
}
