namespace MesControlApp
{
    partial class DeviceList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDevice = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            cboType = new ComboBox();
            label4 = new Label();
            txtSearch = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboStatus = new ComboBox();
            hello = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDevice).BeginInit();
            SuspendLayout();
            // 
            // dgvDevice
            // 
            dgvDevice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDevice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDevice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevice.Location = new Point(28, 113);
            dgvDevice.Name = "dgvDevice";
            dgvDevice.RowHeadersWidth = 51;
            dgvDevice.Size = new Size(1165, 413);
            dgvDevice.TabIndex = 0;
            dgvDevice.CellContentClick += dgvDevice_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 73);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 1;
            label1.Text = "Device List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(522, 80);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Filter :";
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "All", "Camera", "Lens", "Accessory" });
            cboType.Location = new Point(622, 76);
            cboType.Name = "cboType";
            cboType.Size = new Size(131, 28);
            cboType.TabIndex = 3;
            cboType.SelectedIndexChanged += cboType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 81);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 5;
            label4.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(284, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(209, 27);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(576, 81);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(784, 81);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(768, 80);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 8;
            label6.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "All", "Available", "Booked", "Under Maintenance" });
            cboStatus.Location = new Point(823, 77);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(131, 28);
            cboStatus.TabIndex = 3;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // hello
            // 
            hello.AutoSize = true;
            hello.Location = new Point(28, 19);
            hello.Name = "hello";
            hello.Size = new Size(50, 20);
            hello.TabIndex = 9;
            hello.Text = "label7";
            // 
            // DeviceList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 545);
            Controls.Add(hello);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboStatus);
            Controls.Add(cboType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDevice);
            Name = "DeviceList";
            Text = "Device List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDevice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDevice;
        private Label label1;
        private Label label2;
        private ComboBox cboType;
        private Label label4;
        private TextBox txtSearch;
        private Label label3;
        private Label label5;
        private Label label6;
        private ComboBox cboStatus;
        private Label hello;
    }
}
