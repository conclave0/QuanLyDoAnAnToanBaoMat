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
    public partial class CapNhatMonHoc : Form
    {
        MONHOCBUS mh;
        public CapNhatMonHoc()
        {
            mh = new MONHOCBUS();
            InitializeComponent();
        }

        private void CapNhatMonHoc_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "MaMH";
            comboBox1.DisplayMember = "MaMH";
            comboBox1.DataSource = mh.GetData();
            comboBox1.SelectedIndex = 0;
            DataTable tb = mh.xemCTMH(comboBox1.SelectedValue.ToString().Trim());
            if (tb.Rows.Count > 0)
            {
                DataRow row = tb.Rows[0];
                textBox1.Text = row[1].ToString();
                textBox2.Text = row[2].ToString();
                dateTimePicker1.Value = DateTime.Parse(row[3].ToString());
                dateTimePicker2.Value = DateTime.Parse(row[4].ToString());

                textBox5.Text = row[5].ToString();
                textBox6.Text = row[6].ToString();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                mh.capNhatMH(
                    comboBox1.SelectedValue.ToString().Trim(),
                    textBox1.Text.ToString(),
                    textBox2.Text.ToString(),
                    dateTimePicker1.Value,
                    dateTimePicker2.Value,
                    int.Parse(textBox5.Text),
                    int.Parse(textBox6.Text)
                    )
                
                )
                MessageBox.Show("Cập Nhật Thành Công");
            
            else
            {
                MessageBox.Show("Cập Nhật Thất Bại");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tb = mh.xemCTMH(comboBox1.SelectedValue.ToString().Trim());
            if (tb.Rows.Count > 0)
            {
                DataRow row = tb.Rows[0];
                textBox1.Text = row[1].ToString();
                textBox2.Text = row[2].ToString();
                dateTimePicker1.Value = DateTime.Parse(row[3].ToString());
                dateTimePicker2.Value = DateTime.Parse(row[4].ToString());
                textBox5.Text = row[5].ToString();
                textBox6.Text = row[6].ToString();
            }
        }
    }
}
