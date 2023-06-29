namespace QuanLySinhVien
{
    partial class FrmDiemThi
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
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnThem = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            dgvDiemThi = new DataGridView();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDiemThi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(565, 32);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Từ Khóa";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(632, 24);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(177, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(824, 22);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(926, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(167, 32);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Môn Học";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(243, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 28);
            comboBox1.TabIndex = 5;
            // 
            // dgvDiemThi
            // 
            dgvDiemThi.AllowUserToAddRows = false;
            dgvDiemThi.AllowUserToDeleteRows = false;
            dgvDiemThi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDiemThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiemThi.Location = new Point(1, 82);
            dgvDiemThi.Name = "dgvDiemThi";
            dgvDiemThi.ReadOnly = true;
            dgvDiemThi.RowHeadersWidth = 51;
            dgvDiemThi.RowTemplate.Height = 29;
            dgvDiemThi.Size = new Size(1129, 368);
            dgvDiemThi.TabIndex = 6;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1025, 23);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // FrmDiemThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1134, 450);
            Controls.Add(btnXoa);
            Controls.Add(dgvDiemThi);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDiemThi";
            Text = "FrmDiemThi";
            WindowState = FormWindowState.Maximized;
            Load += FrmDiemThi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiemThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnThem;
        private Label label2;
        private ComboBox comboBox1;
        private DataGridView dgvDiemThi;
        private Button btnXoa;
    }
}