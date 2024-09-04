using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;

namespace WEB_APP_CORE.CallWebAPI
{
    public static class WebApiClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static string Get(string baseUrl, string controller, string method, string queryParam = "")
        {
            string url = $"{baseUrl}/{controller}/{method}";
            try
            {
                if (!string.IsNullOrEmpty(queryParam))
                {
                    url += $"?{queryParam}";
                }

                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result;
            }
            catch(Exception ex)
            {
                throw ex;
            } 
        }

        public static string Post(string baseUrl, string controller, string method, string jsonContent)
        {
            try
            {
                string url = $"{baseUrl}/{controller}/{method}";
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PostAsync(url, content).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
