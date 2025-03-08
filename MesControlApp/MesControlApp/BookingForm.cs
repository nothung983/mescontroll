using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Media_Device_Management;

namespace MesControlApp
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        DataTable getAvailableDevice(string table, string deviceID, string deviceName)
        {
            DatabaseConnection.Connect();
            string query = $@"select {deviceID}, {deviceName} from {table} where Booking_Status <> 'Under Maintenance'";
            SqlDataAdapter ad = new SqlDataAdapter(query, DatabaseConnection.connection);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        void BookingDevice(int userID, int? CameraID, int? LensID, int? AccessoryID, DateTime startDate, DateTime endDate)
        {
            string query = @"
            INSERT INTO Bookings (UserID, CameraID, LensID, AccessoryID, StartDate, EndDate, Booking_Status) 
            VALUES (@UserID, @CameraID, @LensID, @AccessoryID, @StartDate, @EndDate, 'Pending')";

            DatabaseConnection.Connect();
            SqlCommand sql = new SqlCommand(query, DatabaseConnection.connection);
            sql.Parameters.AddWithValue("@UserID", userID);
            sql.Parameters.AddWithValue("@CameraID", (object)CameraID ?? DBNull.Value);
            sql.Parameters.AddWithValue("@LensID", (object)LensID ?? DBNull.Value);
            sql.Parameters.AddWithValue("@AccessoryID", (object)AccessoryID ?? DBNull.Value);
            sql.Parameters.AddWithValue("@StartDate", startDate);
            sql.Parameters.AddWithValue("@endDate", endDate);

            sql.ExecuteNonQuery();
            DatabaseConnection.CloseConnect();
        }
        private void BookingForm_Load(object sender, EventArgs e)
        {
            if (Session.userID == 0)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
                return;
            }
            txtUsrID.Text = Session.userID.ToString();
            //fill cbo
            DataTable cameras = getAvailableDevice("Cameras", "CameraID", "Camera_Name");
            DataRow camRow = cameras.NewRow();
            camRow["CameraID"] = DBNull.Value;
            camRow["Camera_Name"] = "-- Không chọn --";
            cameras.Rows.InsertAt(camRow, 0);
            cboCam.DataSource = cameras;
            cboCam.ValueMember = "CameraID";
            cboCam.DisplayMember = "Camera_Name";
            DataTable lenses = getAvailableDevice("Lenses", "LensID", "Lenses_Name");
            DataRow lenseRow = lenses.NewRow();
            lenseRow["LensID"] = DBNull.Value;
            lenseRow["Lenses_Name"] = "-- Không chọn --";
            lenses.Rows.InsertAt(lenseRow, 0);
            cboLens.DataSource = lenses;
            cboLens.ValueMember = "LensID";
            cboLens.DisplayMember = "Lenses_Name";
            DataTable accessories = getAvailableDevice("Accessories", "AccessoryID", "Accessory_Name");
            DataRow accessoryRow = accessories.NewRow();
            accessoryRow["AccessoryID"] = DBNull.Value;
            accessoryRow["Accessory_Name"] = "-- Không chọn --";
            accessories.Rows.InsertAt(accessoryRow, 0);
            cboAcc.DataSource = accessories;
            cboAcc.ValueMember = "AccessoryID";
            cboAcc.DisplayMember = "Accessory_Name";

        }
        bool IsDeviceAvailableAtTime(string columnID, int deviceID, DateTime start, DateTime end)
        {
            DatabaseConnection.Connect();
            string query = $@"SELECT COUNT(*) FROM Bookings 
                            WHERE {columnID}  = @DeviceID
                            AND Booking_Status = 'Approved'
                            AND (StartDate <= @EndDate AND EndDate >= @StartDate)";
            SqlCommand sql = new SqlCommand(query, DatabaseConnection.connection);
            sql.Parameters.AddWithValue("@DeviceID", deviceID);
            sql.Parameters.AddWithValue("@EndDate", end);
            sql.Parameters.AddWithValue("@StartDate", start);
            int count = (int)sql.ExecuteScalar();
            DatabaseConnection.CloseConnect();
            return count == 0;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUsrID.Text);
            int? cameraID = (cboCam.SelectedValue == DBNull.Value) ? (int?)null : Convert.ToInt32(cboCam.SelectedValue);
            int? lensID = (cboLens.SelectedValue == DBNull.Value) ? (int?)null : Convert.ToInt32(cboLens.SelectedValue);
            int? accID = (cboAcc.SelectedValue == DBNull.Value) ? (int?)null : Convert.ToInt32(cboAcc.SelectedValue);
            DateTime start = startDate.Value;
            DateTime end = endDate.Value;
            if (start > end)
            {
                MessageBox.Show("Start time must smaller than End time", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (start < DateTime.Now)
            {
                MessageBox.Show("The booking time must be after the current date.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (start == end)
            {
                MessageBox.Show("Need Booking more than 1 day", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cameraID.HasValue && !IsDeviceAvailableAtTime("CameraID", cameraID.Value, start, end )) 
            {
                MessageBox.Show("This camera already booked on that day!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lensID.HasValue && !IsDeviceAvailableAtTime("LensID", lensID.Value, start, end))
            {
                MessageBox.Show("This lens already booked on that day!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (accID.HasValue && !IsDeviceAvailableAtTime("AccessoryID", accID.Value, start, end))
            {
                MessageBox.Show("This accessory already booked on that day!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            BookingDevice(id, cameraID, lensID,accID,start,end);
            MessageBox.Show("Booked Success. Wait for Approve", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
    }
}
