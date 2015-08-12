using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using FalconSharp.Extensions;
using FalconSharp.Models;
using RestSharp;

namespace FalconSharp
{
    public class FalconClient
    {
        private const string API_BASE_URL = "https://app.falconsocial.com/v1";

        private string _apiKey;

        private RestClient _restClient;

        public FalconClient(string apiKey, IWebProxy proxy = null)
            : this(API_BASE_URL, apiKey, proxy)
        { }

        public FalconClient(string url, string apiKey, IWebProxy proxy = null)
        {
            _apiKey = apiKey;
            _restClient = new RestClient(url);

            if (proxy != null)
                _restClient.Proxy = proxy;
        }

        public FalconEntityCollectionResponse<Channel> GetChannels()
        {
            return _restClient.MakeFalconRequest<FalconEntityCollectionResponse<Channel>>(
                _apiKey, "channels");
        }

        //public FalconEntityCollectionResponse<Content> GetChannelContent(string channelId,
        //    DateTime? since = null, DateTime? until = null,
        //    int? limit = null, int? offset = null)
        //{
        //    throw new NotImplementedException();

        //    //var parameters = new Dictionary<string, string>
        //    //{
        //    //    { "channelId", channelId }
        //    //};

        //    //if (since.HasValue)
        //    //    parameters.Add("since", since.Value.ToString("yyyy-MM-dd'T'HH:mm:ss.SSSZZ"));

        //    //if (until.HasValue)
        //    //    parameters.Add("until", until.Value.ToString("yyyy-MM-dd'T'HH:mm:ss.SSSZZ"));

        //    //if (limit.HasValue)
        //    //    parameters.Add("limit", limit.Value.ToString(CultureInfo.InvariantCulture));

        //    //if (offset.HasValue)
        //    //    parameters.Add("offset", offset.Value.ToString(CultureInfo.InvariantCulture));

        //    //return _restClient.MakeFalconRequest<FalconEntityCollectionResponse<Content>>(
        //    //    _apiKey, "channels/{channelId}/content",
        //    //        parameters: parameters);
        //}

        //public FalconEntityCollectionResponse<Metric> GetChannelMetrics(string channelId,
        //    IEnumerable<string> metrics = null,
        //    DateTime? since = null, DateTime? until = null,
        //    int? limit = null, int? offset = null,
        //    bool replaceMissingValues = false)
        //{
        //    throw new NotImplementedException();
        //}

        public FalconEntityCollectionResponse<Content> GetContentFeed(
            DateTime? since = null, DateTime? until = null,
            int? limit = null, int? offset = null,
            SortOrder sort = SortOrder.Desc,
            IEnumerable<string> channels = null,
            IEnumerable<string> tags = null)
        {
            var parameters = new Dictionary<string, string>
            {
                {"sort", sort.ToString().ToLower()}
            };

            if (since.HasValue)
                parameters.Add("since", since.Value.ToString("yyyy-MM-dd'T'HH:mm:ss.SSSZZ"));

            if (until.HasValue)
                parameters.Add("until", until.Value.ToString("yyyy-MM-dd'T'HH:mm:ss.SSSZZ"));

            if (limit.HasValue)
                parameters.Add("limit", limit.Value.ToString(CultureInfo.InvariantCulture));

            if (offset.HasValue)
                parameters.Add("offset", offset.Value.ToString(CultureInfo.InvariantCulture));

            if (channels != null)
                parameters.Add("channels", string.Join(",", channels));

            if (tags != null)
                parameters.Add("tags", string.Join(",", tags));

            return _restClient.MakeFalconRequest<FalconEntityCollectionResponse<Content>>(
                _apiKey, "content/feed",
                    parameters: parameters);
        }

        //public FalconEntityCollectionResponse<Metric> GetContentMetrics(string contentId,
        //    IEnumerable<string> metrics = null,
        //    DateTime? since = null, DateTime? until = null,
        //    int? limit = null, int? offset = null,
        //    bool replaceMissingValues = false)
        //{
        //    throw new NotImplementedException();
        //}

        //public FalconEntityCollectionResponse<User> GetUsers()
        //{
        //    throw new NotImplementedException();
        //}

        //public FalconEntityCollectionResponse<User> GetUser(string userId)
        //{
        //    throw new NotImplementedException();
        //}

        //public FalconEntityCollectionResponse<Metric> GetUserMetrics(string userId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}