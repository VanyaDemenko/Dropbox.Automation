using Dropbox.Core.Utils.Attributes;
using Dropbox.UI.PageObjects.Base.BaseDropboxPage;
using Dropbox.UI.PageObjects.Pages.Main.MainSection;
using OpenQA.Selenium;

namespace Dropbox.UI.PageObjects.Pages.Main
{
    public class MainPage : DropboxPage
    {
        [Titles("Main Section")]
        public MainSectionContainer MainSectionContainer => Select<MainSectionContainer>(By.XPath(".//main[@id = 'main-content']"));
    }
}
