using Dropbox.Core.Utils.Attributes;
using Dropbox.UI.PageObjects.Base.BaseDropboxPage;
using Dropbox.UI.PageObjects.Pages.Login.LoginSection;
using OpenQA.Selenium;

namespace Dropbox.UI.PageObjects.Pages.Login
{
    public class LoginPage : DropboxPage
    {
        [Titles("Login Section")]
        public LoginSectionContainer LoginSectionContainer => Select<LoginSectionContainer>(By.XPath(".//div[@class = 'login-register-container-wrapper']"));
    }
}
