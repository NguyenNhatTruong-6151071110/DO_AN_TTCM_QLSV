namespace QuanLySinhVien
{
    partial class FrmDSMH
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
            dgvDSMH = new DataGridView();
            mamonhoc = new DataGridViewTextBoxColumn();
            tenmonhoc = new DataGridViewTextBoxColumn();
            sotinchi = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnThemMoi = new Button();
            btnXoa = new Button();
            btnXuatFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSMH).BeginInit();
            SuspendLayout();
            // 
            // dgvDSMH
            // 
            dgvDSMH.AllowUserToAddRows = false;
            dgvDSMH.AllowUserToDeleteRows = false;
            dgvDSMH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMH.Columns.AddRange(new DataGridViewColumn[] { mamonhoc, tenmonhoc, sotinchi });
            dgvDSMH.Location = new Point(0, 100);
            dgvDSMH.MultiSelect = false;
            dgvDSMH.Name = "dgvDSMH";
            dgvDSMH.ReadOnly = true;
            dgvDSMH.RowHeadersWidth = 51;
            dgvDSMH.RowTemplate.Height = 29;
            dgvDSMH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMH.Size = new Size(1111, 350);
            dgvDSMH.TabIndex = 0;
            dgvDSMH.CellDoubleClick += dgvDSMH_CellDoubleClick;
            // 
            // mamonhoc
            // 
            mamonhoc.DataPropertyName = "mamonhoc";
            mamonhoc.HeaderText = "Mã Môn Học";
            mamonhoc.MinimumWidth = 6;
            mamonhoc.Name = "mamonhoc";
            mamonhoc.ReadOnly = true;
            // 
            // tenmonhoc
            // 
            tenmonhoc.DataPropertyName = "tenmonhoc";
            tenmonhoc.HeaderText = "Tên Môn Học";
            tenmonhoc.MinimumWidth = 6;
            tenmonhoc.Name = "tenmonhoc";
            tenmonhoc.ReadOnly = true;
            // 
            // sotinchi
            // 
            sotinchi.DataPropertyName = "sotinchi";
            sotinchi.HeaderText = "Số Tín Chỉ";
            sotinchi.MinimumWidth = 6;
            sotinchi.Name = "sotinchi";
            sotinchi.ReadOnly = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(445, 42);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Từ Khóa";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(515, 40);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(181, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.BackColor = Color.DodgerBlue;
            btnTimKiem.ForeColor = SystemColors.ButtonHighlight;
            btnTimKiem.Location = new Point(702, 33);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 38);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoi.BackColor = Color.DodgerBlue;
            btnThemMoi.ForeColor = SystemColors.ButtonHighlight;
            btnThemMoi.Location = new Point(802, 33);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(94, 38);
            btnThemMoi.TabIndex = 4;
            btnThemMoi.Text = "Thêm Mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.DodgerBlue;
            btnXoa.ForeColor = SystemColors.ButtonHighlight;
            btnXoa.Location = new Point(902, 33);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 38);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXuatFile
            // 
            btnXuatFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatFile.BackColor = Color.DodgerBlue;
            btnXuatFile.ForeColor = SystemColors.ButtonHighlight;
            btnXuatFile.Location = new Point(1005, 33);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(94, 38);
            btnXuatFile.TabIndex = 6;
            btnXuatFile.Text = "Xuất File";
            btnXuatFile.UseVisualStyleBackColor = false;
            btnXuatFile.Click += btnXuatFile_Click;
            // 
            // FrmDSMH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1111, 450);
            Controls.Add(btnXuatFile);
            Controls.Add(btnXoa);
            Controls.Add(btnThemMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(dgvDSMH);
            Name = "FrmDSMH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách môn học";
            Load += FrmDSMH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSMH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSMH;
        private Label label1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnThemMoi;
        private Button btnXoa;
        private DataGridViewTextBoxColumn mamonhoc;
        private DataGridViewTextBoxColumn tenmonhoc;
        private DataGridViewTextBoxColumn sotinchi;
        private Button btnXuatFile;
    }
}