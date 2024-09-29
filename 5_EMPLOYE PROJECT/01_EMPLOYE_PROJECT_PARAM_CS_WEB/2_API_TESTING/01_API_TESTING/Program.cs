using System;
using Newtonsoft.Json;

namespace CONSOLE_API_TESTING
{
    class Program
    {
        public static string GetEmployeeById(int id)
        {
            string baseUrl = "http://localhost:15738"; 
            string controller = "Employee";
            string method = "GetEmployeeById";
            string queryParam = $"id={id}";

            return WebApiClient.Get(baseUrl, controller, method, queryParam);
        }

        public string InsertEmployee(string name, string email, string mobile, string city)
        {
            string baseUrl = "http://localhost:15738"; 
            string controller = "Employee";
            string method = "InsertEmployee";

            var jsonData = new
            {
                name,
                email,
                mobile,
                city
            };
            string jsonContent = JsonConvert.SerializeObject(jsonData);

            return WebApiClient.Post(baseUrl, controller, method, jsonContent);
        }
        static void Main(string[] args)
        {
            string result = GetEmployeeById(2);
            Console.WriteLine(result);

        }
    }
}
