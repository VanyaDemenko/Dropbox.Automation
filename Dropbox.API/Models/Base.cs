using Newtonsoft.Json;

namespace Dropbox.API.Models
{
    public class Base
    {
        [JsonProperty("path")]
        public string Path { get; set; } = string.Empty;
    }
}
