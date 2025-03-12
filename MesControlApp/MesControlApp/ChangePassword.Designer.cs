
namespace MesControlApp
{
    partial class ChangePassword
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
            homeToolStripMenuItem = new ToolStripMenuItem();
            myDeviceToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            devicesToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem1 = new ToolStripMenuItem();
            myAccountToolStripMenuItem = new ToolStripMenuItem();
            myAccountToolStripMenuItem1 = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            usr_email_txt = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lexend Deca", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, devicesToolStripMenuItem, bookingToolStripMenuItem1, myAccountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myDeviceToolStripMenuItem, bookingToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(67, 28);
            homeToolStripMenuItem.Text = "Home";
            // 
            // myDeviceToolStripMenuItem
            // 
            myDeviceToolStripMenuItem.Name = "myDeviceToolStripMenuItem";
            myDeviceToolStripMenuItem.Size = new Size(180, 28);
            myDeviceToolStripMenuItem.Text = "My Devices";
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(180, 28);
            bookingToolStripMenuItem.Text = "My Booking";
            // 
            // devicesToolStripMenuItem
            // 
            devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            devicesToolStripMenuItem.Size = new Size(81, 28);
            devicesToolStripMenuItem.Text = "Devices";
            // 
            // bookingToolStripMenuItem1
            // 
            bookingToolStripMenuItem1.Name = "bookingToolStripMenuItem1";
            bookingToolStripMenuItem1.Size = new Size(84, 28);
            bookingToolStripMenuItem1.Text = "Booking";
            // 
            // myAccountToolStripMenuItem
            // 
            myAccountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myAccountToolStripMenuItem1, logOutToolStripMenuItem });
            myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            myAccountToolStripMenuItem.Size = new Size(83, 28);
            myAccountToolStripMenuItem.Text = "Account";
            // 
            // myAccountToolStripMenuItem1
            // 
            myAccountToolStripMenuItem1.Name = "myAccountToolStripMenuItem1";
            myAccountToolStripMenuItem1.Size = new Size(179, 28);
            myAccountToolStripMenuItem1.Text = "My Account";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(179, 28);
            logOutToolStripMenuItem.Text = "Log out";
            // 
            // usr_email_txt
            // 
            usr_email_txt.Location = new Point(30, 252);
            usr_email_txt.Name = "usr_email_txt";
            usr_email_txt.Size = new Size(328, 27);
            usr_email_txt.TabIndex = 22;
            usr_email_txt.TextChanged += usr_email_txt_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(30, 224);
            label3.Name = "label3";
            label3.Size = new Size(204, 25);
            label3.TabIndex = 20;
            label3.Text = "Re-type new password";
            label3.Click += this.label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(30, 138);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 19;
            label2.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 71);
            label1.Name = "label1";
            label1.Size = new Size(301, 53);
            label1.TabIndex = 23;
            label1.Text = "Change Password";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(30, 314);
            button1.Name = "button1";
            button1.Size = new Size(145, 30);
            button1.TabIndex = 24;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(202, 314);
            button2.Name = "button2";
            button2.Size = new Size(145, 30);
            button2.TabIndex = 25;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(usr_email_txt);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Name = "ChangePassword";
            Text = "ChangePassword";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem myDeviceToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ToolStripMenuItem devicesToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem1;
        private ToolStripMenuItem myAccountToolStripMenuItem;
        private ToolStripMenuItem myAccountToolStripMenuItem1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private TextBox usr_email_txt;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private readonly EventHandler label3_Click;
    }
}