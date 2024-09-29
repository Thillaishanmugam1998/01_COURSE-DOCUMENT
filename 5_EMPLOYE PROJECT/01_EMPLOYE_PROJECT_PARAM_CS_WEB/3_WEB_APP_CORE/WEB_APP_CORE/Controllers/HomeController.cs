using Microsoft.AspNetCore.Mvc;
using WEB_APP_CORE.CallWebAPI;
using System.Threading.Tasks;
using System;

namespace WEB_APP_CORE.Controllers
{
    public class HomeController : Controller
    {
        private string baseUrl = "http://localhost:15738";
        
        #region HOME PAGE:-
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region DASHBOARD PAGE:-
        public IActionResult Dashboard()
        {
            return View();
        }
        #endregion

        #region 01. LOGIN VERIFY:-
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Login(string username, string password)
        {
            bool isAuthenticated = await AuthenticateUserAsync(username, password);

            if (isAuthenticated)
            {
                // Return JSON response with redirect URL on success
                return Json(new { redirect = true, redirectUrl = Url.Action("Dashboard") });
            }
            else
            {
                // Return JSON response with error message on failure
                return Json(new { error = "Invalid username or password" });
            }
        }
        #endregion

        #region 02. VERIFY USER EXISTS:-
        private Task<bool> AuthenticateUserAsync(string username, string password)
        {
            // Example authentication logic
            return Task.FromResult(username == "admin" && password == "password");
        }
        #endregion

        #region 03. GET EMPLOYEE BYID:-
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public JsonResult GetEmployeeById(int id)
        {
            string controller   = "Employee";
            string method       = "GetEmployeeById";
            string queryParam   = $"id={id}";

            string response     = WebApiClient.Get(baseUrl, controller, method, queryParam);
            //var employee      = JsonConvert.DeserializeObject<Employee>(response);

            return Json(response);
        }
        #endregion

        #region 04. GET ALL EMPLOYEE:-
        [HttpGet]
        public JsonResult GetAllEmployees()
        {
            string controller = "Employee";
            string method = "GetAllEmployees";
            string response = WebApiClient.Get(baseUrl, controller, method);
            return Json(response);
        }
        #endregion

        #region 05. INSERT EMPLOYEE:-
        [HttpGet]
        public JsonResult InsertEmployee(string name, string email, string mobile, string city)
        {
            string controller = "Employee";
            string method = "InsertEmployee";
            string queryParam = $"name={name}&email={email}&mobile={mobile}&city={city}";

            string response = WebApiClient.Get(baseUrl, controller, method, queryParam);
            if (Convert.ToInt32(response) > 0)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
        }
        #endregion

        #region 06. DELETE EMPLOYEE:-
        [HttpGet]
        public JsonResult DeleteEmployee(string id)
        {
            string controller = "Employee";
            string method = "DeleteEmployee";
            string queryParam = $"id={id}";

            string response = WebApiClient.Get(baseUrl, controller, method, queryParam);
            if (Convert.ToInt32(response)>0)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
        }
        #endregion

        #region 07. UPDATE EMPLOYEE:-
        [HttpGet]
        public JsonResult UpdateEmployee(string id,string name, string email, string mobile, string city)
        {
            string controller = "Employee";
            string method = "UpdateEmployee";
            string queryParam = $"id={id}&name={name}&email={email}&mobile={mobile}&city={city}";

            string response = WebApiClient.Get(baseUrl, controller, method, queryParam);
            if (Convert.ToInt32(response) > 0)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
        }
        #endregion
    }
}