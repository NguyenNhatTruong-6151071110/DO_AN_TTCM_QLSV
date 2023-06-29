namespace QuanLySinhVien
{
    partial class FrmDSMHDaDangKy
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
            dgvDSMHDK = new DataGridView();
            btnDangKy = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSMHDK).BeginInit();
            SuspendLayout();
            // 
            // dgvDSMHDK
            // 
            dgvDSMHDK.AllowUserToAddRows = false;
            dgvDSMHDK.AllowUserToDeleteRows = false;
            dgvDSMHDK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSMHDK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMHDK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMHDK.Location = new Point(2, 152);
            dgvDSMHDK.MultiSelect = false;
            dgvDSMHDK.Name = "dgvDSMHDK";
            dgvDSMHDK.ReadOnly = true;
            dgvDSMHDK.RowHeadersWidth = 51;
            dgvDSMHDK.RowTemplate.Height = 29;
            dgvDSMHDK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMHDK.Size = new Size(907, 297);
            dgvDSMHDK.TabIndex = 0;
            // 
            // btnDangKy
            // 
            btnDangKy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDangKy.BackColor = Color.DodgerBlue;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKy.ForeColor = SystemColors.ButtonFace;
            btnDangKy.Location = new Point(618, 33);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(280, 58);
            btnDangKy.TabIndex = 3;
            btnDangKy.Text = "Đăng Ký Học Phần";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHuy.BackColor = Color.DodgerBlue;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = SystemColors.ButtonFace;
            btnHuy.Location = new Point(335, 35);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(277, 55);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy Học Phần";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click_1;
            // 
            // FrmDSMHDaDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(910, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(dgvDSMHDK);
            Name = "FrmDSMHDaDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Sách Môn Học Đã Đăng Ký";
            Load += FrmDSMHDaDangKy_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSMHDK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDSMHDK;
        private Button btnDangKy;
        private Button btnHuy;
    }
}