using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitk;
        private void Form1_Load(object sender, EventArgs e)
        {
            var fn = new FrmDangNhap();
            fn.ShowDialog();//cho load frmDangNhap khi form1 dc goi
            //sau khi dang nhap tat. lay tai khoan da dang nhap
            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            if (string.Equals(loaitk, "admin"))
            {
                QlyLopToolStripMenuItem.Visible = false;
                chucNangToolStripMenuItem.Visible = false;
            }
            else
            {
                quanLyToolStripMenuItem.Visible = false;
                if (loaitk.Equals("giaovien"))
                {
                    chucNangToolStripMenuItem.Visible = false;
                }
                else
                {
                    QlyLopToolStripMenuItem.Visible = false;
                }
            }


            FrmWelcome2 f = new FrmWelcome2();
            AddForm(f);
        }
        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sinhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSSV f = new FrmDSSV();
            AddForm(f);
        }

        private void monhocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSMH f = new FrmDSMH();
            AddForm(f);
        }

        private void giaovienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSGV f = new FrmDSGV();
            AddForm(f);
        }

        private void diemthiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiemThi f = new FrmDiemThi();
            AddForm(f);
        }

        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSLH f = new FrmDSLH();
            AddForm(f);
        }

        private void DangkyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có đăng xuất ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FrmDangNhap login = new FrmDangNhap();
                login.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void dangkyMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmDSMHDaDangKy(taikhoan);
            AddForm(f);
        }

        private void traCuuDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new KetQuaHocTap(taikhoan);
            AddForm(f);
        }

        private void QlyLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmQuanLyLop(taikhoan);
            AddForm(f);
        }

        private void doimatkhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new DoiMatKhau().ShowDialog();
            
        }
    }

}