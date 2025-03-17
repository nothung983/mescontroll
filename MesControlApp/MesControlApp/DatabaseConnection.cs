using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace MesControlApp
{
    internal class DatabaseConnection
    {
        public static SqlConnection connection;

        public static bool Connect()
        {
            try
            {
                if (connection == null)
                {
                    string connectionString = "Data Source=DANGHUNG_LAPTOP\\MSSQLSERVER2022;Initial Catalog=mediaz_db;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True";
                    connection = new SqlConnection(connectionString);
                }

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection error: " + ex.Message);
                return false;
            }
        }

        public static bool CloseConnect()
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing connection: " + ex.Message);
                return false;
            }
        }

        public static SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
