using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Media_Device_Management;
using System.Threading.Tasks;

namespace MesControlApp
{
    internal class Logout
    {
        public Logout()
        {
            UserLogout();
        }

        private void UserLogout()
        {
            // Clear all session data
            ClearSession();

            // Redirect to Login
            RedirectToLogin();
        }

        private void ClearSession()
        {
            // Clear session data using Session class
            Session.Logout();
        }

        private void RedirectToLogin()
        {
            // Assuming this is a WinForms application
            System.Windows.Forms.Application.Restart();
        }
    }
}
