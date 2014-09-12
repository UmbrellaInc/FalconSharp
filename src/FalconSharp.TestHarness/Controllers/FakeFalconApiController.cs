using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FalconSharp.Models;
using FizzWare.NBuilder;

namespace FalconSharp.TestHarness.Controllers
{
	public class FakeFalconApiController : ApiController
	{
		[HttpGet]
		public CollectionResponse<Channel> Channels()
		{
			return new CollectionResponse<Channel>
			{
				Items = Builder<Channel>.CreateListOfSize(10)
					.All().With(x => x.Id = Guid.NewGuid().ToString())
					.Build()
			};
		}

		[HttpGet]
		public CollectionResponse<Content> Content(string channelId)
		{
			return new CollectionResponse<Content>
			{
				Items = Builder<Content>.CreateListOfSize(20)
					.All().With(x => x.Id = Guid.NewGuid().ToString())
						.And(x => x.ChannelId = channelId)
						.And(x => x.Type = ContentType.Status)
						.And(x => x.Picture = "")
					.Random(5).With(x => x.Type = ContentType.Photo)
						.And(x => x.Picture = "http://lorempixel.com/400/400/")
					.Build()
			};
		}
	}
}