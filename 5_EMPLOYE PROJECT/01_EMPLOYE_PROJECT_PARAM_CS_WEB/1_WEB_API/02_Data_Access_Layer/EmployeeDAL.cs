using System;
using Npgsql;
using System.Data;
using IniParser;
using IniParser.Model;

namespace DAL
{
    public class EmployeeDAL
    {
        private string _connectionString;

        #region 00. CONSTRUCTOR:-
        public EmployeeDAL(string iniFilePath)
        {
            if (!string.IsNullOrEmpty(iniFilePath))
            {
                ReadConnectionStringFromIni(iniFilePath);
            }
        }
        #endregion

        #region READ CONFIG:-
        private  void ReadConnectionStringFromIni(string filePath)
        {
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(filePath);

                // Extract the connection string from the INI file
                _connectionString = data["DatabaseConfig"]["ConnectionString"];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading INI file: {ex.Message}");
            }
        }
        #endregion

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