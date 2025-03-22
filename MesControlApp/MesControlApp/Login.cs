using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MesControlApp;

namespace Media_Device_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void phonenumtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phoneNumber = phonenumtxt.Text.Trim();
            string password = passtxt.Text.Trim();

            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both phone number and password.");
                return;
            }

            try
            {
                DatabaseConnection.Connect();
                string query = "SELECT UserID, User_Role, User_fullname FROM Users WHERE User_Phone_Num = @PhoneNumber AND User_Pass = @Password";

                using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Session.userID = reader.GetInt32(0);
                            Session.role = reader.GetString(1);
                            Session.name = reader.GetString(2);

                            if (Session.role == "Admin")
                            {
                                this.Hide();
                                Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
                                admin_Dashboard.Show();
                            }
                            else
                            {
                                this.Hide();
                                Main_dashboard main_Dashboard = new Main_dashboard();
                                main_Dashboard.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid phone number or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message);
            }
            finally
            {
                DatabaseConnection.CloseConnect();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Logintxt_Click(object sender, EventArgs e)
        {

        }
    }
}