using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CloasisWeb.ApiInfrastructure
{
    public static class HttpClientInstance
    {
        private static readonly HttpClient instance = new HttpClient { BaseAddress = new Uri(GlobalURL.baseURI) };

        public static HttpClient Instance
        {
            get { return instance; }
        }
    }
}