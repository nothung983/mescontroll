using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MesControlApp
{
    internal class DatabaseConnection
    {

        public static SqlConnection connection;

        public static bool Connect()
        {
            try
            {
                connection = new SqlConnection("Data Source=DESKTOP-HT3APFQ\\SQLEXPRESS;Initial Catalog=mediaz_db;User ID=sa;Password=123456;");
                connection.Open();
                
            }
            catch (Exception ex) 
            {
                return false;
            }
            return true;
        }

        public static bool CloseConnect()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
