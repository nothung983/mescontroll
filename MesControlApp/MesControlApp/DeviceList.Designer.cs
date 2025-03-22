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
            btnBooking = new Button();
            btnReturnBooking = new Button();
            menuStrip1 = new MenuStrip();
            home_menu = new ToolStripMenuItem();
            myDevice_menu = new ToolStripMenuItem();
            mybooking_menu = new ToolStripMenuItem();
            devices_menu = new ToolStripMenuItem();
            allDevices_MenuItem = new ToolStripMenuItem();
            booking_menu = new ToolStripMenuItem();
            pendingBooking_menu = new ToolStripMenuItem();
            allBooking_menu = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            userLists_menu = new ToolStripMenuItem();
            Account_menu = new ToolStripMenuItem();
            myAccount_menu = new ToolStripMenuItem();
            logOut_menu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvDevice).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDevice
            // 
            dgvDevice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDevice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDevice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevice.Location = new Point(28, 138);
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
            label1.Location = new Point(28, 98);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 1;
            label1.Text = "Device List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(522, 105);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Filter :";
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "All", "Camera", "Lens", "Accessory" });
            cboType.Location = new Point(622, 101);
            cboType.Name = "cboType";
            cboType.Size = new Size(131, 28);
            cboType.TabIndex = 3;
            cboType.SelectedIndexChanged += cboType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 106);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 5;
            label4.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(284, 106);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(209, 27);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(576, 106);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(784, 106);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(768, 105);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 8;
            label6.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "All", "Available", "Booked", "Under Maintenance" });
            cboStatus.Location = new Point(823, 102);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(131, 28);
            cboStatus.TabIndex = 3;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.Cyan;
            btnBooking.FlatStyle = FlatStyle.Popup;
            btnBooking.ForeColor = SystemColors.ActiveCaptionText;
            btnBooking.Location = new Point(1035, 87);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(158, 44);
            btnBooking.TabIndex = 9;
            btnBooking.Text = "Device Booking";
            btnBooking.UseVisualStyleBackColor = false;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnReturnBooking
            // 
            btnReturnBooking.BackColor = Color.Cyan;
            btnReturnBooking.FlatStyle = FlatStyle.Popup;
            btnReturnBooking.ForeColor = SystemColors.ActiveCaptionText;
            btnReturnBooking.Location = new Point(1035, 37);
            btnReturnBooking.Name = "btnReturnBooking";
            btnReturnBooking.Size = new Size(158, 44);
            btnReturnBooking.TabIndex = 10;
            btnReturnBooking.Text = "Return Booking";
            btnReturnBooking.UseVisualStyleBackColor = false;
            btnReturnBooking.Click += btnReturnBooking_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lexend Deca", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { home_menu, devices_menu, booking_menu, usersToolStripMenuItem, Account_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1245, 32);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // home_menu
            // 
            home_menu.DropDownItems.AddRange(new ToolStripItem[] { myDevice_menu, mybooking_menu });
            home_menu.Name = "home_menu";
            home_menu.Size = new Size(67, 28);
            home_menu.Text = "Home";
            home_menu.Click += home_menu_Click;
            // 
            // myDevice_menu
            // 
            myDevice_menu.Name = "myDevice_menu";
            myDevice_menu.Size = new Size(224, 28);
            myDevice_menu.Text = "My Devices";
            myDevice_menu.Click += myDevice_menu_Click;
            // 
            // mybooking_menu
            // 
            mybooking_menu.Name = "mybooking_menu";
            mybooking_menu.Size = new Size(224, 28);
            mybooking_menu.Text = "My Booking";
            mybooking_menu.Click += mybooking_menu_Click;
            // 
            // devices_menu
            // 
            devices_menu.DropDownItems.AddRange(new ToolStripItem[] { allDevices_MenuItem });
            devices_menu.Name = "devices_menu";
            devices_menu.Size = new Size(81, 28);
            devices_menu.Text = "Devices";
            // 
            // allDevices_MenuItem
            // 
            allDevices_MenuItem.Name = "allDevices_MenuItem";
            allDevices_MenuItem.Size = new Size(224, 28);
            allDevices_MenuItem.Text = "All Devices";
            allDevices_MenuItem.Click += allDevices_MenuItem_Click;
            // 
            // booking_menu
            // 
            booking_menu.DropDownItems.AddRange(new ToolStripItem[] { pendingBooking_menu, allBooking_menu });
            booking_menu.Name = "booking_menu";
            booking_menu.Size = new Size(84, 28);
            booking_menu.Text = "Booking";
            // 
            // pendingBooking_menu
            // 
            pendingBooking_menu.Name = "pendingBooking_menu";
            pendingBooking_menu.Size = new Size(224, 28);
            pendingBooking_menu.Text = "Pending Booking";
            pendingBooking_menu.Click += pendingBooking_menu_Click;
            // 
            // allBooking_menu
            // 
            allBooking_menu.Name = "allBooking_menu";
            allBooking_menu.Size = new Size(224, 28);
            allBooking_menu.Text = "All Booking";
            allBooking_menu.Click += allBooking_menu_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userLists_menu });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(64, 28);
            usersToolStripMenuItem.Text = "Users";
            // 
            // userLists_menu
            // 
            userLists_menu.Name = "userLists_menu";
            userLists_menu.Size = new Size(224, 28);
            userLists_menu.Text = "All Users";
            userLists_menu.Click += userLists_menu_Click;
            // 
            // Account_menu
            // 
            Account_menu.DropDownItems.AddRange(new ToolStripItem[] { myAccount_menu, logOut_menu });
            Account_menu.Name = "Account_menu";
            Account_menu.Size = new Size(83, 28);
            Account_menu.Text = "Account";
            // 
            // myAccount_menu
            // 
            myAccount_menu.Name = "myAccount_menu";
            myAccount_menu.Size = new Size(224, 28);
            myAccount_menu.Text = "My Account";
            myAccount_menu.Click += myAccount_menu_Click;
            // 
            // logOut_menu
            // 
            logOut_menu.Name = "logOut_menu";
            logOut_menu.Size = new Size(224, 28);
            logOut_menu.Text = "Log out";
            logOut_menu.Click += logOut_menu_Click;
            // 
            // DeviceList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 564);
            Controls.Add(menuStrip1);
            Controls.Add(btnReturnBooking);
            Controls.Add(btnBooking);
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Button btnBooking;
        private Button btnReturnBooking;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem home_menu;
        private ToolStripMenuItem myDevice_menu;
        private ToolStripMenuItem mybooking_menu;
        private ToolStripMenuItem devices_menu;
        private ToolStripMenuItem allDevices_MenuItem;
        private ToolStripMenuItem booking_menu;
        private ToolStripMenuItem pendingBooking_menu;
        private ToolStripMenuItem allBooking_menu;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem userLists_menu;
        private ToolStripMenuItem Account_menu;
        private ToolStripMenuItem myAccount_menu;
        private ToolStripMenuItem logOut_menu;
    }
}
