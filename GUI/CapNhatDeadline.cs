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
    public partial class CapNhatDeadline : Form
    {
        MONHOCBUS monhoc;
        DOANBUS doan;
        public CapNhatDeadline()
        {
            InitializeComponent();
            monhoc = new MONHOCBUS();
            doan = new DOANBUS();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool check;
            check = doan.UpdateDeadline(cb_maMH.SelectedValue.ToString().Trim(), cb_maDA.SelectedValue.ToString().Trim(), dt_deadline.Value);
            if (check)
            {
                MessageBox.Show("Update thành công !");
            }
            else
            {
                MessageBox.Show("Update thất bại !");
            }
            //doan.UpdateDeadline(cb_maMH.SelectedValue.ToString().Trim(), cb_maDA.SelectedValue.ToString().Trim, "dadasdasd");
        }

        private void CapNhatDeadline_Load(object sender, EventArgs e)
        {
            cb_maMH.ValueMember = "MaMH";
            cb_maMH.DisplayMember = "MaMH";
            cb_maMH.DataSource = monhoc.GetDataHienThiComBo();
            cb_maMH.SelectedIndex = 0;
        }

        private void cb_maMH_TextChanged(object sender, EventArgs e)
        {
            
            cb_maDA.ValueMember = "MaLDA";
            cb_maDA.DisplayMember = "MaLDA";
            cb_maDA.DataSource = doan.GetDataHienThiComBoMH(cb_maMH.SelectedValue.ToString().Trim());
            cb_maDA.SelectedIndex = 0;
        }
    }
}
