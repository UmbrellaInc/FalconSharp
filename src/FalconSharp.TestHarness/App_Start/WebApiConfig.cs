using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace FalconSharp.TestHarness
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services
			var jsonFormatter = new JsonMediaTypeFormatter();
			jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

			config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));

			// Web API routes
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "FalconApi_Channels",
				routeTemplate: "api/falcon/channels",
				defaults: new { controller = "FakeFalconApi", action = "channels" }
			);

			config.Routes.MapHttpRoute(
				name: "FalconApi_Content",
				routeTemplate: "api/falcon/channels/{channelId}/content",
				defaults: new { controller = "FakeFalconApi", action = "content" }
			);

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}

	public class JsonContentNegotiator : IContentNegotiator
	{
		private readonly JsonMediaTypeFormatter _jsonFormatter;

		public JsonContentNegotiator(JsonMediaTypeFormatter formatter)
		{
			_jsonFormatter = formatter;
		}

		public ContentNegotiationResult Negotiate(
				Type type,
				HttpRequestMessage request,
				IEnumerable<MediaTypeFormatter> formatters)
		{
			return new ContentNegotiationResult(
				_jsonFormatter,
				new MediaTypeHeaderValue("application/json"));
		}
	}
}