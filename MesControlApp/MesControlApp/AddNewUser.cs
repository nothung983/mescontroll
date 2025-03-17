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

namespace MesControlApp
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = user_name_txt.Text.Trim();
            string password = user_pass_txt.Text.Trim();
            string phoneNumber = user_phone_num.Text.Trim();
            string email = usr_email_txt.Text.Trim();
            string role = usr_role_cmb.SelectedItem.ToString();
            string imagePath = usr_image.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                DatabaseConnection.Connect();
                string query = @"
                        INSERT INTO Users (User_fullname, User_Pass, User_Phone_Num, User_Email, User_Role, User_Image) 
                        VALUES (@FullName, @Password, @PhoneNumber, @Email, @Role, @ImagePath)";
                using SqlCommand cmd = new SqlCommand(query, DatabaseConnection.connection);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(imagePath) ? DBNull.Value : imagePath);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }
    }
}
