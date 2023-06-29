using OfficeOpenXml;
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
    public partial class FrmChamDiem : Form
    {
        public FrmChamDiem(string magiaovien, string malophoc)
        {
            InitializeComponent();
            this.magiaovien = magiaovien;
            this.malophoc = malophoc;
        }
        private string magiaovien;
        private string malophoc;
        private void LoadDSSV()
        {
           List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = malophoc
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTuKhoa.Text
            });
            dgvDSSV.DataSource = new Database().SelectData("dssv", lstPara);
        }
        private void FrmChamDiem_Load(object sender, EventArgs e)
        {
            LoadDSSV();
            dgvDSSV.Columns["masinhvien"].HeaderText = "Mã Sinh Viên";
            dgvDSSV.Columns["hoten"].HeaderText = "Họ Và Tên";
            dgvDSSV.Columns["lanhoc"].HeaderText = "Lần Học";
            dgvDSSV.Columns["diemlan1"].HeaderText = "Điểm Lần 1";
            dgvDSSV.Columns["diemlan2"].HeaderText = "Điểm Lần 2";
            for (int i = 0; i <= 2; i++)
            {
                dgvDSSV.Columns[i].ReadOnly = true;
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xlxs)|*.xlxs";
            saveFileDialog.Title = "Export to Excel";
            saveFileDialog.FileName = "XuatDiem.xlxs";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Data");

                        for (int i = 0; i < dgvDSSV.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvDSSV.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 1, j + 1].Value = dgvDSSV.Rows[i].Cells[j].Value;
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
