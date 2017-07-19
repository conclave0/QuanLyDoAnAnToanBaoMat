using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DTO;
using WindowsFormsApplication1.BUS;

namespace WindowsFormsApplication1.GUI
{
    public partial class ThemMonHoc : Form
    {
        public ThemMonHoc()
        {
            InitializeComponent();
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
            if (txtMaMH.Text.ToString().Trim().Length == 0)
            {
                txtThongBao.Text = "Mã môn học không được để trống";
                return;
            }

            if (txtTenMH.Text.ToString().Trim().Length == 0)
            {
                txtThongBao.Text = "Tên môn học không được để trống";
                return;
            }

            if (!txtTrangThai.Text.ToString().Equals("Mở") && !txtTrangThai.Text.ToString().Equals("Đóng") && !txtTrangThai.Text.ToString().Equals("mở") && !txtTrangThai.Text.ToString().Equals("đóng"))
            {
                txtThongBao.Text = "Trạng thái là Đóng hoặc Mở";
                return;
            }

            if (dtpNgayBD.Value >= dtpNgayKT.Value)
            {
                txtThongBao.Text = "Ngày kết thúc phải lớn hơn ngày bắt đầu";
                return;
            }

            if (txtSL.Text.ToString().Trim().Length == 0)
            {
                txtThongBao.Text = "Số lượng sinh viên không được để trống";
                return;
            }

            if(!checkInputNumber(txtSL.Text.ToString().Trim()))
            {
                txtThongBao.Text = "Số lượng sinh viên tham gia phải là số nguyên dương";
                return;
            }

            MONHOCBUS mh_BUS = new MONHOCBUS();
            MONHOCDTO mh = new MONHOCDTO(txtMaMH.Text.ToString(), txtTenMH.Text.ToString(), txtTrangThai.Text.ToString(), dtpNgayBD.Value, dtpNgayKT.Value, Int16.Parse(txtSL.Text.ToString()));
            if( mh_BUS.themMH(mh))
               txtThongBao.Text = "Hoàn tất!";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            txtTrangThai.ResetText();
            dtpNgayBD.ResetText();
            dtpNgayKT.ResetText();
            txtSL.ResetText();
            txtThongBao.ResetText();
        }

    }
}
