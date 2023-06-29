using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmLopHoc : Form
    {
        public FrmLopHoc(string malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
        }
        private string malophoc;
        private Database db;
        private string nguoithuchien = "admin";
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmLopHoc_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value =""
                }
            };
            cbbMonhoc.DataSource = db.SelectData("selectAllMonhoc", lst);
            cbbMonhoc.DisplayMember = "tenmonhoc";//thuoc tinh hien thi
            cbbMonhoc.ValueMember = "mamonhoc";//gia tri (key) cua combobox
            cbbMonhoc.SelectedIndex = -1;

            cbbGiaovien.DataSource = db.SelectData("selectAllGV", lst);
            cbbGiaovien.DisplayMember = "hoten";//thuoc tinh hien thi
            cbbGiaovien.ValueMember = "magiaovien";//gia tri (key) cua combobox
            cbbGiaovien.SelectedIndex = -1;//set cbb kh chon gia tri nao

            if (string.IsNullOrEmpty(this.malophoc))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                var r = db.Select("exec selectLopHoc '" + malophoc + "'");
                cbbGiaovien.SelectedValue = r["magiaovien"].ToString();
                cbbMonhoc.SelectedValue = r["mamonhoc"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (cbbMonhoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            if (cbbGiaovien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
                return;
            }
            List<CustomParameter> lst = new List<CustomParameter>();
            if (string.IsNullOrEmpty(malophoc))
            {
                sql = "insertLopHoc";
                lst.Add(new CustomParameter()
                {
                    key = "nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "updateLopHoc";
                lst.Add(new CustomParameter()
                {
                    key = "nguoicapnhat",
                    value = nguoithuchien
                });
                lst.Add(new CustomParameter()
                {
                    key = "malophoc",
                    value = malophoc
                });
            }
            lst.Add(new CustomParameter()
            {
                key = "mamonhoc",
                value = cbbMonhoc.SelectedValue.ToString() //lay gia tri duoc chon cua cbb
            });
            lst.Add(new CustomParameter()
            {
                key = "magiaovien",
                value = cbbGiaovien.SelectedValue.ToString()
            });
            var kq = db.ExeCute(sql, lst);
            if (kq == 1)
            {
                if (string.IsNullOrEmpty(malophoc))
                {
                    MessageBox.Show("Thêm mới lớp học thành công");

                }
                else
                {
                    MessageBox.Show("Cập nhật lớp học thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại");
            }
        }
    }
}
