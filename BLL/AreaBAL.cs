using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AreaBAL
    {
        GenderDAL dal = new GenderDAL();
        public List<GenderBEL> ReadGenderList()
        {
            List<GenderBEL> lstArea = dal.ReadGenderList();
            return lstArea;
        }
    }
}
