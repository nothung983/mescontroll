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
            UpdateBookingStatus("Approved");
        }

        private void reject_Btn_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("Rejected");
        }

        private void UpdateBookingStatus(string status)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {

                    string query = "UPDATE Bookings SET Booking_Status = @Status, AdminApprovalID = @AdminID WHERE BookingID = @BookingID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@AdminID", Session.userID);
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Booking {status} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update booking status. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pending_BookingLists pending_Bookings = new Pending_BookingLists();
            pending_Bookings.Show();
        }
    }
}
