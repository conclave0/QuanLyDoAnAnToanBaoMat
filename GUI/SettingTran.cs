using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI
{
    public partial class SettingTran : Form
    {
        public SettingTran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isChecked = radioButton1.Checked;
            bool isChecked1 = radioButton2.Checked;
            bool isChecked2 = radioButton3.Checked;
            bool isChecked3 = radioButton4.Checked;

            if (isChecked)
            {
                DefineClass.TransactionDefault = 1;
            }

            if (isChecked1)
            {
                DefineClass.TransactionDefault = 2;
            }

            if (isChecked2)
            {
                DefineClass.TransactionDefault = 3;
            }

            if (isChecked3)
            {
                DefineClass.TransactionDefault = 4;
            }

            this.Close();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
