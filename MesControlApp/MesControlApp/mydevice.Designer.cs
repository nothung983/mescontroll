namespace MesControlApp
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(153, 41);
            label1.TabIndex = 0;
            label1.Text = "My Devices";
            // 
            // listView1
            // 
            listView1.Location = new Point(20, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(540, 250);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Columns.AddRange(new[] {
                new ColumnHeader { Text = "Device Type", Width = 100 },
                new ColumnHeader { Text = "Name", Width = 200 },
                new ColumnHeader { Text = "Brand", Width = 100 },
                new ColumnHeader { Text = "Booking Status", Width = 120 }
            });
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(400, 300);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Device";
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Click += btnAdd_Click;
            // 
            // mydevice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(btnAdd);
            Controls.Add(listView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "mydevice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Devices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button btnAdd;
    }
}
//namespace MesControlApp
//{
//    partial class mydevice
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            label1 = new Label();
//            listView1 = new ListView();
//            btnAdd = new Button();
//            SuspendLayout();
//            // 
//            // label1
//            // 
//            label1.AutoSize = true;
//            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            label1.Location = new Point(298, 41);
//            label1.Name = "label1";
//            label1.Size = new Size(153, 41);
//            label1.TabIndex = 0;
//            label1.Text = "My device";
//            // 
//            // listView1
//            // 
//            listView1.Location = new Point(40, 100);
//            listView1.Name = "listView1";
//            listView1.Size = new Size(662, 265);
//            listView1.TabIndex = 1;
//            listView1.UseCompatibleStateImageBehavior = false;
//            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
//            // 
//            // btnAdd
//            // 
//            btnAdd.Location = new Point(604, 383);
//            btnAdd.Name = "btnAdd";
//            btnAdd.Size = new Size(98, 49);
//            btnAdd.TabIndex = 2;
//            btnAdd.Text = "Add";
//            btnAdd.UseVisualStyleBackColor = true;
//            btnAdd.Click += btnAdd_Click;
//            // 
//            // mydevice
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(761, 454);
//            Controls.Add(btnAdd);
//            Controls.Add(listView1);
//            Controls.Add(label1);
//            Name = "mydevice";
//            Text = "mydevice";
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private Label label1;
//        private ListView listView1;
//        private Button btnAdd;
//    }
//}