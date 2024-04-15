using Dropbox.Tests.Contexts.Base;
using Dropbox.UI.Drivers;
using Dropbox.UI.Factories;
using Dropbox.UI.PageObjects.Pages.Plans;
using Dropbox.UI.PageObjects.Pages.Plans.TestPlans;

namespace Dropbox.Tests.Contexts
{
    public class PlansContext : IContext
    {
        private PlansPage _plansPage { get; }

        public PlansContext() => _plansPage = EntryPageFactory.Create<PlansPage>(DriverProvider.Driver);

        public string GetControlDataFromPlanWithName(string planName, string controlTitle)
        {
            return _plansPage.GetControlValueFromPlanWithName(planName, controlTitle);
        }
    }
}
