namespace MesControlApp
{
    partial class ReturnBooking
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
            dgvMyBooking = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMyBooking).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 33);
            label1.Name = "label1";
            label1.Size = new Size(215, 46);
            label1.TabIndex = 0;
            label1.Text = "My Booking";
            label1.Click += label1_Click;
            // 
            // dgvMyBooking
            // 
            dgvMyBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyBooking.Location = new Point(12, 119);
            dgvMyBooking.Name = "dgvMyBooking";
            dgvMyBooking.RowHeadersWidth = 51;
            dgvMyBooking.Size = new Size(925, 358);
            dgvMyBooking.TabIndex = 1;
            dgvMyBooking.CellContentClick += dgvMyBooking_CellContentClick_1;
            // 
            // ReturnBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 491);
            Controls.Add(dgvMyBooking);
            Controls.Add(label1);
            Name = "ReturnBooking";
            Text = "ReturnBooking";
            Load += ReturnBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMyBooking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvMyBooking;
    }
}