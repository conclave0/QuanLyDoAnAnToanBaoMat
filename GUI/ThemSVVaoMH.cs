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
    public partial class ThemSVVaoMH : Form
    {
        SINHVIENBUS sv_BUS;
        MONHOCBUS mh_BUS;
        SV_MH_BUS sv_mh_BUS;

        public ThemSVVaoMH()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            sv_BUS = new SINHVIENBUS();
            mh_BUS = new MONHOCBUS();
            sv_mh_BUS = new SV_MH_BUS();
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

        public bool checkInput()
        {
            if (txtFindMSSV.Text.Trim().Length == 0)
            {
                txtThongBao.Text = "Vui lòng nhập mã số sinh viên!";
                btnSave.Enabled = false;
                return false;
            }

            if (txtHocKi.Text.Trim().Length == 0)
            {
                txtThongBao.Text = "Vui lòng nhập học kì!";
                btnSave.Enabled = false;
                return false;
            }

            if (txtNamHoc.Text.Trim().Length == 0)
            {
                txtThongBao.Text = "Vui lòng nhập năm học!";
                btnSave.Enabled = false;
                return false;
            } 
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtThongBao.ResetText();

            if (!checkInputNumber(txtHocKi.Text.ToString()) || !checkInputNumber(txtNamHoc.Text.ToString()))
            {
                txtThongBao.Text = "Học kì và năm học là số nguyên dương!";
                btnSave.Enabled = false;
                return;
            }

            if (!checkInput())
                return;

            SV_MH_DTO svmh = new SV_MH_DTO(txtMaMH.Text.ToString(), txtMaSV.Text.ToString(), Int16.Parse(txtHocKi.Text.ToString()), Int16.Parse(txtNamHoc.Text.ToString()));
            if (sv_mh_BUS.themSV_MH(svmh))
            {
                txtThongBao.Text = "Thêm thành công!";
            }
        }

        private void btnTimMH_Click(object sender, EventArgs e)
        {
            txtThongBao.ResetText();

            DataTable tb = sv_BUS.timKiemSV(txtFindMSSV.Text.ToString());
            DataTable tbMH = mh_BUS.timMH(txtFindMaMH.Text.ToString());
            if (tb.Rows.Count > 0 && tbMH.Rows.Count > 0)
            {
                DataRow row = tb.Rows[0];
                txtMaSV.Text = row[0].ToString();
                txtHoTen.Text = row[1].ToString();
                DataRow rowMH = tbMH.Rows[0];
                txtMaMH.Text = rowMH[0].ToString();
                txtTenMH.Text = rowMH[1].ToString();
                btnSave.Enabled = true;
            }
            else if (tb.Rows.Count < 0 && tbMH.Rows.Count < 0)
            {
                txtThongBao.Text = "Không tìm thấy MSSV: " + txtFindMaMH.Text.ToString() + "và môn học có mã số: " + txtFindMaMH.Text.ToString();
                btnSave.Enabled = false;
                return;
            }
            else if (tb.Rows.Count > 0 )
            {
                DataRow row = tb.Rows[0];
                txtMaSV.Text = row[0].ToString();
                txtHoTen.Text = row[1].ToString();
                txtThongBao.Text = "Không tìm thấy môn học có mã số " + txtFindMaMH.Text.ToString();
                btnSave.Enabled = false;
                return;
            }
            else if (tbMH.Rows.Count > 0)
            {
                txtThongBao.Text = "Không tìm thấy sinh viên có mã số " + txtFindMSSV.Text.ToString();
                btnSave.Enabled = false;
                return;
            }
        }

        private void txtHocKi_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            if (txtFindMaMH.Text.Trim().Length == 0)
            {
                btnSave.Enabled = false;
            }

            if (txtMaSV.Text.Trim().Length == 0)
            {
                btnSave.Enabled = false;
            }
        }

        private void txtNamHoc_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            if (txtFindMaMH.Text.Trim().Length == 0)
            {
                btnSave.Enabled = false;
            }

            if (txtMaSV.Text.Trim().Length == 0)
            {
                btnSave.Enabled = false;
            }
        }
    }
}
