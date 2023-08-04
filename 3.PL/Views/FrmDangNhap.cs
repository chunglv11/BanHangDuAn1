using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmDangNhap : Form
    {
        INhanVienServices _inhanVienServices;
        public FrmDangNhap()
        {
            InitializeComponent();
            _inhanVienServices = new NhanVienServices();
            tb_Tentk.Text = Properties.Settings.Default.tk;
            Tb_Mk.Text = Properties.Settings.Default.mk;
            cb_Save.Checked = true;
        }
        public void saveInfor()
        {
            if (cb_Save.Checked == true)
            {
                Properties.Settings.Default.tk = tb_Tentk.Text;
                Properties.Settings.Default.mk = Tb_Mk.Text;
                Properties.Settings.Default.TKdaLogin = tb_Tentk.Text;
                Properties.Settings.Default.MKdaLogin = Tb_Mk.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.tk = "";
                Properties.Settings.Default.mk = "";
                Properties.Settings.Default.TKdaLogin = tb_Tentk.Text;
                Properties.Settings.Default.MKdaLogin = Tb_Mk.Text;
                Properties.Settings.Default.Save();
            }
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            var login = _inhanVienServices.GetAll().Where(c => c.Username == tb_Tentk.Text && c.MatKhau == Tb_Mk.Text).FirstOrDefault();
            if (login != null)
            {
                saveInfor();
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void lb_QuenMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuenMK frmqmk = new FrmQuenMK();
            frmqmk.ShowDialog();
            
        }
    }
}
