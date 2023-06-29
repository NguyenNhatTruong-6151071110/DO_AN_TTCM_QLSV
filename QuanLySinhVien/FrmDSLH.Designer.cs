namespace QuanLySinhVien
{
    partial class FrmDSLH
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
            dgvLopHoc = new DataGridView();
            btnThem = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label1 = new Label();
            btnXoa = new Button();
            btnXuatFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).BeginInit();
            SuspendLayout();
            // 
            // dgvLopHoc
            // 
            dgvLopHoc.AllowUserToAddRows = false;
            dgvLopHoc.AllowUserToDeleteRows = false;
            dgvLopHoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLopHoc.Location = new Point(0, 82);
            dgvLopHoc.MultiSelect = false;
            dgvLopHoc.Name = "dgvLopHoc";
            dgvLopHoc.ReadOnly = true;
            dgvLopHoc.RowHeadersWidth = 51;
            dgvLopHoc.RowTemplate.Height = 29;
            dgvLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLopHoc.Size = new Size(1111, 368);
            dgvLopHoc.TabIndex = 13;
            dgvLopHoc.CellDoubleClick += dgvLopHoc_CellDoubleClick;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.DodgerBlue;
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(791, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 38);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.BackColor = Color.DodgerBlue;
            btnTimKiem.ForeColor = SystemColors.ButtonHighlight;
            btnTimKiem.Location = new Point(691, 20);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 38);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(508, 26);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(177, 27);
            txtTimKiem.TabIndex = 8;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(426, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Từ Khóa";
            label1.Click += label1_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.DodgerBlue;
            btnXoa.ForeColor = SystemColors.ButtonHighlight;
            btnXoa.Location = new Point(891, 20);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 38);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXuatFile
            // 
            btnXuatFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatFile.BackColor = Color.DodgerBlue;
            btnXuatFile.ForeColor = SystemColors.ButtonHighlight;
            btnXuatFile.Location = new Point(991, 19);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(94, 38);
            btnXuatFile.TabIndex = 15;
            btnXuatFile.Text = "Xuất File";
            btnXuatFile.UseVisualStyleBackColor = false;
            btnXuatFile.Click += btnXuatFile_Click;
            // 
            // FrmDSLH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1111, 450);
            Controls.Add(btnXuatFile);
            Controls.Add(btnXoa);
            Controls.Add(dgvLopHoc);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Name = "FrmDSLH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDSLH";
            Load += FrmDSLH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLopHoc;
        private Button btnThem;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label1;
        private Button btnXoa;
        private Button btnXuatFile;
    }
}