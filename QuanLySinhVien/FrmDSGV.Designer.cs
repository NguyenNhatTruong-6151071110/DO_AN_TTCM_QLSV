namespace QuanLySinhVien
{
    partial class FrmDSGV
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
            textTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnThemMoi = new Button();
            dgvDSGV = new DataGridView();
            btnXoa = new Button();
            btnXuatfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(412, 39);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm";
            // 
            // textTimKiem
            // 
            textTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textTimKiem.Location = new Point(488, 33);
            textTimKiem.Name = "textTimKiem";
            textTimKiem.Size = new Size(198, 27);
            textTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.BackColor = Color.DodgerBlue;
            btnTimKiem.ForeColor = SystemColors.ButtonHighlight;
            btnTimKiem.Location = new Point(692, 27);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 38);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoi.BackColor = Color.DodgerBlue;
            btnThemMoi.ForeColor = SystemColors.ButtonHighlight;
            btnThemMoi.Location = new Point(792, 26);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(94, 38);
            btnThemMoi.TabIndex = 3;
            btnThemMoi.Text = "Thêm Mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // dgvDSGV
            // 
            dgvDSGV.AllowUserToAddRows = false;
            dgvDSGV.AllowUserToDeleteRows = false;
            dgvDSGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSGV.Location = new Point(0, 103);
            dgvDSGV.MultiSelect = false;
            dgvDSGV.Name = "dgvDSGV";
            dgvDSGV.ReadOnly = true;
            dgvDSGV.RowHeadersWidth = 51;
            dgvDSGV.RowTemplate.Height = 29;
            dgvDSGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSGV.Size = new Size(1111, 347);
            dgvDSGV.TabIndex = 4;
            dgvDSGV.CellContentClick += dgvDSGV_CellContentClick;
            dgvDSGV.CellDoubleClick += dgvDSGV_CellDoubleClick;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.DodgerBlue;
            btnXoa.ForeColor = SystemColors.ButtonHighlight;
            btnXoa.Location = new Point(892, 26);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 38);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXuatfile
            // 
            btnXuatfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatfile.BackColor = Color.DodgerBlue;
            btnXuatfile.ForeColor = SystemColors.ButtonHighlight;
            btnXuatfile.Location = new Point(992, 26);
            btnXuatfile.Name = "btnXuatfile";
            btnXuatfile.Size = new Size(94, 38);
            btnXuatfile.TabIndex = 6;
            btnXuatfile.Text = "Xuất File";
            btnXuatfile.UseVisualStyleBackColor = false;
            btnXuatfile.Click += btnXuatfile_Click;
            // 
            // FrmDSGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1111, 450);
            Controls.Add(btnXuatfile);
            Controls.Add(btnXoa);
            Controls.Add(dgvDSGV);
            Controls.Add(btnThemMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(textTimKiem);
            Controls.Add(label1);
            Name = "FrmDSGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Sách Giáo Viên";
            Load += FrmDSGV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textTimKiem;
        private Button btnTimKiem;
        private Button btnThemMoi;
        private DataGridView dgvDSGV;
        private Button btnXoa;
        private Button btnXuatfile;
    }
}