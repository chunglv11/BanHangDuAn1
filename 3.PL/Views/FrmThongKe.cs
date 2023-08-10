using _1.DAL.Models;
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
        private IHoaDonServices _order;
        private IHoaDonChiTietServices _orderdetail;
        private IKhachHangServices _customer;
        private ISanPhamChiTietServices _productDetails;
        private ISanPhamServices _product;
        public List<HoaDon> _lstOrder;
        public List<HoaDonChiTiet> _lstOrderDetail;
        public List<KhachHang> _lstCustomer;
        public FrmThongKe()
        {
            InitializeComponent();
            _order = new HoaDonServices();
            _orderdetail = new HoaDonChiTietServices();
            _customer = new KhachHangServices();
            _productDetails = new SanPhamChiTietServices();
            _product = new SanPhamServices();
            _lstOrder = _order.GetAllHoaDon();
            _lstOrderDetail = new List<HoaDonChiTiet>();
            _lstCustomer = new List<KhachHang>();
            loadDate();
            loadData();
        }
        public void loadDate()
        {
            for (int i = 1; i < 13; i++)
            {
                cmb_Thang.Items.Add(i);
            }
            var x = Convert.ToInt32(_order.GetAllHoaDon().First().NgayTao.ToString("yyyy"));
            var y = Convert.ToInt32(_order.GetAllHoaDon().Last().NgayTao.ToString("yyyy"));
            for (int i = x; i <= y; i++)
            {
                cmb_Nam.Items.Add(i);
            }
        }
        public void loadData()
        {
            dgrid_Show.Rows.Clear();
            var x = (from a in _lstOrder
                     join b in _customer.GetAllKhachHang() on a.IDKH equals b.ID
                     join c in _orderdetail.GetAllHDCTVM() on a.ID equals c.IDHD
                     join d in _productDetails.GetAllSanPhamCT() on c.IDSPCT equals d.ID
                     join e in _product.getlsSpfromDB() on d.IDSP equals e.ID
                     where b.SDT.Contains(txt_Sdt.Text) && e.Ten.ToLower().Contains(txt_TK.Text.ToLower())
                     select new { a, b, c, d, e });

            foreach (var i in x)
            {
                dgrid_Show.Rows.Add(i.a.ID, i.e.Ten, i.c.SoLuong, i.c.DonGia, i.c.DonGia * i.c.SoLuong, i.b.SDT == "0" ? "Khách vãng lai" : i.b.SDT);
            }

            lbl_DoanhThu.Text = x.Select(x => x.c).Distinct().Sum(x => x.ThanhTien).ToString("N0");
            lbl_HD.Text = x.GroupBy(x => x.a).Count().ToString();
            lbl_KH.Text = x.GroupBy(x => x.b).Count().ToString();
            lbl_LN.Text = (x.Select(x => x.c).Distinct().Sum(x => x.ThanhTien) - x.Select(x => x.d).Distinct().Sum(x => x.GiaNhap)).ToString("N0");
            //Decimal tongTien = 0;
            //foreach (var i in x)
            //{
            //    Decimal gia1 = i.c.DonGia * i.c.SoLuong;
            //    Decimal gia2 = i.d.GiaNhap * i.c.SoLuong;
            //    tongTien += (gia1 - gia2);
            //}
            //lbl_LN.Text = tongTien.ToString("N0");
        }

        private void dtp_ngay_ValueChanged(object sender, EventArgs e)
        {
            _lstOrder = _order.GetAllHoaDon().Where(x => x.NgayTao.ToString("dd-MM-yyyy") == dtp_ngay.Value.ToString("dd-MM-yyyy")).ToList();
            loadData();
        }
        private void cmb_Thang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Thang.Text != "")
            {
                _lstOrder = _order.GetAllHoaDon().Where(x => (x.NgayTao.Month.ToString() == cmb_Thang.Text && x.NgayTao.Year.ToString() == cmb_Nam.Text)).ToList();
                loadData();
            }
        }

        private void cmb_Nam_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Thang.Text != "")
            {
                _lstOrder = _order.GetAllHoaDon().Where(x => (x.NgayTao.Month.ToString() == cmb_Thang.Text && x.NgayTao.Year.ToString() == cmb_Nam.Text)).ToList();
                loadData();
            }
            else
            {
                _lstOrder = _order.GetAllHoaDon().Where(x => x.NgayTao.Year.ToString() == cmb_Nam.Text).ToList();
                loadData();
            }
        }



        private void txt_Sdt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Sdt.Text, out int x) || txt_Sdt.Text.Length <= 10)
            {
                loadData();
            }
            else
            {
                dgrid_Show.Rows.Clear();
            }
        }
        private void txt_TK_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
