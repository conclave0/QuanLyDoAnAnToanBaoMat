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
    public partial class ThemDoAN : Form
    {
        MONHOCBUS monhoc;
        DOANBUS doan;
        public ThemDoAN()
        {
            InitializeComponent();
            monhoc = new MONHOCBUS();
            doan = new DOANBUS();
        }

        private void ThemDoAN_Load(object sender, EventArgs e)
        {
            cb_Monhoc.ValueMember = "MaMH";
            cb_Monhoc.DisplayMember = "MaMH";
            cb_Monhoc.DataSource = monhoc.GetDataHienThiComBo();
            cb_hinhthuc.SelectedIndex = 0;
            cb_Monhoc.SelectedIndex = 0;
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            if (doan.ThemDoan(cb_Monhoc.SelectedValue.ToString().Trim(), txt_tenDA.Text.ToString(), txt_soluong.Text.ToString(), dt_deadline.Value.ToString("yyyy-MM-dd HH:mm:ss"), cb_hinhthuc.SelectedItem.ToString()))
            {
                MessageBox.Show("Insert thành công", "Success");
            }
            else
            {
                MessageBox.Show("Insert error !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
