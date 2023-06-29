using OfficeOpenXml;
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
    public partial class FrmDSGV : Form
    {
        public FrmDSGV()
        {
            InitializeComponent();
        }

        private void FrmDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = textTimKiem.Text;
            loadDSGV();
        }
        private string tukhoa = "";
        private string mgv;
        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa,
            });
            dgvDSGV.DataSource = new Database().SelectData(sql, lstPara);
            dgvDSGV.Columns["magiaovien"].HeaderText = "Mã Giáo Viên";
            dgvDSGV.Columns["hoten"].HeaderText = "Họ Tên";
            dgvDSGV.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgvDSGV.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvDSGV.Columns["dienthoai"].HeaderText = "Điện Thoại";
            dgvDSGV.Columns["email"].HeaderText = "Email";
            dgvDSGV.Columns["diachi"].HeaderText = "Địa Chỉ";


        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new FrmGV(null).ShowDialog();
            loadDSGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new FrmGV(mgv).ShowDialog();
                loadDSGV();
            }
        }

        private void dgvDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "";
            int id = (int)dgvDSGV.CurrentRow.Cells["magiaovien"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa Giảng Viên này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string magiaovien = id.ToString();
                List<CustomParameter> lstPara = new List<CustomParameter>();

                {
                    sql = "deleteGV";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@magiaovien",
                        value = magiaovien
                    });
                }
                var rs = new Database().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(mgv))
                    {
                        MessageBox.Show("Xóa Giảng Viên Thành Công!", "Thông Báo");
                        loadDSGV();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa Giảng Viên Thất Bại!", "Thông Báo");
                }

            }
        }

        private void btnXuatfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xlxs)|*.xlxs";
            saveFileDialog.Title = "Export to Excel";
            saveFileDialog.FileName = "XuatGiaoVien.xlxs";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Data");

                        for (int i = 0; i < dgvDSGV.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvDSGV.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 1, j + 1].Value = dgvDSGV.Rows[i].Cells[j].Value;
                            }
                        }
                        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(excelFile);

                        MessageBox.Show("Xuất file thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
