//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using Microsoft.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System;
//using Media_Device_Management;

//namespace MesControlApp
//{
//    public partial class User_Profile : Form
//    {
//        public User_Profile()
//        {
//            InitializeComponent();
//            // Lấy userID từ Session
//            if (Session.userID == 0)
//            {
//                MessageBox.Show("No user is logged in! Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            else
//            {
//                LoadUserProfile(Session.userID);
//            }
//        }
//        private void LoadUserProfile(int loggedInUserId)
//        {
//            string query = @"SELECT
//                            UserID,
//                            User_Role,
//                            User_fullname,
//                            User_Phone_Num, 
//                            User_Email, 
//                            User_Image FROM Users WHERE UserID = @UserID";

//            try
//            {
//                using (SqlConnection connection = DatabaseConnection.GetConnection())
//                {
//                    connection.Open();
//                    using (SqlCommand cmd = new SqlCommand(query, connection))
//                    {
//                        cmd.Parameters.AddWithValue("@UserID", loggedInUserId);
//                        using (SqlDataReader reader = cmd.ExecuteReader())
//                        {
//                            if (reader.Read())
//                            {
//                                // Store user details in session
//                                Session.userID = reader.GetInt32(0);
//                                Session.role = reader.GetString(1);
//                                Session.name = reader.GetString(2);
//                                Session.phoneNumber = reader.GetString(3);
//                                Session.email = reader.GetString(4);
//                                Session.imagePath = reader.IsDBNull(5) ? string.Empty : Path.Combine(@"D:\NAM IV\.NET\PROJECT\mescontroll\MesControlApp\MesControlApp\assets\users", reader.GetString(5));

//                                // Display user details
//                                usr_name_txt.Text = Session.name;
//                                user_phone_num_txt.Text = Session.phoneNumber;
//                                usr_email_txt.Text = Session.email;

//                                // Load user image if available
//                                if (!string.IsNullOrEmpty(Session.imagePath))
//                                {
//                                    usr_image_box.Image = Image.FromFile(Session.imagePath);
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error retrieving user details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            finally
//            {
//                DatabaseConnection.CloseConnect();
//            }
//        }

//        private void ChangePass_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            ChangePassword changePasswordForm = new ChangePassword();
//            changePasswordForm.ShowDialog();
//        }

//        private void ChangeInfo_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            User_Profile_Update ChangeInfo = new User_Profile_Update();
//            ChangeInfo.ShowDialog();
//        }


//        //menu click events

//        private void logOut_menu_Click(object sender, EventArgs e)
//        {
//            Logout logout = new Logout();
//        }

//        private void myAccount_menu_Click(object sender, EventArgs e)
//        {
//            // Open user profile window
//            this.Hide();
//            User_Profile user_Profile = new User_Profile();
//            user_Profile.Show();
//        }

//        private void myDevice_menu_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            mydevice myDevices = new mydevice();
//            myDevices.Show();
//        }

//        private void mybooking_menu_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            myBooking myBooking = new myBooking();
//            myBooking.Show();
//        }

//        private void allDevices_MenuItem_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            DeviceList deviceList = new DeviceList();
//            deviceList.Show();
//        }

//        private void userLists_menu_Click(object sender, EventArgs e)
//        {
//            if (Session.role != "Admin")
//            {
//                MessageBox.Show("You do not have permission to access this page", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }
//            else
//            {
//                this.Hide();
//                UserList userList = new UserList();
//                userList.Show();
//            }

//        }

//        private void home_menu_Click(object sender, EventArgs e)
//        {
//            if (Session.role != "Admin")
//            {
//                this.Hide();
//                Main_dashboard maindashboard = new Main_dashboard();
//                maindashboard.Show();
//            }
//            else
//            {
//                this.Hide();
//                Admin_Dashboard adminDashboard = new Admin_Dashboard();
//                adminDashboard.Show();
//            }

//        }

//        private void allBooking_menu_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            BookingLists bookingList = new BookingLists();
//            bookingList.Show();
//        }

//        private void pendingBooking_menu_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            Pending_BookingLists pendingBooking = new Pending_BookingLists();
//            pendingBooking.Show();
//        }
//    }
//}
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Media_Device_Management;

namespace MesControlApp
{
    public partial class User_Profile : Form
    {
        public User_Profile()
        {
            InitializeComponent();

            // Kiểm tra session
            if (Session.userID == 0)
            {
                MessageBox.Show("No user is logged in! Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                LoadUserProfile(Session.userID);
            }
        }

        private void LoadUserProfile(int loggedInUserId)
        {
            string query = @"SELECT UserID, User_Role, User_fullname, User_Phone_Num, User_Email, User_Image FROM Users WHERE UserID = @UserID";

            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", loggedInUserId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lưu vào session
                            Session.userID = reader.GetInt32(0);
                            Session.role = reader.GetString(1);
                            Session.name = reader.GetString(2);
                            Session.phoneNumber = reader.IsDBNull(3) ? "N/A" : reader.GetString(3);
                            Session.email = reader.IsDBNull(4) ? "N/A" : reader.GetString(4);
                            Session.imagePath = reader.IsDBNull(5) ? string.Empty
                                : Path.Combine(@"D:\NAM IV\.NET\PROJECT\mescontroll\MesControlApp\MesControlApp\assets\users", reader.GetString(5));

                            // Hiển thị dữ liệu
                            usr_name_txt.Text = Session.name;
                            user_phone_num_txt.Text = Session.phoneNumber;
                            usr_email_txt.Text = Session.email;

                            // Hiển thị ảnh (nếu có)
                            if (!string.IsNullOrEmpty(Session.imagePath) && File.Exists(Session.imagePath))
                            {
                                usr_image_box.Image = Image.FromFile(Session.imagePath);
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chuyển sang trang đổi mật khẩu
        private void ChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword();
            changePasswordForm.ShowDialog();
        }

        // Chuyển sang trang chỉnh sửa thông tin
        private void ChangeInfo_Click(object sender, EventArgs e)
        {
            User_Profile_Update changeInfo = new User_Profile_Update();
            changeInfo.ShowDialog();
        }

        // Đăng xuất
        private void logOut_menu_Click(object sender, EventArgs e)
        {
            Logout logout = new Logout();
            this.Close();
        }

        // Các sự kiện mở form khác
        private void myAccount_menu_Click(object sender, EventArgs e)
        {
            User_Profile user_Profile = new User_Profile();
            user_Profile.Show();
        }

        private void myDevice_menu_Click(object sender, EventArgs e)
        {
            mydevice myDevices = new mydevice();
            myDevices.Show();
        }

        private void mybooking_menu_Click(object sender, EventArgs e)
        {
            myBooking myBooking = new myBooking();
            myBooking.Show();
        }

        private void allDevices_MenuItem_Click(object sender, EventArgs e)
        {
            DeviceList deviceList = new DeviceList();
            deviceList.Show();
        }

        private void userLists_menu_Click(object sender, EventArgs e)
        {
            if (Session.role != "Admin")
            {
                MessageBox.Show("You do not have permission to access this page", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UserList userList = new UserList();
                userList.Show();
            }
        }

        private void home_menu_Click(object sender, EventArgs e)
        {
            Form dashboard = (Session.role == "Admin") ? new Admin_Dashboard() : new Main_dashboard();
            dashboard.Show();
        }

        private void allBooking_menu_Click(object sender, EventArgs e)
        {
            BookingLists bookingList = new BookingLists();
            bookingList.Show();
        }

        private void pendingBooking_menu_Click(object sender, EventArgs e)
        {
            Pending_BookingLists pendingBooking = new Pending_BookingLists();
            pendingBooking.Show();
        }
    }
}
