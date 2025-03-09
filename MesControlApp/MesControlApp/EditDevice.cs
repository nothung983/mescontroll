using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class EditDevice : Form
    {
        private readonly string deviceType;
        private readonly string deviceId;
        private readonly string deviceName;
        private readonly string brandId;
        private readonly string brandName;
        private readonly string bookingStatus;
        private readonly string sensorType;
        private readonly string accessoryType;
        private readonly int focalLengthMin;
        private readonly int focalLengthMax;
        private readonly float aperture;
        private readonly string userId;

        private TextBox txtDeviceName;
        private ComboBox comboBrand;
        private Label lblBookingStatusValue;
        private TextBox txtSensorType;
        private TextBox txtFocalLengthMin;
        private TextBox txtFocalLengthMax;
        private TextBox txtAperture;
        private TextBox txtAccessoryType;

        public EditDevice(string deviceType, string deviceId, string deviceName, string brandId, string brandName, string bookingStatus,
            string sensorType, string accessoryType, int focalLengthMin, int focalLengthMax, float aperture, string userId)
        {
            this.deviceType = deviceType ?? throw new ArgumentNullException(nameof(deviceType));
            this.deviceId = deviceId ?? throw new ArgumentNullException(nameof(deviceId));
            this.deviceName = deviceName ?? string.Empty;
            this.brandId = brandId ?? string.Empty;
            this.brandName = brandName ?? string.Empty;
            this.bookingStatus = bookingStatus ?? "Available";
            this.sensorType = sensorType ?? string.Empty;
            this.accessoryType = accessoryType ?? string.Empty;
            this.focalLengthMin = focalLengthMin;
            this.focalLengthMax = focalLengthMax;
            this.aperture = aperture;
            this.userId = userId ?? throw new ArgumentNullException(nameof(userId));

            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = $"Edit {deviceType}: {deviceName}";
            this.Size = new Size(400, deviceType == "Lens" ? 450 : 350);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Device Name
            Label lblDeviceName = new Label
            {
                Text = "Device Name:",
                Location = new Point(30, 30),
                AutoSize = true
            };
            txtDeviceName = new TextBox
            {
                Name = "txtDeviceName",
                Location = new Point(150, 30),
                Width = 200,
                Text = deviceName
            };
            this.Controls.AddRange(new Control[] { lblDeviceName, txtDeviceName });

            // Brand
            Label lblBrand = new Label
            {
                Text = "Brand:",
                Location = new Point(30, 80),
                AutoSize = true
            };
            comboBrand = new ComboBox
            {
                Name = "comboBrand",
                Location = new Point(150, 80),
                Width = 200
            };
            this.Controls.AddRange(new Control[] { lblBrand, comboBrand });

            // Booking Status (chỉ hiển thị, không cho chỉnh sửa)
            Label lblBookingStatus = new Label
            {
                Text = "Booking Status:",
                Location = new Point(30, 130),
                AutoSize = true
            };
            lblBookingStatusValue = new Label
            {
                Text = bookingStatus,
                Location = new Point(150, 130),
                AutoSize = true
            };
            this.Controls.AddRange(new Control[] { lblBookingStatus, lblBookingStatusValue });

            // Khởi tạo các trường cụ thể
            int yPosition = 180;

            if (deviceType == "Camera")
            {
                Label lblSensorType = new Label
                {
                    Text = "Sensor Type:",
                    Location = new Point(30, yPosition),
                    AutoSize = true
                };
                txtSensorType = new TextBox
                {
                    Name = "txtSensorType",
                    Location = new Point(150, yPosition),
                    Width = 200,
                    Text = sensorType
                };
                this.Controls.AddRange(new Control[] { lblSensorType, txtSensorType });
                yPosition += 50;
            }
            else if (deviceType == "Lens")
            {
                Label lblFocalLengthMin = new Label
                {
                    Text = "Focal Length Min:",
                    Location = new Point(30, yPosition),
                    AutoSize = true
                };
                txtFocalLengthMin = new TextBox
                {
                    Name = "txtFocalLengthMin",
                    Location = new Point(150, yPosition),
                    Width = 200,
                    Text = focalLengthMin.ToString()
                };
                yPosition += 50;

                Label lblFocalLengthMax = new Label
                {
                    Text = "Focal Length Max:",
                    Location = new Point(30, yPosition),
                    AutoSize = true
                };
                txtFocalLengthMax = new TextBox
                {
                    Name = "txtFocalLengthMax",
                    Location = new Point(150, yPosition),
                    Width = 200,
                    Text = focalLengthMax.ToString()
                };
                yPosition += 50;

                Label lblAperture = new Label
                {
                    Text = "Aperture:",
                    Location = new Point(30, yPosition),
                    AutoSize = true
                };
                txtAperture = new TextBox
                {
                    Name = "txtAperture",
                    Location = new Point(150, yPosition),
                    Width = 200,
                    Text = aperture.ToString()
                };
                this.Controls.AddRange(new Control[] { lblFocalLengthMin, txtFocalLengthMin, lblFocalLengthMax, txtFocalLengthMax, lblAperture, txtAperture });
                yPosition += 50;
            }
            else if (deviceType == "Accessory")
            {
                Label lblAccessoryType = new Label
                {
                    Text = "Accessory Type:",
                    Location = new Point(30, yPosition),
                    AutoSize = true
                };
                txtAccessoryType = new TextBox
                {
                    Name = "txtAccessoryType",
                    Location = new Point(150, yPosition),
                    Width = 200,
                    Text = accessoryType
                };
                this.Controls.AddRange(new Control[] { lblAccessoryType, txtAccessoryType });
                yPosition += 50;
            }
            else
            {
                MessageBox.Show($"Invalid device type: {deviceType}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Buttons
            Button btnUpdate = new Button
            {
                Name = "btnUpdate",
                Text = "Update",
                Location = new Point(100, yPosition), // Căn giữa hơn
                Size = new Size(100, 35), // Tăng kích thước
                BackColor = Color.FromArgb(46, 204, 113), // Màu xanh lá
                ForeColor = Color.White, // Chữ trắng
                FlatStyle = FlatStyle.Flat, // Bo viền nhẹ
                FlatAppearance = { BorderSize = 0 }, // Không có viền
                Font = new Font("Segoe UI", 10, FontStyle.Bold) // Font chữ đậm
            };
            Button btnCancel = new Button
            {
                Name = "btnCancel",
                Text = "Cancel",
                Location = new Point(220, yPosition), // Căn giữa hơn
                Size = new Size(100, 35), // Tăng kích thước
                BackColor = Color.FromArgb(231, 76, 60), // Màu đỏ nhạt
                ForeColor = Color.White, // Chữ trắng
                FlatStyle = FlatStyle.Flat, // Bo viền nhẹ
                FlatAppearance = { BorderSize = 0 }, // Không có viền
                Font = new Font("Segoe UI", 10, FontStyle.Bold) // Font chữ đậm
            };

            // Thêm hiệu ứng hover cho nút Update
            btnUpdate.MouseEnter += (s, e) =>
            {
                btnUpdate.BackColor = Color.FromArgb(39, 174, 96); // Đậm hơn khi hover
            };
            btnUpdate.MouseLeave += (s, e) =>
            {
                btnUpdate.BackColor = Color.FromArgb(46, 204, 113); // Trở lại màu gốc
            };

            // Thêm hiệu ứng hover cho nút Cancel
            btnCancel.MouseEnter += (s, e) =>
            {
                btnCancel.BackColor = Color.FromArgb(192, 57, 43); // Đậm hơn khi hover
            };
            btnCancel.MouseLeave += (s, e) =>
            {
                btnCancel.BackColor = Color.FromArgb(231, 76, 60); // Trở lại màu gốc
            };

            btnUpdate.Click += BtnUpdate_Click;
            btnCancel.Click += (s, e) => this.Close();
            this.Controls.AddRange(new Control[] { btnUpdate, btnCancel });

            // Load danh sách thương hiệu
            LoadBrands();
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

                // Chọn thương hiệu hiện tại
                foreach (var item in comboBrand.Items)
                {
                    if ((item as dynamic).BrandID == brandId)
                    {
                        comboBrand.SelectedItem = item;
                        break;
                    }
                }
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string newDeviceName = txtDeviceName.Text.Trim();
            if (comboBrand.SelectedItem == null)
            {
                MessageBox.Show("Please select a brand.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newBrandId = (comboBrand.SelectedItem as dynamic).BrandID;

            if (string.IsNullOrEmpty(newDeviceName))
            {
                MessageBox.Show("Please enter the device name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseConnection.Connect();

                if (deviceType == "Camera")
                {
                    string newSensorType = txtSensorType?.Text.Trim() ?? string.Empty;
                    string query = @"
                        UPDATE Cameras 
                        SET Camera_Name = @NewName, Camera_Brand = @NewBrand, Camera_SensorType = @NewSensorType
                        WHERE CameraID = @DeviceID AND OwnerID = @UserID";
                    using SqlCommand cmd = new SqlCommand(query, DatabaseConnection.connection);
                    cmd.Parameters.AddWithValue("@NewName", newDeviceName);
                    cmd.Parameters.AddWithValue("@NewBrand", newBrandId);
                    cmd.Parameters.AddWithValue("@NewSensorType", newSensorType);
                    cmd.Parameters.AddWithValue("@DeviceID", deviceId);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.ExecuteNonQuery();
                }
                else if (deviceType == "Lens")
                {
                    if (!int.TryParse(txtFocalLengthMin?.Text ?? "0", out int newFocalLengthMin) ||
                        !int.TryParse(txtFocalLengthMax?.Text ?? "0", out int newFocalLengthMax) ||
                        !float.TryParse(txtAperture?.Text ?? "0", out float newAperture))
                    {
                        MessageBox.Show("Please enter valid numeric values for Focal Length and Aperture.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = @"
                        UPDATE Lenses 
                        SET Lenses_Name = @NewName, Lenses_Brand = @NewBrand, 
                            Lenses_FocalLengthMin = @FocalLengthMin, Lenses_FocalLengthMax = @FocalLengthMax, Lenses_Aperture = @Aperture
                        WHERE LensID = @DeviceID AND OwnerID = @UserID";
                    using SqlCommand cmd = new SqlCommand(query, DatabaseConnection.connection);
                    cmd.Parameters.AddWithValue("@NewName", newDeviceName);
                    cmd.Parameters.AddWithValue("@NewBrand", newBrandId);
                    cmd.Parameters.AddWithValue("@FocalLengthMin", newFocalLengthMin);
                    cmd.Parameters.AddWithValue("@FocalLengthMax", newFocalLengthMax);
                    cmd.Parameters.AddWithValue("@Aperture", newAperture);
                    cmd.Parameters.AddWithValue("@DeviceID", deviceId);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.ExecuteNonQuery();
                }
                else if (deviceType == "Accessory")
                {
                    string newAccessoryType = txtAccessoryType?.Text.Trim() ?? string.Empty;
                    string query = @"
                        UPDATE Accessories 
                        SET Accessory_Name = @NewName, Accessory_Brand = @NewBrand, Accessory_Type = @NewAccessoryType
                        WHERE AccessoryID = @DeviceID AND OwnerID = @UserID";
                    using SqlCommand cmd = new SqlCommand(query, DatabaseConnection.connection);
                    cmd.Parameters.AddWithValue("@NewName", newDeviceName);
                    cmd.Parameters.AddWithValue("@NewBrand", newBrandId);
                    cmd.Parameters.AddWithValue("@NewAccessoryType", newAccessoryType);
                    cmd.Parameters.AddWithValue("@DeviceID", deviceId);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Device updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating device: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnect();
            }
        }
    }
}