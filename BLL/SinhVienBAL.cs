using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SinhVienBAL
    {
        SinhvienDAL dal = new SinhvienDAL();
        public List<SinhVienBEL> ReadSV()
        {
            List<SinhVienBEL> lstCus = dal.ReadSV();
            return lstCus;
        }
        public void NewSV(SinhVienBEL cus)
        {
            dal.NewSV(cus);
        }
        public void DeleteSV(SinhVienBEL cus)
        {
            dal.DeleteSV(cus);
        }
        public void EditSV(SinhVienBEL cus)
        {
            dal.EditSV(cus);
        }
    }
}
