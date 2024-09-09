using Microsoft.AspNetCore.Mvc;
using SamplewebMVC.Models;
using SamplewebMVC.BusinessLogicLayer;

namespace SamplewebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly BAL _BAL;

        #region 00. PAGES:-
        // GET:  /Home/Index
        // GET:  /Home/Dashboard
        // POST: /Home/VerifyLogin
        #endregion

        #region 01. CONSTRUCTOR:-
        public HomeController() 
        {
            _BAL = new BAL();
        }
        #endregion

        #region 02. INDEX PAGE:-
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region 03. VERIFY LOGIN:-
        /// <summary>
        /// Verifies the login credentials of a user.
        /// </summary>
        /// <param name="model">The login model containing the username and password.</param>
        /// <returns>A JsonResult indicating whether the login was successful or not.</returns>
        [HttpPost]
        public JsonResult VerifyLogin([FromBody] LoginModel model)
        {
            int result = _BAL.verifyUser(model.Username, model.Password);

            if (result > 0)
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

