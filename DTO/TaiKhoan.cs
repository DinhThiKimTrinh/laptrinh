using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public string sMaTK { get; set; }
        public string sTaikhoan { get; set; }
        public string sMatkhau { get; set; }
        public int FK_iMaQuyen { get; set; }
    }
}
