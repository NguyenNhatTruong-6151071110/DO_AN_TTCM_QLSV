namespace QuanLySinhVien
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbbLoaitaikhoan = new ComboBox();
            txtDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            cbHienmatkhau = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 229);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Loại Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 309);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 392);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // cbbLoaitaikhoan
            // 
            cbbLoaitaikhoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbLoaitaikhoan.FormattingEnabled = true;
            cbbLoaitaikhoan.Items.AddRange(new object[] { "Quản trị viên", "Giáo Viên", "Sinh Viên" });
            cbbLoaitaikhoan.Location = new Point(182, 230);
            cbbLoaitaikhoan.Name = "cbbLoaitaikhoan";
            cbbLoaitaikhoan.Size = new Size(283, 28);
            cbbLoaitaikhoan.TabIndex = 5;
            // 
            // txtDangNhap
            // 
            txtDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDangNhap.Location = new Point(182, 296);
            txtDangNhap.Multiline = true;
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(283, 50);
            txtDangNhap.TabIndex = 5;
            txtDangNhap.TextAlign = HorizontalAlignment.Center;
            txtDangNhap.TextChanged += txtDangNhap_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(183, 381);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(283, 50);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.DodgerBlue;
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangNhap.Location = new Point(57, 516);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(185, 55);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.DodgerBlue;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(266, 516);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(190, 55);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Pink;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(169, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(100, 184);
            label4.Name = "label4";
            label4.Size = new Size(367, 31);
            label4.TabIndex = 9;
            label4.Text = "PHẦN MỀM QUẢN LÝ SINH VIÊN";
            // 
            // cbHienmatkhau
            // 
            cbHienmatkhau.AutoSize = true;
            cbHienmatkhau.Location = new Point(183, 456);
            cbHienmatkhau.Name = "cbHienmatkhau";
            cbHienmatkhau.Size = new Size(148, 24);
            cbHienmatkhau.TabIndex = 10;
            cbHienmatkhau.Text = "Hiển thị mật khẩu";
            cbHienmatkhau.UseVisualStyleBackColor = true;
            cbHienmatkhau.CheckedChanged += cbHienmatkhau_CheckedChanged;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(528, 606);
            Controls.Add(cbHienmatkhau);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtDangNhap);
            Controls.Add(cbbLoaitaikhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbLoaitaikhoan;
        private TextBox txtDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
        private PictureBox pictureBox1;
        private Label label4;
        private CheckBox cbHienmatkhau;
    }
}