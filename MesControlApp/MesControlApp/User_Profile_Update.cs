using System;
using System.Windows.Forms;
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
    public partial class User_Profile_Update : Form
    {
        public User_Profile_Update()
        {
            InitializeComponent();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            try
            {
                // Fill the fields with session data
                usr_name_txt.Text = Session.name;
                usr_phone_txt.Text = Session.phoneNumber;
                usr_email_txt.Text = Session.email;

                if (!string.IsNullOrEmpty(Session.imagePath))
                {
                    usr_img_box.Image = Image.FromFile(Session.imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeInfo_Click(object sender, EventArgs e)
        {
            string newFullName = usr_name_txt.Text.Trim();
            string newPhoneNumber = usr_phone_txt.Text.Trim();
            string newEmail = usr_email_txt.Text.Trim();
            string newImagePath = Session.imagePath; // Keep the current image by default

            if (string.IsNullOrEmpty(newFullName) || string.IsNullOrEmpty(newPhoneNumber) || string.IsNullOrEmpty(newEmail))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "UPDATE Users SET User_fullname = @FullName, User_Phone_Num = @PhoneNumber, User_Email = @Email, User_Image = @Image WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FullName", newFullName);
                        cmd.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber);
                        cmd.Parameters.AddWithValue("@Email", newEmail);
                        cmd.Parameters.AddWithValue("@Image", newImagePath);
                        cmd.Parameters.AddWithValue("@UserID", Session.userID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Update session data
                            Session.name = newFullName;
                            Session.phoneNumber = newPhoneNumber;
                            Session.email = newEmail;
                            Session.imagePath = newImagePath;

                            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to user profile
                            this.Hide();
                            User_Profile userProfile = new User_Profile();
                            userProfile.Show();
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void user_imageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    usr_img_box.Image = Image.FromFile(openFileDialog.FileName);
                    Session.imagePath = openFileDialog.FileName; // Store the selected image path
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Add your event handling code here
        }



        //menu click events

        private void logOut_menu_Click(object sender, EventArgs e)
        {
            Logout logout = new Logout();
        }

        private void myAccount_menu_Click(object sender, EventArgs e)
        {
            string query = "SELECT UserID, User_Role, User_fullname, User_Phone_Num, User_Email, User_Image FROM Users WHERE UserID = @UserID";

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", Session.userID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Store user details in session
                                Session.userID = reader.GetInt32(0);
                                Session.role = reader.GetString(1);
                                Session.name = reader.GetString(2);
                                Session.phoneNumber = reader.GetString(3);
                                Session.email = reader.GetString(4);
                                Session.imagePath = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void allDevices_MenuItem_Click(object sender, EventArgs e)
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
            this.Hide();
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
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