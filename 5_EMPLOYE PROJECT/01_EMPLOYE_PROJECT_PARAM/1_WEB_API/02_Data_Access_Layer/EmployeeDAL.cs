using System;
using Npgsql;
using System.Data;

namespace DAL
{
    public class EmployeeDAL
    {
        private string _connectionString = "Host=localhost;Username=postgres;Password=sar@123;Database=SampleDB";

        #region 01. EXECUTE_SCALAR:-
        public int ExecuteScalar(string query, NpgsqlParameter[] parameters)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        #endregion

        #region 02. EXECUTE_NON_QUERY:-
        public int ExecuteNonQuery(string query, NpgsqlParameter[] parameters)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region 03. EXECUTE_READER:-
        public DataTable ExecuteReader(string query, NpgsqlParameter[] parameters)
        {
            DataTable dt = new DataTable();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }
        #endregion
    }
}