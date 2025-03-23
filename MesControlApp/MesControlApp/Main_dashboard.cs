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
using Media_Device_Management;
using MesControlApp;
using System.Collections;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Media_Device_Management
{
    public partial class Main_dashboard : Form
    {
        public Main_dashboard()
        {
            InitializeComponent();
            User_RecentBooking();
            TotalDevicesUserload();
            welcome_usr_load();
            TotalPendingBooking();
            TotalUserBooking();
        }

        private void welcome_usr_load()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed) connection.Open();
                string query = "SELECT User_fullname FROM Users WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", Session.userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            welcome_lb.Text = "Hello, " + reader.GetString(0) + "\nWelcome to Media Devices Management App";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void User_RecentBooking()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed) connection.Open();
                string query = @"
                        SELECT TOP 10 C.Camera_Name as 'Camera', A.Accessory_Name as 'Accessory', L.Lenses_name as 'Lens', 
                               B.StartDate as 'Start Date', B.EndDate as 'End Date', B.Booking_Status as 'Status'
                        FROM Bookings B 
                        LEFT JOIN Cameras C ON B.CameraID = C.CameraID
                        LEFT JOIN Accessories A ON B.AccessoryID = A.AccessoryID
                        LEFT JOIN Lenses L ON B.LensID = L.LensID 
                        WHERE B.UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", Session.userID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        recentbook_GridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalDevicesUserload()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed) connection.Open();
                string query = @"SELECT 
                (SELECT COUNT(*) FROM Cameras WHERE OwnerID = @UserID) +
                (SELECT COUNT(*) FROM Lenses WHERE OwnerID = @UserID) +
                (SELECT COUNT(*) FROM Accessories WHERE OwnerID = @UserID) AS Devices ;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", Session.userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            total_usr_devices_txt.Text = "Your Devices: " + reader.GetInt32(0).ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalPendingBooking()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed) connection.Open();
                string query = "SELECT COUNT(*) FROM Bookings WHERE Booking_Status = 'Pending' and UserID = @UserID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", Session.userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usr_total_pend_txt.Text = "Pending Bookings: " + reader.GetInt32(0).ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalUserBooking()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed) connection.Open();
                string query = "SELECT COUNT(*) FROM Bookings WHERE UserID = @UserID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", Session.userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            total_usr_book_txt.Text = "Your Bookings: " + reader.GetInt32(0).ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_dashboard_Load(object sender, EventArgs e)
        {

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

        private void home_menu_Click_1(object sender, EventArgs e)
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
