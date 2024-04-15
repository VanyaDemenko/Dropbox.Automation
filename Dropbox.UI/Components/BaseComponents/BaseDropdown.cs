using Dropbox.UI.Drivers;
using Dropbox.UI.Extensions;
using Dropbox.UI.Interfaces.Components;
using Dropbox.UI.PageObjects.Base;
using OpenQA.Selenium;

namespace Dropbox.UI.Components.BaseComponents
{
    public class BaseDropdown : Container, IGetValue, ISetValue, IDropdown
    {
        public IWebElement Dropdown => DriverProvider.Driver.FindElement(By.XPath("//div[contains(@class, 'Block__menu--')]"));

        public IEnumerable<IWebElement> DropdownOptions
            => DriverProvider.Driver.FindElements(By.XPath("//div[contains(@class, 'Block__menu--')]//*[contains(@class, 'menu-item')]"));

        public IWebElement GetOption(string option)
            => DropdownOptions.First(name => name.GetInnerText().Equals(option));

        public string GetValue()
        {
            return Element.GetAttribute("innerText");
        }

        public void SetValue(string value)
        {
            Open();
            SelectOption(value);
        }

        public List<string> GetOptions()
        {
            Open();
            List<string> options = new();
            DropdownOptions.ToList().ForEach(option => options.Add(option.GetInnerText()));
            return options;
        }

        public void Open()
        {
            Element.Click();
            Dropdown.WaitForElementToDisplayed();
        }

        public void SelectOption(string option)
        {
            GetOption(option).Click();
        }
    }
}
