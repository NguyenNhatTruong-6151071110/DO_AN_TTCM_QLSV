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
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            this.Text = "Nhập điểm của sinh viên";
            //lay thong tin chi tiet cua sinh vien dua vao msv
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "updateDiemSinhVien";
            string diemlan1 = txtdiemlan1.Text;
            string diemlan2 = txtdiemlan2.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@diemlan1",
                value = diemlan1
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diemlan2",
                value = diemlan2
            });
            var rs = new Database().ExeCute(sql, lstPara);
            MessageBox.Show("Nhập điểm thành công");
            this.Dispose();
        }
    }
}
