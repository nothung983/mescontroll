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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ChangeInfo = new Button();
            textBox1 = new TextBox();
            usr_email_txt = new TextBox();
            textBox3 = new TextBox();
            ChangePass = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(357, 110);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(357, 181);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 4;
            label3.Text = "User Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(357, 260);
            label4.Name = "label4";
            label4.Size = new Size(185, 25);
            label4.TabIndex = 5;
            label4.Text = "User Phone Number";
            // 
            // ChangeInfo
            // 
            ChangeInfo.Location = new Point(357, 360);
            ChangeInfo.Name = "ChangeInfo";
            ChangeInfo.Size = new Size(167, 40);
            ChangeInfo.TabIndex = 6;
            ChangeInfo.Text = "Change Information";
            ChangeInfo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 138);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 7;
            // 
            // usr_email_txt
            // 
            usr_email_txt.Location = new Point(357, 221);
            usr_email_txt.Name = "usr_email_txt";
            usr_email_txt.ReadOnly = true;
            usr_email_txt.Size = new Size(328, 27);
            usr_email_txt.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(357, 299);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(328, 27);
            textBox3.TabIndex = 9;
            // 
            // ChangePass
            // 
            ChangePass.Location = new Point(548, 360);
            ChangePass.Name = "ChangePass";
            ChangePass.Size = new Size(158, 40);
            ChangePass.TabIndex = 10;
            ChangePass.Text = "Change Password";
            ChangePass.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(42, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 358);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Image";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 261);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lexend Deca", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { home_menu, devices_menu, booking_menu, Account_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 23;
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
            // User_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(ChangePass);
            Controls.Add(textBox3);
            Controls.Add(usr_email_txt);
            Controls.Add(textBox1);
            Controls.Add(ChangeInfo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "User_Profile";
            Text = "User_Profile";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ChangeInfo;
        private TextBox textBox1;
        private TextBox usr_email_txt;
        private TextBox textBox3;
        private Button ChangePass;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
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