using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.BUS
{
    class SINHVIENBUS
    {
        SinhVien sv;
        public SINHVIENBUS()
        {
            sv = new SinhVien();
        }

        public DataTable getSinhviencomboMonHoc(string maMH, string maDA)
        {
            return sv.GetDataHienThiComBoSVDATHAMGIA(maMH, maDA);
        }
        public DataTable getSinhviencomboNhomCu(string maMH, string maDA , string masv)
        {
            return sv.GetDataHienThiComBoSVNhomChuyen(maMH, maDA, masv);
        }
        public DataTable getSinhviencomboNhomMoi(string maMH, string maDA, string masv)
        {
            return sv.GetDataHienThiComBoNhomKhac(maMH, maDA, masv);
        }
        public DataTable getNhomDangKy(string maMH, string maDA)
        {
            return sv.GetcomboboxNhom(maMH, maDA);
        }

        public DataTable GetcomboboxSinhVienChuaNhom(string maMH, string maDA, string maNhom)
        {
            return sv.GetcomboboxSinhVienChuaNhom(maMH, maDA, maNhom);
        }
        public bool chuyennhom(string MaNhom, string MaSV, string MaMonHoc, string MaDoAn, string MaNhomCu)
        {
            return sv.ChuyenNhom(MaNhom, MaSV, MaMonHoc, MaDoAn, MaNhomCu);
        }
        public bool dangkynhom(string MaMonHoc, string MaDoAn, string MaNhom, string MaSV)
        {
            return sv.Dangkynhom(MaMonHoc, MaDoAn, MaNhom, MaSV);
        }

        public DataTable timKiemSV(string maSV)
        {
            return sv.timKiemSV(maSV);
        }

        internal bool themSV(SINHVIENDTO sv)
        {
            return this.sv.themSV(sv);
        }
    }
}
