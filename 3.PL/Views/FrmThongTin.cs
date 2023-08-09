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
    public partial class FrmThongTin : Form
    {
        public INhanVienServices _Inhanvien;

        public FrmThongTin()
        {
            InitializeComponent();
            _Inhanvien = new NhanVienServices();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoiMK frmdoimk = new FrmDoiMK();
            frmdoimk.ShowDialog();
        }
        private void LoadData()
        {

            var nhanvien = _Inhanvien.GetAllView().FirstOrDefault(p => p.Username == Properties.Settings.Default.TKdaLogin);
            tb_MaNV.Text = nhanvien.MaNv;
            lb_CV.Text = nhanvien.Ten;
            lb_Tencv.Text = nhanvien.Ten;
            lb_HoTen.Text = nhanvien.HoTen;
            lb_Email.Text = nhanvien.Email;
            lb_GioiTinh.Text = nhanvien.GioiTinh == 1 ? "nam" : "nữ";
            string formattedDate = nhanvien.NgaySinh.ToString("dd-MM-yyyy");  //chuyển đổi sang dd/mm/yyyy 
            dateTimePicker1.Text = Convert.ToString(formattedDate);

        }
    }
}
