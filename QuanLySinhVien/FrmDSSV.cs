using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Spreadsheet;

namespace QuanLySinhVien
{
    public partial class FrmDSSV : Form
    {


        public FrmDSSV()
        {
            InitializeComponent();
        }

        private void FrmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();//gọi tới hàm loadDSSV
        }
        private string msv;
        private void LoadDSSV()
        {
            string tukhoa = textTuKhoa.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });

            //load toan bo danh sach sinh vien khi form load
            dataGridView1.DataSource = new Database().SelectData("SelectAllSinhVien", lstPara);

            dataGridView1.Columns["masinhvien"].HeaderText = "Mã Sinh Viên";
            dataGridView1.Columns["hoten"].HeaderText = "Họ Tên";
            dataGridView1.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["gioitinh"].HeaderText = "Giới Tính";
            dataGridView1.Columns["quequan"].HeaderText = "Quê Quán";
            dataGridView1.Columns["diachi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["dienthoai"].HeaderText = "Điện Thoại";
            dataGridView1.Columns["email"].HeaderText = "Email";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();//nếu thêm mới sinh viên -> msv = null
            LoadDSSV();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "";
            string ma = (string)dataGridView1.CurrentRow.Cells["masinhvien"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa Sinh Viên này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string masinhvien = ma.ToString();
                List<CustomParameter> lstPara = new List<CustomParameter>();

                {
                    sql = "deleteSV";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@masinhvien",
                        value = masinhvien
                    });
                }
                var rs = new Database().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(msv))
                    {
                        MessageBox.Show("Xóa Sinh Viên Thành Công!", "Thông Báo");
                        LoadDSSV();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa Sinh Viên Thất Bại!", "Thông Báo");
                }
            }
        }

        private void xuatfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xlxs)|*.xlxs";
            saveFileDialog.Title = "Export to Excel";
            saveFileDialog.FileName = "XuatSinhVien.xlxs";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Data");
                        
                        for(int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for(int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 1, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value;
                            }
                        }
                        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(excelFile);

                        MessageBox.Show("Xuất file thành công");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dataGridView1.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                // truyền mã sinh viên vào form sinh viên
                new frmSinhVien(msv).ShowDialog();

                //sau khi form SV đóng cần load lại DSSV
                LoadDSSV();
            }
        }
    }
}
