using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitk;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //kiem tra rang buoc
            if (cbbLoaitaikhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txtDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                txtDangNhap.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu không thể để trống");
            }
            tendangnhap = txtDangNhap.Text;
            loaitk = "";

            #region swtk
            switch (cbbLoaitaikhoan.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo Viên":
                    loaitk = "giaovien";
                    break;
                case "Sinh Viên":
                    loaitk = "sinhvien";
                    break;
            }
            #endregion

            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value=loaitk
                },
                 new CustomParameter()
                {
                    key = "@taikhoan",
                    value=txtDangNhap.Text
                },
                  new CustomParameter()
                {
                    key = "@matkhau",
                    value=txtMatKhau.Text
                },
            };
            var rs = new Database().SelectData("dangnhap", lst);
            if (rs.Rows.Count <= 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu", "Tài khoản hoặc mật khẩu không đúng");
            }
            else
            {
                this.Hide();
            }

        }

        private void cbHienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienmatkhau.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '●';
            }
        }
    }
}
