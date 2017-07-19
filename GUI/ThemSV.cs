using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DTO;
using WindowsFormsApplication1.BUS;

namespace WindowsFormsApplication1.GUI
{
    public partial class ThemSV : Form
    {
        private SINHVIENBUS sv_BUS = new SINHVIENBUS();
        public ThemSV()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSV.ResetText();
            txtHoTen.ResetText();
            txtTrangThai.ResetText();
            txtGioiTinh.ResetText();
            txtTrangThai.ResetText();
            txtThongBao.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtThongBao.ResetText();
            if (txtMaSV.Text.ToString().Trim().Length == 0)
            {
                txtThongBao.Text = "Mã sinh viên không được để trống";
                return;
            }

            if(txtHoTen.Text.ToString().Trim().Length == 0)
            {
                txtThongBao.Text = "Họ tên sinh viên không được để trống";
                return;
            }

            if (!txtTrangThai.Text.ToString().Equals("Mở") && !txtTrangThai.Text.ToString().Equals("Đóng") && !txtTrangThai.Text.ToString().Equals("mở") && !txtTrangThai.Text.ToString().Equals("đóng"))
            {
                txtThongBao.Text = "Trạng thái là Đóng hoặc Mở";
                return;
            }

            if (!txtGioiTinh.Text.ToString().Equals("Nam") && !txtGioiTinh.Text.ToString().Equals("Nữ") && !txtGioiTinh.Text.ToString().Equals("nam") && !txtGioiTinh.Text.ToString().Equals("nữ"))
            {
                txtThongBao.Text = "Giới tính là Nam hoặc Nữ";
                return;
            }

            SINHVIENDTO sv = new SINHVIENDTO(txtMaSV.Text.ToString(), txtHoTen.Text.ToString(),txtTrangThai.Text.ToString(), txtGioiTinh.Text.ToString(), dtpNgaySinh.Value);
            if(sv_BUS.themSV(sv))
                txtThongBao.Text = "Hoàn tất!";
        }
    }
}
