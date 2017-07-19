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
    public partial class CapNhatSoLuong : Form
    {
        DOANBUS doan;
        public CapNhatSoLuong()
        {
            InitializeComponent();
            doan = new DOANBUS();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (doan.capnhatsoluong(cb_madoan.SelectedValue.ToString().Trim(), bt_soluongthem.Text.ToString()))
            {
                MessageBox.Show("Update Thanh cong");
            }
            else
            {
                MessageBox.Show("Update That bai");
            }
        }

        private void CapNhatSoLuong_Load(object sender, EventArgs e)
        {
            cb_madoan.ValueMember = "MaLDA";
            cb_madoan.DisplayMember = "MaLDA";
            cb_madoan.DataSource = doan.GetDataHienThiComBo();
            cb_madoan.SelectedIndex = 0;
        }

        private void cb_madoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
