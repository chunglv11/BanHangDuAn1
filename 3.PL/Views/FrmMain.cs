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
    public partial class FrmMain : Form
    {
        private INhanVienServices _inhanVienServices;
        private IChucVuServices _ichucVuServices;
        public FrmMain()
        {
            InitializeComponent();
            _inhanVienServices = new NhanVienServices();
            _ichucVuServices = new ChucVuServices();
            //FrmBanHang frmBanHang = new FrmBanHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.PanelPhai.Controls.Add(frmBanHang);
            //frmBanHang.Show();
        }

        private Form activeForm;
        private void ChangeForm(Form childForm)
        {
            if (activeForm != null)
            {

                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelPhai.Controls.Add(childForm);

            childForm.Show();
        }
        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmBanHang());
        }

        private void btn_KH_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmKhachHang());
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmQuanLyNhanVien());
        }

        private void btn_Sp_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmQuanLySP());
        }

        private void btn_HD_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmQuanLyHoaDon());
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {

        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
