using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DTO;
using System.Data;
using System.Globalization;
using System.Threading;

namespace WindowsFormsApplication1.DAO
{
    class DOAN
    {
        DOANDTO db;
        ConnectDB dbs;

        public DOAN()
        {
            dbs = new ConnectDB();
            db = new DOANDTO();
        }

        public DataSet GetdataSet()
        {
            return dbs.execute_Query1("exec sp_lietkedoan");
        }
        public DataTable Getdata()
        {
            return dbs.execute_Query("exec sp_lietkedoan");
        }
        public DataTable GetDataHienThiComBo()
        {
            return dbs.execute_Query("Select MaLDA From DOAN");
        }

        public DataTable GetDataHienThiComBoTheoMaMH(string maMH)
        {
            return dbs.execute_Query("Select MaLDA From DOAN a, MONHOC b where a.maMH = b.maMH and b.maMH = '" + maMH + "'");
        }
        public bool UpdateDeadline(string maMH, string maDA, DateTime deadline)
        {
            return dbs.execute_storeUpdateDeadline("sp_capnhatdeadline", maMH, maDA, deadline);
        }
        public bool capnhatsoluong(string maDA, string soluong)
        {
            bool check = false;
            try
            {
                check = dbs.execute_store("sp_CNSoluong_DA", maDA, soluong);
            }
            catch
            {
                check = false;
            }
            return check;
        }

        public bool ThemDoan(DOANDTO temp)
        {
            bool check = false;
            try
            {
                string query = "exec sp_themdoan '" + temp.maMH + "', '" + temp.TenLDA + "', " + temp.Soluongtoida + ", '" + temp.deadline + "', N'Cộng điểm';";
                check = dbs.execute_nonQuery(query);
            }
            catch
            {
                check = false;
            }
            return check;
        }
    }
}
