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
    public partial class FrmDSMH : Form
    {
        public FrmDSMH()
        {
            InitializeComponent();
        }

        private void dgvDSMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamonhoc = dgvDSMH.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                new FrmMonHoc(mamonhoc).ShowDialog();
                loadDSMH();
            }
        }
        private string tukhoa = "";

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new FrmMonHoc(null).ShowDialog();
            loadDSMH();
        }
        private void loadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSMH.DataSource = new Database().SelectData("selectAllMonhoc", lstPara);
        }

        private void FrmDSMH_Load(object sender, EventArgs e)
        {
            loadDSMH();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSMH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "";
            int id = (int)dgvDSMH.CurrentRow.Cells["mamonhoc"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa Môn học này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string mamonhoc = id.ToString();
                List<CustomParameter> lstPara = new List<CustomParameter>();

                {
                    sql = "deleteMonhoc";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@mamonhoc",
                        value = mamonhoc
                    });
                }
                var rs = new Database().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(mamonhoc))
                    {
                        MessageBox.Show("Xóa Môn Học Thành Công!", "Thông Báo");
                        loadDSMH();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa Môn Học Thất Bại!", "Thông Báo");
                }

            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xlxs)|*.xlxs";
            saveFileDialog.Title = "Export to Excel";
            saveFileDialog.FileName = "XuatMonHoc.xlxs";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Data");

                        for (int i = 0; i < dgvDSMH.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvDSMH.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 1, j + 1].Value = dgvDSMH.Rows[i].Cells[j].Value;
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
