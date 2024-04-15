using Dropbox.Core.Utils.Attributes;
using Dropbox.UI.Components.BaseComponents;
using OpenQA.Selenium;

namespace Dropbox.UI.PageObjects.Base.BaseDropboxPage.HederSection
{
    public class HederSectionContainer : Container
    {
        [Titles("Sign up")]
        public BaseButton SignUpButton => Select<BaseButton>(By.XPath(".//div[./span[text() = 'Sign up']]"));

        [Titles("Login")]
        public BaseButton LoginButton => Select<BaseButton>(By.XPath(".//div[./span[text() = 'Login']]"));

        [Titles("Get Started")]
        public BaseButton GetStartedButton => Select<BaseButton>(By.XPath(".//div[./span[text() = 'Get started']]"));
    }
}
