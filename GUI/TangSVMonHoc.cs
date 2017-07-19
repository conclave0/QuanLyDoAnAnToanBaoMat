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
    public partial class TangSVMonHoc : Form
    {
        MONHOCBUS mh_BUS;
        MONHOCDTO mh;
        public TangSVMonHoc()
        {
            InitializeComponent();
            mh_BUS = new MONHOCBUS();
            mh = new MONHOCDTO();
            btnSave.Enabled = false;
        }

        private bool checkInputNumber(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if ((num[i] < '0' || num[i] > '9') && num[i] != '+')
                    return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtThongBao.ResetText();
            if (!checkInputNumber(txtSL.Text.ToString()))
            {
                txtThongBao.Text = "Số lượng tăng phải là số nguyên dương";
                return;
            }
            else
            {
                if (mh_BUS.updateSLSV_MH(txtMaMH.Text.ToString(), Int16.Parse(txtSL.Text.ToString())))
                    txtThongBao.Text = "Cập nhật thành công!";
            }
        }

        private void btnTimMH_Click(object sender, EventArgs e)
        {
            txtThongBao.ResetText();
            DataTable tb = mh_BUS.timMH(txtFindMaMH.Text.ToString());
            if (tb.Rows.Count > 0)
            {
                btnSave.Enabled = true;
                DataRow row = tb.Rows[0];
                txtMaMH.Text = row[0].ToString();
                txtTenMH.Text = row[1].ToString();
                txtTrangThai.Text = row[2].ToString();
                dtpNgayBD.Text = DateTime.Parse(row[3].ToString()).ToString("dd/MM/yyyy");
                dtpNgayKT.Text = DateTime.Parse(row[4].ToString()).ToString("dd/MM/yyyy");
                txtSLSV.Text = row[5].ToString();
            }
            else
            {
                txtThongBao.Text = "Không tìm thấy môn học có mã số " + txtFindMaMH.Text.ToString();
                btnSave.Enabled = false;
            }
        }
    }
}
