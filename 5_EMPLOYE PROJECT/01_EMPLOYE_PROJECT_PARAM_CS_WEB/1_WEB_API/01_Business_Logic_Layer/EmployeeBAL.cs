using System;
using DAL;
using Newtonsoft.Json;
using System.Data;
using Npgsql;
using System.IO;

namespace BAL
{
    public class EmployeeBAL
    {
        private readonly EmployeeDAL _employeeDAL;
        string iniFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DBConnectionString.ini");

        #region 01. CONSTRUCTOR:-
        public EmployeeBAL()
        {
            _employeeDAL = new EmployeeDAL(iniFilePath);
        }
        #endregion

        #region 02. INSERT:-
        public int InsertEmployee(string name, string email, string mobile, string city)
        {
            string query = "INSERT INTO EmployeeDetails (name, email, mobile, city, createdon, isdeleted) " +
                           "VALUES (@Name, @Email, @Mobile, @City, NOW(), false) " +
                           "RETURNING id";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@Name", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = name },
                new NpgsqlParameter("@Email", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = email },
                new NpgsqlParameter("@Mobile", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = mobile },
                new NpgsqlParameter("@City", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = city }
            };

            int result = _employeeDAL.ExecuteScalar(query, parameters);
            return result;
        }
        #endregion

        #region 03. UPDATE:-
        public int UpdateEmployee(int id, string name, string email, string mobile, string city)
        {
            string query = "UPDATE EmployeeDetails SET " +
                           "name = @Name, " +
                           "email = @Email, " +
                           "mobile = @Mobile, " +
                           "city = @City, " +
                           "createdon = NOW() " +
                           "WHERE id = @Id";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@Id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id },
                new NpgsqlParameter("@Name", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = name },
                new NpgsqlParameter("@Email", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = email },
                new NpgsqlParameter("@Mobile", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = mobile },
                new NpgsqlParameter("@City", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = city }
            };

            int result = _employeeDAL.ExecuteNonQuery(query, parameters);
            return result;
        }
        #endregion

        #region 04. DELETE:-
        public int SoftDeleteEmployee(int id)
        {
            string query = "UPDATE EmployeeDetails SET isdeleted = true WHERE id = @Id";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@Id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            int result = _employeeDAL.ExecuteNonQuery(query, parameters);
            return result;
        }
        #endregion

        #region 05. GET_EMPLOYEE_BY_ID:-
        public string GetEmployeeById(int id)
        {
            string query = "SELECT * FROM EmployeeDetails WHERE id = @Id AND isdeleted = false";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@Id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable result = _employeeDAL.ExecuteReader(query, parameters);
            return JsonConvert.SerializeObject(result);
        }
        #endregion

        #region 06. GET_ALL_EMPLOYEE:-
        public string GetAllEmployees()
        {
            string query = "SELECT * FROM EmployeeDetails WHERE isdeleted = false";
            DataTable result = _employeeDAL.ExecuteReader(query, null);
            return JsonConvert.SerializeObject(result);
        }
        #endregion

    }
}
