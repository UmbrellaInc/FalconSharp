using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FalconSharp.Models
{
    public class Content
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        public ContentType Type { get; set; }

        [JsonProperty("publicationDate")]
        public DateTime PublicationDate { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("channel")]
        public ChannelSummary Channel { get; set; }

        [JsonProperty("stats")]
        public ContentStats Stats { get; set; }

        [JsonProperty("falcon")]
        public UserSummary Falcon { get; set; }

        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}