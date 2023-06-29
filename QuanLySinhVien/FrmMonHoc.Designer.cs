namespace QuanLySinhVien
{
    partial class FrmMonHoc
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
            txtTenMonHoc = new TextBox();
            txtSoTinChi = new TextBox();
            label2 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 42);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Môn Học";
            // 
            // txtTenMonHoc
            // 
            txtTenMonHoc.Location = new Point(158, 35);
            txtTenMonHoc.Name = "txtTenMonHoc";
            txtTenMonHoc.Size = new Size(222, 27);
            txtTenMonHoc.TabIndex = 1;
            txtTenMonHoc.TextChanged += textBox1_TextChanged;
            // 
            // txtSoTinChi
            // 
            txtSoTinChi.Location = new Point(158, 77);
            txtSoTinChi.Name = "txtSoTinChi";
            txtSoTinChi.Size = new Size(222, 27);
            txtSoTinChi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 84);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Số Tín Chỉ";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DodgerBlue;
            btnLuu.ForeColor = SystemColors.ButtonHighlight;
            btnLuu.Location = new Point(158, 129);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(105, 38);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DodgerBlue;
            btnHuy.ForeColor = SystemColors.ButtonHighlight;
            btnHuy.Location = new Point(286, 129);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(105, 38);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FrmMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(451, 199);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtSoTinChi);
            Controls.Add(label2);
            Controls.Add(txtTenMonHoc);
            Controls.Add(label1);
            Name = "FrmMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMonHoc";
            Load += FrmMonHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenMonHoc;
        private TextBox txtSoTinChi;
        private Label label2;
        private Button btnLuu;
        private Button btnHuy;
    }
}