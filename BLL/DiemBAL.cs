using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DiemBAL
    {

        DiemDAL dal = new DiemDAL();
        public List<SinhVienBEL> ReadDSV()
        {
            List<SinhVienBEL> lstCus = dal.ReadDSV();
            return lstCus;
        }
        public void Newdiem(SinhVienBEL cus)
        {
            dal.NewDSV(cus);
        }
        public void Deletediem(SinhVienBEL cus)
        {
            dal.DeleteDSV(cus);
        }
        public void Editdiem(SinhVienBEL cus)
        {
            dal.EditDSV(cus);
        }
    }
}
