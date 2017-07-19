using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    class MONHOCDTO
    {
        public string maMH { get; set; }
        public string tenMH { get; set; }
        public string TrangThai { get; set; }
        public System.DateTime thoigianbatdau { get; set; }
        public System.DateTime thoigianketthuc { get; set; }

        public int SoLuong { get; set; }

        public MONHOCDTO() { }

        public MONHOCDTO(string maMH, string tenMH, string TrangThai, DateTime thoigianbatdau, DateTime thoigianketthuc, int SoLuong)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.TrangThai = TrangThai;
            this.thoigianbatdau = thoigianbatdau;
            this.thoigianketthuc = thoigianketthuc;
            this.SoLuong = SoLuong;
        }
    }
}
