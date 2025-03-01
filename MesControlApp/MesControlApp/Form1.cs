using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MesControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(""); // Hiển thị toàn bộ dữ liệu khi mở form
        }

        private void LoadData(string searchWord)
        {
            if (string.IsNullOrWhiteSpace(searchWord))
                searchWord = "%"; // Nếu search rỗng, lấy toàn bộ dữ liệu

            string query = @"
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
                WHERE c.Camera_Name LIKE @SearchWord

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
                WHERE l.Lenses_Name LIKE @SearchWord

                UNION ALL

                SELECT 
                    a.AccessoryID AS ID, 
                    a.Accessory_Name AS Device_Name, 
                    'Accessory' AS Device_Type, 
                    b.Brand_Name, 
                    u.User_Fullname AS Owner_Name, 
                    a.Booking_Status, 
                    a.CreatedAt
                FROM Accessories a
                LEFT JOIN Brands b ON a.Accessory_Brand = b.BrandID
                LEFT JOIN Users u ON a.OwnerID = u.UserID
                WHERE a.Accessory_Name LIKE @SearchWord;
            ";

            try
            {
                DatabaseConnection.Connect();
                SqlDataAdapter da = new SqlDataAdapter(query, DatabaseConnection.connection);
                da.SelectCommand.Parameters.Add("@SearchWord", SqlDbType.NVarChar).Value = "%" + searchWord + "%";
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDevice.DataSource = dt;
                dgvDevice.Refresh(); // Cập nhật lại giao diện
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
            string searchText = txtSearch.Text.Trim();
            LoadData(searchText);
            
        }
    }
}
