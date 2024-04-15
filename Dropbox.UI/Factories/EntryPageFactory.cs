using Dropbox.UI.PageObjects.Base;
using OpenQA.Selenium;

namespace Dropbox.UI.Factories
{
    public static class EntryPageFactory
    {
        public static TPage Create<TPage>(IWebDriver driver) where TPage : BasePage, new()
        {
            return new TPage()
            {
                Driver = driver
            };
        }
    }
}
