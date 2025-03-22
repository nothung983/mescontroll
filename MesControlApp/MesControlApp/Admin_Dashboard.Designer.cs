namespace MesControlApp
{
    partial class Admin_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            total_booking_panel = new Panel();
            total_booking_lb = new Label();
            total_dev_panel = new Panel();
            total_dev_lb = new Label();
            total_usr_panel = new Panel();
            total_usr_lb = new Label();
            total_brands_panel = new Panel();
            total_brands_lb = new Label();
            latest_req_groupBox = new GroupBox();
            latest_req = new DataGridView();
            req_from = new DataGridViewTextBoxColumn();
            device_type = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            total_booking_panel.SuspendLayout();
            total_dev_panel.SuspendLayout();
            total_usr_panel.SuspendLayout();
            total_brands_panel.SuspendLayout();
            latest_req_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)latest_req).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lexend Deca", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { home_menu, devices_menu, booking_menu, usersToolStripMenuItem, Account_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(902, 32);
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
            myDevice_menu.Size = new Size(180, 28);
            myDevice_menu.Text = "My Devices";
            myDevice_menu.Click += myDevice_menu_Click;
            // 
            // mybooking_menu
            // 
            mybooking_menu.Name = "mybooking_menu";
            mybooking_menu.Size = new Size(180, 28);
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
            allDevices_MenuItem.Size = new Size(173, 28);
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
            pendingBooking_menu.Size = new Size(219, 28);
            pendingBooking_menu.Text = "Pending Booking";
            pendingBooking_menu.Click += pendingBooking_menu_Click;
            // 
            // allBooking_menu
            // 
            allBooking_menu.Name = "allBooking_menu";
            allBooking_menu.Size = new Size(219, 28);
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
            userLists_menu.Size = new Size(156, 28);
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
            myAccount_menu.Size = new Size(179, 28);
            myAccount_menu.Text = "My Account";
            myAccount_menu.Click += myAccount_menu_Click;
            // 
            // logOut_menu
            // 
            logOut_menu.Name = "logOut_menu";
            logOut_menu.Size = new Size(179, 28);
            logOut_menu.Text = "Log out";
            logOut_menu.Click += logOut_menu_Click;
            // 
            // total_booking_panel
            // 
            total_booking_panel.BorderStyle = BorderStyle.FixedSingle;
            total_booking_panel.Controls.Add(total_booking_lb);
            total_booking_panel.Font = new Font("Lexend Deca", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_booking_panel.Location = new Point(57, 277);
            total_booking_panel.Margin = new Padding(3, 4, 3, 4);
            total_booking_panel.Name = "total_booking_panel";
            total_booking_panel.Size = new Size(318, 57);
            total_booking_panel.TabIndex = 27;
            // 
            // total_booking_lb
            // 
            total_booking_lb.AutoSize = true;
            total_booking_lb.Location = new Point(124, 15);
            total_booking_lb.Name = "total_booking_lb";
            total_booking_lb.Size = new Size(66, 29);
            total_booking_lb.TabIndex = 1;
            total_booking_lb.Text = "label3";
            // 
            // total_dev_panel
            // 
            total_dev_panel.BorderStyle = BorderStyle.FixedSingle;
            total_dev_panel.Controls.Add(total_dev_lb);
            total_dev_panel.Font = new Font("Lexend Deca", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_dev_panel.Location = new Point(57, 193);
            total_dev_panel.Margin = new Padding(3, 4, 3, 4);
            total_dev_panel.Name = "total_dev_panel";
            total_dev_panel.Size = new Size(318, 57);
            total_dev_panel.TabIndex = 26;
            // 
            // total_dev_lb
            // 
            total_dev_lb.AutoSize = true;
            total_dev_lb.Location = new Point(124, 13);
            total_dev_lb.Name = "total_dev_lb";
            total_dev_lb.Size = new Size(66, 29);
            total_dev_lb.TabIndex = 1;
            total_dev_lb.Text = "label2";
            // 
            // total_usr_panel
            // 
            total_usr_panel.BorderStyle = BorderStyle.FixedSingle;
            total_usr_panel.Controls.Add(total_usr_lb);
            total_usr_panel.Font = new Font("Lexend Deca", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_usr_panel.Location = new Point(57, 104);
            total_usr_panel.Margin = new Padding(3, 4, 3, 4);
            total_usr_panel.Name = "total_usr_panel";
            total_usr_panel.Size = new Size(318, 57);
            total_usr_panel.TabIndex = 25;
            // 
            // total_usr_lb
            // 
            total_usr_lb.AutoSize = true;
            total_usr_lb.Location = new Point(124, 15);
            total_usr_lb.Name = "total_usr_lb";
            total_usr_lb.Size = new Size(65, 29);
            total_usr_lb.TabIndex = 1;
            total_usr_lb.Text = "label1";
            total_usr_lb.Click += total_usr_lb_Click;
            // 
            // total_brands_panel
            // 
            total_brands_panel.BorderStyle = BorderStyle.FixedSingle;
            total_brands_panel.Controls.Add(total_brands_lb);
            total_brands_panel.Font = new Font("Lexend Deca", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_brands_panel.Location = new Point(57, 369);
            total_brands_panel.Margin = new Padding(3, 4, 3, 4);
            total_brands_panel.Name = "total_brands_panel";
            total_brands_panel.Size = new Size(318, 57);
            total_brands_panel.TabIndex = 28;
            // 
            // total_brands_lb
            // 
            total_brands_lb.AutoSize = true;
            total_brands_lb.Location = new Point(124, 13);
            total_brands_lb.Name = "total_brands_lb";
            total_brands_lb.Size = new Size(67, 29);
            total_brands_lb.TabIndex = 1;
            total_brands_lb.Text = "label4";
            // 
            // latest_req_groupBox
            // 
            latest_req_groupBox.Controls.Add(latest_req);
            latest_req_groupBox.Font = new Font("Lexend Deca Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            latest_req_groupBox.Location = new Point(396, 76);
            latest_req_groupBox.Name = "latest_req_groupBox";
            latest_req_groupBox.Size = new Size(473, 365);
            latest_req_groupBox.TabIndex = 29;
            latest_req_groupBox.TabStop = false;
            latest_req_groupBox.Text = "Latest Request";
            // 
            // latest_req
            // 
            latest_req.AllowUserToAddRows = false;
            latest_req.AllowUserToDeleteRows = false;
            latest_req.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            latest_req.Columns.AddRange(new DataGridViewColumn[] { req_from, device_type });
            latest_req.Location = new Point(10, 35);
            latest_req.Name = "latest_req";
            latest_req.ReadOnly = true;
            latest_req.RowHeadersWidth = 51;
            latest_req.Size = new Size(457, 324);
            latest_req.TabIndex = 0;
            // 
            // req_from
            // 
            req_from.HeaderText = "Request From";
            req_from.MinimumWidth = 6;
            req_from.Name = "req_from";
            req_from.ReadOnly = true;
            req_from.Width = 150;
            // 
            // device_type
            // 
            device_type.HeaderText = "Device Type";
            device_type.MinimumWidth = 6;
            device_type.Name = "device_type";
            device_type.ReadOnly = true;
            device_type.Width = 150;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 532);
            Controls.Add(latest_req_groupBox);
            Controls.Add(total_brands_panel);
            Controls.Add(total_booking_panel);
            Controls.Add(total_dev_panel);
            Controls.Add(total_usr_panel);
            Controls.Add(menuStrip1);
            Name = "Admin_Dashboard";
            Text = "Admin_Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            total_booking_panel.ResumeLayout(false);
            total_booking_panel.PerformLayout();
            total_dev_panel.ResumeLayout(false);
            total_dev_panel.PerformLayout();
            total_usr_panel.ResumeLayout(false);
            total_usr_panel.PerformLayout();
            total_brands_panel.ResumeLayout(false);
            total_brands_panel.PerformLayout();
            latest_req_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)latest_req).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Panel total_booking_panel;
        private Label total_booking_lb;
        private Panel total_dev_panel;
        private Label total_dev_lb;
        private Panel total_usr_panel;
        private Label total_usr_lb;
        private Panel total_brands_panel;
        private Label total_brands_lb;
        private GroupBox latest_req_groupBox;
        private DataGridView latest_req;
        private DataGridViewTextBoxColumn req_from;
        private DataGridViewTextBoxColumn device_type;
    }
}