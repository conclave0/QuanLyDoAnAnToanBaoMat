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

   
    public partial class DemMonTheoTrangThai : Form
    {
        MONHOCBUS mh;
        public DemMonTheoTrangThai()
        {
            mh = new MONHOCBUS();
            InitializeComponent();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void DemMonTheoTrangThai_load(object sender, EventArgs e)
        {
            ComboboxItem item = new ComboboxItem();
            comboBox1.Items.AddRange(new object[] { "Mở","Đóng" });
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable result;
            result = mh.xemTongMonTheoTrangThai(comboBox1.SelectedItem.ToString().Trim());
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                textBox1.Text = row[0].ToString();
                textBox2.Text = row[1].ToString();

            }

        }
    }
}
