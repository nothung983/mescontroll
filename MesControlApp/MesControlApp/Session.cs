using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesControlApp
{
    internal static class Session
    {
        public static int userID { get; set; }
        public static string role { get; set; } 
        public static string name { get; set; }

        public static void Logout()
        {
            userID = 0;
            role = string.Empty;
            name = string.Empty;
        }
    }
}
