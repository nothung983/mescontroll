using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using Media_Device_Management;

namespace MesControlApp
{
    public partial class DeviceList : Form
    {
        public DeviceList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Session.userID == 0)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
            LoadData("", cboType.SelectedItem?.ToString(), cboStatus.SelectedItem?.ToString()); // Hiển thị toàn bộ dữ liệu khi mở form

            //DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            //btnColumn.HeaderText = "Action";
            //btnColumn.Text = "Book";
            //btnColumn.Name = "btnBook";
            //btnColumn.UseColumnTextForButtonValue = true;
            //dgvDevice.Columns.Add(btnColumn);

        }

        private void LoadData(string searchWord, string selectedType, string selectedStatus)
        {
            if (string.IsNullOrWhiteSpace(searchWord))
                searchWord = "%"; // Nếu không có từ khóa, lấy tất cả

            string query = @"
            SELECT * FROM (
                SELECT 
                    c.CameraID AS ID, 
                    c.Camera_Name AS Device_Name, 
                    'Camera' AS Device_Type, 
                    b.Brand_Name, 
                    u.User_Fullname AS Owner_Name, 
                    c.Booking_Status, 
                    c.CreatedAt
                FROM Cameras c
                LEFT JOIN Brands b ON c.Camera_Brand = b.BrandID
                LEFT JOIN Users u ON c.OwnerID = u.UserID

                UNION ALL

                SELECT 
                    l.LensID, 
                    l.Lenses_Name AS Device_Name, 
                    'Lens' AS Device_Type, 
                    b.Brand_Name, 
                    u.User_Fullname AS Owner_Name, 
                    l.Booking_Status, 
                    l.CreatedAt
                FROM Lenses l
                LEFT JOIN Brands b ON l.Lenses_Brand = b.BrandID
                LEFT JOIN Users u ON l.OwnerID = u.UserID

                UNION ALL

                SELECT 
                    a.AccessoryID, 
                    a.Accessory_Name AS Device_Name, 
                    'Accessory' AS Device_Type, 
                    b.Brand_Name, 
                    u.User_Fullname AS Owner_Name, 
                    a.Booking_Status, 
                    a.CreatedAt
                FROM Accessories a
                LEFT JOIN Brands b ON a.Accessory_Brand = b.BrandID
                LEFT JOIN Users u ON a.OwnerID = u.UserID
            ) AS DeviceList
            WHERE Device_Name LIKE @SearchWord";

            // Dictionary để lưu các tham số SQL
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@SearchWord", "%" + searchWord + "%");

            if (!string.IsNullOrEmpty(selectedType) && selectedType != "All")
            {
                query += " AND Device_Type = @DeviceType";
                parameters.Add("@DeviceType", selectedType);
            }
            if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "All")
            {
                query += " AND Booking_Status = @BookingStatus";
                parameters.Add("@BookingStatus", selectedStatus);
            }

            try
            {
                DatabaseConnection.Connect();
                SqlDataAdapter da = new SqlDataAdapter(query, DatabaseConnection.GetConnection());

                // Gán tham số vào truy vấn
                foreach (var param in parameters)
                {
                    da.SelectCommand.Parameters.AddWithValue(param.Key, param.Value);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDevice.DataSource = dt;
                dgvDevice.Refresh();
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


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            LoadData(txtSearch.Text.Trim().ToString(), cboType.SelectedItem?.ToString(), cboStatus.SelectedItem?.ToString());

        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text.Trim().ToString(), cboType.SelectedItem?.ToString(), cboStatus.SelectedItem?.ToString());
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text.Trim().ToString(), cboType.SelectedItem?.ToString(), cboStatus.SelectedItem?.ToString());
        }

        private void dgvDevice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            BookingForm bk = new BookingForm();
            bk.ShowDialog();
        }

        private void btnReturnBooking_Click(object sender, EventArgs e)
        {
            ReturnBooking rk = new ReturnBooking();
            rk.ShowDialog();
            MessageBox.Show(Session.userID.ToString());
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
