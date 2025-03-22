using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace MesControlApp
{
    internal class DatabaseConnection
    {
        private static SqlConnection connection;

        private static readonly string connectionString =
            "Data Source=DANGHUNG_LAPTOP\\MSSQLSERVER2022;Initial Catalog=mediaz_db;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True";

        public static bool Connect()
        {
            try
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                }
                else if (string.IsNullOrWhiteSpace(connection.ConnectionString))
                {
                    connection.ConnectionString = connectionString;
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
                if (connection != null && connection.State != ConnectionState.Closed)
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
            if (connection == null || string.IsNullOrWhiteSpace(connection.ConnectionString))
            {
                Connect();
            }

            return connection;
        }
    }
}