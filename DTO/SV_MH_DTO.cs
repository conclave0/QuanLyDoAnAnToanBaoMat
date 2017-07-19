using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    class SV_MH_DTO
    {
        public string masv { get; set; }
        public string mamh { get; set; }
        public int hocky { get; set; }
        public int namhoc { get; set; }

        public SV_MH_DTO() { }

        public SV_MH_DTO(string mamh, string masv, int hocky, int namhoc) {
            this.mamh = mamh;
            this.masv = masv;
            this.hocky = hocky;
            this.namhoc = namhoc;
        }

    }
}
