namespace QuanLySinhVien
{
    partial class frmNhapDiem
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
            txtdiemlan1 = new TextBox();
            label4 = new Label();
            txtdiemlan2 = new TextBox();
            label5 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // txtdiemlan1
            // 
            txtdiemlan1.Location = new Point(157, 45);
            txtdiemlan1.Name = "txtdiemlan1";
            txtdiemlan1.Size = new Size(218, 27);
            txtdiemlan1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 48);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 6;
            label4.Text = "Điểm Lần 1";
            // 
            // txtdiemlan2
            // 
            txtdiemlan2.Location = new Point(157, 95);
            txtdiemlan2.Name = "txtdiemlan2";
            txtdiemlan2.Size = new Size(218, 27);
            txtdiemlan2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 95);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 8;
            label5.Text = "Điểm Lần 2";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(157, 143);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(281, 143);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmNhapDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(484, 209);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtdiemlan2);
            Controls.Add(label5);
            Controls.Add(txtdiemlan1);
            Controls.Add(label4);
            Name = "frmNhapDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập Điểm";
            Load += frmNhapDiem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtdiemlan1;
        private Label label4;
        private TextBox txtdiemlan2;
        private Label label5;
        private Button btnLuu;
        private Button btnHuy;
    }
}