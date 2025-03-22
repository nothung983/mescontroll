using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using Media_Device_Management;

namespace MesControlApp
{
    public partial class Admin_Dashboard : Form
    {
        private DatabaseConnection conn = new DatabaseConnection();

        public Admin_Dashboard()
        {
            InitializeComponent();
            //Latest_Req_Load();
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

                        total_usr_lb.Text = $"Total Users: {totalUsers}";
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
        private void Latest_Req_Load()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT TOP 10  r.RequestID, u.User_fullname, r.DeviceType, r.Request_content, r.CreatedAt 
                                    FROM Requests r JOIN Users u ON r.UserID = u.UserID ORDER BY r.CreatedAt DESC;";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                       using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                       {
                          DataTable dt = new DataTable();
                          adapter.Fill(dt);
                          latest_req.DataSource = dt;
                       }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //menu click events
        private void total_usr_lb_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserList userList = new UserList();
            userList.Show();
        }

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
