using Dropbox.Core.Utils.Attributes;
using Dropbox.UI.Components.BaseComponents;
using Dropbox.UI.PageObjects.Base;
using OpenQA.Selenium;

namespace Dropbox.UI.PageObjects.Pages.Main.MainSection
{
    public class MainSectionContainer : Container
    {
        [Titles("Sign Up Email")]
        public BaseTextField SignUpEmailInput => Select<BaseTextField>(By.XPath(".//input[@type = 'email']"));

        [Titles("Sign Up For Free")]
        public BaseButton SignUpForFreeButton => Select<BaseButton>(By.XPath(".//button[.//span[text() = 'Sign up for free']]"));

        [Titles("Sign Up Error Message")]
        public BaseLabel ErrorMessage => Select<BaseLabel>(By.XPath(".//span[contains(@class, 'dwg-color--alert')]"));
    }
}
