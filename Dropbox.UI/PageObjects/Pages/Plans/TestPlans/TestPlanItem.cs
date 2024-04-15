using Dropbox.Core.Utils.Attributes;
using Dropbox.UI.Components.BaseComponents;
using Dropbox.UI.PageObjects.Base;
using OpenQA.Selenium;

namespace Dropbox.UI.PageObjects.Pages.Plans.TestPlans
{
    public class TestPlanItem : Container
    {
        [Titles("Type")]
        public BaseLabel Type => Select<BaseLabel>(By.XPath(".//div[contains(@class, 'dwg-display--grid dwg-position--static')]//h3"));

        [Titles("Name")]
        public BaseLabel Name => Select<BaseLabel>(By.XPath(".//div[@data-testid = 'alignable-container__plan-name']//span[@data-testid = 'plan_name_test_id']"));

        [Titles("Price")]
        public BaseLabel Price => Select<BaseLabel>(By.XPath(".//div[@data-testid = 'alignable-container__price-and-rate']//span[@data-testid = 'price_test_id']"));

        [Titles("Users")]
        public BaseLabel Users => Select<BaseLabel>(By.XPath(".//div[contains(@data-testid, 'secondary-button-container')]//following-sibling::div//li[1]"));

        [Titles("Storage")]
        public BaseLabel Storage => Select<BaseLabel>(By.XPath(".//div[contains(@data-testid, 'secondary-button-container')]//following-sibling::div//li[2]"));

        [Titles("Transfer Files")]
        public BaseLabel TransferFiles => Select<BaseLabel>(By.XPath(".//div[contains(@data-testid, 'secondary-button-container')]//following-sibling::div//li[3]"));

        [Titles("Restore Dayes")]
        public BaseLabel RestoreDayes => Select<BaseLabel>(By.XPath(".//div[contains(@data-testid, 'secondary-button-container')]//following-sibling::div//li[4]"));

    }
}
