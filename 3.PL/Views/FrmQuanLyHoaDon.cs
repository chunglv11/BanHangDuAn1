using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmQuanLyHoaDon : Form
    {
        IHoaDonChiTietServices _ihoaDonChiTietService;
        IHoaDonServices _ihoaDonServices;
        ISanPhamChiTietServices _isanPhamServices;
        Guid _id;
        public FrmQuanLyHoaDon()
        {
            InitializeComponent();
            _ihoaDonChiTietService = new HoaDonChiTietServices();
            _ihoaDonServices = new HoaDonServices();
            _isanPhamServices = new SanPhamChiTietServices();
            dtg_ShowHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_hdct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loadHD();
        }
        public void loadHD()
        {
            dtg_ShowHD.ColumnCount = 7;
            dtg_ShowHD.Columns[0].Name = " ID";
            dtg_ShowHD.Columns[0].Visible = false;
            dtg_ShowHD.Columns[1].Name = " Mã";
            dtg_ShowHD.Columns[2].Name = " Ngày Tạo";
            dtg_ShowHD.Columns[3].Name = " Ngày Thanh Toán";
            dtg_ShowHD.Columns[4].Name = " Tên NV";
            //dtg_ShowHD.Columns[5].Name = " Tên KM";
            dtg_ShowHD.Columns[5].Name = " SDT KH";
            dtg_ShowHD.Columns[6].Name = " Trạng Thái";
            dtg_ShowHD.AllowUserToAddRows = false;
            dtg_ShowHD.Rows.Clear();
            foreach (var item in _ihoaDonServices.GetAllHoaDon().OrderByDescending(c => c.NgayTao).ToList())
            {
                dtg_ShowHD.Rows.Add(item.ID, item.Ma, item.NgayTao, item.NgayThanhToan, item.nhanvien.HoTen, item.khachhang.SDT == "0" ? "Khách vãng lai" : item.khachhang.SDT, item.TrangThai == 1 ? "Đã thanh toán" : "Chờ thanh toán");
            }
        }
        public void loadHDCT(Guid id)
        {
            _id = id;
            dtg_hdct.Columns.Clear(); // xóa các cột hiện có
            dtg_hdct.Rows.Clear();
            dtg_hdct.ColumnCount = 6;
            dtg_hdct.Columns[0].Name = "IDSPCT";
            dtg_hdct.Columns[0].Visible = false;
            dtg_hdct.Columns[1].Name = "Mã SPCT";
            dtg_hdct.Columns[2].Name = "Tên sản phẩm";
            dtg_hdct.Columns[3].Name = "Số lượng";
            dtg_hdct.Columns[4].Name = "Đơn giá";
            dtg_hdct.Columns[5].Name = "Thành tiền";
            dtg_hdct.AllowUserToAddRows = false;
            foreach (var item in _ihoaDonChiTietService.GetAllHDCTVM(id))
            {
                dtg_hdct.Rows.Add(item.IDSPCT, item.MaSPCT, item.TenSP, item.SoLuong,
                    item.DonGia.ToString("N0") + " VND", item.ThanhTien.ToString("N0"));
            }
        }

        private void dtg_ShowHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _id = Guid.Parse(dtg_ShowHD.Rows[e.RowIndex].Cells[0].Value.ToString());
                loadHDCT(_id);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_id == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }
            else
            {
                var o = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(x => x.ID == _id);
                if (o.TrangThai == 1)
                {
                    MessageBox.Show("Chỉ được xóa các hóa đơn chưa thanh toán");
                }
                else
                {

                    DialogResult dialog = MessageBox.Show("Bạn có muốn xoá hoá đơn này không?", "Xoá", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        var _lstOd = _ihoaDonChiTietService.GetAllHDCT().Where(x => x.IDHD == _id);
                        foreach (var item in _lstOd)
                        {
                            //var p = _isanPhamServices.GetsListCtSp().FirstOrDefault(x => x.ID == item.IDSPCT);
                            //p.SoLuongTon += item.SoLuong;
                            //_isanPhamServices.UpdateSanPhamCT(p);
                            _ihoaDonChiTietService.DeleteHDCT(item);
                        }
                        _ihoaDonServices.DeleteHoaDon(o);
                        MessageBox.Show("Xóa thành công");
                        dtg_ShowHD.Rows.Clear();
                        loadHD();
                    }

                }
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            dtg_ShowHD.Rows.Clear();

            foreach (var item in _ihoaDonServices.GetAllHoaDonVM().Where(c => c.Ma.Contains(tb_timkiem.Text)))
            {
                dtg_ShowHD.Rows.Add(item.ID, item.Ma, item.NgayTao, item.NgayThanhToan, item.HoTenNV, item.TenKM, item.SDTKH, item.TrangThai == 1 ? "Đã thanh toán" : "Chờ thanh toán");
            }


        }

        private void rdb_Chua_CheckedChanged(object sender, EventArgs e)
        {
            dtg_ShowHD.Rows.Clear();
            dtg_hdct.Rows.Clear();
            foreach (var item in _ihoaDonServices.GetAllHoaDon().Where(c => c.TrangThai is not 1))
            {
                dtg_ShowHD.Rows.Add(item.ID, item.Ma, item.NgayTao, item.NgayThanhToan, item.nhanvien.HoTen, item.khachhang.SDT == "0" ? "Khách vãng lai" : item.khachhang.SDT, item.TrangThai == 1 ? "Đã thanh toán" : "Chờ thanh toán");
            }
        }

        private void rdb_Da_CheckedChanged(object sender, EventArgs e)
        {
            dtg_ShowHD.Rows.Clear();
            dtg_hdct.Rows.Clear();
            foreach (var item in _ihoaDonServices.GetAllHoaDon().Where(c => c.TrangThai == 1))
            {
                dtg_ShowHD.Rows.Add(item.ID, item.Ma, item.NgayTao, item.NgayThanhToan, item.nhanvien.HoTen, item.khachhang.SDT == "0" ? "Khách vãng lai" : item.khachhang.SDT, item.TrangThai == 1 ? "Đã thanh toán" : "Chờ thanh toán");
            }
        }
    }
}
