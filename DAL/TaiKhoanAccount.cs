using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanAccount: Database
    {
        public string CheckLogic(TaiKhoan taikhoan)
        {
            string info = CheckLogicDTO(taikhoan);
            return info;
        }
    }
}
