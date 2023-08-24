using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=NITRO5;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);//khởi tao connect
            return conn;
        }
    }

    // Tạo chuỗi kết nối cơ sở dữ liệu

    public class Database
    {
        public static string CheckLogicDTO(TaiKhoan taikhoan)
        {
            string user = null;
            // conn.Open
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_logic", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.sTaikhoan);
            command.Parameters.AddWithValue("@pass", taikhoan.sMatkhau);
            
            //Kiểm tra quyền các bạn thêm 1 cái parmaeter
            command.Connection= conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return user;
         }
        //public void HienThi(GiangVien gv)
        //{
        //    SqlConnection conn= SqlConnectionData.Connect();
        //    conn.Open();

        //}
        //public void HienThiSV(SinhVien sv)
        //{
        //    SqlConnection conn = SqlConnectionData.Connect();
        //    conn.Open();

        //}
    }


}
