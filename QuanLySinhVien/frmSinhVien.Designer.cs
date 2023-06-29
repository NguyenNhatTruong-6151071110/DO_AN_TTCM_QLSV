namespace QuanLySinhVien
{
    partial class frmSinhVien
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
            textHo = new TextBox();
            textTendem = new TextBox();
            label2 = new Label();
            textTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            maskedTextBoxNgaysinh = new MaskedTextBox();
            rbtNam = new RadioButton();
            label5 = new Label();
            rbtNu = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            buttonLuu = new Button();
            buttonHuy = new Button();
            textQuequan = new TextBox();
            textDiachi = new TextBox();
            textSodienthoai = new TextBox();
            textEmail = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 19);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ";
            // 
            // textHo
            // 
            textHo.Location = new Point(224, 12);
            textHo.Name = "textHo";
            textHo.Size = new Size(240, 27);
            textHo.TabIndex = 1;
            // 
            // textTendem
            // 
            textTendem.Location = new Point(224, 45);
            textTendem.Name = "textTendem";
            textTendem.Size = new Size(240, 27);
            textTendem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 52);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Đệm";
            // 
            // textTen
            // 
            textTen.Location = new Point(224, 78);
            textTen.Name = "textTen";
            textTen.Size = new Size(240, 27);
            textTen.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 85);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 118);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 6;
            label4.Text = "Ngày Sinh";
            // 
            // maskedTextBoxNgaysinh
            // 
            maskedTextBoxNgaysinh.Location = new Point(224, 115);
            maskedTextBoxNgaysinh.Mask = "00/00/0000";
            maskedTextBoxNgaysinh.Name = "maskedTextBoxNgaysinh";
            maskedTextBoxNgaysinh.Size = new Size(240, 27);
            maskedTextBoxNgaysinh.TabIndex = 7;
            maskedTextBoxNgaysinh.ValidatingType = typeof(DateTime);
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.Checked = true;
            rbtNam.Location = new Point(224, 144);
            rbtNam.Name = "rbtNam";
            rbtNam.Size = new Size(62, 24);
            rbtNam.TabIndex = 8;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 148);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 9;
            label5.Text = "Giới Tính";
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.Location = new Point(347, 144);
            rbtNu.Name = "rbtNu";
            rbtNu.Size = new Size(50, 24);
            rbtNu.TabIndex = 10;
            rbtNu.Text = "Nữ";
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 177);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 11;
            label6.Text = "Quê Quán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(114, 214);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 13;
            label7.Text = "Địa Chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(113, 247);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 15;
            label8.Text = "Số Điện Thoại";
            label8.Click += label8_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(113, 280);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 17;
            label9.Text = "Email";
            // 
            // buttonLuu
            // 
            buttonLuu.BackColor = Color.DodgerBlue;
            buttonLuu.ForeColor = SystemColors.ButtonHighlight;
            buttonLuu.Location = new Point(224, 323);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(117, 38);
            buttonLuu.TabIndex = 19;
            buttonLuu.Text = "Lưu";
            buttonLuu.UseVisualStyleBackColor = false;
            buttonLuu.Click += buttonLuu_Click;
            // 
            // buttonHuy
            // 
            buttonHuy.BackColor = Color.DodgerBlue;
            buttonHuy.ForeColor = SystemColors.ButtonHighlight;
            buttonHuy.Location = new Point(347, 323);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(117, 38);
            buttonHuy.TabIndex = 20;
            buttonHuy.Text = "Hủy";
            buttonHuy.UseVisualStyleBackColor = false;
            buttonHuy.Click += button2_Click;
            // 
            // textQuequan
            // 
            textQuequan.Location = new Point(224, 177);
            textQuequan.Name = "textQuequan";
            textQuequan.Size = new Size(240, 27);
            textQuequan.TabIndex = 21;
            // 
            // textDiachi
            // 
            textDiachi.Location = new Point(224, 214);
            textDiachi.Name = "textDiachi";
            textDiachi.Size = new Size(240, 27);
            textDiachi.TabIndex = 22;
            // 
            // textSodienthoai
            // 
            textSodienthoai.Location = new Point(224, 247);
            textSodienthoai.Name = "textSodienthoai";
            textSodienthoai.Size = new Size(240, 27);
            textSodienthoai.TabIndex = 23;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(224, 280);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(240, 27);
            textEmail.TabIndex = 24;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(567, 383);
            Controls.Add(textEmail);
            Controls.Add(textSodienthoai);
            Controls.Add(textDiachi);
            Controls.Add(textQuequan);
            Controls.Add(buttonHuy);
            Controls.Add(buttonLuu);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(rbtNu);
            Controls.Add(label5);
            Controls.Add(rbtNam);
            Controls.Add(maskedTextBoxNgaysinh);
            Controls.Add(label4);
            Controls.Add(textTen);
            Controls.Add(label3);
            Controls.Add(textTendem);
            Controls.Add(label2);
            Controls.Add(textHo);
            Controls.Add(label1);
            Name = "frmSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSinhVien";
            Load += frmSinhVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textHo;
        private TextBox textTendem;
        private Label label2;
        private TextBox textTen;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBoxNgaysinh;
        private RadioButton rbtNam;
        private Label label5;
        private RadioButton rbtNu;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button buttonLuu;
        private Button buttonHuy;
        private TextBox textQuequan;
        private TextBox textDiachi;
        private TextBox textSodienthoai;
        private TextBox textEmail;
    }
}