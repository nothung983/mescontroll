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
    public partial class BookingLists : Form
    {
        public BookingLists()
        {
            InitializeComponent();

            if (!DatabaseConnection.Connect())
            {
                MessageBox.Show("Failed to connect to the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadBookingsLists();
        }

        private void LoadBookingsLists()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = @"
                        SELECT B.BookingID, C.Camera_Name, A.Accessory_Name, L.Lenses_name, 
                               B.StartDate, B.EndDate, U.User_fullname
                        FROM Bookings B 
                        LEFT JOIN Cameras C ON B.CameraID = C.CameraID
                        LEFT JOIN Accessories A ON B.AccessoryID = A.AccessoryID
                        LEFT JOIN Lenses L ON B.LensID = L.LensID 
                        LEFT JOIN Users U ON B.UserID = U.UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        BookingListGridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
