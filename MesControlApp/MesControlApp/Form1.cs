using System.Data;
using System.Data.SqlClient;

namespace MesControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

                UNION ALL

                SELECT 
                    l.LensID, 
                    l.Lenses_Name, 
                    'Lens', 
                    b.Brand_Name, 
                    u.User_Fullname, 
                    l.Booking_Status, 
                    l.CreatedAt
                FROM Lenses l
                LEFT JOIN Brands b ON l.Lenses_Brand = b.BrandID
                LEFT JOIN Users u ON l.OwnerID = u.UserID

                UNION ALL

                SELECT 
                    a.AccessoryID, 
                    a.Accessory_Name, 
                    'Accessory', 
                    b.Brand_Name, 
                    u.User_Fullname, 
                    a.Booking_Status, 
                    a.CreatedAt
                FROM Accessories a
                LEFT JOIN Brands b ON a.Accessory_Brand = b.BrandID
                LEFT JOIN Users u ON a.OwnerID = u.UserID;
                ";
            DatabaseConnection.Connect();
            SqlDataAdapter da = new SqlDataAdapter(query, DatabaseConnection.connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDevice.DataSource = dt;
            DatabaseConnection.CloseConnect();
        }
    }
}
