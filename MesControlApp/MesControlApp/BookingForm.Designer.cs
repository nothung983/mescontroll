namespace MesControlApp
{
    partial class BookingForm
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
            label5 = new Label();
            txtUsrID = new TextBox();
            startDate = new DateTimePicker();
            endDate = new DateTimePicker();
            label6 = new Label();
            textBox3 = new TextBox();
            cboCam = new ComboBox();
            label7 = new Label();
            cboLens = new ComboBox();
            label8 = new Label();
            cboAcc = new ComboBox();
            btnBook = new Button();
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lexend Deca", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(317, 75);
            label1.Name = "label1";
            label1.Size = new Size(238, 48);
            label1.TabIndex = 0;
            label1.Text = "Booking Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lexend SemiBold", 11F, FontStyle.Bold);
            label2.Location = new Point(30, 165);
            label2.Name = "label2";
            label2.Size = new Size(86, 30);
            label2.TabIndex = 1;
            label2.Text = "User ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lexend SemiBold", 11F, FontStyle.Bold);
            label3.Location = new Point(406, 168);
            label3.Name = "label3";
            label3.Size = new Size(87, 30);
            label3.TabIndex = 2;
            label3.Text = "Camera";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lexend SemiBold", 11F, FontStyle.Bold);
            label4.Location = new Point(29, 243);
            label4.Name = "label4";
            label4.Size = new Size(104, 30);
            label4.TabIndex = 3;
            label4.Text = "Start Day";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lexend SemiBold", 11F, FontStyle.Bold);
            label5.Location = new Point(30, 318);
            label5.Name = "label5";
            label5.Size = new Size(94, 30);
            label5.TabIndex = 4;
            label5.Text = "End Day";
            // 
            // txtUsrID
            // 
            txtUsrID.Location = new Point(139, 165);
            txtUsrID.Name = "txtUsrID";
            txtUsrID.ReadOnly = true;
            txtUsrID.Size = new Size(235, 27);
            txtUsrID.TabIndex = 5;
            // 
            // startDate
            // 
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(139, 246);
            startDate.Name = "startDate";
            startDate.Size = new Size(235, 27);
            startDate.TabIndex = 7;
            // 
            // endDate
            // 
            endDate.Format = DateTimePickerFormat.Short;
            endDate.Location = new Point(139, 321);
            endDate.Name = "endDate";
            endDate.Size = new Size(235, 27);
            endDate.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lexend SemiBold", 11F, FontStyle.Bold);
            label6.Location = new Point(30, 392);
            label6.Name = "label6";
            label6.Size = new Size(82, 30);
            label6.TabIndex = 9;
            label6.Text = "Reason";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(139, 395);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(677, 136);
            textBox3.TabIndex = 10;
            // 
            // cboCam
            // 
            cboCam.FormattingEnabled = true;
            cboCam.Location = new Point(519, 171);
            cboCam.Name = "cboCam";
            cboCam.Size = new Size(297, 28);
            cboCam.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lexend SemiBold", 11F, FontStyle.Bold);
            label7.Location = new Point(409, 238);
            label7.Name = "label7";
            label7.Size = new Size(57, 30);
            label7.TabIndex = 2;
            label7.Text = "Lens";
            label7.Click += label3_Click;
            // 
            // cboLens
            // 
            cboLens.FormattingEnabled = true;
            cboLens.Location = new Point(519, 241);
            cboLens.Name = "cboLens";
            cboLens.Size = new Size(297, 28);
            cboLens.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lexend SemiBold", 11F, FontStyle.Bold);
            label8.Location = new Point(406, 318);
            label8.Name = "label8";
            label8.Size = new Size(107, 30);
            label8.TabIndex = 2;
            label8.Text = "Accessory";
            label8.Click += label3_Click;
            // 
            // cboAcc
            // 
            cboAcc.FormattingEnabled = true;
            cboAcc.Location = new Point(519, 318);
            cboAcc.Name = "cboAcc";
            cboAcc.Size = new Size(297, 28);
            cboAcc.TabIndex = 12;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(317, 552);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(202, 38);
            btnBook.TabIndex = 13;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lexend Deca", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { home_menu, devices_menu, booking_menu, usersToolStripMenuItem, Account_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(881, 32);
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
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 630);
            Controls.Add(menuStrip1);
            Controls.Add(btnBook);
            Controls.Add(cboAcc);
            Controls.Add(cboLens);
            Controls.Add(cboCam);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(txtUsrID);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookingForm";
            Text = "BookingForm";
            Load += BookingForm_Load;
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
        private Label label5;
        private TextBox txtUsrID;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private Label label6;
        private TextBox textBox3;
        private ComboBox cboCam;
        private Label label7;
        private ComboBox cboLens;
        private Label label8;
        private ComboBox cboAcc;
        private Button btnBook;
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