using ApiHelper.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ApiHelper.Client
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient httpClient;
        private readonly ITokenContainer tokenContainer;

        public ApiClient(HttpClient httpClient, ITokenContainer tokenContainer)
        {
            this.httpClient = httpClient;
             this.tokenContainer = tokenContainer;
        }

        public async Task<HttpResponseMessage> GetFormEncodedContent(string requestUri, params KeyValuePair<string, string>[] values)
        {
            AddToken();
            using (var content = new FormUrlEncodedContent(values))
            {
                var query = await content.ReadAsStringAsync();
                var requestUriWithQuery = string.Concat(requestUri);
                var response = await httpClient.GetAsync(requestUriWithQuery);
                return response;
            }
        }

        public async Task<HttpResponseMessage> PostFormEncodedContent(string requestUri, params System.Collections.Generic.KeyValuePair<string, string>[] values)
        {
            using (var content = new FormUrlEncodedContent(values))
            {
                AddToken();
                var response = await httpClient.PostAsync(requestUri, content);
                return response;
            }
        }

        public async Task<HttpResponseMessage> PostJsonEncodedContent<T>(string requestUri, T content) where T : ApiModel
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            AddToken();
            var response = await httpClient.PostAsJsonAsync(requestUri, content);
            return response;
        }

        public async Task<HttpResponseMessage> PutJsonEncodedContent<T>(string requestUri, T content) where T : ApiModel
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            AddToken();
            var response = await httpClient.PutAsJsonAsync(requestUri, content);
            return response;
        }

        public async Task<HttpResponseMessage> DeleteEncodedContent(string requestUri, params KeyValuePair<string, string>[] values)
        {
            AddToken();
            using (var content = new FormUrlEncodedContent(values))
            {
                var query = await content.ReadAsStringAsync();
                var requestUriWithQuery = string.Concat(requestUri);
                var response = await httpClient.DeleteAsync(requestUriWithQuery);
                return response;
            }
        }


        private void AddToken()
        {
 
        }
    }
}
