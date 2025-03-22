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
            user_role = new Label();
            usr_pass = new TextBox();
            user_pass = new Label();
            groupBox1 = new GroupBox();
            user_image = new PictureBox();
            usr_phone_txt = new TextBox();
            usr_email_txt = new TextBox();
            user_name_txt = new TextBox();
            user_phone_num = new Label();
            user_mail = new Label();
            user_name = new Label();
            user_info_lb = new Label();
            user_role_txt = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_image).BeginInit();
            SuspendLayout();
            // 
            // user_role
            // 
            user_role.AutoSize = true;
            user_role.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_role.Location = new Point(395, 344);
            user_role.Name = "user_role";
            user_role.Size = new Size(92, 25);
            user_role.TabIndex = 52;
            user_role.Text = "User Role";
            // 
            // usr_pass
            // 
            usr_pass.Location = new Point(395, 304);
            usr_pass.Name = "usr_pass";
            usr_pass.ReadOnly = true;
            usr_pass.Size = new Size(328, 27);
            usr_pass.TabIndex = 48;
            // 
            // user_pass
            // 
            user_pass.AutoSize = true;
            user_pass.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_pass.Location = new Point(395, 276);
            user_pass.Name = "user_pass";
            user_pass.Size = new Size(134, 25);
            user_pass.TabIndex = 47;
            user_pass.Text = "User Password";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(user_image);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(44, 78);
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
            usr_phone_txt.Location = new Point(395, 240);
            usr_phone_txt.Name = "usr_phone_txt";
            usr_phone_txt.ReadOnly = true;
            usr_phone_txt.Size = new Size(328, 27);
            usr_phone_txt.TabIndex = 45;
            // 
            // usr_email_txt
            // 
            usr_email_txt.Location = new Point(395, 179);
            usr_email_txt.Name = "usr_email_txt";
            usr_email_txt.ReadOnly = true;
            usr_email_txt.Size = new Size(328, 27);
            usr_email_txt.TabIndex = 44;
            // 
            // user_name_txt
            // 
            user_name_txt.Location = new Point(395, 119);
            user_name_txt.Name = "user_name_txt";
            user_name_txt.ReadOnly = true;
            user_name_txt.Size = new Size(328, 27);
            user_name_txt.TabIndex = 43;
            // 
            // user_phone_num
            // 
            user_phone_num.AutoSize = true;
            user_phone_num.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_phone_num.Location = new Point(395, 212);
            user_phone_num.Name = "user_phone_num";
            user_phone_num.Size = new Size(185, 25);
            user_phone_num.TabIndex = 41;
            user_phone_num.Text = "User Phone Number";
            // 
            // user_mail
            // 
            user_mail.AutoSize = true;
            user_mail.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_mail.Location = new Point(395, 151);
            user_mail.Name = "user_mail";
            user_mail.Size = new Size(102, 25);
            user_mail.TabIndex = 40;
            user_mail.Text = "User Email";
            // 
            // user_name
            // 
            user_name.AutoSize = true;
            user_name.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            user_name.Location = new Point(395, 91);
            user_name.Name = "user_name";
            user_name.Size = new Size(98, 25);
            user_name.TabIndex = 39;
            user_name.Text = "Username";
            // 
            // user_info_lb
            // 
            user_info_lb.AutoSize = true;
            user_info_lb.Font = new Font("Poppins", 14F, FontStyle.Bold);
            user_info_lb.Location = new Point(44, 33);
            user_info_lb.Name = "user_info_lb";
            user_info_lb.Size = new Size(301, 42);
            user_info_lb.TabIndex = 38;
            user_info_lb.Text = "User Detail Information";
            // 
            // user_role_txt
            // 
            user_role_txt.Location = new Point(395, 372);
            user_role_txt.Name = "user_role_txt";
            user_role_txt.ReadOnly = true;
            user_role_txt.Size = new Size(328, 27);
            user_role_txt.TabIndex = 54;
            // 
            // User_Detail_for_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 471);
            Controls.Add(user_role_txt);
            Controls.Add(user_role);
            Controls.Add(usr_pass);
            Controls.Add(user_pass);
            Controls.Add(groupBox1);
            Controls.Add(usr_phone_txt);
            Controls.Add(usr_email_txt);
            Controls.Add(user_name_txt);
            Controls.Add(user_phone_num);
            Controls.Add(user_mail);
            Controls.Add(user_name);
            Controls.Add(user_info_lb);
            Name = "User_Detail_for_Admin";
            Text = "User_Detail_for_Admin";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)user_image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label user_role;
        private TextBox usr_pass;
        private Label user_pass;
        private GroupBox groupBox1;
        private PictureBox user_image;
        private TextBox usr_phone_txt;
        private TextBox usr_email_txt;
        private TextBox user_name_txt;
        private Label user_phone_num;
        private Label user_mail;
        private Label user_name;
        private Label user_info_lb;
        private TextBox user_role_txt;
    }
}