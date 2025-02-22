﻿using Dropbox.API.Extensions;
using Dropbox.Core.DataConstants;
using System.Text;
using static Dropbox.Core.Extensions.UriExtensions;

namespace Dropbox.API.Builders
{
    public class RequestBuilder
    {
        private static HttpRequestMessage _request;
        private static Uri BaseServiceUri { get; set; }

        public RequestBuilder(string url)
        {
            _request = new HttpRequestMessage();
            BaseServiceUri = new Uri(url);
            WithHeader("Authorization", BaseApiConstance.Token);
        }

        public RequestBuilder WithHeaders(Dictionary<string, string> headers)
        {
            foreach (var header in headers)
            {
                _request.Headers.Add(header.Key, header.Value);
            }

            return this;
        }

        public RequestBuilder Uri(string url)
        {
            _request.RequestUri = BaseServiceUri.Append(url);
            return this;
        }

        public RequestBuilder Method(HttpMethod method)
        {
            _request.Method = method;
            return this;
        }

        public RequestBuilder WithHeader(string key, string value)
        {
            _request.Headers.Add(key, value);
            return this;
        }

        public RequestBuilder WithBody(string requestBody)
        {
            _request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            return this;
        }

        public RequestBuilder WithFile(byte[] fileBytes)
        {
            _request.Content = new StreamContent(new MemoryStream(fileBytes));
            _request.Content.Headers.Add("Content-Type", "application/octet-stream");
            return this;
        }

        public ApiResponse Execute()
        {
            using (var httpClient = new HttpClient())
            {
                _request.Headers.Referrer = _request.RequestUri;
                var response = httpClient.SendAsync(_request, CancellationToken.None).Result;
                return new ApiResponse(response);
            }
        }
    }
}
