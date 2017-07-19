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
    class MONHOCBUS
    {
        MONHOC monhoc;

        public MONHOCBUS()
        {
            monhoc = new MONHOC();
        }

        public DataTable GetDataHienThiComBo()
        {
            return monhoc.GetDataHienThiComBo();
        }

        public DataTable GetData()
        {
            return monhoc.Getdata();
        }

        public bool themMH(MONHOCDTO mh)
        {
            return monhoc.themMH(mh);
        }

        public DataSet layDanhSachMH()
        {
            return monhoc.layDanhSachMH();
        }

        public DataTable timMH(string mamh)
        {
            return monhoc.timMH(mamh);
        }

        public bool updateSLSV_MH(string mamh, int sl)
        {
            return monhoc.updateSLSV_MH(mamh, sl);
        }

        public DataTable xemCTMH(string mamh)
        {
            return monhoc.XemChiTietMonHoc(mamh);
        }

        public bool tangNgayKT(string mamh, int soluong)
        {
            return monhoc.TangNgayKetThuc(mamh, soluong);
        }

        public bool capNhatMH(string mamh, string tenmh, string trangthai, DateTime ngayBD, DateTime ngayKT, int sl_sv, int sl_sv_duocdk)
        {
            return monhoc.CapNhatMonHoc(mamh, tenmh, trangthai, ngayBD, ngayKT, sl_sv, sl_sv_duocdk);
        }

        public DataTable xemTongMonTheoTrangThai(string trangthai)
        {
            return monhoc.XemTongMonTrangThai(trangthai);
        }

        public bool xoaMonHoc(string mamh)
        {
            return monhoc.XoaMonHoc(mamh);
        }
    }
}
