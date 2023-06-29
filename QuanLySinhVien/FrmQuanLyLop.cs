using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmQuanLyLop : Form
    {
        public FrmQuanLyLop(string magiaovien)
        {
            InitializeComponent();
            this.magiaovien = magiaovien;
        }
        private string magiaovien;

        private void FrmQuanLyLop_Load(object sender, EventArgs e)
        {
            LoadDSLop();
            dgvDSLop.Columns["malophoc"].HeaderText = "Mã Lớp Học";
            dgvDSLop.Columns["mamonhoc"].HeaderText = "Mã Học Phần";
            dgvDSLop.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
            dgvDSLop.Columns["sotinchi"].HeaderText = "Số Tín Chỉ";
            dgvDSLop.Columns["siso"].HeaderText = "Sĩ Số";
        }
        private void LoadDSLop()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = magiaovien
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTuKhoa.Text
            });
            dgvDSLop.DataSource = new Database().SelectData("tracuulop", lstPara);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadDSLop();
        }

        private void dgvDSLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLop.Rows[e.RowIndex].Index >= 0)
            {
                new FrmChamDiem(dgvDSLop.Rows[e.RowIndex].Cells["malophoc"].Value.ToString(),magiaovien).ShowDialog();
                LoadDSLop();
            }
        }
    }
}
