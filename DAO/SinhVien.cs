using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DTO;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.DAO
{
    class SinhVien
    {
        SINHVIENDTO sinhvien;
        ConnectDB dbs;

        public SinhVien()
        {
            dbs = new ConnectDB();
            sinhvien = new SINHVIENDTO();
        }

        public DataTable Getdata()
        {
            return dbs.execute_Query("select * from SINHVIEN");
        }
        public DataTable GetDataHienThiComBoSVDATHAMGIA(string maMH, string maDA)
        {
            string query = string.Format("select a.MaSV from DS_SINHVIEN_NHOM a, NHOM b, DOAN c, MONHOC d where a.MaNhom = b.MaNhom and b.MaLDA = c.MaLDA and c.MaLDA = '{0}' and c.MaMH = d.MaMH and d.MaMH = '{1}'", maDA, maMH);
            return dbs.execute_Query(query);
        }
        public DataTable GetDataHienThiComBoSVNhomChuyen(string maMH, string maDA, string maSV)
        {
            string query = string.Format("select a.MaSV, a.MaNhom from DS_SINHVIEN_NHOM a, NHOM b, DOAN c, MONHOC d where a.MaNhom = b.MaNhom and b.MaLDA = c.MaLDA and c.MaLDA = '{0}' and c.MaMH = d.MaMH and d.MaMH = '{1}' and a.MaSV = '{2}'", maDA, maMH, maSV);
            return dbs.execute_Query(query);
        }
        public DataTable GetDataHienThiComBoNhomKhac(string maMH, string maDA, string maSV)
        {
            string query = string.Format("select f.MaNhom from NHOM f, DOAN s where f.MaLDA = '{1}' and s.MaLDA = f.MaLDA and s.MaMH = '{0}' and f.MaNhom not in (select  a.MaNhom from DS_SINHVIEN_NHOM a, NHOM b, DOAN c, MONHOC d where a.MaNhom = b.MaNhom and b.MaLDA = c.MaLDA and c.MaLDA = '{1}' and c.MaMH = d.MaMH and d.MaMH = '{0}' and a.MaSV = '{2}')", maMH, maDA, maSV);
            return dbs.execute_Query(query);
        }
        public DataTable GetcomboboxNhom(string maMH, string maDA)
        {
            string query = string.Format("select c.MaNhom from dbo.MONHOC a, dbo.DOAN b, dbo.NHOM c where a.MaMH = b.MaMH and b.MaLDA = c.MaLDA and a.MaMH = '{0}' and b.MaLDA = '{1}';", maMH, maDA);
            return dbs.execute_Query(query);
        }
        public DataTable GetcomboboxSinhVienChuaNhom(string maMH, string maDA, string maNhom)
        {
            string query = string.Format("select sv.MaSV from dbo.SINHVIEN sv where sv.MaSV not in (select d.MaSV from dbo.MONHOC a, dbo.DOAN b, dbo.NHOM c, dbo.DS_SINHVIEN_NHOM d where a.MaMH = b.MaMH and b.MaLDA = c.MaLDA and a.MaMH = '{0}' and b.MaLDA = '{1}' and d.MaNhom = c.MaNhom)", maMH, maDA);
            return dbs.execute_Query(query);
        }
        public bool Dangkynhom(string MaMonHoc, string MaDoAn, string MaNhom, string MaSV)
        {
            bool check = false;
            try
            {
                check = dbs.execute_store2s("sp_DangKy_Nhom", MaMonHoc, MaDoAn, MaNhom, MaSV);
            }
            catch
            {
                check = false;
            }
            return check;
        }

        public bool ChuyenNhom(string MaNhom , string MaSV ,string MaMonHoc ,string MaDoAn ,string MaNhomCu ) 
        {
            bool check = false;
            try
            {
                check = dbs.execute_store1s("sp_ChuyenNhom", MaNhom, MaSV, MaMonHoc, MaDoAn, MaNhomCu);
            }
            catch
            {
                check = false;
            }
            return check;
        }

        public DataTable timKiemSV(string maSV)
        {
            return dbs.execute_storeTimSV("sp_layThongTinSV", maSV);
        }

        internal bool themSV(SINHVIENDTO sv)
        {
            return dbs.execute_storeThemSV("sp_themSV", sv.maSV, sv.tenSV, sv.TrangThai, sv.GioiTinh, sv.ngaysinh);
        }
    }
}
