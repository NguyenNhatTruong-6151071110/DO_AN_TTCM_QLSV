using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmDSLH : Form
    {
        public FrmDSLH()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private string mlh;
        private void FrmDSLH_Load(object sender, EventArgs e)
        {
            loadDSLH();
        }
        private void loadDSLH()
        {
            string sql = "allLopHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = tukhoa
                }
            };
            dgvLopHoc.DataSource = new Database().SelectData(sql, lstPara);

            dgvLopHoc.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvLopHoc.Columns["giaovien"].HeaderText = "Giáo Viên";
            dgvLopHoc.Columns["tenmonhoc"].HeaderText = "Tên Môn Học";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSLH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new FrmLopHoc(null).ShowDialog();
            loadDSLH();
        }

        private void dgvLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new FrmLopHoc(dgvLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()).ShowDialog();
                loadDSLH();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "";
            int id = (int)dgvLopHoc.CurrentRow.Cells["malophoc"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa Lớp Học này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string malophoc = id.ToString();
                List<CustomParameter> lstPara = new List<CustomParameter>();
                {
                    sql = "deleteLopHoc";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = malophoc
                    });
                }
                var rs = new Database().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(mlh))
                    {
                        MessageBox.Show("Xóa Lớp Học Thành Công!", "Thông Báo");
                        loadDSLH();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa Lớp Học Thất Bại!", "Thông Báo");
                }

            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xlxs)|*.xlxs";
            saveFileDialog.Title = "Export to Excel";
            saveFileDialog.FileName = "XuatLopHoc.xlxs";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Data");

                        for (int i = 0; i < dgvLopHoc.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvLopHoc.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 1, j + 1].Value = dgvLopHoc.Rows[i].Cells[j].Value;
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
