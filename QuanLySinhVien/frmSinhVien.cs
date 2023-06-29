using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien(string msv)
        {
            this.msv = msv; //truyền lại msv khi form chạy
            InitializeComponent();
        }
        private string msv;


        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))//nếu msv k có => thêm mới sinh viên
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên";
                //lay thong tin chi tiet cua sinh vien dua vao msv
                var r = new Database().Select("selectSV '" + msv + "'");
                //MessageBox.Show(r[0].ToString());
                //set cac gia tri vao component cua form
                textHo.Text = r["ho"].ToString();
                textTendem.Text = r["tendem"].ToString();
                textTen.Text = r["ten"].ToString();
                maskedTextBoxNgaysinh.Text = r["ngaysinh"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 0)
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }
                textQuequan.Text = r["quequan"].ToString();
                textDiachi.Text = r["diachi"].ToString();
                textSodienthoai.Text = r["dienthoai"].ToString();
                textEmail.Text = r["email"].ToString();
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string ho = textHo.Text;
            string tendem = textTendem.Text;
            string ten = textTen.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(maskedTextBoxNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                maskedTextBoxNgaysinh.Select();//trỏ chuột về maskedTextBoxNgaysinh
                return;
            }
            string gioitinh = rbtNam.Checked ? "0" : "1";//toán thử 2 ngôi
            string quequan = textQuequan.Text;
            string diachi = textDiachi.Text;
            string dienthoai = textSodienthoai.Text;
            string email = textEmail.Text;
            //Khai báo ds tham số = class Parameter
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv))//msv k co gia tri->them moi
            {
                sql = "ThemMoiSV";//truy van toi procedure them moi
            }
            else//cap nhat sinh vien
            {
                sql = "updateSV";//truy van toi procedure update

                lstPara.Add(new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = ho
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = tendem
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = ten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@quequan",
                value = quequan
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = diachi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = dienthoai
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = email
            });
            var rs = new Database().ExeCute(sql, lstPara);//truyền 2 tham số vào câu lệnh sql và ds tham số
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                }
                else //nếu cập nhật
                {
                    MessageBox.Show("Cập nhật sinh viên thành công");
                }
                this.Dispose(); //Đóng form
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}
