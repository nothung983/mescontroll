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
using Media_Device_Management;

namespace MesControlApp
{
    public partial class User_Profile_Update : Form
    {
        public User_Profile_Update()
        {
            InitializeComponent();
            // Lấy userID từ Session
            if (Session.userID == 0)
            {
                MessageBox.Show("No user is logged in! Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                LoadUserInfo();
            }
        }

        private void LoadUserInfo()
        {
            try
            {
                // Fill the fields with session data
                usr_name_txt.Text = Session.name;
                usr_phone_txt.Text = Session.phoneNumber;
                usr_email_txt.Text = Session.email;

                // Load user image if available
                if (!string.IsNullOrEmpty(Session.imagePath))
                {
                    usr_img_box.Image = Image.FromFile(Session.imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void savenewinfo_btn_Click(object sender, EventArgs e)
        {
            
            string query = "UPDATE Users SET User_fullname = @User_fullname, User_Phone_Num = @User_Phone_Num, User_Email = @User_Email, User_Image = @User_Image WHERE UserID = @UserID";

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    if (connection.State == ConnectionState.Open)
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            string newFullName = usr_name_txt.Text;
                            string newPhoneNumber = usr_phone_txt.Text;
                            string newEmail = usr_email_txt.Text;
                            string newImagePath = Session.imagePath;

                            cmd.Parameters.AddWithValue("@User_fullname", newFullName);
                            cmd.Parameters.AddWithValue("@User_Phone_Num", newPhoneNumber);
                            cmd.Parameters.AddWithValue("@User_Email", newEmail);
                            cmd.Parameters.AddWithValue("@User_Image", newImagePath);
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
                MessageBox.Show("Error updating user details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Session.imagePath = openFileDialog.FileName;
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