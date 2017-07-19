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
    public partial class DanhSachMonHoc : Form
    {
        MONHOCBUS monhoc;
        public DanhSachMonHoc()
        {
            InitializeComponent();
            monhoc = new MONHOCBUS();
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            ThemMonHoc frm = new ThemMonHoc();
            frm.Show();
        }

        private void DanhSachMonHoc_Load(object sender, EventArgs e)
        {
            DataSet ds = monhoc.layDanhSachMH();
            tbDSMH.DataSource = ds.Tables[0];
            String tongsv = ds.Tables[1].Rows[0][0].ToString();
            txtTongMH.Text = tongsv;
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // DanhSachMonHoc
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "DanhSachMonHoc";
        //    this.Load += new System.EventHandler(this.DanhSachMonHoc_Load_1);
        //    this.ResumeLayout(false);

        //}

        private void DanhSachMonHoc_Load_1(object sender, EventArgs e)
        {

        }
    }
}
