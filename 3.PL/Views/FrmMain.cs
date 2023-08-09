using _1.DAL.Models;
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
        NhanVien _nhanVien;
        public FrmMain()
        {
            InitializeComponent();
            _inhanVienServices = new NhanVienServices();
            _ichucVuServices = new ChucVuServices();
            _nhanVien = new NhanVien();

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
            PanelPhai.Controls.Add(childForm);
            PanelPhai.Tag = childForm;

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

        private void btn_NhanVien_Click(object sender, EventArgs e)//
        {
            Guid idRole = _inhanVienServices.GetAll().FirstOrDefault(x => x.Username == Properties.Settings.Default.TKdaLogin).ID;
            var id = _inhanVienServices.GetAll().FirstOrDefault(p => p.ID == idRole).IDCV;
            var idcv = _ichucVuServices.GetAll().FirstOrDefault(p => p.ID == id).Ten;
            if (idcv == "Quản lý")
            {

                ChangeForm(new FrmQuanLyNhanVien());
            }
            else if (idcv != "Quản lý")
            {
                MessageBox.Show("Nhân viên không có quyền sử dụng chức năng này");
            }

        }

        private void btn_Sp_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmQuanLySP());
        }

        private void btn_HD_Click(object sender, EventArgs e)
        {
            ChangeForm(new FrmQuanLyHoaDon());
        }

        private void btn_TK_Click(object sender, EventArgs e)//
        {
            Guid idRole = _inhanVienServices.GetAll().FirstOrDefault(x => x.Username == Properties.Settings.Default.TKdaLogin).ID;
            var id = _inhanVienServices.GetAll().FirstOrDefault(p => p.ID == idRole).IDCV;
            var idcv = _ichucVuServices.GetAll().FirstOrDefault(p => p.ID == id).Ten;
            if (idcv == "Quản lý")
            {

                ChangeForm(new FrmThongKe());
            }
            else if (idcv != "Quản lý")
            {
                MessageBox.Show("Nhân viên không có quyền sử dụng chức năng này");
            }

        }
        private void btn_KhuyenMai_Click(object sender, EventArgs e)//
        {
            Guid idRole = _inhanVienServices.GetAll().FirstOrDefault(x => x.Username == Properties.Settings.Default.TKdaLogin).ID;
            var id = _inhanVienServices.GetAll().FirstOrDefault(p => p.ID == idRole).IDCV;
            var idcv = _ichucVuServices.GetAll().FirstOrDefault(p => p.ID == id).Ten;
            if (idcv == "Quản lý")
            {

                ChangeForm(new FrmKhuyenMai());
            }
            else if (idcv != "Quản lý")
            {
                MessageBox.Show("Nhân viên không có quyền sử dụng chức năng này");
            }

        }
        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {

            //var nhanvien = _inhanVienServices.GetAllView().FirstOrDefault(p => p.Username == Properties.Settings.Default.TKdaLogin);
            //lb_HoTen.Text = nhanvien.HoTen.ToString();
            ////lb_CV.Text = nhanvien.ChucVu;
            //lb_MaNV.Text = nhanvien.MaNv;
            //lb_Email.Text = nhanvien.Email;
            //lb_GioiTinh.Text = nhanvien.GioiTinh == 1 ? "nam" : "nữ";
            //string formattedDate = nhanvien.NgaySinh.ToString("dd-MM-yyyy");  //chuyển đổi sang dd/mm/yyyy 
            //dateTimePicker1.Text = Convert.ToString(formattedDate);
            //lb_User.Text = nhanvien.Username;
            ChangeForm(new FrmThongTin());
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FrmDangNhap frmDangNhap = new FrmDangNhap();
                frmDangNhap.ShowDialog();
                this.Close();
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var layuser = Properties.Settings.Default.TKdaLogin;
            var nv = _inhanVienServices.GetAll().FirstOrDefault(c => c.Username == layuser);
            var role = _ichucVuServices.GetAll().FirstOrDefault(c => c.ID == nv.IDCV);
            lb_TenCV.Text = role.Ten;
            lb_TenNV.Text = nv.HoTen;
        }
    }
}
