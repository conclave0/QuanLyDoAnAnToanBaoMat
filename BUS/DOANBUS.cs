using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.DTO;
using System.Data;

namespace WindowsFormsApplication1.BUS
{
    class DOANBUS
    {
        DOAN doan;

        public DOANBUS()
        {
            doan = new DOAN();
        }
        public DataTable GetDataHienThiComBo()
        {
            return doan.GetDataHienThiComBo();
        }
        public DataTable GetDataHienThiComBoMH(string maMH)
        {
            return doan.GetDataHienThiComBoTheoMaMH(maMH);
        }
        public bool capnhatsoluong(string maDA, string soluong)
        {
            return doan.capnhatsoluong(maDA, soluong.ToString());
        }
        public DataSet GetData()
        {
            return doan.GetdataSet();
        }
        public bool UpdateDeadline(string maMH, string maDA, DateTime deadline)
        {
            return doan.UpdateDeadline(maMH, maDA, deadline);
        }
        public bool ThemDoan(string maMHs, string TenLDAs, string Soluongtoidas, string deadlines, string hinhthucs)
        {
            DOANDTO doandto = new DOANDTO()
            {
                maDA = "",
                maMH = maMHs,
                TenLDA = TenLDAs,
                Soluongtoida = (Soluongtoidas != "") ? int.Parse(Soluongtoidas) : 0,
                deadline = deadlines,
                hinhthuc = hinhthucs
            };
            return doan.ThemDoan(doandto);
        }


    }
}
