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
    public partial class FrmDSMHDaDangKy : Form
    {
        private string msv;
        private string mlh;
        public FrmDSMHDaDangKy(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }

        private void FrmDSMHDaDangKy_Load(object sender, EventArgs e)
        {
            LoadMonDky();
        }
        private void LoadMonDky()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv
                }
            };
            dgvDSMHDK.DataSource = new Database().SelectData("monDaDky", lst);
            dgvDSMHDK.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDSMHDK.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvDSMHDK.Columns["sotinchi"].HeaderText = "Số Tín Chỉ";
            dgvDSMHDK.Columns["giaovien"].HeaderText = "Giáo Viên";
            dgvDSMHDK.Columns["diemlan1"].HeaderText = "Điểm Lần 1";
            dgvDSMHDK.Columns["diemlan2"].HeaderText = "Điểm Lần 2";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            new FrmDangKyMonHoc(msv).ShowDialog();
            LoadMonDky();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            string sql = "";
            int id = (int)dgvDSMHDK.CurrentRow.Cells["malophoc"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa Lớp Học này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string malophoc = id.ToString();
                List<CustomParameter> lstPara = new List<CustomParameter>();
                {
                    sql = "deletemonDaDky";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = malophoc
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@masinhvien",
                        value = msv
                    });
                }
                var rs = new Database().ExeCute(sql, lstPara);
                if (rs == 0)
                {
                    if (string.IsNullOrEmpty(mlh))
                    {
                        MessageBox.Show("Hủy Học Phần Thành Công!", "Thông Báo");
                        LoadMonDky();
                    }
                }
                else
                {
                    MessageBox.Show("Hủy Học Phần Thất Bại!", "Thông Báo");
                }

            }
        }
    }
}
