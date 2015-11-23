using System;
using System.Linq;
using NUnit.Framework;

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

            Assert.That(channels, Is.Not.Null);
            Assert.That(channels.Items, Is.Not.Null);


            var channelIds = new[] { "<omitted>" };

            var feed = client.GetContentFeed(
                since: new DateTime(2014, 01, 01),
                until: new DateTime(2015, 05, 31),
                limit: 100,
                sort: Models.SortOrder.Desc,
                channels: channelIds,
                tags: null);

            Assert.That(feed, Is.Not.Null);
        }
    }
}