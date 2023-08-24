using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GiangVienDAL : DBConnection
    {
        public List<GiangVienBEL> ReadGV()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from giangvien", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<GiangVienBEL> lstCus = new List<GiangVienBEL>();

            GenderDAL gd = new GenderDAL();

            while (reader.Read())
            {
                GiangVienBEL cus = new GiangVienBEL();

                cus.id = int.Parse(reader["id"].ToString());
                cus.name = reader["name"].ToString();
                cus.GT = gd.ReadGender(int.Parse(reader["gioitinh"].ToString()));

                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void DeleteGV(GiangVienBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from giangvien where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void NewGV(GiangVienBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into giangvien values(@id, @name ,@gioitinh )", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.name));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", cus.GT.id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditGV(GiangVienBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update giangvien set name = @name, gioitinh = @gioitinh where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.name));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", cus.GT.id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }

}
