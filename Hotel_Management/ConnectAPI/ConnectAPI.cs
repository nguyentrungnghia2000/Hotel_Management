using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConnectAPI
{
    public class ConnectAPI
    {
        static string URL_Local = @"https://localhost:5001";

        private HttpClient apiClient { get; set; }
        private ConnectAPI()
        {
            InitializeClient();
        }
        private static ConnectAPI instance = null;
        public static ConnectAPI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConnectAPI();
                }
                return instance;
            }
        }

        private void InitializeClient()
        {
            string api = URL_Local;

            apiClient = new HttpClient();
            apiClient.BaseAddress = new Uri(api);
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> Get<T>(string route)
        {
            this.InitializeClient();

            using (HttpResponseMessage response = await apiClient.GetAsync(route))
            {
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<T>();
                    if (data != null)
                        return data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
                return default;
            }
        }

        public async Task<T> Post<T>(string route, object body = null)
        {
            this.InitializeClient();

            using (HttpResponseMessage response = await apiClient.PostAsJsonAsync(route, body))
            {
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<T>();
                    if (data != null)
                        return data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
                return default;
            }
        }

    }
}
