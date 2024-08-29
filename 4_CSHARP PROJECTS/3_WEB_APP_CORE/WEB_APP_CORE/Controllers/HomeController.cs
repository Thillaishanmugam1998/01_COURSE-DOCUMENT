using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WEB_APP_CORE.CallWebAPI;
using Newtonsoft.Json;

namespace WEB_APP_CORE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetEmployeeById(int id)
        {
            string baseUrl = "http://localhost:15738";
            string controller = "Employee";
            string method = "GetEmployeeById";
            string queryParam = $"id={id}";

            string response = WebApiClient.Get(baseUrl, controller, method, queryParam);
            //var employee = JsonConvert.DeserializeObject<Employee>(response);

            return Json(response);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}