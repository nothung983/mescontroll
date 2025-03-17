using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace MesControlApp
{
    public partial class Edit_User_for_Admin : Form
    {
        private int userId; // Store user ID

        public Edit_User_for_Admin(int userId, string username, string email)
        {
            InitializeComponent();
            this.userId = userId;

            user_name_txt.Text = username;
            usr_email_txt.Text = email;

            LoadUserData(); // Load additional user details if needed
        }

        private void LoadUserData()
        {
            if (!DatabaseConnection.Connect())
            {
                MessageBox.Show("Database connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT phone_number, password, role FROM Users WHERE user_id = @userId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        user_phone_txt.Text = reader["phone_number"].ToString();
                        user_pass_txt.Text = reader["password"].ToString();
                        retype_pass_txt.Text = reader["password"].ToString();
                        usr_role_cmb.SelectedItem = reader["role"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SavesBtn_Click(object sender, EventArgs e)
        {
            if (user_pass_txt.Text != retype_pass_txt.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DatabaseConnection.Connect())
            {
                MessageBox.Show("Database connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"UPDATE Users SET username = @username, email = @email, phone_number = @phone, 
                                    password = @password, role = @role WHERE user_id = @userId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user_name_txt.Text);
                cmd.Parameters.AddWithValue("@email", usr_email_txt.Text);
                cmd.Parameters.AddWithValue("@phone", user_phone_txt.Text);
                cmd.Parameters.AddWithValue("@password", user_pass_txt.Text);
                cmd.Parameters.AddWithValue("@role", usr_role_cmb.SelectedItem?.ToString() ?? "User");
                cmd.Parameters.AddWithValue("@userId", userId);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Close the form after saving
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
