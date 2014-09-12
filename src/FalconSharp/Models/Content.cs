using System;
using System.Collections.Generic;

namespace FalconSharp.Models
{
	public class Content
	{
		public string Id { get; set; }
		public string ChannelId { get; set; }
		public string Network { get; set; }
		public ContentStatus Status { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Message { get; set; }
		public string Picture { get; set; }
		public string Caption { get; set; }
		public string Link { get; set; }
		public string PermLink { get; set; }
		public string FromId { get; set; }
		public string FromName { get; set; }
		public ContentType Type { get; set; }
		public IEnumerable<string> Tags { get; set; }
		public IDictionary<string, object> Stats { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
