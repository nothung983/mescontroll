namespace Media_Device_Management
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Logintxt = new Label();
            pictureBox1 = new PictureBox();
            phonenumtxt = new TextBox();
            passtxt = new TextBox();
            submitBtn = new Button();
            PhoneNumber = new Label();
            Password = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Logintxt
            // 
            Logintxt.AutoSize = true;
            Logintxt.Font = new Font("Lexend Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logintxt.Location = new Point(485, 74);
            Logintxt.Name = "Logintxt";
            Logintxt.Size = new Size(121, 54);
            Logintxt.TabIndex = 0;
            Logintxt.Text = "Login";
            Logintxt.Click += Logintxt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 64);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 395);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // phonenumtxt
            // 
            phonenumtxt.Location = new Point(414, 189);
            phonenumtxt.Margin = new Padding(3, 4, 3, 4);
            phonenumtxt.Name = "phonenumtxt";
            phonenumtxt.Size = new Size(273, 27);
            phonenumtxt.TabIndex = 2;
            phonenumtxt.TextChanged += phonenumtxt_TextChanged;
            // 
            // passtxt
            // 
            passtxt.Location = new Point(412, 279);
            passtxt.Margin = new Padding(3, 4, 3, 4);
            passtxt.Name = "passtxt";
            passtxt.PasswordChar = '*';
            passtxt.Size = new Size(276, 27);
            passtxt.TabIndex = 3;
            passtxt.TextChanged += passtxt_TextChanged;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(485, 334);
            submitBtn.Margin = new Padding(3, 4, 3, 4);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(139, 46);
            submitBtn.TabIndex = 4;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += button1_Click;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Font = new Font("Lexend", 12F);
            PhoneNumber.Location = new Point(409, 149);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(160, 32);
            PhoneNumber.TabIndex = 5;
            PhoneNumber.Text = "Phone Number";
            PhoneNumber.Click += label2_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Lexend", 12F);
            Password.Location = new Point(409, 238);
            Password.Name = "Password";
            Password.Size = new Size(109, 32);
            Password.TabIndex = 6;
            Password.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(Password);
            Controls.Add(PhoneNumber);
            Controls.Add(submitBtn);
            Controls.Add(passtxt);
            Controls.Add(phonenumtxt);
            Controls.Add(pictureBox1);
            Controls.Add(Logintxt);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Logintxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox phonenumtxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Password;
    }
}

