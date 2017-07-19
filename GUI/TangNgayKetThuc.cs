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
    public partial class TangNgayKetThuc : Form
    {
        MONHOCBUS mh;
        public TangNgayKetThuc()
        {
            mh = new MONHOCBUS();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soluongValue = (int)numericUpDown1.Value;
            if (mh.tangNgayKT(comboBox1.SelectedValue.ToString().Trim(), soluongValue))
            {
                MessageBox.Show("Update Thành công");
            }
            else
            {
                MessageBox.Show("Update Thất bại");
            }
        }

        private void TangNgayKetThuc_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "MaMH";
            comboBox1.DisplayMember = "MaMH";
            comboBox1.DataSource = mh.GetDataHienThiComBo();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
