using Dropbox.UI.Interfaces.Components;
using Dropbox.UI.PageObjects.Base;

namespace Dropbox.UI.Components.BaseComponents
{
    public class BaseLabel : Container, IGetValue
    {
        public virtual string GetValue()
        {
            return Element.GetAttribute("innerText");
        }
    }
}
