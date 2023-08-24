using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAL;
using System.Data.SqlClient;

namespace DAL
{
    public class GenderDAL:DBConnection
    {
        public List<GenderBEL> ReadGenderList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from gender", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<GenderBEL> lstArea = new List<GenderBEL>();
            while (reader.Read())
            {
                GenderBEL gt = new GenderBEL();
                gt.id = int.Parse(reader["id"].ToString());
                gt.gioitinh = reader["gioitinh"].ToString();
                lstArea.Add(gt);
            }
            conn.Close();
            return lstArea;
        }
        public GenderBEL ReadGender(int id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from gender where id=" + id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();

            GenderBEL gd = new GenderBEL();

            if (reader.HasRows && reader.Read())
            {
                gd.id = int.Parse(reader["id"].ToString());
                gd.gioitinh = reader["gioitinh"].ToString();
            }
            conn.Close();
            return gd;
        }
    }
}
