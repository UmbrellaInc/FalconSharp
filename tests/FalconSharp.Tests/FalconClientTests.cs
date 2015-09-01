using NUnit.Framework;
using System;
using System.Linq;

namespace FalconSharp.Tests
{
    [TestFixture]
    public class FalconClientTests
    {
        [Test]
        public void DoesItConnect()
        {
            var apiKey = "<omitted>";

            var client = new FalconClient(apiKey);

            var channels = client.GetChannels();

            //Assert.That(channels, Is.Not.Null);
            //Assert.That(channels.Items, Is.Not.Null);


            //var uniqueNetworks = channels.Items.ToLookup(x => x.Network);
            //var uniqueNetworkIds = uniqueNetworks.Select(x => x.Key).ToList();

            //var networkChannels = channels.Items.Where(x => x.Network == "googleplus");

            //Assert.That(networkChannels, Is.Not.Null);

            //var channelIds = networkChannels.Select(x => x.PlatformId).Take(10);


            var channelIds = new[] { "instagram_3350_1111721537" };

            var feed = client.GetContentFeed(
                since: new DateTime(2014,01,01),
                until: new DateTime(2015,05,31),
                limit: 100,
                sort: Models.SortOrder.Desc,
                channels: channelIds,
                tags: null);

            Assert.That(feed, Is.Not.Null);

            //var content = client.GetChannelContent(channelIds.First());
            //Assert.That(content, Is.Not.Null);
            //Assert.That(content.Items, Is.Not.Null);
        }
    }
}