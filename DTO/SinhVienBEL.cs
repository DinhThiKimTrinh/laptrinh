using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVienBEL
    {
        public int id { get; set; }
        public string name { get; set; }
        public string diem { get; set; }
        public GenderBEL ML { get; set; }

        public string TenML
        {
            get
            {
                return ML.gioitinh;
            }
        }
    }
    public class GenderBEL
    {
        public int id { get; set; }
        public string gioitinh { get; set; }
        public List<SinhVienBEL> GDSV { get; set; }
    }
   
}
