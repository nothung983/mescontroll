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
using System.Configuration;

namespace MesControlApp
{
    public partial class Detail_Pending : Form
    {
        private int bookingID;
        public Detail_Pending(int bookingID)
        {
            InitializeComponent();
            this.bookingID = bookingID;
            LoadBookingDetails();
        }

        //public void LoadBookingDetails()
        //{
        //    try
        //    {
        //        DatabaseConnection.Connect(); // Ensure connection is established
        //        using (SqlConnection conn = DatabaseConnection.GetConnection())
        //        {
        //            if (conn.State == ConnectionState.Closed)
        //            {
        //                conn.Open();
        //            }
        //            //        string query = @"SELECT 
        //            //                            u.User_fullname,
        //            //                            b.StartDate,
        //            //                            b.EndDate,
        //            //                            c.Camera_Name,
        //            //                            l.Lenses_Name,
        //            //                            a.Accessory_Name,
        //            //                            r.Request_content
        //            //                        FROM Bookings b
        //            //                        JOIN Users u ON b.UserID = u.UserID
        //            //                        LEFT JOIN Cameras c ON b.CameraID = c.CameraID
        //            //                        LEFT JOIN Lenses l ON b.LensID = l.LensID
        //            //                        LEFT JOIN Accessories a ON b.AccessoryID = a.AccessoryID
        //            //                        LEFT JOIN Requests r ON r.UserID = b.UserID
        //            //                        WHERE b.Booking_Status = 'Pending';";
        //            //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //            //        {
        //            //            cmd.Parameters.AddWithValue("@BookingID", bookingID);
        //            //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            //            {
        //            //                if (reader.Read())
        //            //                {
        //            //                    user_txt.Text = reader["User_fullname"].ToString();
        //            //                    cam_txt.Text = reader["Camera_Name"].ToString();
        //            //                    accessory_txt.Text = reader["Accessory_Name"].ToString();
        //            //                    lens_txt.Text = reader["Lenses_name"].ToString();
        //            //                    startDate_txt.Text = reader["StartDate"].ToString();
        //            //                    endDate_txt.Text = reader["EndDate"].ToString();
        //            //                    reason_txt.Text = reader["Request_content"].ToString();
        //            //                }
        //            //            }
        //            //        }
        //            //    }
        //            //}
        //            string query = @"SELECT 
        //            u.User_fullname,
        //            b.StartDate,
        //            b.EndDate,
        //            c.Camera_Name,
        //            l.Lenses_Name,
        //            a.Accessory_Name,
        //            r.Request_content
        //        FROM Bookings b
        //        JOIN Users u ON b.UserID = u.UserID
        //        LEFT JOIN Cameras c ON b.CameraID = c.CameraID
        //        LEFT JOIN Lenses l ON b.LensID = l.LensID
        //        LEFT JOIN Accessories a ON b.AccessoryID = a.AccessoryID
        //        LEFT JOIN Requests r ON r.UserID = b.UserID
        //        WHERE b.BookingID = @BookingID AND b.Booking_Status = 'Pending';"; // Đã sửa BookingID

        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@BookingID", bookingID);
        //                using (SqlDataReader reader = cmd.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        user_txt.Text = reader["User_fullname"].ToString();
        //                        cam_txt.Text = reader["Camera_Name"].ToString();
        //                        accessory_txt.Text = reader["Accessory_Name"].ToString();
        //                        lens_txt.Text = reader["Lenses_Name"].ToString();
        //                        startDate_txt.Text = reader["StartDate"].ToString();
        //                        endDate_txt.Text = reader["EndDate"].ToString();
        //                        reason_txt.Text = reader["Request_content"].ToString();
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("No booking details found!");
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading booking details: " + ex.Message);
        //    }
        //}
        public void LoadBookingDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                u.User_fullname,
                                b.StartDate,
                                b.EndDate,
                                c.Camera_Name,
                                l.Lenses_Name,
                                a.Accessory_Name,
                                r.Request_content
                            FROM Bookings b
                            JOIN Users u ON b.UserID = u.UserID
                            LEFT JOIN Cameras c ON b.CameraID = c.CameraID
                            LEFT JOIN Lenses l ON b.LensID = l.LensID
                            LEFT JOIN Accessories a ON b.AccessoryID = a.AccessoryID
                            LEFT JOIN Requests r ON r.UserID = b.UserID
                            WHERE b.BookingID = @BookingID AND b.Booking_Status = 'Pending';";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
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
                                reason_txt.Text = reader["Request_content"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No booking details found!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking details: " + ex.Message);
            }
        }
        private void approve_Btn_Click(object sender, EventArgs e)
        {

        }

        private void reject_Btn_Click(object sender, EventArgs e)
        {

        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pending_BookingLists pending_Bookings = new Pending_BookingLists();
            pending_Bookings.Show();
        }
    }
}
