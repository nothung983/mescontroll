namespace MesControlApp
{
    partial class User_Profile
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
            label1 = new Label();
            Username = new Label();
            User_mail = new Label();
            user_phone = new Label();
            ChangeInfo = new Button();
            usr_name_txt = new TextBox();
            usr_email_txt = new TextBox();
            user_phone_num_txt = new TextBox();
            ChangePass = new Button();
            groupBox1 = new GroupBox();
            usr_image_box = new PictureBox();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usr_image_box).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(446, 42);
            label1.Name = "label1";
            label1.Size = new Size(196, 53);
            label1.TabIndex = 0;
            label1.Text = "User Profile";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            Username.Location = new Point(357, 110);
            Username.Name = "Username";
            Username.Size = new Size(98, 25);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // User_mail
            // 
            User_mail.AutoSize = true;
            User_mail.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            User_mail.Location = new Point(357, 181);
            User_mail.Name = "User_mail";
            User_mail.Size = new Size(102, 25);
            User_mail.TabIndex = 4;
            User_mail.Text = "User Email";
            // 
            // user_phone
            // 
            user_phone.AutoSize = true;
            user_phone.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_phone.Location = new Point(357, 260);
            user_phone.Name = "user_phone";
            user_phone.Size = new Size(185, 25);
            user_phone.TabIndex = 5;
            user_phone.Text = "User Phone Number";
            // 
            // ChangeInfo
            // 
            ChangeInfo.Location = new Point(357, 360);
            ChangeInfo.Name = "ChangeInfo";
            ChangeInfo.Size = new Size(167, 40);
            ChangeInfo.TabIndex = 6;
            ChangeInfo.Text = "Change Information";
            ChangeInfo.UseVisualStyleBackColor = true;
            ChangeInfo.Click += ChangeInfo_Click;
            // 
            // usr_name_txt
            // 
            usr_name_txt.Location = new Point(357, 138);
            usr_name_txt.Name = "usr_name_txt";
            usr_name_txt.ReadOnly = true;
            usr_name_txt.Size = new Size(328, 27);
            usr_name_txt.TabIndex = 7;
            // 
            // usr_email_txt
            // 
            usr_email_txt.Location = new Point(357, 221);
            usr_email_txt.Name = "usr_email_txt";
            usr_email_txt.ReadOnly = true;
            usr_email_txt.Size = new Size(328, 27);
            usr_email_txt.TabIndex = 8;
            // 
            // user_phone_num_txt
            // 
            user_phone_num_txt.Location = new Point(357, 299);
            user_phone_num_txt.Name = "user_phone_num_txt";
            user_phone_num_txt.ReadOnly = true;
            user_phone_num_txt.Size = new Size(328, 27);
            user_phone_num_txt.TabIndex = 9;
            // 
            // ChangePass
            // 
            ChangePass.Location = new Point(548, 360);
            ChangePass.Name = "ChangePass";
            ChangePass.Size = new Size(158, 40);
            ChangePass.TabIndex = 10;
            ChangePass.Text = "Change Password";
            ChangePass.UseVisualStyleBackColor = true;
            ChangePass.Click += ChangePass_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(usr_image_box);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(42, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 358);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Image";
            // 
            // usr_image_box
            // 
            usr_image_box.Location = new Point(21, 46);
            usr_image_box.Name = "usr_image_box";
            usr_image_box.Size = new Size(213, 261);
            usr_image_box.SizeMode = PictureBoxSizeMode.CenterImage;
            usr_image_box.TabIndex = 12;
            usr_image_box.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lexend Deca", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { home_menu, devices_menu, booking_menu, usersToolStripMenuItem, Account_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
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
            // User_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(ChangePass);
            Controls.Add(user_phone_num_txt);
            Controls.Add(usr_email_txt);
            Controls.Add(usr_name_txt);
            Controls.Add(ChangeInfo);
            Controls.Add(user_phone);
            Controls.Add(User_mail);
            Controls.Add(Username);
            Controls.Add(label1);
            Name = "User_Profile";
            Text = "User_Profile";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usr_image_box).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Username;
        private Label User_mail;
        private Label user_phone;
        private Button ChangeInfo;
        private TextBox usr_name_txt;
        private TextBox usr_email_txt;
        private TextBox user_phone_num_txt;
        private Button ChangePass;
        private GroupBox groupBox1;
        private PictureBox usr_image_box;
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