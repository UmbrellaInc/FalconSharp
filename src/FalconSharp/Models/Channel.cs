using System;
using Newtonsoft.Json;

namespace FalconSharp.Models
{
	public class Channel
	{
        [JsonProperty("id")]
		public string Id { get; set; }

        [JsonProperty("network")]
		public string Network { get; set; }

        [JsonProperty("name")]
		public string Name { get; set; }

        [JsonProperty("status")]
        public ChannelStatus Status { get; set; }

        [JsonProperty("disabledWarning")]
        public string DisabledWarning { get; set; }

        [JsonProperty("disabledDate")]
        public DateTime DisabledDate { get; set; }

        [JsonProperty("profileImageUrl")]
		public string ProfileImageUrl { get; set; }

        [JsonProperty("permLink")]
        public string PermLink { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }
	}
}