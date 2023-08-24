using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhvienDAL:DBConnection
    {
        public List<SinhVienBEL> ReadSV()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from sinhvien", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<SinhVienBEL> lstCus = new List<SinhVienBEL>();

            GenderDAL gd=new GenderDAL();

            while (reader.Read())
            {
                SinhVienBEL cus = new SinhVienBEL();

                cus.id = int.Parse(reader["id"].ToString());
                cus.name = reader["name"].ToString();
                cus.ML = gd.ReadGender(int.Parse(reader["gioitinh"].ToString()));

                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void DeleteSV(SinhVienBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from sinhvien where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void NewSV(SinhVienBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO sinhvien (id, name, gioitinh) VALUES (@id, @name, @malop)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.name));
            cmd.Parameters.Add(new SqlParameter("@malop", cus.ML.id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditSV(SinhVienBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update sinhvien set name = @name, gioitinh = @malop where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.name));
            cmd.Parameters.Add(new SqlParameter("@malop", cus.ML.id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
