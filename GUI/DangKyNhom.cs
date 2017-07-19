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
    public partial class DangKyNhom : Form
    {
        MONHOCBUS monhoc;
        DOANBUS doan;
        SINHVIENBUS sv;
        public DangKyNhom()
        {
            InitializeComponent();
            monhoc = new MONHOCBUS();
            doan = new DOANBUS();
            sv = new SINHVIENBUS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sv.dangkynhom(cb_monhoc.SelectedValue.ToString().Trim(), cb_doan.SelectedValue.ToString().Trim(), cb_nhom.SelectedValue.ToString().Trim(), cb_masv.SelectedValue.ToString().Trim()))
            {
                MessageBox.Show("Đăng ký thành công !");
            }
            else
            {
                MessageBox.Show("Đăng Ký Không thành công !");
            }
        }

        private void DangKyNhom_Load(object sender, EventArgs e)
        {
            cb_monhoc.ValueMember = "MaMH";
            cb_monhoc.DisplayMember = "MaMH";
            cb_monhoc.DataSource = monhoc.GetDataHienThiComBo();
            //cb_monhoc.SelectedIndex = 0;
        }

        private void cb_monhoc_TextChanged(object sender, EventArgs e)
        {
            cb_doan.ValueMember = "MaLDA";
            cb_doan.DisplayMember = "MaLDA";
            cb_doan.DataSource = doan.GetDataHienThiComBoMH(cb_monhoc.SelectedValue.ToString().Trim());
            //cb_doan.SelectedIndex = 0;
        }

        private void cb_doan_TextChanged(object sender, EventArgs e)
        {
            cb_nhom.ValueMember = "MaNhom";
            cb_nhom.DisplayMember = "MaNhom";
            cb_nhom.DataSource = sv.getNhomDangKy(cb_monhoc.SelectedValue.ToString().Trim(), cb_doan.SelectedValue.ToString().Trim());
            //cb_nhom.SelectedIndex = 0;
        }

        private void cb_nhom_TextChanged(object sender, EventArgs e)
        {
            // loading sinh vien nao chua co nhom
            cb_masv.ValueMember = "MaSV";
            cb_masv.DisplayMember = "MaSV";
            cb_masv.DataSource = sv.GetcomboboxSinhVienChuaNhom(cb_monhoc.SelectedValue.ToString().Trim(), cb_doan.SelectedValue.ToString().Trim(), cb_nhom.SelectedValue.ToString().Trim());
            //cb_masv.SelectedIndex = 0;
        }
    }
}
