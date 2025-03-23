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

namespace MesControlApp
{
    public partial class mydevice : Form
    {
        private ContextMenuStrip contextMenuStrip;
        private bool isLeftClick;

        public mydevice()
        {
            InitializeComponent(); // Gọi phương thức từ Designer để khởi tạo giao diện

            // Thêm ContextMenuStrip cho listView1
            contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            deleteMenuItem.Click += DeleteMenuItem_Click;
            contextMenuStrip.Items.Add(deleteMenuItem);
            listView1.ContextMenuStrip = contextMenuStrip;

            // Điều chỉnh giao diện của các control từ Designer
            label1.Text = "My Devices";
            label1.Location = new Point(20, 10);
            label1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(44, 62, 80);

            listView1.Location = new Point(20, 40);
            listView1.Size = new Size(540, 250);
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            listView1.Columns.Clear();
            listView1.Columns.Add("Device Type", 100);
            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Brand", 100);
            listView1.Columns.Add("Booking Status", 120);

            btnAdd.Location = new Point(400, 300);
            btnAdd.Size = new Size(100, 35);
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnAdd.Text = "Add Device";

            // Thêm hiệu ứng hover cho nút Add
            btnAdd.MouseEnter += (s, e) => btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.MouseLeave += (s, e) => btnAdd.BackColor = Color.FromArgb(46, 204, 113);

            // Gắn sự kiện MouseDown và SelectedIndexChanged cho listView1
            listView1.MouseDown += (sender, e) => isLeftClick = e.Button == MouseButtons.Left;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;

            // Lấy userID từ Session
            if (Session.userID == 0)
            {
                MessageBox.Show("No user is logged in! Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                LoadDevices();
            }
        }

        private void LoadDevices()
        {
            try
            {
                listView1.Items.Clear();

                DatabaseConnection.Connect();

                // Lấy danh sách Cameras
                string cameraQuery = @"
                    SELECT c.CameraID, c.Camera_Name, b.Brand_Name, c.Booking_Status
                    FROM Cameras c
                    LEFT JOIN Brands b ON c.Camera_Brand = b.BrandID
                    WHERE c.OwnerID = @UserID";
                using (SqlCommand cameraCmd = new SqlCommand(cameraQuery, DatabaseConnection.GetConnection()))
                {
                    cameraCmd.Parameters.AddWithValue("@UserID", Session.userID);
                    using (SqlDataReader cameraReader = cameraCmd.ExecuteReader())
                    {
                        while (cameraReader.Read())
                        {
                            ListViewItem item = new ListViewItem("Camera")
                            {
                                SubItems = { cameraReader["Camera_Name"].ToString(), cameraReader["Brand_Name"].ToString(), cameraReader["Booking_Status"].ToString() },
                                Tag = "Camera_" + cameraReader["CameraID"].ToString()
                            };
                            listView1.Items.Add(item);
                        }
                    }
                }

                // Lấy danh sách Lenses
                string lensQuery = @"
                    SELECT l.LensID, l.Lenses_Name, b.Brand_Name, l.Booking_Status
                    FROM Lenses l
                    LEFT JOIN Brands b ON l.Lenses_Brand = b.BrandID
                    WHERE l.OwnerID = @UserID";
                using (SqlCommand lensCmd = new SqlCommand(lensQuery, DatabaseConnection.GetConnection()))
                {
                    lensCmd.Parameters.AddWithValue("@UserID", Session.userID);
                    using (SqlDataReader lensReader = lensCmd.ExecuteReader())
                    {
                        while (lensReader.Read())
                        {
                            ListViewItem item = new ListViewItem("Lens")
                            {
                                SubItems = { lensReader["Lenses_Name"].ToString(), lensReader["Brand_Name"].ToString(), lensReader["Booking_Status"].ToString() },
                                Tag = "Lens_" + lensReader["LensID"].ToString()
                            };
                            listView1.Items.Add(item);
                        }
                    }
                }

                // Lấy danh sách Accessories
                string accessoryQuery = @"
                    SELECT a.AccessoryID, a.Accessory_Name, b.Brand_Name, a.Booking_Status
                    FROM Accessories a
                    LEFT JOIN Brands b ON a.Accessory_Brand = b.BrandID
                    WHERE a.OwnerID = @UserID";
                using (SqlCommand accessoryCmd = new SqlCommand(accessoryQuery, DatabaseConnection.GetConnection()))
                {
                    accessoryCmd.Parameters.AddWithValue("@UserID", Session.userID);
                    using (SqlDataReader accessoryReader = accessoryCmd.ExecuteReader())
                    {
                        while (accessoryReader.Read())
                        {
                            ListViewItem item = new ListViewItem("Accessory")
                            {
                                SubItems = { accessoryReader["Accessory_Name"].ToString(), accessoryReader["Brand_Name"].ToString(), accessoryReader["Booking_Status"].ToString() },
                                Tag = "Accessory_" + accessoryReader["AccessoryID"].ToString()
                            };
                            listView1.Items.Add(item);
                        }
                    }
                }

                // Thêm màu xen kẽ cho các hàng
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (i % 2 == 0)
                        listView1.Items[i].BackColor = Color.FromArgb(240, 248, 255);
                    else
                        listView1.Items[i].BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading devices: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnect();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && isLeftClick)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string deviceType = selectedItem.Text;
                string tag = selectedItem.Tag.ToString();

                string[] parts = tag.Split('_');
                string deviceId = parts[1];

                try
                {
                    DatabaseConnection.Connect();

                    if (deviceType == "Camera")
                    {
                        string query = @"
                            SELECT c.Camera_Name, b.BrandID, b.Brand_Name, c.Booking_Status, c.Camera_SensorType
                            FROM Cameras c
                            LEFT JOIN Brands b ON c.Camera_Brand = b.BrandID
                            WHERE c.CameraID = @DeviceID";
                        using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@DeviceID", deviceId);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string deviceName = reader["Camera_Name"].ToString();
                                    string brandId = reader["BrandID"].ToString();
                                    string brandName = reader["Brand_Name"].ToString();
                                    string bookingStatus = reader["Booking_Status"].ToString();
                                    string sensorType = reader["Camera_SensorType"].ToString();

                                    EditDevice editDeviceForm = new EditDevice(deviceType, deviceId, deviceName, brandId, brandName, bookingStatus, sensorType, null, 0, 0, 0, Session.userID.ToString());
                                    editDeviceForm.ShowDialog();
                                }
                            }
                        }
                    }
                    else if (deviceType == "Lens")
                    {
                        string query = @"
                            SELECT l.Lenses_Name, b.BrandID, b.Brand_Name, l.Booking_Status, l.Lenses_FocalLengthMin, l.Lenses_FocalLengthMax, l.Lenses_Aperture
                            FROM Lenses l
                            LEFT JOIN Brands b ON l.Lenses_Brand = b.BrandID
                            WHERE l.LensID = @DeviceID";
                        using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@DeviceID", deviceId);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string deviceName = reader["Lenses_Name"].ToString();
                                    string brandId = reader["BrandID"].ToString();
                                    string brandName = reader["Brand_Name"].ToString();
                                    string bookingStatus = reader["Booking_Status"].ToString();
                                    int focalLengthMin = Convert.ToInt32(reader["Lenses_FocalLengthMin"]);
                                    int focalLengthMax = Convert.ToInt32(reader["Lenses_FocalLengthMax"]);
                                    float aperture = Convert.ToSingle(reader["Lenses_Aperture"]);

                                    EditDevice editDeviceForm = new EditDevice(deviceType, deviceId, deviceName, brandId, brandName, bookingStatus, null, null, focalLengthMin, focalLengthMax, aperture, Session.userID.ToString());
                                    editDeviceForm.ShowDialog();
                                }
                            }
                        }
                    }
                    else if (deviceType == "Accessory")
                    {
                        string query = @"
                            SELECT a.Accessory_Name, b.BrandID, b.Brand_Name, a.Booking_Status, a.Accessory_Type
                            FROM Accessories a
                            LEFT JOIN Brands b ON a.Accessory_Brand = b.BrandID
                            WHERE a.AccessoryID = @DeviceID";
                        using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@DeviceID", deviceId);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string deviceName = reader["Accessory_Name"].ToString();
                                    string brandId = reader["BrandID"].ToString();
                                    string brandName = reader["Brand_Name"].ToString();
                                    string bookingStatus = reader["Booking_Status"].ToString();
                                    string accessoryType = reader["Accessory_Type"].ToString();

                                    EditDevice editDeviceForm = new EditDevice(deviceType, deviceId, deviceName, brandId, brandName, bookingStatus, null, accessoryType, 0, 0, 0, Session.userID.ToString());
                                    editDeviceForm.ShowDialog();
                                }
                            }
                        }
                    }

                    LoadDevices();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading device details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DatabaseConnection.CloseConnect();
                }
            }
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string deviceType = selectedItem.Text;
                string tag = selectedItem.Tag.ToString();

                string[] parts = tag.Split('_');
                string deviceId = parts[1];

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the {deviceType} '{selectedItem.SubItems[1].Text}'?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DatabaseConnection.Connect();

                        if (deviceType == "Camera")
                        {
                            string query = "DELETE FROM Cameras WHERE CameraID = @DeviceID AND OwnerID = @UserID";
                            using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                            {
                                cmd.Parameters.AddWithValue("@DeviceID", deviceId);
                                cmd.Parameters.AddWithValue("@UserID", Session.userID);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (deviceType == "Lens")
                        {
                            string query = "DELETE FROM Lenses WHERE LensID = @DeviceID AND OwnerID = @UserID";
                            using (SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection()))
                            {
                                cmd.Parameters.AddWithValue("@DeviceID", deviceId);
                                cmd.Parameters.AddWithValue("@UserID", Session.userID);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (deviceType == "Accessory")
                        {
                            string deleteBookingsQuery = "DELETE FROM Bookings WHERE AccessoryID = @DeviceID";
                            using (SqlCommand deleteBookingsCmd = new SqlCommand(deleteBookingsQuery, DatabaseConnection.GetConnection()))
                            {
                                deleteBookingsCmd.Parameters.AddWithValue("@DeviceID", deviceId);
                                deleteBookingsCmd.ExecuteNonQuery();
                            }

                            string deleteAccessoryQuery = "DELETE FROM Accessories WHERE AccessoryID = @DeviceID AND OwnerID = @UserID";
                            using (SqlCommand deleteAccessoryCmd = new SqlCommand(deleteAccessoryQuery, DatabaseConnection.GetConnection()))
                            {
                                deleteAccessoryCmd.Parameters.AddWithValue("@DeviceID", deviceId);
                                deleteAccessoryCmd.Parameters.AddWithValue("@UserID", Session.userID);
                                deleteAccessoryCmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Device deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDevices();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting device: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        DatabaseConnection.CloseConnect();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a device to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddMydevicecs addMydevicecs = new AddMydevicecs();
                addMydevicecs.ShowDialog();
                LoadDevices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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