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
using Microsoft.VisualBasic.ApplicationServices;

namespace MesControlApp
{
    public partial class Pending_BookingLists : Form
    {
        public Pending_BookingLists()
        {
            InitializeComponent();

            if (!DatabaseConnection.Connect())
            {
                MessageBox.Show("Failed to connect to the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Session.userID == 0)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                LoadPendingBookings();
                AddDetailButton();
            }
        }

        private void LoadPendingBookings()
        {
            try
            {
                if (!DatabaseConnection.Connect())
                {
                    MessageBox.Show("Database connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Database connection is null.");
                    }

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = Session.role == "Admin" ?
                        @"SELECT B.BookingID, C.Camera_Name, A.Accessory_Name, L.Lenses_name, B.StartDate, B.EndDate, U.User_fullname
                              FROM Bookings B 
                              LEFT JOIN Cameras C ON B.CameraID = C.CameraID
                              LEFT JOIN Accessories A ON B.AccessoryID = A.AccessoryID
                              LEFT JOIN Lenses L ON B.LensID = L.LensID 
                              LEFT JOIN Users U ON B.UserID = U.UserID
                              WHERE B.Booking_Status = 'Pending'" :

                                    @"SELECT B.BookingID, C.Camera_Name, A.Accessory_Name, L.Lenses_name, B.StartDate, B.EndDate
                              FROM Bookings B 
                              LEFT JOIN Cameras C ON B.CameraID = C.CameraID
                              LEFT JOIN Accessories A ON B.AccessoryID = A.AccessoryID
                              LEFT JOIN Lenses L ON B.LensID = L.LensID
                              WHERE B.Booking_Status = 'Pending' AND B.UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (Session.role != "Admin")
                        {
                            cmd.Parameters.AddWithValue("@UserID", Session.userID);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            PendingBookingGridView.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending bookings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //  Add Detail button to each row
        private void AddDetailButton()
        {
            if (PendingBookingGridView.Columns["Detail"] == null)
            {
                DataGridViewButtonColumn detailButton = new DataGridViewButtonColumn();
                detailButton.Name = "Detail";
                detailButton.HeaderText = "Details";
                detailButton.Text = "View Details";
                detailButton.UseColumnTextForButtonValue = true;
                PendingBookingGridView.Columns.Add(detailButton);
            }

            PendingBookingGridView.CellClick += PendingBookingGridView_CellClick;
        }

        // Handle Detail button click
        private void PendingBookingGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == PendingBookingGridView.Columns["Detail"].Index && e.RowIndex >= 0)
            {
                int bookingID = Convert.ToInt32(PendingBookingGridView.Rows[e.RowIndex].Cells["BookingID"].Value);
                ShowBookingDetails(bookingID);
            }
        }

        // Show Booking Details
        private void ShowBookingDetails(int bookingID)
        {
            BookingDetail detailsForm = new BookingDetail(bookingID);
            detailsForm.ShowDialog();
        }

        // menu click events

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

        private void allDevices_MenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeviceList deviceList = new DeviceList();
            deviceList.Show();
        }

        private void pendingBooking_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pending_BookingLists pendingBooking = new Pending_BookingLists();
            pendingBooking.Show();

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

        private void allBooking_menu_Click(object sender, EventArgs e)
        {

            this.Hide();
            BookingLists bookingList = new BookingLists();
            bookingList.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(Session.role == "Admin")
            {
                Admin_Dashboard adminDashboard = new Admin_Dashboard();
                adminDashboard.Show();
            }
            else
            {
                Main_dashboard maindashboard = new Main_dashboard();
                maindashboard.Show();
            }
        }
    }
}
