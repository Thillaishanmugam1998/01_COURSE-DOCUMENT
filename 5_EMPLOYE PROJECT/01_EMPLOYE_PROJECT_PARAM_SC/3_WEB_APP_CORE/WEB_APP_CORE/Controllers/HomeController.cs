using WEB_APP_CORE.Models;
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
        [ValidateAntiForgeryToken]
        public JsonResult GetEmployeeById(int id)
        {
            string baseUrl      = "http://localhost:15738";
            string controller   = "Employee";
            string method       = "GetEmployeeById";
            string queryParam   = $"id={id}";

            string response     = WebApiClient.Get(baseUrl, controller, method, queryParam);
            //var employee      = JsonConvert.DeserializeObject<Employee>(response);

            return Json(response);
        }
    }

}