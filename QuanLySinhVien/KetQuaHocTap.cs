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
    public partial class KetQuaHocTap : Form
    {
        private string msv;
        public KetQuaHocTap(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }

        private void KetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadKQHT();
            dgvKetQua.Columns["mamonhoc"].HeaderText = "Mã Học Phần";
            dgvKetQua.Columns["tenmonhoc"].HeaderText = "Tên Học Phần";
            dgvKetQua.Columns["lanhoc"].HeaderText = "Lần Học";
            dgvKetQua.Columns["giaovien"].HeaderText = "Giáo Viên";
            dgvKetQua.Columns["diemlan1"].HeaderText = "Điểm Lần 1";
            dgvKetQua.Columns["diemlan2"].HeaderText = "Điểm Lần 2";
        }
        private void LoadKQHT()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTimKiem.Text
            });
            dgvKetQua.DataSource = new Database().SelectData("tracuudiem", lstPara);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadKQHT();
        }
    }
}
