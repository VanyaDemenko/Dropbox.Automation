using Dropbox.Core.Utils.Attributes;
using Dropbox.UI.Components.BaseComponents;
using Dropbox.UI.PageObjects.Base;
using OpenQA.Selenium;

namespace Dropbox.UI.PageObjects.Pages.Login.LoginSection
{
    public class LoginSectionContainer : Container
    {
        [Titles("Email")]
        public BaseTextField EmailInput => Select<BaseTextField>(By.XPath(".//input[@type = 'email']"));

        [Titles("Continue")]
        public BaseButton ContinueButton => Select<BaseButton>(By.XPath(".//span[text() = 'Continue']"));

        [Titles("Error Message")]
        public BaseLabel ErrorMessage => Select<BaseLabel>(By.XPath(".//span[contains(@class, '_error-message')]"));
    }
}
