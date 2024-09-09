using Microsoft.AspNetCore.Mvc;
using SamplewebMVC.BusinessLogicLayer;

namespace SamplewebMVC.Controllers
{
    public class DashboardController : Controller
    {
        private readonly BAL _BAL;

        #region 00. PAGES:-
        // GET:  /Home/Dashboard
        #endregion

        #region 01. CONSTRUCTOR:-
        public DashboardController()
        {
            _BAL = new BAL();
        }
        #endregion

        #region 02. DASHBOARD PAGE:-
        /// <summary>
        /// Displays the dashboard page after a successful login.
        /// </summary>
        /// <returns>An IActionResult representing the dashboard view.</returns>
        public IActionResult Dashboard()
        {
            return View();
        }
        #endregion

        public void InsertData()
        {

        }

        public void UpdateData()
        {
        }


        public void DeleteData()
        {
        }

        public void GetallData()
        {

        }


    }
}
