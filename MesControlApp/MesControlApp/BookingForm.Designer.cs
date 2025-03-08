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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            textBox3 = new TextBox();
            cboCam = new ComboBox();
            label7 = new Label();
            cboLens = new ComboBox();
            label8 = new Label();
            cboAcc = new ComboBox();
            btnBook = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(204, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 0;
            label1.Text = "Booking Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 102);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "User ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 162);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Camera";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 372);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Start Day";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 437);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "End Day";
            // 
            // txtUsrID
            // 
            txtUsrID.Location = new Point(145, 95);
            txtUsrID.Name = "txtUsrID";
            txtUsrID.ReadOnly = true;
            txtUsrID.Size = new Size(205, 27);
            txtUsrID.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(140, 365);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(140, 430);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(126, 27);
            dateTimePicker2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 510);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 9;
            label6.Text = "Reason";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 507);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(332, 136);
            textBox3.TabIndex = 10;
            // 
            // cboCam
            // 
            cboCam.FormattingEnabled = true;
            cboCam.Location = new Point(145, 154);
            cboCam.Name = "cboCam";
            cboCam.Size = new Size(205, 28);
            cboCam.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 232);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 2;
            label7.Text = "Lens";
            label7.Click += label3_Click;
            // 
            // cboLens
            // 
            cboLens.FormattingEnabled = true;
            cboLens.Location = new Point(145, 224);
            cboLens.Name = "cboLens";
            cboLens.Size = new Size(205, 28);
            cboLens.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 299);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 2;
            label8.Text = "Accessory";
            label8.Click += label3_Click;
            // 
            // cboAcc
            // 
            cboAcc.FormattingEnabled = true;
            cboAcc.Location = new Point(145, 291);
            cboAcc.Name = "cboAcc";
            cboAcc.Size = new Size(205, 28);
            cboAcc.TabIndex = 12;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(171, 678);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(140, 38);
            btnBook.TabIndex = 13;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 749);
            Controls.Add(btnBook);
            Controls.Add(cboAcc);
            Controls.Add(cboLens);
            Controls.Add(cboCam);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
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
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private TextBox textBox3;
        private ComboBox cboCam;
        private Label label7;
        private ComboBox cboLens;
        private Label label8;
        private ComboBox cboAcc;
        private Button btnBook;
    }
}