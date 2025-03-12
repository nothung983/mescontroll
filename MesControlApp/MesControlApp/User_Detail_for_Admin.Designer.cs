namespace MesControlApp
{
    partial class User_Detail_for_Admin
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
            label7 = new Label();
            usr_pass = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            user_image = new PictureBox();
            usr_phone_txt = new TextBox();
            usr_email_txt = new TextBox();
            user_name_txt = new TextBox();
            backBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            user_info_lb = new Label();
            user_role_txt = new TextBox();
            menuStrip1 = new MenuStrip();
            home_menu = new ToolStripMenuItem();
            myDevice_menu = new ToolStripMenuItem();
            mybooking_menu = new ToolStripMenuItem();
            devices_menu = new ToolStripMenuItem();
            booking_menu = new ToolStripMenuItem();
            Account_menu = new ToolStripMenuItem();
            myAccount_menu = new ToolStripMenuItem();
            logOut_menu = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_image).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.Location = new Point(399, 348);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 52;
            label7.Text = "User Role";
            // 
            // usr_pass
            // 
            usr_pass.Location = new Point(399, 308);
            usr_pass.Name = "usr_pass";
            usr_pass.ReadOnly = true;
            usr_pass.Size = new Size(328, 27);
            usr_pass.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(399, 280);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 47;
            label5.Text = "User Password";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(user_image);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(47, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 361);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Image";
            // 
            // user_image
            // 
            user_image.Location = new Point(35, 44);
            user_image.Name = "user_image";
            user_image.Size = new Size(213, 295);
            user_image.SizeMode = PictureBoxSizeMode.CenterImage;
            user_image.TabIndex = 12;
            user_image.TabStop = false;
            // 
            // usr_phone_txt
            // 
            usr_phone_txt.Location = new Point(399, 244);
            usr_phone_txt.Name = "usr_phone_txt";
            usr_phone_txt.ReadOnly = true;
            usr_phone_txt.Size = new Size(328, 27);
            usr_phone_txt.TabIndex = 45;
            // 
            // usr_email_txt
            // 
            usr_email_txt.Location = new Point(399, 183);
            usr_email_txt.Name = "usr_email_txt";
            usr_email_txt.ReadOnly = true;
            usr_email_txt.Size = new Size(328, 27);
            usr_email_txt.TabIndex = 44;
            // 
            // user_name_txt
            // 
            user_name_txt.Location = new Point(399, 123);
            user_name_txt.Name = "user_name_txt";
            user_name_txt.ReadOnly = true;
            user_name_txt.Size = new Size(328, 27);
            user_name_txt.TabIndex = 43;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.DodgerBlue;
            backBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = Color.White;
            backBtn.Location = new Point(492, 428);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(167, 40);
            backBtn.TabIndex = 42;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(399, 216);
            label4.Name = "label4";
            label4.Size = new Size(185, 25);
            label4.TabIndex = 41;
            label4.Text = "User Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(399, 155);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 40;
            label3.Text = "User Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(399, 95);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 39;
            label2.Text = "Username";
            // 
            // user_info_lb
            // 
            user_info_lb.AutoSize = true;
            user_info_lb.Font = new Font("Poppins", 14F, FontStyle.Bold);
            user_info_lb.Location = new Point(47, 50);
            user_info_lb.Name = "user_info_lb";
            user_info_lb.Size = new Size(301, 42);
            user_info_lb.TabIndex = 38;
            user_info_lb.Text = "User Detail Information";
            // 
            // user_role_txt
            // 
            user_role_txt.Location = new Point(399, 376);
            user_role_txt.Name = "user_role_txt";
            user_role_txt.ReadOnly = true;
            user_role_txt.Size = new Size(328, 27);
            user_role_txt.TabIndex = 54;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lexend Deca", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { home_menu, devices_menu, booking_menu, Account_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(801, 32);
            menuStrip1.TabIndex = 55;
            menuStrip1.Text = "menuStrip1";
            // 
            // home_menu
            // 
            home_menu.DropDownItems.AddRange(new ToolStripItem[] { myDevice_menu, mybooking_menu });
            home_menu.Name = "home_menu";
            home_menu.Size = new Size(67, 28);
            home_menu.Text = "Home";
            // 
            // myDevice_menu
            // 
            myDevice_menu.Name = "myDevice_menu";
            myDevice_menu.Size = new Size(180, 28);
            myDevice_menu.Text = "My Devices";
            // 
            // mybooking_menu
            // 
            mybooking_menu.Name = "mybooking_menu";
            mybooking_menu.Size = new Size(180, 28);
            mybooking_menu.Text = "My Booking";
            // 
            // devices_menu
            // 
            devices_menu.Name = "devices_menu";
            devices_menu.Size = new Size(81, 28);
            devices_menu.Text = "Devices";
            // 
            // booking_menu
            // 
            booking_menu.Name = "booking_menu";
            booking_menu.Size = new Size(84, 28);
            booking_menu.Text = "Booking";
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
            // 
            // logOut_menu
            // 
            logOut_menu.Name = "logOut_menu";
            logOut_menu.Size = new Size(179, 28);
            logOut_menu.Text = "Log out";
            // 
            // User_Detail_for_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 493);
            Controls.Add(menuStrip1);
            Controls.Add(user_role_txt);
            Controls.Add(label7);
            Controls.Add(usr_pass);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(usr_phone_txt);
            Controls.Add(usr_email_txt);
            Controls.Add(user_name_txt);
            Controls.Add(backBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(user_info_lb);
            Name = "User_Detail_for_Admin";
            Text = "User_Detail_for_Admin";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)user_image).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private TextBox usr_pass;
        private Label label5;
        private GroupBox groupBox1;
        private PictureBox user_image;
        private TextBox usr_phone_txt;
        private TextBox usr_email_txt;
        private TextBox user_name_txt;
        private Button backBtn;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label user_info_lb;
        private TextBox user_role_txt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem home_menu;
        private ToolStripMenuItem myDevice_menu;
        private ToolStripMenuItem mybooking_menu;
        private ToolStripMenuItem devices_menu;
        private ToolStripMenuItem booking_menu;
        private ToolStripMenuItem Account_menu;
        private ToolStripMenuItem myAccount_menu;
        private ToolStripMenuItem logOut_menu;
    }
}