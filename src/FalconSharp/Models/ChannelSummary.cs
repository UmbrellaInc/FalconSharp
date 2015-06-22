using Newtonsoft.Json;

namespace FalconSharp.Models
{
    public class ChannelSummary
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
