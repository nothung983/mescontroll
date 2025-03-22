namespace MesControlApp
{
    partial class AddNewUser
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
            groupBox1 = new GroupBox();
            usr_image_Btn = new Button();
            usr_image = new PictureBox();
            user_phone_txt = new TextBox();
            usr_email_txt = new TextBox();
            user_name_txt = new TextBox();
            SavesBtn = new Button();
            user_phone_num = new Label();
            user_mail = new Label();
            user_name = new Label();
            addnewlb = new Label();
            user_pass_txt = new TextBox();
            user_pass = new Label();
            retype_pass_txt = new TextBox();
            repass = new Label();
            usr_role_cmb = new ComboBox();
            user_role = new Label();
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
            ((System.ComponentModel.ISupportInitialize)usr_image).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(usr_image_Btn);
            groupBox1.Controls.Add(usr_image);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(46, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 361);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Image";
            // 
            // usr_image_Btn
            // 
            usr_image_Btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            usr_image_Btn.Location = new Point(51, 306);
            usr_image_Btn.Name = "usr_image_Btn";
            usr_image_Btn.Size = new Size(185, 32);
            usr_image_Btn.TabIndex = 13;
            usr_image_Btn.Text = "Upload New Image";
            usr_image_Btn.UseVisualStyleBackColor = true;
            usr_image_Btn.Click += usr_image_Btn_Click;
            // 
            // usr_image
            // 
            usr_image.Location = new Point(32, 39);
            usr_image.Name = "usr_image";
            usr_image.Size = new Size(213, 261);
            usr_image.SizeMode = PictureBoxSizeMode.CenterImage;
            usr_image.TabIndex = 12;
            usr_image.TabStop = false;
            // 
            // user_phone_txt
            // 
            user_phone_txt.Location = new Point(396, 198);
            user_phone_txt.Name = "user_phone_txt";
            user_phone_txt.Size = new Size(328, 27);
            user_phone_txt.TabIndex = 29;
            // 
            // usr_email_txt
            // 
            usr_email_txt.Location = new Point(396, 137);
            usr_email_txt.Name = "usr_email_txt";
            usr_email_txt.Size = new Size(328, 27);
            usr_email_txt.TabIndex = 28;
            // 
            // user_name_txt
            // 
            user_name_txt.Location = new Point(396, 77);
            user_name_txt.Name = "user_name_txt";
            user_name_txt.Size = new Size(328, 27);
            user_name_txt.TabIndex = 27;
            // 
            // SavesBtn
            // 
            SavesBtn.BackColor = Color.MediumSeaGreen;
            SavesBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SavesBtn.ForeColor = Color.White;
            SavesBtn.Location = new Point(488, 439);
            SavesBtn.Name = "SavesBtn";
            SavesBtn.Size = new Size(167, 40);
            SavesBtn.TabIndex = 26;
            SavesBtn.Text = "Save";
            SavesBtn.UseVisualStyleBackColor = false;
            SavesBtn.Click += SavesBtn_Click;
            // 
            // user_phone_num
            // 
            user_phone_num.AutoSize = true;
            user_phone_num.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_phone_num.Location = new Point(396, 170);
            user_phone_num.Name = "user_phone_num";
            user_phone_num.Size = new Size(185, 25);
            user_phone_num.TabIndex = 25;
            user_phone_num.Text = "User Phone Number";
            // 
            // user_mail
            // 
            user_mail.AutoSize = true;
            user_mail.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_mail.Location = new Point(396, 109);
            user_mail.Name = "user_mail";
            user_mail.Size = new Size(102, 25);
            user_mail.TabIndex = 24;
            user_mail.Text = "User Email";
            // 
            // user_name
            // 
            user_name.AutoSize = true;
            user_name.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_name.Location = new Point(396, 49);
            user_name.Name = "user_name";
            user_name.Size = new Size(98, 25);
            user_name.TabIndex = 23;
            user_name.Text = "Username";
            // 
            // addnewlb
            // 
            addnewlb.AutoSize = true;
            addnewlb.Font = new Font("Poppins", 14F, FontStyle.Bold);
            addnewlb.Location = new Point(46, 43);
            addnewlb.Name = "addnewlb";
            addnewlb.Size = new Size(187, 42);
            addnewlb.TabIndex = 22;
            addnewlb.Text = "Add New User";
            addnewlb.Click += Label1_Click;
            // 
            // user_pass_txt
            // 
            user_pass_txt.Location = new Point(396, 262);
            user_pass_txt.Name = "user_pass_txt";
            user_pass_txt.Size = new Size(328, 27);
            user_pass_txt.TabIndex = 32;
            // 
            // user_pass
            // 
            user_pass.AutoSize = true;
            user_pass.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_pass.Location = new Point(396, 234);
            user_pass.Name = "user_pass";
            user_pass.Size = new Size(134, 25);
            user_pass.TabIndex = 31;
            user_pass.Text = "User Password";
            // 
            // retype_pass_txt
            // 
            retype_pass_txt.Location = new Point(396, 326);
            retype_pass_txt.Name = "retype_pass_txt";
            retype_pass_txt.Size = new Size(328, 27);
            retype_pass_txt.TabIndex = 34;
            // 
            // repass
            // 
            repass.AutoSize = true;
            repass.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            repass.Location = new Point(396, 298);
            repass.Name = "repass";
            repass.Size = new Size(163, 25);
            repass.TabIndex = 33;
            repass.Text = "Re-type Password";
            // 
            // usr_role_cmb
            // 
            usr_role_cmb.FormattingEnabled = true;
            usr_role_cmb.Items.AddRange(new object[] { "User", "Admin" });
            usr_role_cmb.Location = new Point(396, 394);
            usr_role_cmb.Name = "usr_role_cmb";
            usr_role_cmb.Size = new Size(328, 28);
            usr_role_cmb.TabIndex = 35;
            // 
            // user_role
            // 
            user_role.AutoSize = true;
            user_role.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_role.Location = new Point(396, 366);
            user_role.Name = "user_role";
            user_role.Size = new Size(92, 25);
            user_role.TabIndex = 36;
            user_role.Text = "User Role";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lexend Deca", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { home_menu, devices_menu, booking_menu, usersToolStripMenuItem, Account_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(821, 32);
            menuStrip1.TabIndex = 37;
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
            // AddNewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 529);
            Controls.Add(menuStrip1);
            Controls.Add(user_role);
            Controls.Add(usr_role_cmb);
            Controls.Add(retype_pass_txt);
            Controls.Add(repass);
            Controls.Add(user_pass_txt);
            Controls.Add(user_pass);
            Controls.Add(groupBox1);
            Controls.Add(user_phone_txt);
            Controls.Add(usr_email_txt);
            Controls.Add(user_name_txt);
            Controls.Add(SavesBtn);
            Controls.Add(user_phone_num);
            Controls.Add(user_mail);
            Controls.Add(user_name);
            Controls.Add(addnewlb);
            Name = "AddNewUser";
            Text = "AddNewUser";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usr_image).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public GroupBox groupBox1;
        public Button usr_image_Btn;
        public PictureBox usr_image;
        public TextBox user_phone_txt;
        public TextBox usr_email_txt;
        public TextBox user_name_txt;
        public Button SavesBtn;
        public Label user_phone_num;
        public Label user_mail;
        public Label user_name;
        public Label addnewlb;
        public TextBox user_pass_txt;
        public Label user_pass;
        public TextBox retype_pass_txt;
        public Label repass;
        public ComboBox usr_role_cmb;
        public Label user_role;
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