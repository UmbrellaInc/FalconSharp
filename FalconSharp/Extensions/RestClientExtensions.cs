﻿using System.Collections.Generic;
using System.Net;
using RestSharp;

namespace FalconSharp.Extensions
{
	internal static class RestClientExtensions
	{
		public static TReturnType MakeFalconRequest<TReturnType>(this RestClient restClient,
			string apiKey,
			string resourePath,
			Method method = Method.GET,
			IDictionary<string, string> parameters = null,
			HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
			where TReturnType : FalconResponse, new()
		{
			// Construct the request
			var req = new RestRequest(resourePath, method);
			req.AddHeader("X-Falcon-ApiKey", apiKey);
			req.OnBeforeDeserialization = response => { response.ContentType = "application/json"; };

			if (parameters != null)
			{
				foreach (var key in parameters.Keys)
				{
					if (resourePath.Contains("{" + key + "}"))
						req.AddParameter(key, parameters[key], ParameterType.UrlSegment);
					else
						req.AddParameter(key, parameters[key]);
				}
			}

			// Perform the request
			var resp = restClient.Execute(req);

			// Check the result
			if (resp.StatusCode == expectedStatusCode)
			{
				// Return success
				var res = resp.Content.DeserializeJsonTo<TReturnType>();
				res.Success = true;
				return res;
			}

			// Return error
			return new TReturnType
			{
				Success = false,
				ErrorMessage = resp.ErrorMessage ?? resp.StatusDescription
			};
		}
	}
}
