namespace Dropbox.UI.Interfaces.Components
{
    public interface IDropdown
    {
        void Open();

        void SelectOption(string option);

        List<string> GetOptions();
    }
}
