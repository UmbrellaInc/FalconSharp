using System;
using System.Net.Http;
using System.Web.Http;
using NUnit.Framework;

namespace FalconSharp.Tests
{
    [SetUpFixture]
    public class MockFalconServer
    {
        public const string API_BASE_URL = "http://localhost:8888";

        public static HttpClient Client { get; set; }

        [SetUp]
        public void SetUp()
        {
            var config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                name: "FalconApi_Channels",
                routeTemplate: "channels",
                defaults: new { controller = "MockFalconApi", action = "channels" }
            );

            config.Routes.MapHttpRoute(
                name: "FalconApi_Content",
                routeTemplate: "channels/{channelId}/content",
                defaults: new { controller = "MockFalconApi", action = "content" }
            );

            var server = new HttpServer(config);

            Client = new HttpClient(server) { BaseAddress = new Uri(API_BASE_URL) };
        }

        [TearDown]
        public void TearDown()
        {
            if (Client != null)
                Client.Dispose();
        }
    }
}