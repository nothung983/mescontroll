using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Media_Device_Management;
using System.Data.SqlClient;

namespace MesControlApp
{
    public class AddMydevicecs : Form
    {
        private ComboBox comboDeviceType;
        private TextBox txtDeviceName;
        private ComboBox comboBrand;
        private Label lblDeviceType;
        private Label lblDeviceName;
        private Label lblBrand;
        private Label lblSensorType;
        private TextBox txtSensorType;
        private Label lblFocalLengthMin;
        private TextBox txtFocalLengthMin;
        private Label lblFocalLengthMax;
        private TextBox txtFocalLengthMax;
        private Label lblAperture;
        private TextBox txtAperture;
        private Label lblAccessoryType;
        private TextBox txtAccessoryType;
        private Button btnAdd;
        private Button btnCancel;

        public AddMydevicecs()
        {
            // Cấu hình form
            this.Text = "Add Device";
            this.Size = new Size(450, 400);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            // Device Type
            lblDeviceType = new Label
            {
                Text = "Device Type:",
                Location = new Point(30, 20),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            comboDeviceType = new ComboBox
            {
                Name = "comboDeviceType",
                Location = new Point(150, 20),
                Width = 250,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            comboDeviceType.Items.AddRange(new string[] { "Camera", "Lens", "Accessory" });
            comboDeviceType.SelectedIndex = 0;

            // Device Name
            lblDeviceName = new Label
            {
                Text = "Device Name:",
                Location = new Point(30, 60),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            txtDeviceName = new TextBox
            {
                Name = "txtDeviceName",
                Location = new Point(150, 60),
                Width = 250,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            // Brand
            lblBrand = new Label
            {
                Text = "Brand:",
                Location = new Point(30, 100),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            comboBrand = new ComboBox
            {
                Name = "comboBrand",
                Location = new Point(150, 100),
                Width = 250,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            // Camera: Sensor Type
            lblSensorType = new Label
            {
                Text = "Sensor Type:",
                Location = new Point(30, 140),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            txtSensorType = new TextBox
            {
                Name = "txtSensorType",
                Location = new Point(150, 140),
                Width = 250,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            // Lens: Focal Length Min, Max, Aperture
            lblFocalLengthMin = new Label
            {
                Text = "Focal Length Min:",
                Location = new Point(30, 140),
                AutoSize = true,
                Font = new Font("Segoe UI", 8, FontStyle.Regular)
            };
            txtFocalLengthMin = new TextBox
            {
                Name = "txtFocalLengthMin",
                Location = new Point(150, 140),
                Width = 250,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            lblFocalLengthMax = new Label
            {
                Text = "Focal Length Max:",
                Location = new Point(30, 180),
                AutoSize = true,
                Font = new Font("Segoe UI", 8, FontStyle.Regular)
            };
            txtFocalLengthMax = new TextBox
            {
                Name = "txtFocalLengthMax",
                Location = new Point(150, 180),
                Width = 250,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            lblAperture = new Label
            {
                Text = "Aperture:",
                Location = new Point(30, 220),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            txtAperture = new TextBox
            {
                Name = "txtAperture",
                Location = new Point(150, 220),
                Width = 250,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            // Accessory: Type
            lblAccessoryType = new Label
            {
                Text = "Accessory Type:",
                Location = new Point(30, 140),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };
            txtAccessoryType = new TextBox
            {
                Name = "txtAccessoryType",
                Location = new Point(150, 140),
                Width = 250,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            // Buttons
            btnAdd = new Button
            {
                Name = "btnAdd",
                Text = "Add",
                Location = new Point(150, 280),
                Size = new Size(100, 35),
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnCancel = new Button
            {
                Name = "btnCancel",
                Text = "Cancel",
                Location = new Point(260, 280),
                Size = new Size(100, 35),
                BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            // Thêm hiệu ứng hover cho nút Add
            btnAdd.MouseEnter += (s, e) => btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.MouseLeave += (s, e) => btnAdd.BackColor = Color.FromArgb(46, 204, 113);

            // Thêm hiệu ứng hover cho nút Cancel
            btnCancel.MouseEnter += (s, e) => btnCancel.BackColor = Color.FromArgb(192, 57, 43);
            btnCancel.MouseLeave += (s, e) => btnCancel.BackColor = Color.FromArgb(231, 76, 60);

            // Thêm controls vào form
            this.Controls.AddRange(new Control[] {
                lblDeviceType, comboDeviceType,
                lblDeviceName, txtDeviceName,
                lblBrand, comboBrand,
                lblSensorType, txtSensorType,
                lblFocalLengthMin, txtFocalLengthMin,
                lblFocalLengthMax, txtFocalLengthMax,
                lblAperture, txtAperture,
                lblAccessoryType, txtAccessoryType,
                btnAdd, btnCancel
            });

            // Ẩn các trường ban đầu
            UpdateFieldsVisibility();

            // Sự kiện khi thay đổi Device Type
            comboDeviceType.SelectedIndexChanged += (s, e) => UpdateFieldsVisibility();

            // Sự kiện cho nút Add
            btnAdd.Click += btnAdd_Click;

            // Sự kiện cho nút Cancel
            btnCancel.Click += (s, e) => this.Close();

            // Load danh sách thương hiệu khi form khởi tạo
            LoadBrands();
        }

        private void UpdateFieldsVisibility()
        {
            string selectedType = comboDeviceType.SelectedItem?.ToString();
            lblSensorType.Visible = txtSensorType.Visible = selectedType == "Camera";
            lblFocalLengthMin.Visible = txtFocalLengthMin.Visible = selectedType == "Lens";
            lblFocalLengthMax.Visible = txtFocalLengthMax.Visible = selectedType == "Lens";
            lblAperture.Visible = txtAperture.Visible = selectedType == "Lens";
            lblAccessoryType.Visible = txtAccessoryType.Visible = selectedType == "Accessory";
        }

        private void LoadBrands()
        {
            try
            {
                DatabaseConnection.Connect();
                string query = "SELECT BrandID, Brand_Name FROM Brands";
                using SqlCommand cmd = new SqlCommand(query, DatabaseConnection.connection);
                using SqlDataReader reader = cmd.ExecuteReader();

                comboBrand.Items.Clear();
                while (reader.Read())
                {
                    comboBrand.Items.Add(new { BrandID = reader["BrandID"].ToString(), Brand_Name = reader["Brand_Name"].ToString() });
                }
                comboBrand.DisplayMember = "Brand_Name";
                comboBrand.ValueMember = "BrandID";
                if (comboBrand.Items.Count > 0) comboBrand.SelectedIndex = 0; // Chọn thương hiệu đầu tiên nếu có
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading brands: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnect();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string deviceType = comboDeviceType.SelectedItem?.ToString();
            string deviceName = txtDeviceName.Text.Trim();
            if (comboBrand.SelectedItem == null)
            {
                MessageBox.Show("Please select a brand.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string brandId = (comboBrand.SelectedItem as dynamic).BrandID;

            if (Session.userID == 0)
            {
                MessageBox.Show("No user is logged in! Please log in first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(deviceName))
            {
                MessageBox.Show("Please enter the device name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseConnection.Connect();

                if (deviceType == "Camera")
                {
                    string sensorType = txtSensorType.Text.Trim();
                    if (string.IsNullOrEmpty(sensorType))
                    {
                        MessageBox.Show("Please enter the sensor type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string query = @"
                        INSERT INTO Cameras (Camera_Name, Camera_Brand, Camera_SensorType, OwnerID, Booking_Status)
                        VALUES (@CameraName, @CameraBrand, @SensorType, @OwnerID, 'Available')";
                    using SqlCommand cmd = new SqlCommand(query, DatabaseConnection.connection);
                    cmd.Parameters.AddWithValue("@CameraName", deviceName);
                    cmd.Parameters.AddWithValue("@CameraBrand", brandId);
                    cmd.Parameters.AddWithValue("@SensorType", sensorType);
                    cmd.Parameters.AddWithValue("@OwnerID", Session.userID);
                    cmd.ExecuteNonQuery();
                }
                else if (deviceType == "Lens")
                {
                    if (!int.TryParse(txtFocalLengthMin.Text, out int focalLengthMin) ||
                        !int.TryParse(txtFocalLengthMax.Text, out int focalLengthMax) ||
                        !float.TryParse(txtAperture.Text, out float aperture))
                    {
                        MessageBox.Show("Please enter valid numeric values for Focal Length and Aperture.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (focalLengthMin >= focalLengthMax)
                    {
                        MessageBox.Show("Focal Length Min must be less than Focal Length Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = @"
                        INSERT INTO Lenses (Lenses_Name, Lenses_Brand, Lenses_FocalLengthMin, Lenses_FocalLengthMax, Lenses_Aperture, OwnerID, Booking_Status)
                        VALUES (@LensesName, @LensesBrand, @FocalLengthMin, @FocalLengthMax, @Aperture, @OwnerID, 'Available')";
                    using SqlCommand cmd = new SqlCommand(query, DatabaseConnection.connection);
                    cmd.Parameters.AddWithValue("@LensesName", deviceName);
                    cmd.Parameters.AddWithValue("@LensesBrand", brandId);
                    cmd.Parameters.AddWithValue("@FocalLengthMin", focalLengthMin);
                    cmd.Parameters.AddWithValue("@FocalLengthMax", focalLengthMax);
                    cmd.Parameters.AddWithValue("@Aperture", aperture);
                    cmd.Parameters.AddWithValue("@OwnerID", Session.userID);
                    cmd.ExecuteNonQuery();
                }
                else if (deviceType == "Accessory")
                {
                    string accessoryType = txtAccessoryType.Text.Trim();
                    if (string.IsNullOrEmpty(accessoryType))
                    {
                        MessageBox.Show("Please enter the accessory type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string query = @"
                        INSERT INTO Accessories (Accessory_Name, Accessory_Brand, Accessory_Type, OwnerID, Booking_Status)
                        VALUES (@AccessoryName, @AccessoryBrand, @AccessoryType, @OwnerID, 'Available')";
                    using SqlCommand cmd = new SqlCommand(query, DatabaseConnection.connection);
                    cmd.Parameters.AddWithValue("@AccessoryName", deviceName);
                    cmd.Parameters.AddWithValue("@AccessoryBrand", brandId);
                    cmd.Parameters.AddWithValue("@AccessoryType", accessoryType);
                    cmd.Parameters.AddWithValue("@OwnerID", Session.userID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Device added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding device: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnect();
            }
        }
    }
}