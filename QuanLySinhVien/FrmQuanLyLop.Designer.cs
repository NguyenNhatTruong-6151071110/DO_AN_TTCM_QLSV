namespace QuanLySinhVien
{
    partial class FrmQuanLyLop
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
            dgvDSLop = new DataGridView();
            label1 = new Label();
            txtTuKhoa = new TextBox();
            btnTraCuu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSLop).BeginInit();
            SuspendLayout();
            // 
            // dgvDSLop
            // 
            dgvDSLop.AllowUserToAddRows = false;
            dgvDSLop.AllowUserToDeleteRows = false;
            dgvDSLop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLop.Location = new Point(-1, 124);
            dgvDSLop.MultiSelect = false;
            dgvDSLop.Name = "dgvDSLop";
            dgvDSLop.ReadOnly = true;
            dgvDSLop.RowHeadersWidth = 51;
            dgvDSLop.RowTemplate.Height = 29;
            dgvDSLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSLop.Size = new Size(1111, 326);
            dgvDSLop.TabIndex = 0;
            dgvDSLop.CellDoubleClick += dgvDSLop_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Pink;
            label1.Location = new Point(599, 56);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Từ Khóa";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTuKhoa.Location = new Point(681, 49);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(251, 27);
            txtTuKhoa.TabIndex = 2;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTraCuu.BackColor = Color.DodgerBlue;
            btnTraCuu.ForeColor = SystemColors.ButtonHighlight;
            btnTraCuu.Location = new Point(938, 44);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(104, 38);
            btnTraCuu.TabIndex = 3;
            btnTraCuu.Text = "Tra Cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // FrmQuanLyLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1111, 450);
            Controls.Add(btnTraCuu);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Controls.Add(dgvDSLop);
            Name = "FrmQuanLyLop";
            Text = "Quản Lý Lớp";
            Load += FrmQuanLyLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSLop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSLop;
        private Label label1;
        private TextBox txtTuKhoa;
        private Button btnTraCuu;
    }
}