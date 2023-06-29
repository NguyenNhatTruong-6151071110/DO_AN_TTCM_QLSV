namespace QuanLySinhVien
{
    partial class FrmChamDiem
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
            dgvDSSV = new DataGridView();
            label1 = new Label();
            txtTuKhoa = new TextBox();
            btnTraCuu = new Button();
            btnXuatFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSSV).BeginInit();
            SuspendLayout();
            // 
            // dgvDSSV
            // 
            dgvDSSV.AllowUserToAddRows = false;
            dgvDSSV.AllowUserToDeleteRows = false;
            dgvDSSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSSV.Location = new Point(-3, 116);
            dgvDSSV.Name = "dgvDSSV";
            dgvDSSV.ReadOnly = true;
            dgvDSSV.RowHeadersWidth = 51;
            dgvDSSV.RowTemplate.Height = 29;
            dgvDSSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSSV.Size = new Size(1114, 334);
            dgvDSSV.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(586, 54);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Từ Khóa";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(656, 47);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(243, 27);
            txtTuKhoa.TabIndex = 2;
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.DodgerBlue;
            btnTraCuu.ForeColor = SystemColors.ButtonHighlight;
            btnTraCuu.Location = new Point(905, 41);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(94, 38);
            btnTraCuu.TabIndex = 3;
            btnTraCuu.Text = "Tra Cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // btnXuatFile
            // 
            btnXuatFile.BackColor = Color.DodgerBlue;
            btnXuatFile.ForeColor = SystemColors.ButtonHighlight;
            btnXuatFile.Location = new Point(1005, 41);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(94, 38);
            btnXuatFile.TabIndex = 4;
            btnXuatFile.Text = "Xuất File";
            btnXuatFile.UseVisualStyleBackColor = false;
            btnXuatFile.Click += btnXuatFile_Click;
            // 
            // FrmChamDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1111, 450);
            Controls.Add(btnXuatFile);
            Controls.Add(btnTraCuu);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Controls.Add(dgvDSSV);
            Name = "FrmChamDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chấm Điểm";
            Load += FrmChamDiem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSSV;
        private Label label1;
        private TextBox txtTuKhoa;
        private Button btnTraCuu;
        private Button btnXuatFile;
    }
}