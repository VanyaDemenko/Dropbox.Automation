using Dropbox.UI.Interfaces.Components;
using Dropbox.UI.PageObjects.Base;
using Dropbox.UI.PageObjects.Base.BaseDropboxPage;
using Dropbox.UI.PageObjects.Pages.Plans.TestPlans;
using OpenQA.Selenium;

namespace Dropbox.UI.PageObjects.Pages.Plans
{
    public class PlansPage : DropboxPage
    {
        public IEnumerable<TestPlanItem> TestPlanItems => SelectAll<TestPlanItem>(By.XPath(".//div[contains(@class, 'dwg-css-grid__cell')]"));

        public string GetControlValueFromPlanWithName(string planName, string controlTitle)
            => (GetPlanWithName(planName).GetComponent<Container>(controlTitle) as IGetValue)!.GetValue();

        private TestPlanItem GetPlanWithName(string planName)
            => TestPlanItems.First(plan => plan.Name.GetValue().Equals(planName));
    }
}
