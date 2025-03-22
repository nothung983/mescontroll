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
    public partial class BookingDetail : Form
    {
        private int bookingID;
        public BookingDetail(int bookingID)
        {
            InitializeComponent();
            this.bookingID = bookingID;
            LoadBookingDetails(bookingID);
        }

        private void LoadBookingDetails(int bookingID)
        {
            string query = @"SELECT 
                                u.User_fullname,
                                b.StartDate,
                                b.EndDate,
                                c.Camera_Name,
                                l.Lenses_Name,
                                a.Accessory_Name
                            FROM Bookings b
                            JOIN Users u ON b.UserID = u.UserID
                            LEFT JOIN Cameras c ON b.CameraID = c.CameraID
                            LEFT JOIN Lenses l ON b.LensID = l.LensID
                            LEFT JOIN Accessories a ON b.AccessoryID = a.AccessoryID
                            WHERE b.BookingID = @BookingID AND b.Booking_Status = 'Pending';";
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user_txt.Text = reader["User_fullname"].ToString();
                            cam_txt.Text = reader["Camera_Name"].ToString();
                            accessory_txt.Text = reader["Accessory_Name"].ToString();
                            lens_txt.Text = reader["Lenses_Name"].ToString();
                            startDate_txt.Text = reader["StartDate"].ToString();
                            endDate_txt.Text = reader["EndDate"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
