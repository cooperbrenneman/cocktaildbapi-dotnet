using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CocktailDbAPI.Http
{
    class HttpRequester
    {
        private HttpClient _httpClient;
        private string _baseUrl;

        /// <summary>
        /// Http requestor
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <exception cref="ArgumentNullException">baseUrl</exception>
        public HttpRequester(string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(baseUrl))
            {
                throw new ArgumentNullException(nameof(baseUrl));
            }

            _httpClient = new HttpClient();

            _baseUrl = baseUrl;
            _httpClient.BaseAddress = new Uri(baseUrl);
        }

        /// <summary>
        /// Sends an <see cref="HttpRequestMessage"/> asynchronously.
        /// </summary>
        /// <param name="requestUrl"></param>
        /// <returns></returns>
        /// <exception cref="CocktailAPIException">Thrown if an Http error occurs. Contains the Http error code and error message.</exception>
        public async Task<T> GetAsync<T>(string requestUrl)
        {
            try
            {
                using (HttpResponseMessage httpResponse = await _httpClient.GetAsync(requestUrl).ConfigureAwait(false))
                {
                    if (!httpResponse.IsSuccessStatusCode)
                    {
                        HandleRequestFailure(httpResponse);
                    }

                    string data = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return JsonConvert.DeserializeObject<T>(data,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                }
            }
            catch
            {
                throw;
            }
        }

        private static void HandleRequestFailure(HttpResponseMessage httpResponse)
        {
            try
            {
                string message;
                try
                {
                    var jsonContentStr = httpResponse.Content.ReadAsStringAsync().Result;
                    var jsonContentObj = JObject.Parse(jsonContentStr);
                    message = jsonContentObj["status"]["message"].ToObject<string>();
                }
                catch
                {
                    message = httpResponse.StatusCode.ToString();
                }
            
                throw new CocktailAPIException(message, httpResponse.StatusCode);
            }
            finally
            {
                httpResponse.Dispose();
            }
        }
    }
}
