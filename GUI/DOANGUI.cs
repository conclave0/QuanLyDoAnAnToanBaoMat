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
    public partial class DOANGUI : Form
    {
        DOANBUS doan;
        BindingSource bs = new BindingSource();
        public DOANGUI()
        {
            InitializeComponent();
            doan = new DOANBUS();
        }
        private void BindSoucre_Data()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            string soluong = "";
            ds = doan.GetData();
            dt = ds.Tables[1]; // sửa lại khúc này khi đã có sáchBUS
            soluong = ds.Tables[0].Rows[0][0].ToString();
            bs.DataSource = dt;
            txt_rows_doan.Text = soluong;
            gridview_doan.DataSource = bs;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            BindSoucre_Data();
        }

        private void btn_dangkydoan_Click(object sender, EventArgs e)
        {
            ThemDoAN frm = new ThemDoAN();
            frm.Show();
        }

        private void bt_capnhat_sl_Click(object sender, EventArgs e)
        {
            CapNhatSoLuong frm = new CapNhatSoLuong();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChuyenNhom frm = new ChuyenNhom();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKyNhom frm = new DangKyNhom();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CapNhatDeadline frm = new CapNhatDeadline();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SettingTran frm = new SettingTran();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DanhSachMonHoc frm = new DanhSachMonHoc();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TimKiemSV frm = new TimKiemSV();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThemSV frm = new ThemSV();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TangSVMonHoc frm = new TangSVMonHoc();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ThemSVVaoMH frm = new ThemSVVaoMH();
            frm.Show();
        }

        private void xemChiTietMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemChiTietMonHoc frm = new XemChiTietMonHoc();
            frm.Show();
        }

        private void xemMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void demTongMonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void suaNgayKetThucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TangNgayKetThuc frm = new TangNgayKetThuc();
            frm.Show();
        }

        private void capNhatMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatMonHoc frm = new CapNhatMonHoc();
            frm.Show();
        }

        private void themMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemMonTheoTrangThaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void demMonTheoTrangThaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemMonTheoTrangThai frm = new DemMonTheoTrangThai();
            frm.Show();
        }
    }
}
