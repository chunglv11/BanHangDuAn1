using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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
    public partial class FrmThongKe : Form
    {
        private IThongKeServices _services;
        public FrmThongKe()
        {
            InitializeComponent();
            _services = new ThongKeServices();
            LoadData(_services.GetLstSpDaBan());
            loadthang();
            loadnam();
            loadngay();
        }
        public string[] Getnam()
        {
            string[] TempNs = new string[2030 - 2010];
            for (int i = 0; i < TempNs.Length; i++)
            {
                TempNs[i] = Convert.ToString(2010 + i);
            }
            return TempNs;
        }
        public string[] Getngay()
        {
            string[] TempNs = new string[32 - 1];
            for (int i = 0; i < TempNs.Length; i++)
            {
                TempNs[i] = Convert.ToString(1 + i);
            }
            return TempNs;
        }
        void loadngay()
        {
            foreach (var x in Getngay())
            {
                cmb_Ngay.Items.Add(x);
            }

        }
        void loadnam()
        {
            foreach (var x in Getnam())
            {
                cmb_Nam.Items.Add(x);
            }

        }
        void loadthang()
        {

            string[] lstmon = new string[12];
            lstmon[0] = "1";
            lstmon[1] = "2";
            lstmon[2] = "3";
            lstmon[3] = "4";
            lstmon[4] = "5";
            lstmon[5] = "6";
            lstmon[6] = "7";
            lstmon[7] = "8";
            lstmon[8] = "9";
            lstmon[9] = "10";
            lstmon[10] = "11";
            lstmon[11] = "12";

            foreach (var x in lstmon)
            {
                cmb_Thang.Items.Add(x);
            }

        }
        public void LoadData(List<ThongKeVM> thongKeVMs)
        {
            dgrid_Show.ColumnCount = 6;
            dgrid_Show.Columns[0].Name = "Mã sản phẩm";
            dgrid_Show.Columns[1].Name = "Tên sản phẩm";
            dgrid_Show.Columns[2].Name = "Số lượng";
            dgrid_Show.Columns[3].Name = "Đơn Giá";
            dgrid_Show.Columns[4].Name = "Thành tiền";
            dgrid_Show.Columns[5].Name = "SDT";
            dgrid_Show.Rows.Clear();
            foreach (var x in _services.GetLstSpDaBan().OrderByDescending(c => c.ThanhTien))
            {
                dgrid_Show.Rows.Add(x.MaSp, x.TenSp, x.SoLuong, x.DonGia, x.ThanhTien, x.SDT);
            }
        }

        private void cmb_Ngay_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Thang.Text == "" && cmb_Nam.Text == "")
            {
                loaddataforlocngay(cmb_Ngay.Text);
                return;
            }
            else
            {
                loaddoanhthuforlocall(cmb_Ngay.Text, cmb_Thang.Text, cmb_Nam.Text);
                return;
            }
        }

        private void cmb_Nam_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Thang.Text == "" && cmb_Ngay.Text == "")
            {
                loaddataforlocnam(cmb_Nam.Text);
                return;
            }
            else
            {
                loaddoanhthuforlocall(cmb_Ngay.Text, cmb_Thang.Text, cmb_Nam.Text);
                return;
            }
        }

        private void cmb_Thang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Ngay.Text == "" && cmb_Nam.Text == "")
            {
                loaddataforlocthang(cmb_Thang.Text);
                return;
            }
            else
            {
                loaddoanhthuforlocall(cmb_Ngay.Text, cmb_Thang.Text, cmb_Nam.Text);
            }
        }
        void loaddoanhthuforlocall(string ngay, string thang, string nam)
        {
            dgrid_Show.ColumnCount = 6;
            dgrid_Show.Columns[0].Name = "Mã sản phẩm";
            dgrid_Show.Columns[1].Name = "Tên sản phẩm";
            dgrid_Show.Columns[2].Name = "Số lượng";
            dgrid_Show.Columns[3].Name = "Đơn Giá";
            dgrid_Show.Columns[4].Name = "Thành tiền";
            dgrid_Show.Columns[5].Name = "SDT";
            dgrid_Show.Rows.Clear();
            foreach (var x in _services.GetLstSpDaBan().Where(c => c.NgayTao.Day.ToString() == ngay &&
                c.NgayTao.Month.ToString() == thang && c.NgayTao.Year.ToString() == nam).OrderByDescending(c => c.ThanhTien))
            {
                dgrid_Show.Rows.Add(x.MaSp, x.TenSp, x.SoLuong, x.DonGia, x.ThanhTien, x.SDT);
            }
        }
        //ngày
        void loaddataforlocngay(string ngay)
        {
            dgrid_Show.ColumnCount = 6;
            dgrid_Show.Columns[0].Name = "Mã sản phẩm";
            dgrid_Show.Columns[1].Name = "Tên sản phẩm";
            dgrid_Show.Columns[2].Name = "Số lượng";
            dgrid_Show.Columns[3].Name = "Đơn Giá";
            dgrid_Show.Columns[4].Name = "Thành tiền";
            dgrid_Show.Columns[5].Name = "SDT";
            dgrid_Show.Rows.Clear();
            foreach (var x in _services.GetLstSpDaBan().Where(c => c.NgayTao.Day.ToString() == ngay).OrderByDescending(c => c.ThanhTien))
            {
                dgrid_Show.Rows.Add(x.MaSp, x.TenSp, x.SoLuong, x.DonGia, x.ThanhTien, x.SDT);
            }
        }
        //tháng
        void loaddataforlocthang(string thang)
        {
            dgrid_Show.ColumnCount = 6;
            dgrid_Show.Columns[0].Name = "Mã sản phẩm";
            dgrid_Show.Columns[1].Name = "Tên sản phẩm";
            dgrid_Show.Columns[2].Name = "Số lượng";
            dgrid_Show.Columns[3].Name = "Đơn Giá";
            dgrid_Show.Columns[4].Name = "Thành tiền";
            dgrid_Show.Columns[5].Name = "SDT";
            dgrid_Show.Rows.Clear();
            foreach (var x in _services.GetLstSpDaBan().Where(c => c.NgayTao.Month.ToString() == thang).OrderByDescending(c => c.ThanhTien))
            {
                dgrid_Show.Rows.Add(x.MaSp, x.TenSp, x.SoLuong, x.DonGia, x.ThanhTien, x.SDT);
            }
        }
        //năm
        void loaddataforlocnam(string nam)
        {
            dgrid_Show.ColumnCount = 6;
            dgrid_Show.Columns[0].Name = "Mã sản phẩm";
            dgrid_Show.Columns[1].Name = "Tên sản phẩm";
            dgrid_Show.Columns[2].Name = "Số lượng";
            dgrid_Show.Columns[3].Name = "Đơn Giá";
            dgrid_Show.Columns[4].Name = "Thành tiền";
            dgrid_Show.Columns[5].Name = "SDT";
            dgrid_Show.Rows.Clear();
            foreach (var x in _services.GetLstSpDaBan().Where(c => c.NgayTao.Year.ToString() == nam).OrderByDescending(c => c.ThanhTien))
            {
                dgrid_Show.Rows.Add(x.MaSp, x.TenSp, x.SoLuong, x.DonGia, x.ThanhTien, x.SDT);
            }
        }

        private void txt_TK_TextChanged(object sender, EventArgs e)
        {
            LoadData(_services.GetLstSpDaBan().Where(c => c.MaSp.Contains(txt_TK.Text.ToLower()) || c.TenSp.Contains(txt_TK.Text.ToLower())).ToList());
        }

        private void txt_Sdt_TextChanged(object sender, EventArgs e)
        {
            LoadData(_services.GetLstSpDaBan().Where(c => c.SDT.Contains(txt_Sdt.Text)).ToList());
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            lbl_KH.Text = _services.GetLstSpDaBan().Select(x => x.SDT).Distinct().Count().ToString();
            lbl_DoanhThu.Text = _services.GetLstSpDaBan().Sum(x => x.ThanhTien).ToString();
            lbl_LN.Text = (_services.GetLstSpDaBan().Sum(x => x.ThanhTien) - _services.GetLstSpDaBan().Sum(x => x.GiaNhap)).ToString();
        }
    }
}
