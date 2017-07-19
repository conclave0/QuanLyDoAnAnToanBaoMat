using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DTO;
using System.Data;

namespace WindowsFormsApplication1.DAO
{
    class MONHOC
    {
        MONHOCDTO db;
        ConnectDB dbs;

        public MONHOC()
        {
            dbs = new ConnectDB();
            db = new MONHOCDTO();
        }

        public DataTable Getdata()
        {
            return dbs.execute_Query("select * from MONHOC");
        }
        public DataTable GetDataHienThiComBo()
        {
            return dbs.execute_Query("Select MaMH From MONHOC");
        }

        //hải
        public bool themMH(MONHOCDTO mh)
        {
            return dbs.execute_storeThemMH("sp_themMH", mh.maMH, mh.tenMH, mh.TrangThai, mh.thoigianbatdau, mh.thoigianketthuc, mh.SoLuong);
        }

        public DataSet layDanhSachMH()
        {
            return dbs.execute_storelayDanhSachMH("sp_layDanhSachMH");
        }

        public DataTable timMH(string mamh)
        {
            return dbs.execute_storeTimMH("sp_layThongTinMH", mamh);
        }

        public bool updateSLSV_MH(string mamh, int sl)
        {
            return dbs.execute_storeupdateSLSV_MH("sp_updateSLSV_MH", mamh, sl);
        }
        //hoàng
        public DataTable XemChiTietMonHoc(string maMH)
        {
            return dbs.execute_storeXemChiTietMonHoc("sp_XemCTMH", maMH);
        }

        public bool TangNgayKetThuc(string maMH, int songay)
        {
            return dbs.execute_storeTangNgayKT("sp_SuaNgayKT", maMH,songay);
        }

        public bool CapNhatMonHoc(string mamh,string tenmh, string trangthai, DateTime ngayBD, DateTime ngayKT, int sl_sv, int sl_sv_duocdk)
        {
            return dbs.store_procedureCapNhatMH("sp_CapNhatMonHoc", mamh, tenmh, trangthai, ngayBD, ngayKT, sl_sv, sl_sv_duocdk);
        }

        public DataTable XemTongMonTrangThai(string trangthai)
        {
            return dbs.execute_storeXemTongMonTrangThai("sp_XemTongMonTrangThai", trangthai);
        }

        public bool XoaMonHoc(string mamh)
        {
            return dbs.execute_storeXoaMonHoc("sp_XoaMonHoc", mamh);
        }
    }
}
