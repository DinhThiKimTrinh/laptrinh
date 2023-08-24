using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccount tkAccount = new TaiKhoanAccount();
        public string CheckLogic(TaiKhoan taikhoan)
        {
            if(taikhoan.sTaikhoan == "")
            {
                return "requeid_taikhoan";
            }
            if(taikhoan.sMatkhau == "")
            {
                return "requeid_password";
            }
            string info = tkAccount.CheckLogic(taikhoan);
            return info;
        }
    }
}
