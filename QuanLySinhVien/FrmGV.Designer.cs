namespace QuanLySinhVien
{
    partial class FrmGV
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
            txtHo = new TextBox();
            txtTendem = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            rbtnNam = new RadioButton();
            rbtnNu = new RadioButton();
            mtbNgaysinh = new MaskedTextBox();
            label5 = new Label();
            txtDienthoai = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtDiachi = new TextBox();
            label8 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 51);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(183, 44);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(261, 27);
            txtHo.TabIndex = 1;
            // 
            // txtTendem
            // 
            txtTendem.Location = new Point(184, 77);
            txtTendem.Name = "txtTendem";
            txtTendem.Size = new Size(261, 27);
            txtTendem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 84);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Đệm";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(184, 110);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(261, 27);
            txtTen.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 117);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 157);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 6;
            label4.Text = "Giới Tính";
            // 
            // rbtnNam
            // 
            rbtnNam.AutoSize = true;
            rbtnNam.Checked = true;
            rbtnNam.Location = new Point(184, 153);
            rbtnNam.Name = "rbtnNam";
            rbtnNam.Size = new Size(62, 24);
            rbtnNam.TabIndex = 7;
            rbtnNam.TabStop = true;
            rbtnNam.Text = "Nam";
            rbtnNam.UseVisualStyleBackColor = true;
            // 
            // rbtnNu
            // 
            rbtnNu.AutoSize = true;
            rbtnNu.Location = new Point(318, 153);
            rbtnNu.Name = "rbtnNu";
            rbtnNu.Size = new Size(50, 24);
            rbtnNu.TabIndex = 8;
            rbtnNu.Text = "Nữ";
            rbtnNu.UseVisualStyleBackColor = true;
            // 
            // mtbNgaysinh
            // 
            mtbNgaysinh.Location = new Point(184, 183);
            mtbNgaysinh.Mask = "00/00/0000";
            mtbNgaysinh.Name = "mtbNgaysinh";
            mtbNgaysinh.Size = new Size(261, 27);
            mtbNgaysinh.TabIndex = 9;
            mtbNgaysinh.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 190);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 10;
            label5.Text = "Ngày Sinh";
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(183, 216);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(261, 27);
            txtDienthoai.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 223);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 11;
            label6.Text = "Điện Thoại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(184, 249);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 27);
            txtEmail.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(96, 256);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 13;
            label7.Text = "Email";
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(184, 282);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(261, 27);
            txtDiachi.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(96, 289);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 15;
            label8.Text = "Địa Chỉ";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DodgerBlue;
            btnLuu.ForeColor = SystemColors.ButtonHighlight;
            btnLuu.Location = new Point(184, 340);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(117, 38);
            btnLuu.TabIndex = 17;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DodgerBlue;
            btnHuy.ForeColor = SystemColors.ButtonHighlight;
            btnHuy.Location = new Point(318, 340);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(117, 38);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FrmGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(530, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtDiachi);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtDienthoai);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(mtbNgaysinh);
            Controls.Add(rbtnNu);
            Controls.Add(rbtnNam);
            Controls.Add(label4);
            Controls.Add(txtTen);
            Controls.Add(label3);
            Controls.Add(txtTendem);
            Controls.Add(label2);
            Controls.Add(txtHo);
            Controls.Add(label1);
            Name = "FrmGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGV";
            Load += FrmGV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHo;
        private TextBox txtTendem;
        private Label label2;
        private TextBox txtTen;
        private Label label3;
        private Label label4;
        private RadioButton rbtnNam;
        private RadioButton rbtnNu;
        private MaskedTextBox mtbNgaysinh;
        private Label label5;
        private TextBox txtDienthoai;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtDiachi;
        private Label label8;
        private Button btnLuu;
        private Button btnHuy;
    }
}