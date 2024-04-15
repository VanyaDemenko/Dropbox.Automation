using Dropbox.UI.Drivers;
using Dropbox.UI.Interfaces.PageObjects;

namespace Dropbox.UI.PageObjects.Base
{
    public abstract class BasePage : Container, IPage
    {
        public virtual void WaitForReadyState()
        {
            DriverHelper.WaitPageFullLoaded();
        }
    }
}
