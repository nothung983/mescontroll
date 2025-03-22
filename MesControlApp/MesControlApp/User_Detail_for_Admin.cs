using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Media_Device_Management;
using Microsoft.Data.SqlClient;

namespace MesControlApp
{
    public partial class User_Detail_for_Admin : Form
    {

        public User_Detail_for_Admin(int userId)
        {
            InitializeComponent();
            LoadUserDetails(userId);
        }

        private void LoadUserDetails(int userId)
        {
            string query = "SELECT User_Fullname, User_Email, User_Phone_Num, User_Pass, User_Role, User_Image FROM Users WHERE UserID = @UserID";

            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user_name_txt.Text = reader.GetString(0);
                            usr_email_txt.Text = reader.GetString(1);
                            usr_phone_txt.Text = reader.GetString(2);
                            usr_pass.Text = reader.GetString(3);
                            user_role_txt.Text = reader.GetString(4);
                            user_image.Image = reader.IsDBNull(5) ? null : Image.FromFile(Path.Combine(@"D:\NAM IV\.NET\PROJECT\mescontroll\MesControlApp\MesControlApp\assets\users", reader.GetString(5)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
