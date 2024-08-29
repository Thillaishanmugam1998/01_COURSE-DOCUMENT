using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace CONSOLE_API_TESTING
{
    public static class WebApiClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static string Get(string baseUrl, string controller, string method, string queryParam = "")
        {
            string url = $"{baseUrl}/{controller}/{method}";
            if (!string.IsNullOrEmpty(queryParam))
            {
                url += $"?{queryParam}";
            }

            HttpResponseMessage response = client.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsStringAsync().Result;
        }

        public static string Post(string baseUrl, string controller, string method, string jsonContent)
        {
            string url = $"{baseUrl}/{controller}/{method}";
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(url, content).Result;
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
