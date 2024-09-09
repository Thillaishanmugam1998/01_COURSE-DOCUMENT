using System;
using Npgsql;
using System.Data;

namespace SamplewebMVC.DataAccessLayer
{
    public class DAL
    {
        private string _connectionString = "Host=localhost;Username=postgres;Password=sar@123;Database=SampleDB";

        #region 01. EXECUTE_SCALAR:-
        public int ExecuteScalar(string query)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    try
                    {
                        int newId = (int)command.ExecuteScalar();
                        return newId;
                    }
                    catch (Exception ex)
                    {
                        // Log or handle exception
                        Console.WriteLine(ex.Message);
                        return -1;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        #endregion

        #region 02. EXECUTE_NON_QUERY:-
        public int ExecuteNonQuery(string query)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    try
                    {
                        int affectedRows = command.ExecuteNonQuery();
                        return affectedRows;
                    }
                    catch (Exception ex)
                    {
                        // Log or handle exception
                        Console.WriteLine(ex.Message);
                        return -1;
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }
        #endregion

        #region 03. EXECUTE_READER:-
        public DataTable ExecuteReader(string query)
        {
            DataTable dataTable = new DataTable();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }
        #endregion
    }
}





