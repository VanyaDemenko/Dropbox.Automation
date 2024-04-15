namespace Dropbox.Core.Utils.Attributes
{
    public class TitlesAttribute : Attribute
    {
        public TitlesAttribute(params string[] titles) => Titles = titles.ToList();

        public List<string> Titles { get; private set; }
    }
}
