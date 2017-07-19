using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    class SINHVIENDTO
    {
        public string maSV { get; set; }
        public string tenSV { get; set; }
        public string TrangThai { get; set; }
        public string GioiTinh { get; set; }
        public System.DateTime ngaysinh { get; set; }

        public SINHVIENDTO() { }

        //Hải thêm
        public SINHVIENDTO(string maSV, string tenSV, string TrangThai, string GioiTinh, DateTime ngaysinh)
        {
            // TODO: Complete member initialization
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.TrangThai = TrangThai;
            this.GioiTinh = GioiTinh;
            this.ngaysinh = ngaysinh;
        }
    }
}
