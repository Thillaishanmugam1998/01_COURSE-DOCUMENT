using Microsoft.AspNetCore.Mvc;
using BAL;
using System;

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
        [HttpPost("InsertEmployee")]
        public string InsertEmployee(string name, string email, string mobile, string city)
        {
            string[] strarr = new string[] { "name","emai"};
            String[] str = new String[1];

            string result = _employeeBAL.InsertEmployee(name, email, mobile, city);
            return (result);
        }
        #endregion

        #region 04. UPDATE EMPLOYEE:-
        [HttpPost("UpdateEmployee")]
        public string UpdateEmployee(int id, string name, string email, string mobile, string city)
        {
            string result = _employeeBAL.UpdateEmployee(id, name, email, mobile, city);
            return (result);
        }
        #endregion

        #region 05. DELETE EMPLOYEE:-
        [HttpPost("DeleteEmployee")]
        public string DeleteEmployee(int id)
        {
            string result = _employeeBAL.SoftDeleteEmployee(id);
            return (result);
        }
        #endregion

        #region 06. GET EMPLOYEE BY ID:-
        [HttpGet("GetEmployeeById")]
        public string GetEmployeeById()
        {
            int id = 1;
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
