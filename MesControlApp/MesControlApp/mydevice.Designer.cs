﻿namespace MesControlApp
{
    partial class mydevice
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
            listView1 = new ListView();
            btnAdd = new Button();
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
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(77, 104);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "My Devices";
            // 
            // listView1
            // 
            listView1.Location = new Point(77, 134);
            listView1.Name = "listView1";
            listView1.Size = new Size(540, 250);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(457, 394);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Device";
            btnAdd.Click += btnAdd_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lexend Deca", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { home_menu, devices_menu, booking_menu, usersToolStripMenuItem, Account_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(713, 32);
            menuStrip1.TabIndex = 25;
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
            // mydevice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 452);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(btnAdd);
            Name = "mydevice";
            Text = "My Devices";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button btnAdd;
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