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
    public partial class FrmMonHoc : Form
    {
        private string mamonhoc;
        private string nguoithuchien = "admin";

        public FrmMonHoc(string mamonhoc)
        {
            this.mamonhoc = mamonhoc;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mamonhoc))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật môn học";
                var r = new Database().Select("exec SelectMonhoc '" + mamonhoc + "'");
                txtTenMonHoc.Text = r["tenmonhoc"].ToString();
                txtSoTinChi.Text = r["sotinchi"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var stc = int.Parse(txtSoTinChi.Text);
                if (stc <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                    txtSoTinChi.Select();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Số tín chỉ phải là kiểu số nguyên");
                txtSoTinChi.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtTenMonHoc.Text))
            {
                MessageBox.Show("Tên Môn Học không được để trống");
                txtTenMonHoc.Select();
                return;
            }
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mamonhoc))
            {
                sql = "insertMonhoc";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = mamonhoc
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                sql = "updateMonhoc";
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@tenmonhoc",
                value = txtTenMonHoc.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@sotinchi",
                value = txtSoTinChi.Text
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mamonhoc))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật môn học thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực hiện truy vấn thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
