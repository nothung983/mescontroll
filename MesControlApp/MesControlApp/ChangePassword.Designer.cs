
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
            re_new_pass_txt = new TextBox();
            new_pass_txt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            savenewpass_Btn = new Button();
            Back_Btn = new Button();
            SuspendLayout();
            // 
            // re_new_pass_txt
            // 
            re_new_pass_txt.Location = new Point(29, 210);
            re_new_pass_txt.Name = "re_new_pass_txt";
            re_new_pass_txt.Size = new Size(328, 27);
            re_new_pass_txt.TabIndex = 22;
            re_new_pass_txt.TextChanged += usr_email_txt_TextChanged;
            // 
            // new_pass_txt
            // 
            new_pass_txt.Location = new Point(29, 124);
            new_pass_txt.Name = "new_pass_txt";
            new_pass_txt.Size = new Size(328, 27);
            new_pass_txt.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(29, 182);
            label3.Name = "label3";
            label3.Size = new Size(204, 25);
            label3.TabIndex = 20;
            label3.Text = "Re-type new password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(29, 96);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 19;
            label2.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(301, 53);
            label1.TabIndex = 23;
            label1.Text = "Change Password";
            // 
            // savenewpass_Btn
            // 
            savenewpass_Btn.BackColor = Color.MediumSeaGreen;
            savenewpass_Btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savenewpass_Btn.ForeColor = SystemColors.ControlLightLight;
            savenewpass_Btn.Location = new Point(29, 272);
            savenewpass_Btn.Name = "savenewpass_Btn";
            savenewpass_Btn.Size = new Size(145, 40);
            savenewpass_Btn.TabIndex = 24;
            savenewpass_Btn.Text = "Submit";
            savenewpass_Btn.UseVisualStyleBackColor = false;
            savenewpass_Btn.Click += savenewpass_Btn_Click;
            // 
            // Back_Btn
            // 
            Back_Btn.Location = new Point(201, 272);
            Back_Btn.Name = "Back_Btn";
            Back_Btn.Size = new Size(145, 40);
            Back_Btn.TabIndex = 25;
            Back_Btn.Text = "Back";
            Back_Btn.UseVisualStyleBackColor = true;
            Back_Btn.Click += Back_Btn_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 365);
            Controls.Add(Back_Btn);
            Controls.Add(savenewpass_Btn);
            Controls.Add(label1);
            Controls.Add(re_new_pass_txt);
            Controls.Add(new_pass_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox re_new_pass_txt;
        private TextBox new_pass_txt;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button savenewpass_Btn;
        private Button Back_Btn;
    }
}