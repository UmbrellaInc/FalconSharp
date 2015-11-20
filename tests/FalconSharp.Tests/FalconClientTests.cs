using System;
using NUnit.Framework;

namespace FalconSharp.Tests
{
    [TestFixture]
    public class FalconClientTests
    {
        [Test]
        public void FalconClient_Has_Response()
        {
            var response = MockFalconServer.Client.GetAsync("channels").Result;

            Assert.True(response.IsSuccessStatusCode, "Actual status code: {0}", response.StatusCode);
        }
    }
}