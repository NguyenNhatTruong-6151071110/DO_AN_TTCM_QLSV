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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLySinhVien
{
    public partial class DoiMatKhau : Form
    {
        private string connectionString = "Data Source=MSI;Initial Catalog=QLSinhVien;User ID=sa;Password=123456";
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string currentPassword = txtmkc.Text;
            string newPassword = txtmkm.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("doimatkhau", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Thêm các tham số vào thủ tục
                        command.Parameters.AddWithValue("@tentaikhoan", username);
                        command.Parameters.AddWithValue("@matkhaucu", currentPassword);
                        command.Parameters.AddWithValue("@matkhaumoi", newPassword);

                        // Thực thi thủ tục
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string result = reader["ThongBao"].ToString();
                                MessageBox.Show(result);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Xóa các ô đầu vào
            txtTaiKhoan.Clear();
            txtmkc.Clear();
            txtmkm.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmkc.PasswordChar = (char)0;
                txtmkm.PasswordChar = (char)0;
            }
            else
            {
                txtmkc.PasswordChar = '●';
                txtmkm.PasswordChar = '●';
            }
        }
    }
}
