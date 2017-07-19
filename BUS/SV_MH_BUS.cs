using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.BUS
{
    class SV_MH_BUS
    {
        SV_MH sv_mh;

        public SV_MH_BUS()
        {
            sv_mh = new SV_MH();
        }

        public bool themSV_MH(SV_MH_DTO svmh){
            return sv_mh.themSV_MH(svmh);
        }
    }
}
