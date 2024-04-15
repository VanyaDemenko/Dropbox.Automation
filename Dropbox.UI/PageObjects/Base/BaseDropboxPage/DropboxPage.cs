using Dropbox.Core.Utils.Attributes;
using Dropbox.UI.PageObjects.Base.BaseDropboxPage.HederSection;
using OpenQA.Selenium;

namespace Dropbox.UI.PageObjects.Base.BaseDropboxPage
{
    public class DropboxPage : BasePage
    {
        [Titles("Header Section")]
        public HederSectionContainer BuildNumber => Select<HederSectionContainer>(By.XPath("//nav[contains(@class, 'dwg-nav')]"));
    }
}
