using Dropbox.UI.Extensions;
using Dropbox.UI.Interfaces.Components;
using Dropbox.UI.PageObjects.Base;

namespace Dropbox.UI.Components.BaseComponents
{
    public class BaseTextField : Container, ISetValue, IGetValue
    {
        public virtual void SetValue(string value)
        {
            Element.SetValueAndFocusOut(value);
        }

        public virtual string GetValue()
        {
            return Element.GetAttribute("value");
        }
    }
}
