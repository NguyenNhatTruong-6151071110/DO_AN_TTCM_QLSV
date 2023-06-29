namespace QuanLySinhVien
{
    partial class KetQuaHocTap
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
            dgvKetQua = new DataGridView();
            label1 = new Label();
            txtTimKiem = new TextBox();
            btnTraCuu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // dgvKetQua
            // 
            dgvKetQua.AllowUserToAddRows = false;
            dgvKetQua.AllowUserToDeleteRows = false;
            dgvKetQua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Location = new Point(0, 112);
            dgvKetQua.MultiSelect = false;
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.ReadOnly = true;
            dgvKetQua.RowHeadersWidth = 51;
            dgvKetQua.RowTemplate.Height = 29;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.Size = new Size(1110, 338);
            dgvKetQua.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(596, 56);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(678, 49);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(251, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTraCuu.BackColor = Color.DodgerBlue;
            btnTraCuu.ForeColor = SystemColors.ButtonHighlight;
            btnTraCuu.Location = new Point(935, 44);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(104, 38);
            btnTraCuu.TabIndex = 3;
            btnTraCuu.Text = "Tra Cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // KetQuaHocTap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1111, 450);
            Controls.Add(btnTraCuu);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(dgvKetQua);
            Name = "KetQuaHocTap";
            Text = "Kết Quả Học Tập";
            Load += KetQuaHocTap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKetQua;
        private Label label1;
        private TextBox txtTimKiem;
        private Button btnTraCuu;
    }
}