using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.DAO
{
    class SV_MH
    {
        SV_MH_DTO db;
        ConnectDB dbs;

        public SV_MH() {
            db = new SV_MH_DTO();
            dbs = new ConnectDB();
        }

        internal bool themSV_MH(SV_MH_DTO svmh)
        {
            return dbs.execute_storeThemSV_MH("sp_themSV_MH", svmh.mamh, svmh.masv, svmh.hocky, svmh.namhoc);
        }
    }
}
