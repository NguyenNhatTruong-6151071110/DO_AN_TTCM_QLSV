namespace QuanLySinhVien
{
    partial class FrmLopHoc
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
            cbbMonhoc = new ComboBox();
            cbbGiaovien = new ComboBox();
            label2 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Môn Học";
            // 
            // cbbMonhoc
            // 
            cbbMonhoc.FormattingEnabled = true;
            cbbMonhoc.Location = new Point(122, 19);
            cbbMonhoc.Name = "cbbMonhoc";
            cbbMonhoc.Size = new Size(276, 28);
            cbbMonhoc.TabIndex = 1;
            // 
            // cbbGiaovien
            // 
            cbbGiaovien.FormattingEnabled = true;
            cbbGiaovien.Location = new Point(122, 71);
            cbbGiaovien.Name = "cbbGiaovien";
            cbbGiaovien.Size = new Size(276, 28);
            cbbGiaovien.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 74);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Giáo Viên";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DodgerBlue;
            btnLuu.ForeColor = SystemColors.ButtonHighlight;
            btnLuu.Location = new Point(122, 121);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(117, 38);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DodgerBlue;
            btnHuy.ForeColor = SystemColors.ButtonHighlight;
            btnHuy.Location = new Point(285, 121);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(117, 38);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FrmLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(437, 186);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(cbbGiaovien);
            Controls.Add(label2);
            Controls.Add(cbbMonhoc);
            Controls.Add(label1);
            Name = "FrmLopHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLopHoc";
            Load += FrmLopHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbMonhoc;
        private ComboBox cbbGiaovien;
        private Label label2;
        private Button btnLuu;
        private Button btnHuy;
    }
}