using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using Media_Device_Management;

namespace MesControlApp
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
            LoadTotalUsers();
            LoadTotalDevices();
            LoadTotalBookings();
            LoadTotalBrands();
            LoadLatestBooking();
        }

        private void LoadTotalUsers()
        { 
            string query = "SELECT COUNT(*) FROM Users";
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            total_usr_lb.Text = "Total Users: " + reader.GetInt32(0).ToString();
                        }
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
                string query = @"SELECT 
                (SELECT COUNT(*) FROM Cameras) +
                (SELECT COUNT(*) FROM Lenses) +
                (SELECT COUNT(*) FROM Accessories) AS Devices;";
                SqlConnection connection = DatabaseConnection.GetConnection();
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            total_dev_lb.Text = "Total Devices: " + reader.GetInt32(0).ToString();
                        }
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
            SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "SELECT COUNT(*) FROM Bookings";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }   
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            total_booking_lb.Text = "Total Bookings: " + reader.GetInt32(0).ToString();
                        }
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
            SqlConnection connection = DatabaseConnection.GetConnection();
            string query = "SELECT COUNT(*) FROM Brands";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            total_brands_lb.Text = "Total Brands: " + reader.GetInt32(0).ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadLatestBooking()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed) connection.Open();

                string query = @"
                      SELECT TOP 10 U.User_fullname AS 'User', 
                      C.Camera_Name AS 'Camera', 
                      B.StartDate, B.EndDate
                      FROM Bookings B
                      JOIN Users U ON B.UserID = U.UserID
                      LEFT JOIN Cameras C ON B.CameraID = C.CameraID
                      ORDER BY B.StartDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        latest_book_DataGridView.DataSource = dt;
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
