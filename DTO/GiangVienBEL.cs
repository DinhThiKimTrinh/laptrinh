using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVienBEL
    {
        public int id { get; set; }
        public string name { get; set; }
        public GenderBEL GT { get; set; }
        public string TenGT
        {
            get
            {
                return GT.gioitinh;
            }
        }
    }
    
}
