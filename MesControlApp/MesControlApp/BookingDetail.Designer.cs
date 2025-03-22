namespace MesControlApp
{
    partial class BookingDetail
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
            back_Btn = new Button();
            accessory_txt = new TextBox();
            lens_txt = new TextBox();
            cam_txt = new TextBox();
            endDate_txt = new TextBox();
            startDate_txt = new TextBox();
            user_txt = new TextBox();
            Accessory_lb = new Label();
            Cam_lb = new Label();
            Lens_lb = new Label();
            EndDate_lb = new Label();
            StartDate_lb = new Label();
            Book_Usr = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // back_Btn
            // 
            back_Btn.BackColor = Color.DodgerBlue;
            back_Btn.Font = new Font("Lexend Deca Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_Btn.ForeColor = SystemColors.ButtonHighlight;
            back_Btn.Location = new Point(42, 322);
            back_Btn.Name = "back_Btn";
            back_Btn.Size = new Size(206, 45);
            back_Btn.TabIndex = 35;
            back_Btn.Text = "Back";
            back_Btn.UseVisualStyleBackColor = false;
            back_Btn.Click += back_Btn_Click;
            // 
            // accessory_txt
            // 
            accessory_txt.Location = new Point(603, 255);
            accessory_txt.Name = "accessory_txt";
            accessory_txt.ReadOnly = true;
            accessory_txt.Size = new Size(279, 27);
            accessory_txt.TabIndex = 31;
            // 
            // lens_txt
            // 
            lens_txt.Location = new Point(603, 185);
            lens_txt.Name = "lens_txt";
            lens_txt.ReadOnly = true;
            lens_txt.Size = new Size(279, 27);
            lens_txt.TabIndex = 30;
            // 
            // cam_txt
            // 
            cam_txt.Location = new Point(603, 127);
            cam_txt.Name = "cam_txt";
            cam_txt.ReadOnly = true;
            cam_txt.Size = new Size(279, 27);
            cam_txt.TabIndex = 29;
            // 
            // endDate_txt
            // 
            endDate_txt.Location = new Point(183, 255);
            endDate_txt.Name = "endDate_txt";
            endDate_txt.ReadOnly = true;
            endDate_txt.Size = new Size(279, 27);
            endDate_txt.TabIndex = 28;
            // 
            // startDate_txt
            // 
            startDate_txt.Location = new Point(183, 190);
            startDate_txt.Name = "startDate_txt";
            startDate_txt.ReadOnly = true;
            startDate_txt.Size = new Size(279, 27);
            startDate_txt.TabIndex = 27;
            // 
            // user_txt
            // 
            user_txt.Location = new Point(183, 127);
            user_txt.Name = "user_txt";
            user_txt.ReadOnly = true;
            user_txt.Size = new Size(279, 27);
            user_txt.TabIndex = 26;
            // 
            // Accessory_lb
            // 
            Accessory_lb.AutoSize = true;
            Accessory_lb.Font = new Font("Lexend Deca", 12F);
            Accessory_lb.Location = new Point(483, 250);
            Accessory_lb.Name = "Accessory_lb";
            Accessory_lb.Size = new Size(114, 32);
            Accessory_lb.TabIndex = 24;
            Accessory_lb.Text = "Accessory";
            // 
            // Cam_lb
            // 
            Cam_lb.AutoSize = true;
            Cam_lb.Font = new Font("Lexend Deca", 12F);
            Cam_lb.Location = new Point(483, 122);
            Cam_lb.Name = "Cam_lb";
            Cam_lb.Size = new Size(92, 32);
            Cam_lb.TabIndex = 23;
            Cam_lb.Text = "Camera";
            // 
            // Lens_lb
            // 
            Lens_lb.AutoSize = true;
            Lens_lb.Font = new Font("Lexend Deca", 12F);
            Lens_lb.Location = new Point(483, 185);
            Lens_lb.Name = "Lens_lb";
            Lens_lb.Size = new Size(60, 32);
            Lens_lb.TabIndex = 22;
            Lens_lb.Text = "Lens";
            // 
            // EndDate_lb
            // 
            EndDate_lb.AutoSize = true;
            EndDate_lb.Font = new Font("Lexend Deca", 12F);
            EndDate_lb.Location = new Point(32, 250);
            EndDate_lb.Name = "EndDate_lb";
            EndDate_lb.Size = new Size(105, 32);
            EndDate_lb.TabIndex = 21;
            EndDate_lb.Text = "End Date";
            // 
            // StartDate_lb
            // 
            StartDate_lb.AutoSize = true;
            StartDate_lb.Font = new Font("Lexend Deca", 12F);
            StartDate_lb.Location = new Point(32, 185);
            StartDate_lb.Name = "StartDate_lb";
            StartDate_lb.Size = new Size(117, 32);
            StartDate_lb.TabIndex = 20;
            StartDate_lb.Text = "Start Date";
            // 
            // Book_Usr
            // 
            Book_Usr.AutoSize = true;
            Book_Usr.Font = new Font("Lexend Deca", 12F);
            Book_Usr.Location = new Point(32, 122);
            Book_Usr.Name = "Book_Usr";
            Book_Usr.Size = new Size(145, 32);
            Book_Usr.TabIndex = 19;
            Book_Usr.Text = "Booking User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lexend Deca SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(354, 48);
            label1.TabIndex = 18;
            label1.Text = "Booking Informations";
            // 
            // BookingDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 424);
            Controls.Add(back_Btn);
            Controls.Add(accessory_txt);
            Controls.Add(lens_txt);
            Controls.Add(cam_txt);
            Controls.Add(endDate_txt);
            Controls.Add(startDate_txt);
            Controls.Add(user_txt);
            Controls.Add(Accessory_lb);
            Controls.Add(Cam_lb);
            Controls.Add(Lens_lb);
            Controls.Add(EndDate_lb);
            Controls.Add(StartDate_lb);
            Controls.Add(Book_Usr);
            Controls.Add(label1);
            Name = "BookingDetail";
            Text = "BookingDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_Btn;
        private TextBox accessory_txt;
        private TextBox lens_txt;
        private TextBox cam_txt;
        private TextBox endDate_txt;
        private TextBox startDate_txt;
        private TextBox user_txt;
        private Label Accessory_lb;
        private Label Cam_lb;
        private Label Lens_lb;
        private Label EndDate_lb;
        private Label StartDate_lb;
        private Label Book_Usr;
        private Label label1;
    }
}