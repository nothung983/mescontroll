using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace MesControlApp
{
    public partial class Admin_Dashboard : Form
    {
        private DatabaseConnection conn = new DatabaseConnection();

        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void LoadTotalUsers()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int totalUsers = (int)cmd.ExecuteScalar();

                        MessageBox.Show("Total Users Count: " + totalUsers.ToString(), "Debug Info");

                        total_usr_lb.Text = "Total Users: " + totalUsers.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTotalDevices()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Devices";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int totalDevices = (int)cmd.ExecuteScalar();
                        total_dev_lb.Text = "Total Devices: " + totalDevices.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTotalBookings()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Bookings";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int totalBookings = (int)cmd.ExecuteScalar();
                        total_booking_lb.Text = "Total Bookings: " + totalBookings.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTotalBrands()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Brands";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int totalBrands = (int)cmd.ExecuteScalar();
                        total_brands_lb.Text = "Total Brands: " + totalBrands.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            LoadTotalUsers();
            LoadTotalDevices();
            LoadTotalBookings();
            LoadTotalBrands();
            LoadTotalUsersOnLoad();
        }

        private void LoadTotalUsersOnLoad()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int totalUsers = (int)cmd.ExecuteScalar();

                        MessageBox.Show("Total Users Count: " + totalUsers.ToString(), "Debug Info");

                        total_usr_lb.Text = "Total Users: " + totalUsers.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void total_usr_lb_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserList userList = new UserList();
            userList.Show();
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
