using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CampusResolve
{
    public class DatabaseHelper
    {
        // Adjust these to match your local MySQL configuration
        private static readonly string Server = "localhost";
        private static readonly string Database = "campus_resolve_db";
        private static readonly string User = "root";
        private static readonly string Password = "sudha"; // Change to your actual MySQL root password

        public static string GetConnectionString()
        {
            return $"Server={Server};Database={Database};Uid={User};Pwd={Password};";
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(GetConnectionString());
        }

        public static bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database Connection Error: {ex.Message}");
                return false;
            }
        }
        
        public static int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"DB Error ExecuteNonQuery: {ex.Message}");
                throw;
            }
        }

        public static DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"DB Error ExecuteQuery: {ex.Message}");
                throw;
            }
            return dt;
        }

        // Retrieves the last inserted ID, useful for getting auto-increment values
        public static int ExecuteScalar(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"DB Error ExecuteScalar: {ex.Message}");
                throw;
            }
        }
    }
}
