namespace QuanLySinhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            form1BindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            doimatkhauToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            quanLyToolStripMenuItem = new ToolStripMenuItem();
            sinhvienToolStripMenuItem = new ToolStripMenuItem();
            monhocToolStripMenuItem = new ToolStripMenuItem();
            giaovienToolStripMenuItem = new ToolStripMenuItem();
            lopHocToolStripMenuItem = new ToolStripMenuItem();
            chucNangToolStripMenuItem = new ToolStripMenuItem();
            dangkyMonHocToolStripMenuItem = new ToolStripMenuItem();
            traCuuDiemToolStripMenuItem = new ToolStripMenuItem();
            QlyLopToolStripMenuItem = new ToolStripMenuItem();
            dangXuatToolStripMenuItem = new ToolStripMenuItem();
            pnlContent = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Pink;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quanLyToolStripMenuItem, chucNangToolStripMenuItem, QlyLopToolStripMenuItem, dangXuatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(191, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doimatkhauToolStripMenuItem, thoatToolStripMenuItem });
            hệThốngToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            hệThốngToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            hệThốngToolStripMenuItem.Margin = new Padding(30, 200, 30, 10);
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(118, 29);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // doimatkhauToolStripMenuItem
            // 
            doimatkhauToolStripMenuItem.Name = "doimatkhauToolStripMenuItem";
            doimatkhauToolStripMenuItem.Size = new Size(224, 30);
            doimatkhauToolStripMenuItem.Text = "Đổi Mật Khẩu";
            doimatkhauToolStripMenuItem.Click += doimatkhauToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(224, 30);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // quanLyToolStripMenuItem
            // 
            quanLyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sinhvienToolStripMenuItem, monhocToolStripMenuItem, giaovienToolStripMenuItem, lopHocToolStripMenuItem });
            quanLyToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            quanLyToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            quanLyToolStripMenuItem.Margin = new Padding(30, 20, 30, 10);
            quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            quanLyToolStripMenuItem.Size = new Size(118, 29);
            quanLyToolStripMenuItem.Text = "Quản Lý";
            // 
            // sinhvienToolStripMenuItem
            // 
            sinhvienToolStripMenuItem.Name = "sinhvienToolStripMenuItem";
            sinhvienToolStripMenuItem.Size = new Size(180, 30);
            sinhvienToolStripMenuItem.Text = "Sinh Viên";
            sinhvienToolStripMenuItem.Click += sinhvienToolStripMenuItem_Click;
            // 
            // monhocToolStripMenuItem
            // 
            monhocToolStripMenuItem.Name = "monhocToolStripMenuItem";
            monhocToolStripMenuItem.Size = new Size(180, 30);
            monhocToolStripMenuItem.Text = "Môn Học";
            monhocToolStripMenuItem.Click += monhocToolStripMenuItem_Click;
            // 
            // giaovienToolStripMenuItem
            // 
            giaovienToolStripMenuItem.Name = "giaovienToolStripMenuItem";
            giaovienToolStripMenuItem.Size = new Size(180, 30);
            giaovienToolStripMenuItem.Text = "Giáo Viên";
            giaovienToolStripMenuItem.Click += giaovienToolStripMenuItem_Click;
            // 
            // lopHocToolStripMenuItem
            // 
            lopHocToolStripMenuItem.Name = "lopHocToolStripMenuItem";
            lopHocToolStripMenuItem.Size = new Size(180, 30);
            lopHocToolStripMenuItem.Text = "Lớp Học";
            lopHocToolStripMenuItem.Click += lopHocToolStripMenuItem_Click;
            // 
            // chucNangToolStripMenuItem
            // 
            chucNangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dangkyMonHocToolStripMenuItem, traCuuDiemToolStripMenuItem });
            chucNangToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            chucNangToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            chucNangToolStripMenuItem.Margin = new Padding(30, 20, 30, 10);
            chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            chucNangToolStripMenuItem.Size = new Size(118, 29);
            chucNangToolStripMenuItem.Text = "Chức Năng";
            // 
            // dangkyMonHocToolStripMenuItem
            // 
            dangkyMonHocToolStripMenuItem.Name = "dangkyMonHocToolStripMenuItem";
            dangkyMonHocToolStripMenuItem.Size = new Size(252, 30);
            dangkyMonHocToolStripMenuItem.Text = "Đăng Ký Môn Học";
            dangkyMonHocToolStripMenuItem.Click += dangkyMonHocToolStripMenuItem_Click;
            // 
            // traCuuDiemToolStripMenuItem
            // 
            traCuuDiemToolStripMenuItem.Name = "traCuuDiemToolStripMenuItem";
            traCuuDiemToolStripMenuItem.Size = new Size(252, 30);
            traCuuDiemToolStripMenuItem.Text = "Tra Cứu Điểm";
            traCuuDiemToolStripMenuItem.Click += traCuuDiemToolStripMenuItem_Click;
            // 
            // QlyLopToolStripMenuItem
            // 
            QlyLopToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            QlyLopToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            QlyLopToolStripMenuItem.Margin = new Padding(30, 20, 30, 10);
            QlyLopToolStripMenuItem.Name = "QlyLopToolStripMenuItem";
            QlyLopToolStripMenuItem.Size = new Size(118, 27);
            QlyLopToolStripMenuItem.Text = "Quản Lý Lớp";
            QlyLopToolStripMenuItem.Click += QlyLopToolStripMenuItem_Click;
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dangXuatToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            dangXuatToolStripMenuItem.Margin = new Padding(30, 20, 30, 10);
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(118, 27);
            dangXuatToolStripMenuItem.Text = "Đăng Xuất";
            dangXuatToolStripMenuItem.Click += dangXuatToolStripMenuItem_Click;
            // 
            // pnlContent
            // 
            pnlContent.AutoSize = true;
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(191, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(920, 450);
            pnlContent.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Pink;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 450);
            Controls.Add(pictureBox1);
            Controls.Add(pnlContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sinh Viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource form1BindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem doimatkhauToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem quanLyToolStripMenuItem;
        private ToolStripMenuItem sinhvienToolStripMenuItem;
        private ToolStripMenuItem monhocToolStripMenuItem;
        private ToolStripMenuItem giaovienToolStripMenuItem;
        private ToolStripMenuItem lopHocToolStripMenuItem;
        private ToolStripMenuItem chucNangToolStripMenuItem;
        private Panel pnlContent;
        private ToolStripMenuItem QlyLopToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem dangXuatToolStripMenuItem;
        private ToolStripMenuItem dangkyMonHocToolStripMenuItem;
        private ToolStripMenuItem traCuuDiemToolStripMenuItem;
    }
}