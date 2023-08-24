using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GiangVienBAL
    {
        GiangVienDAL dal = new GiangVienDAL();
        public List<GiangVienBEL> ReadGV()
        {
            List<GiangVienBEL> lstCus = dal.ReadGV();
            return lstCus;
        }
        public void NewGV(GiangVienBEL cus)
        {
            dal.NewGV(cus);
        }
        public void DeleteGV(GiangVienBEL cus)
        {
            dal.DeleteGV(cus);
        }
        public void EditGV(GiangVienBEL cus)
        {
            dal.EditGV(cus);
        }
    }
}
