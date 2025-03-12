namespace MesControlApp
{
    partial class User_Profile_Update
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
            usr_phone_txt = new TextBox();
            usr_email_txt = new TextBox();
            usr_name_txt = new TextBox();
            ChangeInfo = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            usr_img_box = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            user_imageBtn = new Button();
            menuStrip1 = new MenuStrip();
            home_menu = new ToolStripMenuItem();
            myDevice_menu = new ToolStripMenuItem();
            mybooking_menu = new ToolStripMenuItem();
            devices_menu = new ToolStripMenuItem();
            booking_menu = new ToolStripMenuItem();
            Account_menu = new ToolStripMenuItem();
            myAccount_menu = new ToolStripMenuItem();
            logOut_menu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)usr_img_box).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // usr_phone_txt
            // 
            usr_phone_txt.Location = new Point(366, 303);
            usr_phone_txt.Name = "usr_phone_txt";
            usr_phone_txt.Size = new Size(328, 27);
            usr_phone_txt.TabIndex = 19;
            // 
            // usr_email_txt
            // 
            usr_email_txt.Location = new Point(366, 225);
            usr_email_txt.Name = "usr_email_txt";
            usr_email_txt.Size = new Size(328, 27);
            usr_email_txt.TabIndex = 18;
            // 
            // usr_name_txt
            // 
            usr_name_txt.Location = new Point(366, 142);
            usr_name_txt.Name = "usr_name_txt";
            usr_name_txt.Size = new Size(328, 27);
            usr_name_txt.TabIndex = 17;
            // 
            // ChangeInfo
            // 
            ChangeInfo.BackColor = Color.MediumSeaGreen;
            ChangeInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangeInfo.ForeColor = Color.White;
            ChangeInfo.Location = new Point(465, 364);
            ChangeInfo.Name = "ChangeInfo";
            ChangeInfo.Size = new Size(167, 40);
            ChangeInfo.TabIndex = 16;
            ChangeInfo.Text = "Save Changes";
            ChangeInfo.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(366, 275);
            label4.Name = "label4";
            label4.Size = new Size(185, 25);
            label4.TabIndex = 15;
            label4.Text = "User Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(366, 197);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 14;
            label3.Text = "User Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(366, 114);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // usr_img_box
            // 
            usr_img_box.Location = new Point(33, 40);
            usr_img_box.Name = "usr_img_box";
            usr_img_box.Size = new Size(213, 244);
            usr_img_box.SizeMode = PictureBoxSizeMode.CenterImage;
            usr_img_box.TabIndex = 12;
            usr_img_box.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(436, 46);
            label1.Name = "label1";
            label1.Size = new Size(196, 53);
            label1.TabIndex = 11;
            label1.Text = "User Profile";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(user_imageBtn);
            groupBox1.Controls.Add(usr_img_box);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(41, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 358);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Image";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // user_imageBtn
            // 
            user_imageBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            user_imageBtn.Location = new Point(49, 301);
            user_imageBtn.Name = "user_imageBtn";
            user_imageBtn.Size = new Size(185, 32);
            user_imageBtn.TabIndex = 13;
            user_imageBtn.Text = "Upload New Image";
            user_imageBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lexend Deca", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { home_menu, devices_menu, booking_menu, Account_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 22;
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
            // User_Profile_Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(usr_phone_txt);
            Controls.Add(usr_email_txt);
            Controls.Add(usr_name_txt);
            Controls.Add(ChangeInfo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "User_Profile_Update";
            Text = "User Profile Update";
            ((System.ComponentModel.ISupportInitialize)usr_img_box).EndInit();
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox usr_phone_txt;
        private TextBox usr_email_txt;
        private TextBox usr_name_txt;
        private Button ChangeInfo;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox usr_img_box;
        private Label label1;
        private GroupBox groupBox1;
        private Button user_imageBtn;
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