using Microsoft.AspNetCore.Mvc;
using BAL;

namespace WEBApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region 01. INITIALIZE BAL:-
        private readonly EmployeeBAL _employeeBAL = new EmployeeBAL();
        #endregion

        #region 02. INITIALIZE METHOD:-
        [HttpGet]
        public string  Get()
        {
            return "Welcome to API";
        }
        #endregion

        #region 03. INSERT EMPLOYEE:-
        [HttpGet("InsertEmployee")]
        public int InsertEmployee(string name, string email, string mobile, string city)
        {
            int result = _employeeBAL.InsertEmployee(name, email, mobile, city);
            return (result);
        }
        #endregion

        #region 04. UPDATE EMPLOYEE:-
        [HttpGet("UpdateEmployee")]
        public int UpdateEmployee(int id, string name, string email, string mobile, string city)
        {
            int result = _employeeBAL.UpdateEmployee(id, name, email, mobile, city);
            return (result);
        }
        #endregion

        #region 05. DELETE EMPLOYEE:-
        [HttpGet("DeleteEmployee")]
        public int DeleteEmployee(int id)
        {
            int result = _employeeBAL.SoftDeleteEmployee(id);
            return result;

        }
        #endregion

        #region 06. GET EMPLOYEE BY ID:-
        [HttpGet("GetEmployeeById")]
        public string GetEmployeeById(int id)
        {
            string result = _employeeBAL.GetEmployeeById(id);
            return (result);
        }
        #endregion

        #region 07. GET ALL EMPLOYEE:-
        [HttpGet("GetAllEmployees")]
        public string GetAllEmployees()
        {
            string result = _employeeBAL.GetAllEmployees();
            return result;
        }
        #endregion
    }
}
