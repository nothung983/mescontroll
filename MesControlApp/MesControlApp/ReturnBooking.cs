using Media_Device_Management;
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

namespace MesControlApp
{
    public partial class ReturnBooking : Form
    {
        public ReturnBooking()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Xử lý khi nhấn vào label1 (hoặc để trống nếu không cần)
        }
        private void ReturnBooking_Load(object sender, EventArgs e)

        {

            if (Session.userID == 0)
            {
                MessageBox.Show("Bạn cần đăng nhập để xem thông tin đặt thiết bị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                Login login = new Login();
                login.Show();
                return;
            }

            LoadData(Session.userID);
            
        }
        private void LoadData(int loggedInUserId)
        {
            string query = @"
                SELECT * FROM (
                    SELECT 
                        c.CameraID AS ID, 
                        c.Camera_Name AS Device_Name, 
                        'Camera' AS Device_Type, 
                        b.Brand_Name, 
                        bk.StartDate, 
                        bk.EndDate,
                        bk.Booking_Status
                    FROM Bookings bk
                    INNER JOIN Cameras c ON bk.CameraID = c.CameraID
                    LEFT JOIN Brands b ON c.Camera_Brand = b.BrandID
                    WHERE bk.UserID = @UserID AND bk.Booking_Status != 'Returned'
        
                    UNION ALL
        
                    SELECT 
                        l.LensID, 
                        l.Lenses_Name AS Device_Name, 
                        'Lens' AS Device_Type, 
                        b.Brand_Name, 
                        bk.StartDate, 
                        bk.EndDate,
                        bk.Booking_Status
                    FROM Bookings bk
                    INNER JOIN Lenses l ON bk.LensID = l.LensID
                    LEFT JOIN Brands b ON l.Lenses_Brand = b.BrandID
                    WHERE bk.UserID = @UserID AND bk.Booking_Status != 'Returned'
        
                    UNION ALL
        
                    SELECT 
                        a.AccessoryID, 
                        a.Accessory_Name AS Device_Name, 
                        'Accessory' AS Device_Type, 
                        b.Brand_Name, 
                        bk.StartDate, 
                        bk.EndDate,
                        bk.Booking_Status
                    FROM Bookings bk
                    INNER JOIN Accessories a ON bk.AccessoryID = a.AccessoryID
                    LEFT JOIN Brands b ON a.Accessory_Brand = b.BrandID
                    WHERE bk.UserID = @UserID AND bk.Booking_Status != 'Returned'
                ) AS DeviceList";

            try
            {
                DatabaseConnection.Connect();
                SqlDataAdapter da = new SqlDataAdapter(query, DatabaseConnection.connection);
                da.SelectCommand.Parameters.AddWithValue("@UserID", loggedInUserId);

                DataTable dta = new DataTable();
                da.Fill(dta);
                dgvMyBooking.DataSource = dta;
                dgvMyBooking.Refresh();
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Action";
                btnColumn.Text = "Return";
                btnColumn.Name = "btnReturn";
                btnColumn.UseColumnTextForButtonValue = true;
                dgvMyBooking.Columns.Add(btnColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                DatabaseConnection.CloseConnect();
            }
        }


        private void dgvMyBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMyBooking.Columns["btnReturn"].Index && e.RowIndex >= 0)
            {
                // Lấy thông tin hàng được chọn
                int bookingID = Convert.ToInt32(dgvMyBooking.Rows[e.RowIndex].Cells["ID"].Value);
                string deviceType = dgvMyBooking.Rows[e.RowIndex].Cells["Device_Type"].Value.ToString();

                if (ReturnDevice(bookingID, deviceType))
                {
                    MessageBox.Show($"{deviceType} của bạn đã được trả về!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(Session.userID); // Tải lại danh sách sau khi cập nhật
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi trả thiết bị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ReturnDevice(int bookingID, string deviceType)
        {
            string columnToUpdate = "";
            switch (deviceType)
            {
                case "Camera":
                    columnToUpdate = "CameraID";
                    break;
                case "Lens":
                    columnToUpdate = "LensID";
                    break;
                case "Accessory":
                    columnToUpdate = "AccessoryID";
                    break;
                default:
                    return false;
            }

            string query = $@"
                UPDATE Bookings 
                SET {columnToUpdate} = NULL
                WHERE {columnToUpdate} = @BookingID;
                DELETE FROM Bookings 
                WHERE CameraID IS NULL AND LensID IS NULL AND AccessoryID IS NULL;
                ";

            try
            {
                DatabaseConnection.Connect();
                SqlCommand cmd = new SqlCommand(query, DatabaseConnection.connection);
                cmd.Parameters.AddWithValue("@BookingID", bookingID);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                return false;
            }
            finally
            {
                DatabaseConnection.CloseConnect();
            }
        }



    }
}
