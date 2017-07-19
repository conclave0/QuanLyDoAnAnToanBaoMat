using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.GUI
{
    public partial class TimKiemSV : Form
    {
        SINHVIENBUS sv_BUS = new SINHVIENBUS();
        SINHVIENDTO sv = new SINHVIENDTO();
        public TimKiemSV()
        {
            InitializeComponent();
        }

        private void btnTimSV_Click(object sender, EventArgs e)
        {
            DataTable tb = sv_BUS.timKiemSV(txtFindMSSV.Text.ToString());
            if(tb.Rows.Count > 0)
            {
                DataRow row = tb.Rows[0];
                    txtMaSV.Text = row[0].ToString();
                    txtHoTen.Text = row[1].ToString();
                    txtTrangThai.Text = row[2].ToString();
                    txtGioiTinh.Text = row[3].ToString();
                    txtNgaySinh.Text = DateTime.Parse(row[4].ToString()).ToString("dd/MM/yyyy");
            }
            
            else
            {
                txtThongBao.Text = "Không tìm thấy sinh viên có mã số " + txtFindMSSV.Text.ToString();
            }
        }

    }
}
