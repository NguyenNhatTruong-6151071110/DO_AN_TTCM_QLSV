namespace QuanLySinhVien
{
    partial class FrmDangKyMonHoc
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
            dgvDSLH = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDSLH).BeginInit();
            SuspendLayout();
            // 
            // dgvDSLH
            // 
            dgvDSLH.AllowUserToAddRows = false;
            dgvDSLH.AllowUserToDeleteRows = false;
            dgvDSLH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSLH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLH.Dock = DockStyle.Bottom;
            dgvDSLH.Location = new Point(0, 91);
            dgvDSLH.MultiSelect = false;
            dgvDSLH.Name = "dgvDSLH";
            dgvDSLH.ReadOnly = true;
            dgvDSLH.RowHeadersVisible = false;
            dgvDSLH.RowHeadersWidth = 51;
            dgvDSLH.RowTemplate.Height = 29;
            dgvDSLH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSLH.Size = new Size(800, 359);
            dgvDSLH.TabIndex = 0;
            dgvDSLH.CellDoubleClick += dgvDSLH_CellDoubleClick;
            // 
            // FrmDangKyMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDSLH);
            Name = "FrmDangKyMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Sách Lớp Học";
            Load += FrmDangKyMonHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSLH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDSLH;
    }
}