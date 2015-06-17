using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FalconSharp.Models
{
    public class Content
    {
        [JsonProperty("disabledDate")]
        public string Id { get; set; }

        [JsonProperty("channelId")]
        public string ChannelId { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("status")]
        public ContentStatus Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("permLink")]
        public string PermLink { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        [JsonProperty("fromId")]
        public string FromId { get; set; }

        [JsonProperty("fromName")]
        public string FromName { get; set; }

        [JsonProperty("type")]
        public ContentType Type { get; set; }

        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }

        [JsonProperty("stats")]
        public IDictionary<string, object> Stats { get; set; }

        [JsonProperty("createDate")]
        public DateTime CreateDate { get; set; }

        [JsonProperty("updateDate")]
        public DateTime UpdateDate { get; set; }

        [JsonProperty("unPublished")]
        public bool Unpublished { get; set; }
    }
}