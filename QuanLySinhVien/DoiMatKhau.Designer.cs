namespace QuanLySinhVien
{
    partial class DoiMatKhau
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
            txtmkc = new TextBox();
            txtmkm = new TextBox();
            button1 = new Button();
            label3 = new Label();
            txtTaiKhoan = new TextBox();
            btnHuy = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 114);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập Mật Khẩu Cũ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 174);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập Mật Khẩu Mới";
            // 
            // txtmkc
            // 
            txtmkc.Location = new Point(226, 107);
            txtmkc.Name = "txtmkc";
            txtmkc.PasswordChar = '●';
            txtmkc.Size = new Size(272, 27);
            txtmkc.TabIndex = 2;
            // 
            // txtmkm
            // 
            txtmkm.Location = new Point(226, 167);
            txtmkm.Name = "txtmkm";
            txtmkm.PasswordChar = '●';
            txtmkm.Size = new Size(272, 27);
            txtmkm.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(226, 256);
            button1.Name = "button1";
            button1.Size = new Size(115, 42);
            button1.TabIndex = 4;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 60);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 5;
            label3.Text = "Tài Khoản";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(226, 53);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(272, 27);
            txtTaiKhoan.TabIndex = 6;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DodgerBlue;
            btnHuy.ForeColor = SystemColors.ButtonHighlight;
            btnHuy.Location = new Point(383, 256);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(115, 42);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(221, 208);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(588, 337);
            Controls.Add(checkBox1);
            Controls.Add(btnHuy);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtmkm);
            Controls.Add(txtmkc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Mật Khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtmkc;
        private TextBox txtmkm;
        private Button button1;
        private Label label3;
        private TextBox txtTaiKhoan;
        private Button btnHuy;
        private CheckBox checkBox1;
    }
}