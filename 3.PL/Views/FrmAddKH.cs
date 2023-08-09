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
    public partial class FrmAddKH : Form
    {
        IKhachHangServices _ikhachhang;
        KhachHang _khachhang;
        public FrmAddKH()
        {
            InitializeComponent();
            _ikhachhang = new KhachHangServices();
        }
        private bool checknhap()
        {
            if (txb_hoten.Text == "" || txb_sdt.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var sdt = _ikhachhang.GetAllKhachHang().FirstOrDefault(p => p.SDT == txb_sdt.Text);
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (txb_sdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải có ít nhất 10 kí tự");

            }
            else if (txb_sdt.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại phải nhỏ hơn 11 kí tự");

            }
            else if (sdt != null)
            {
                MessageBox.Show("Số điện thoại đã được sử dụng", "Chú ý");
            }
            else
            {

                _khachhang = new KhachHang()
                {
                    ID = Guid.NewGuid(),
                    HovaTen = txb_hoten.Text,
                    Diem = 0,
                    SDT = txb_sdt.Text,
                    TrangThai = rbtn_Vang.Checked ? 0 : 1,
                };
                _ikhachhang.AddKhachHang(_khachhang);
                MessageBox.Show("Thêm khách hàng thành công");
                this.Close();
            }
        }
    }
}
