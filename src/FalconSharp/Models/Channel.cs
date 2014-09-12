namespace FalconSharp.Models
{
	public class Channel
	{
		public string Id { get; set; }

		public string Network { get; set; }

		public string Name { get; set; }

		public ChannelStatus Status { get; set; }

		public string ProfileImageUrl { get; set; }

		public string PermLink { get; set; }
	}
}