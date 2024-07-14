using Newtonsoft.Json;
using OKX.API.Authentication;
using OKX.API.Base.Models;
using System.Text;

namespace OKX.API.Base
{
    public class BaseRestClient
    {
        private AuthenticationProvider _authenticationProvider;

        public BaseRestClient(CredentialsAPI Credentials)
        {
            _authenticationProvider = new AuthenticationProvider(Credentials);
        }

        protected async Task<DataResponse<List<T>>> PostAPI<T>(string endpoint, Dictionary<string, string> bodyParameters = null)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{RestClientAPI.API_URL}/{endpoint}";
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                string requestBody = "";
                if (bodyParameters != null)
                {
                    requestBody = JsonConvert.SerializeObject(bodyParameters);
                    StringContent content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                    request.Content = content;
                }
                await _authenticationProvider.AuthenticateRequest(request);
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<DataResponse<List<T>>>(responseData);
                }
                else
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    try
                    {
                        return JsonConvert.DeserializeObject<DataResponse<List<T>>>(responseData);
                    }
                    catch (Exception)
                    {
                        return default;
                    }
                }
            }
        }

        protected async Task<DataResponse<List<T>>> GetAPI<T>(string endpoint, Dictionary<string, string> queryParameters = null)
        {
            using (HttpClient client = new HttpClient())
            {
                string query = "";
                if (queryParameters != null)
                {
                    query = $"?{ToQueryString(queryParameters)}";
                }
                string url = $"{RestClientAPI.API_URL}/{endpoint}{query}";
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                await _authenticationProvider.AuthenticateRequest(request);
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<DataResponse<List<T>>>(responseData);
                }
                else
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    try
                    {
                        var data = JsonConvert.DeserializeObject<DataResponse<List<T>>>(responseData);
                        return data;
                    }
                    catch (Exception)
                    {
                        return default;
                    }
                }
            }
        }

        private string ToQueryString(Dictionary<string, string> queryParameters)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var kvp in queryParameters)
            {
                if (sb.Length > 0)
                {
                    sb.Append("&");
                }
                sb.Append(Uri.EscapeDataString(kvp.Key));
                sb.Append("=");
                sb.Append(Uri.EscapeDataString(kvp.Value));
            }
            return sb.ToString();
        }
    }
}
