using Newtonsoft.Json;

namespace FalconSharp.Models
{
    public class UserSummary
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
