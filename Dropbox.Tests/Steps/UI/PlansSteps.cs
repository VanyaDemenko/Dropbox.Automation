using Dropbox.Tests.Contexts;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Dropbox.Tests.Steps.UI
{
    [Binding]
    public class PlansSteps
    {
        private readonly PlansContext _plansContext = new();

        [Then(@"The Plan with '(.*)' name has following data:")]
        public void ThenThePlanWithNameHasFollowingData(string planName, List<Dictionary<string, string>> valuesToCheck)
        {
            foreach (var (fieldName, expectedValue) in valuesToCheck.Single())
            {
                var actualValue = _plansContext.GetControlDataFromPlanWithName(planName, fieldName);
                actualValue.Should().Be(expectedValue);
            }
        }
    }
}
