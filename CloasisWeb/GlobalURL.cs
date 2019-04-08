using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CloasisWeb
{
    public class GlobalURL
    {
        public static string baseURI = "https://cloasis.azurewebsites.net/api/v1/";
        public static string key = "uy/DEZcyLOpWzVXW6UvO79n6yvBGpPYIDuXPXa9RXWjfrfLOQiWiCQ=="; 

        public static HttpClient AddHeader(HttpClient client)
        {
            if (client.DefaultRequestHeaders.Where(a => a.Key == "x-functions-key").SingleOrDefault().Value == null)
            {
                client.DefaultRequestHeaders.Add("x-functions-key", key);
            }
            return client;
        }
    }
}