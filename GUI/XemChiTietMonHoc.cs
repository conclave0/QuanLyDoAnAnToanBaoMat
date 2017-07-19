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
    public partial class XemChiTietMonHoc : Form
    {
        MONHOCBUS mh_BUS = new MONHOCBUS();
        MONHOCDTO mh = new MONHOCDTO();
        public XemChiTietMonHoc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void XemChiTietMonHoc_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "MaMH";
            comboBox1.DisplayMember = "MaMH";
            comboBox1.DataSource = mh_BUS.GetData();
            comboBox1.SelectedIndex = 0;
            DataTable tb = mh_BUS.xemCTMH(comboBox1.SelectedValue.ToString().Trim());
            if (tb.Rows.Count > 0)
            {
                DataRow row = tb.Rows[0];
                textBox2.Text = row[1].ToString();
                textBox3.Text = row[2].ToString();
                textBox4.Text = DateTime.Parse(row[3].ToString()).ToString("dd/MM/yyyy");
                textBox5.Text = DateTime.Parse(row[4].ToString()).ToString("dd/MM/yyyy");
                textBox6.Text = row[5].ToString();
                textBox7.Text = row[6].ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (mh_BUS.xoaMonHoc(comboBox1.SelectedValue.ToString().Trim()))
            {
                MessageBox.Show("Xoá Môn Học Thành Công.");
            }
            else
            {
                MessageBox.Show("Xoá Môn Học Thất Bại!");
            }
            XemChiTietMonHoc_Load(this, e);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tb = mh_BUS.xemCTMH(comboBox1.SelectedValue.ToString().Trim());
            if (tb.Rows.Count > 0)
            {
                DataRow row = tb.Rows[0];
                textBox2.Text = row[1].ToString();
                textBox3.Text = row[2].ToString();
                textBox4.Text = DateTime.Parse(row[3].ToString()).ToString("dd/MM/yyyy");
                textBox5.Text = DateTime.Parse(row[4].ToString()).ToString("dd/MM/yyyy");
                textBox6.Text = row[5].ToString();
                textBox7.Text = row[6].ToString();
            }
        }
    }
}
