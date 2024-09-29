using System;
using DAL;
using Newtonsoft.Json;
using System.Data;

namespace BAL
{
    public class EmployeeBAL
    {

        private readonly EmployeeDAL _employeeDAL;
        
        #region 01. CONSTRUCTOR:-
        public EmployeeBAL()
        {
            _employeeDAL = new EmployeeDAL();
        }
        #endregion

        #region 02. INSERT:-
        public string InsertEmployee(string name, string email, string mobile, string city)
        {
            string query = $"INSERT INTO EmployeeDetails (name, email, mobile, city, createdon, isdeleted) " +
                           $"VALUES ('{name}', '{email}', '{mobile}', '{city}', NOW(), false) " +
                           $"RETURNING id";

            int result = _employeeDAL.ExecuteScalar(query);
            if (result > 0)
            {
                return "Insert successful";
            }
            else
            {
                return "Insert failed";
            }
        }
        #endregion

        #region 03. UPDATE:-
        public string UpdateEmployee(int id, string name, string email, string mobile, string city)
        {
            string query = $"UPDATE EmployeeDetails SET " +
                           $"name = '{name}', " +
                           $"email = '{email}', " +
                           $"mobile = '{mobile}', " +
                           $"city = '{city}', " +
                           $"createdon = NOW() " +
                           $"WHERE id = {id}";

            int result = _employeeDAL.ExecuteNonQuery(query);
            if (result > 0)
            {
                return "Update successful";
            }
            else
            {
                return "Update failed";
            }
        }
        #endregion

        #region 04. DELETE:-
        public string SoftDeleteEmployee(int id)
        {
            string query = $"UPDATE EmployeeDetails SET isdeleted = true WHERE id = {id}";

            int result = _employeeDAL.ExecuteNonQuery(query);
            if (result > 0)
            {
                return "Employee marked as deleted successfully";
            }
            else
            {
                return "Failed to mark employee as deleted";
            }
        }
        #endregion

        #region 05. GET_EMPLOYEE_BY_ID:-
        public string GetEmployeeById(int id)
        {
            string query = $"SELECT * FROM EmployeeDetails WHERE id = {id} AND isdeleted = false";
            DataTable result = _employeeDAL.ExecuteReader(query);
            return JsonConvert.SerializeObject(result);
        }
        #endregion

        #region 06. GET_ALL_EMPLOYEE:-
        public string GetAllEmployees()
        {
            string query = "SELECT * FROM employeedetails WHERE isdeleted = false";
            DataTable result = _employeeDAL.ExecuteReader(query);
            return JsonConvert.SerializeObject(result);
        }
        #endregion

    }
}
