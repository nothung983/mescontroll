namespace Media_Device_Management
{
    partial class Main_dashboard
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
            total_usr_devices_txt = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            total_usr_book_txt = new Label();
            panel3 = new Panel();
            usr_total_pend_txt = new Label();
            welcome_lb = new Label();
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
            recent_book_Groupbox = new GroupBox();
            recentbook_GridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            recent_book_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recentbook_GridView).BeginInit();
            SuspendLayout();
            // 
            // total_usr_devices_txt
            // 
            total_usr_devices_txt.AutoSize = true;
            total_usr_devices_txt.Location = new Point(20, 14);
            total_usr_devices_txt.Name = "total_usr_devices_txt";
            total_usr_devices_txt.Size = new Size(65, 29);
            total_usr_devices_txt.TabIndex = 1;
            total_usr_devices_txt.Text = "label1";
            total_usr_devices_txt.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(total_usr_devices_txt);
            panel1.Font = new Font("Lexend Deca", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(44, 146);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 57);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(total_usr_book_txt);
            panel2.Font = new Font("Lexend Deca", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(44, 235);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 57);
            panel2.TabIndex = 3;
            // 
            // total_usr_book_txt
            // 
            total_usr_book_txt.AutoSize = true;
            total_usr_book_txt.Location = new Point(20, 13);
            total_usr_book_txt.Name = "total_usr_book_txt";
            total_usr_book_txt.Size = new Size(66, 29);
            total_usr_book_txt.TabIndex = 1;
            total_usr_book_txt.Text = "label2";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(usr_total_pend_txt);
            panel3.Font = new Font("Lexend Deca", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(44, 319);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 57);
            panel3.TabIndex = 4;
            // 
            // usr_total_pend_txt
            // 
            usr_total_pend_txt.AutoSize = true;
            usr_total_pend_txt.Location = new Point(20, 15);
            usr_total_pend_txt.Name = "usr_total_pend_txt";
            usr_total_pend_txt.Size = new Size(66, 29);
            usr_total_pend_txt.TabIndex = 1;
            usr_total_pend_txt.Text = "label3";
            // 
            // welcome_lb
            // 
            welcome_lb.AutoSize = true;
            welcome_lb.Font = new Font("Lexend Deca Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_lb.Location = new Point(49, 52);
            welcome_lb.Name = "welcome_lb";
            welcome_lb.Size = new Size(81, 32);
            welcome_lb.TabIndex = 2;
            welcome_lb.Text = "label4";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lexend Deca", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { home_menu, devices_menu, booking_menu, usersToolStripMenuItem, Account_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(960, 32);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // home_menu
            // 
            home_menu.DropDownItems.AddRange(new ToolStripItem[] { myDevice_menu, mybooking_menu });
            home_menu.Name = "home_menu";
            home_menu.Size = new Size(67, 28);
            home_menu.Text = "Home";
            home_menu.Click += home_menu_Click_1;
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
            // recent_book_Groupbox
            // 
            recent_book_Groupbox.Controls.Add(recentbook_GridView);
            recent_book_Groupbox.Font = new Font("Lexend Deca SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recent_book_Groupbox.Location = new Point(408, 128);
            recent_book_Groupbox.Name = "recent_book_Groupbox";
            recent_book_Groupbox.Size = new Size(516, 309);
            recent_book_Groupbox.TabIndex = 25;
            recent_book_Groupbox.TabStop = false;
            recent_book_Groupbox.Text = "Recent Booking";
            // 
            // recentbook_GridView
            // 
            recentbook_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recentbook_GridView.Location = new Point(12, 36);
            recentbook_GridView.Name = "recentbook_GridView";
            recentbook_GridView.RowHeadersWidth = 51;
            recentbook_GridView.Size = new Size(486, 256);
            recentbook_GridView.TabIndex = 0;
            // 
            // Main_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 452);
            Controls.Add(recent_book_Groupbox);
            Controls.Add(menuStrip1);
            Controls.Add(welcome_lb);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main_dashboard";
            Text = "Dashboard";
            Load += Main_dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            recent_book_Groupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)recentbook_GridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label total_usr_devices_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label total_usr_book_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label usr_total_pend_txt;
        private Label welcome_lb;
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
        private GroupBox recent_book_Groupbox;
        private DataGridView recentbook_GridView;
    }
}