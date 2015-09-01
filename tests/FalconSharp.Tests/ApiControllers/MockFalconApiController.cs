using System;
using System.Web.Http;
using FalconSharp.Models;
using FizzWare.NBuilder;

namespace FalconSharp.Tests.ApiControllers
{
    public class MockFalconApiController : ApiController
    {
        [HttpGet]
        public CollectionResponse<Channel> Channels()
        {
            return new CollectionResponse<Channel>
            {
                Items = Builder<Channel>
                    .CreateListOfSize(10)
                    .All()
                    .With(x => x.Id = Guid.NewGuid().ToString())
                    .Build()
            };
        }

        [HttpGet]
        public CollectionResponse<Content> Content(string channelId)
        {
            return new CollectionResponse<Content>
            {
                Items = Builder<Content>
                    .CreateListOfSize(20)
                    .All()
                    .With(x => x.Id = Guid.NewGuid().ToString())
                    .And(x => x.Channel.Id = channelId)
                    .And(x => x.Type = ContentType.Status)
                    .And(x => x.Picture = "")
                    .Random(5)
                    .With(x => x.Type = ContentType.Photo)
                    .And(x => x.Picture = "http://lorempixel.com/400/400/")
                    .Build()
            };
        }
    }
}