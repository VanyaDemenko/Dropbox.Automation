using Dropbox.UI.Drivers;
using Dropbox.UI.Factories;
using Dropbox.UI.PageObjects.Base;

namespace Dropbox.Tests.Contexts.Base
{
    public abstract class AbstractContext<TPage> : IContext where TPage : BasePage, new()
    {
        protected TPage Page { get; }

        protected AbstractContext()
        {
            Page = EntryPageFactory.Create<TPage>(DriverProvider.Driver);
        }
    }
}
