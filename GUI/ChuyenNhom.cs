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
    public partial class ChuyenNhom : Form
    {
        MONHOCBUS monhoc;
        DOANBUS doan;
        SINHVIENBUS sinhvien;
        public ChuyenNhom()
        {
            InitializeComponent();
            monhoc = new MONHOCBUS();
            doan = new DOANBUS();
            sinhvien = new SINHVIENBUS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // thuc hien qua trnh chay procedure 
            sinhvien.chuyennhom(cb_nhommoi.SelectedValue.ToString().Trim(), cb_MaSV.SelectedValue.ToString().Trim(), cb_maMH.SelectedValue.ToString().Trim(), cb_maDA.SelectedValue.ToString().Trim(), tb_nhomcu.Text.ToString().Trim());
        }

        private void ChuyenNhom_Load(object sender, EventArgs e)
        {
            cb_maMH.ValueMember = "MaMH";
            cb_maMH.DisplayMember = "MaMH";
            cb_maMH.DataSource = monhoc.GetDataHienThiComBo();
            cb_maMH.SelectedIndex = 0;
        }

        private void cb_maDA_TextChanged(object sender, EventArgs e)
        {
            cb_MaSV.ValueMember = "MaSV";
            cb_MaSV.DisplayMember = "MaSV";
            cb_MaSV.DataSource = sinhvien.getSinhviencomboMonHoc(cb_maMH.SelectedValue.ToString().Trim(), cb_maDA.SelectedValue.ToString().Trim());
        }

        private void cb_maMH_TextChanged(object sender, EventArgs e)
        {
            cb_maDA.ValueMember = "MaLDA";
            cb_maDA.DisplayMember = "MaLDA";
            cb_maDA.DataSource = doan.GetDataHienThiComBoMH(cb_maMH.SelectedValue.ToString().Trim());
        }

        private void cb_MaSV_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            // phai lay dc doan text cua no 
            cb_nhommoi.ValueMember = "MaNhom";
            cb_nhommoi.DisplayMember = "MaNhom";
            cb_nhommoi.DataSource = sinhvien.getSinhviencomboNhomMoi(cb_maMH.SelectedValue.ToString().Trim(), cb_maDA.SelectedValue.ToString().Trim(), cb_MaSV.SelectedValue.ToString().Trim());
            dt = sinhvien.getSinhviencomboNhomCu(cb_maMH.SelectedValue.ToString().Trim(), cb_maDA.SelectedValue.ToString().Trim(), cb_MaSV.SelectedValue.ToString().Trim());
            tb_nhomcu.Text = dt.Rows[0]["MaNhom"].ToString();
        }
    }
}
