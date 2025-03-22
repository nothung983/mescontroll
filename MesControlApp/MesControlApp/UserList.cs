using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Media_Device_Management;
using Microsoft.Data.SqlClient;

namespace MesControlApp
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "SELECT UserID, User_Fullname, User_Phone_Num, User_Email, User_Role FROM Users";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridViewUsers.DataSource = dt;

                            // Add View Details button column
                            if (!dataGridViewUsers.Columns.Contains("ViewDetails"))
                            {
                                DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn();
                                viewButton.Name = "ViewDetails";
                                viewButton.HeaderText = "View";
                                viewButton.Text = "View";
                                viewButton.UseColumnTextForButtonValue = true;
                                dataGridViewUsers.Columns.Add(viewButton);
                            }

                            // Add Delete button column
                            if (!dataGridViewUsers.Columns.Contains("DeleteUser"))
                            {
                                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                                deleteButton.Name = "DeleteUser";
                                deleteButton.HeaderText = "Delete";
                                deleteButton.Text = "Delete";
                                deleteButton.UseColumnTextForButtonValue = true;
                                dataGridViewUsers.Columns.Add(deleteButton);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["UserID"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this user?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteUser(userId);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE FROM Users WHERE UserID = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers(); // Refresh the user list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["UserID"].Value);
                string username = dataGridViewUsers.SelectedRows[0].Cells["User_Fullname"].Value?.ToString() ?? string.Empty;
                string email = dataGridViewUsers.SelectedRows[0].Cells["User_Email"].Value?.ToString() ?? string.Empty;

                // Open the Edit_User_for_Admin form and pass user details
                Edit_User_for_Admin editForm = new Edit_User_for_Admin(userId, username, email);
                editForm.ShowDialog();

                LoadUsers(); // Refresh the user list after editing
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the User ID from the selected row
                int userId = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells["UserID"].Value);

                // Check if View Details button was clicked
                if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "ViewDetails")
                {
                    // Open User Detail form
                    User_Detail_for_Admin userDetailForm = new User_Detail_for_Admin(userId);
                    userDetailForm.Show();
                    userDetailForm.Show();
                }
                // Check if Delete button was clicked
                else if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "DeleteUser")
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this user?", "Confirm Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DeleteUser(userId);
                    }
                }
            }
        }


        //private string GetUserPhone(object userId)
        //{
        //    string phone = "";
        //    try
        //    {
        //        using (SqlConnection conn = DatabaseConnection.GetConnection())
        //        {
        //            string query = "SELECT User_Phone_Num FROM Users WHERE UserID = @UserId";
        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@UserId", userId);
        //                object result = cmd.ExecuteScalar();
        //                if (result != null)
        //                {
        //                    phone = result.ToString();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error retrieving phone number: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return phone;
        //}

        //private string GetUserPassword(object userId)
        //{
        //    string password = "";
        //    try
        //    {
        //        using (SqlConnection conn = DatabaseConnection.GetConnection())
        //        {
        //            string query = "SELECT User_Pass FROM Users WHERE UserID = @UserId";
        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@UserId", userId);
        //                object result = cmd.ExecuteScalar();
        //                if (result != null)
        //                {
        //                    password = result.ToString();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error retrieving password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return password;
        //}

        //private string GetUserRole(object userId)
        //{
        //    string role = "User";
        //    try
        //    {
        //        using (SqlConnection conn = DatabaseConnection.GetConnection())
        //        {
        //            string query = "SELECT User_Role FROM Users WHERE UserID = @UserId";
        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@UserId", userId);
        //                object result = cmd.ExecuteScalar();
        //                if (result != null)
        //                {
        //                    role = result.ToString();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error retrieving role: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return role;
        //}

        private void new_user_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewUser addNewUser = new AddNewUser();
            addNewUser.ShowDialog();
        }



        //menu click events
        private void logOut_menu_Click(object sender, EventArgs e)
        {
            Logout logout = new Logout();
        }

        private void myAccount_menu_Click(object sender, EventArgs e)
        {
            // Open user profile window
            this.Hide();
            User_Profile user_Profile = new User_Profile();
            user_Profile.Show();
        }

        private void myDevice_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mydevice myDevices = new mydevice();
            myDevices.Show();
        }

        private void mybooking_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            myBooking myBooking = new myBooking();
            myBooking.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeviceList deviceList = new DeviceList();
            deviceList.Show();
        }

        private void userLists_menu_Click(object sender, EventArgs e)
        {
            if (Session.role != "Admin")
            {
                MessageBox.Show("You do not have permission to access this page", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.Hide();
                UserList userList = new UserList();
                userList.Show();
            }

        }

        private void home_menu_Click(object sender, EventArgs e)
        {
            if (Session.role != "Admin")
            {
                this.Hide();
                Main_dashboard maindashboard = new Main_dashboard();
                maindashboard.Show();
            }
            else
            {
                this.Hide();
                Admin_Dashboard adminDashboard = new Admin_Dashboard();
                adminDashboard.Show();
            }

        }

        private void allBooking_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingLists bookingList = new BookingLists();
            bookingList.Show();
        }

        private void pendingBooking_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pending_BookingLists pendingBooking = new Pending_BookingLists();
            pendingBooking.Show();
        }
    }
}
