using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLySinhVien
{
    internal class Database
    {
        private string connectionString = @"Data Source=MSI;Initial Catalog=QLSinhVien;User ID=sa; Password=123456";
        private SqlConnection cnn;
        private DataTable dt;
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                cnn = new SqlConnection(connectionString);
            }catch (Exception ex)
            {
                MessageBox.Show("connected failed:" + ex.Message);
            }
        }
        public DataTable? SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql,cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                cnn.Close();
            }
        }

        public DataRow? Select(string sql)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql,cnn);//truyen gia tri vao cmd
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());//thuc thi cau lenh
                return dt.Rows[0];//tra ve ket qua
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally
            {
                cnn.Close();
            }
        }

        public int ExeCute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql,cnn);//thuc thi cau lenh
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in lstPara)//gắn tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();//lấy kết quả thực thi truy vấn
                return(int)rs;//tra ve ket qua
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -100;
            }
            finally 
            { 
                cnn.Close(); 
            }
        }


    }
}
