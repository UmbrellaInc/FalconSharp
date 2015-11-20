using Newtonsoft.Json;

namespace FalconSharp.Models
{
    public class ContentStats
    {
        [JsonProperty("comments")]
        public int Comments { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("shares")]
        public int Shares { get; set; }
    }
}