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

        //[JsonProperty("status")]
        //public ContentStatus Status { get; set; }

        //[JsonProperty("name")]
        //public string Name { get; set; }

        //[JsonProperty("description")]
        //public string Description { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }

        //[JsonProperty("caption")]
        //public string Caption { get; set; }

        //[JsonProperty("link")]
        //public string Link { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        //[JsonProperty("orgId")]
        //public string OrgId { get; set; }

        //[JsonProperty("fromId")]
        //public string FromId { get; set; }

        //[JsonProperty("fromName")]
        //public string FromName { get; set; }

        [JsonProperty("falcon")]
        public UserSummary Falcon { get; set; }

        [JsonProperty("channel")]
        public ChannelSummary Channel { get; set; }

        [JsonProperty("type")]
        public ContentType Type { get; set; }

        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }

        [JsonProperty("stats")]
        public IDictionary<string, object> Stats { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public DateTime ModifiedDate { get; set; }

        [JsonProperty("publicationDate")]
        public DateTime PublicationDate { get; set; }

        //[JsonProperty("unPublished")]
        //public bool Unpublished { get; set; }
    }
}