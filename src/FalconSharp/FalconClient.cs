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
        private const string API_BASE_URL = "https://api.falcon.io/";

        private string _apiKey;

        private RestClient _restClient;

        public FalconClient(string apiKey, IWebProxy proxy = null)
            : this(API_BASE_URL, apiKey, proxy)
        {
        }

        public FalconClient(string url, string apiKey, IWebProxy proxy = null)
        {
            // It appears that Falcon have enabled TLS 1.2 encryption.
            // Check if `SecurityProtocol` has TLS 1.2 enabled, if not, enable it.
            if (!ServicePointManager.SecurityProtocol.HasFlag(SecurityProtocolType.Tls12))
            {
                // for reference: https://groups.google.com/d/msg/devtargetprocess/1R1niz_WCFE/2-PvKltxBgAJ
                ServicePointManager.SecurityProtocol = ServicePointManager.SecurityProtocol | SecurityProtocolType.Tls12;
            }

            _apiKey = apiKey;
            _restClient = new RestClient(url);

            if (proxy != null)
            {
                _restClient.Proxy = proxy;
            }
        }

        public FalconEntityCollectionResponse<Channel> GetChannels(int? limit = null)
        {
            var parameters = new Dictionary<string, string>();

            if (limit.HasValue)
                parameters.Add("limit", limit.Value.ToString(CultureInfo.InvariantCulture));

            return _restClient.MakeFalconRequest<FalconEntityCollectionResponse<Channel>>(_apiKey, "channels/", parameters: parameters);
        }

        public FalconEntityResponse<Channel> GetChannel(string channelId)
        {
            // http://docs.falconsocial.apiary.io/#reference/channel-api/get-a-specific-channel
            throw new PullRequestRequiredException();
        }

        public FalconEntityCollectionResponse<Dictionary<string, object>> GetChannelMetrics(
            string channelId,
            IEnumerable<string> metrics,
            DateTime? since = null,
            DateTime? until = null)
        {
            // http://docs.falconsocial.apiary.io/#reference/channel-api/get-insight-metrics-for-a-channel-id/get-metrics-for-a-specific-post
            throw new PullRequestRequiredException();
        }

        public FalconEntityCollectionResponse<Content> GetContentFeed(
            int? limit = null,
            DateTime? since = null,
            DateTime? until = null,
            SortOrder sort = SortOrder.Desc,
            IEnumerable<string> channels = null,
            IEnumerable<string> tags = null,
            IEnumerable<NetworkType> networks = null)
        {
            var parameters = new Dictionary<string, string>();

            if (limit.HasValue)
                parameters.Add("limit", limit.Value.ToString(CultureInfo.InvariantCulture));

            if (since.HasValue)
                parameters.Add("since", since.Value.ToString("o"));

            if (until.HasValue)
                parameters.Add("until", until.Value.ToString("o"));

            parameters.Add("sort", sort.ToString().ToLower());

            if (channels != null)
                parameters.Add("channels", string.Join(",", channels));

            if (tags != null)
                parameters.Add("tags", string.Join(",", tags));

            if (networks != null)
                parameters.Add("networks", string.Join(",", networks));

            return _restClient.MakeFalconRequest<FalconEntityCollectionResponse<Content>>(_apiKey, "content/feed", parameters: parameters);
        }

        public FalconEntityCollectionResponse<object> GetContentFeedMetrics(string postId, IEnumerable<string> metrics)
        {
            // http://docs.falconsocial.apiary.io/#reference/published-posts-api/get-metrics-for-a-facebook-post/get-metrics-for-a-specific-post
            throw new PullRequestRequiredException();
        }

        public FalconEntityCollectionResponse<object> GetProjects()
        {
            // http://docs.falconsocial.apiary.io/#reference/project-api/get-all-projects
            throw new PullRequestRequiredException();
        }

        public FalconEntityCollectionResponse<object> GetProjectTopics(string projectId)
        {
            // http://docs.falconsocial.apiary.io/#reference/project-api/get-all-topics-for-a-project
            throw new PullRequestRequiredException();
        }

        public FalconEntityCollectionResponse<object> GetTopicMetrics(
            string metrics,
            int? limit = null,
            DateTime? since = null,
            DateTime? until = null,
            int granularity = 100)
        {
            // http://docs.falconsocial.apiary.io/#reference/project-api/get-metrics-for-a-topic
            throw new PullRequestRequiredException();
        }

        public FalconEntityResponse<object> GetOrganizationMetrics()
        {
            // http://docs.falconsocial.apiary.io/#reference/organization-api/get-organization-metrics
            throw new PullRequestRequiredException();
        }

        public FalconEntityCollectionResponse<object> GetOrganizationTeams()
        {
            // http://docs.falconsocial.apiary.io/#reference/organization-api/get-teams
            throw new PullRequestRequiredException();
        }

        public FalconEntityCollectionResponse<object> GetOrganizationTeam(string teamId)
        {
            // http://docs.falconsocial.apiary.io/#reference/organization-api/get-specific-team
            throw new PullRequestRequiredException();
        }

        public FalconEntityCollectionResponse<object> GetOrganizationTeamMetrics(
            string teamId,
            IEnumerable<string> metrics,
            DateTime? since = null,
            DateTime? until = null)
        {
            // http://docs.falconsocial.apiary.io/#reference/organization-api/get-team-performance-metrics
            throw new PullRequestRequiredException();
        }

        public FalconEntityCollectionResponse<object> GetOrganizationTeamUsers(string teamId)
        {
            // http://docs.falconsocial.apiary.io/#reference/organization-api/get-team-users
            throw new PullRequestRequiredException();
        }

        public FalconEntityCollectionResponse<object> GetOrganizationTeamUserMetrics(
            string teamId,
            IEnumerable<string> metrics,
            DateTime? since = null,
            DateTime? until = null)
        {
            // http://docs.falconsocial.apiary.io/#reference/organization-api/get-user-performance-metrics
            throw new PullRequestRequiredException();
        }
    }
}