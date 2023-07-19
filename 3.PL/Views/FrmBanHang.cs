using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Microsoft.VisualBasic;
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
    public partial class FrmBanHang : Form
    {
        private ISanPhamChiTietServices _isanphamChiTietServices;
        private ILoaiSanPhamServices _ilsanphamServices;
        private IKhuyenMaiServices _ikhuyenMaiServices;
        private IKhachHangServices _ikhachHangServices;
        private INhanVienServices _inhanVienServices;
        private IPhuongThucThanhToanServices _iphuongThucTTServices;
        private IHoaDonServices _ihoaDonServices;
        private IHoaDonChiTietServices _ihoaDonCTServices;
        List<HoaDonCTVM> _HDCT;
        Guid _idSpct;
        Guid _idhd;
        KhachHang _kh;
        public FrmBanHang()
        {
            InitializeComponent();

            dtg_GioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_DonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _isanphamChiTietServices = new SanPhamChiTietServices();
            _ilsanphamServices = new LoaiSanPhamServices();
            _ikhuyenMaiServices = new KhuyenMaiServices();
            _ikhachHangServices = new KhachHangServices();
            _inhanVienServices = new NhanVienServices();
            _iphuongThucTTServices = new PhuongThucThanhToanServices();
            _ihoaDonServices = new HoaDonServices();
            _ihoaDonCTServices = new HoaDonChiTietServices();

            _HDCT = new List<HoaDonCTVM>();
            _kh = new KhachHang();
            List<SanPhamCTViewModels> sanPhamChiTiets = _isanphamChiTietServices.GetsListCtSp();
            LoadSp(sanPhamChiTiets);
            LoadCbb();
            loadGioHang();
            LoadDonHang();
        }

        public void LoadSp(List<SanPhamCTViewModels> list)
        {

            flowPanelSp.Controls.Clear();
            foreach (SanPhamCTViewModels sp in list)
            {
                Panel pn = new Panel()
                {
                    Width = 180,
                    Height = 200,
                    BackColor = Color.DarkSeaGreen,

                };

                #region
                PictureBox pictureBox = new PictureBox()
                {
                    Image = Image.FromFile(sp.HinhAnh),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill,
                    Tag = sp,
                };
                //Thêm 1 hàm khi click hình ảnh
                pictureBox.Click += PictureBox_Click;
                pn.Controls.Add(pictureBox);

                Label lbtensp = new Label()
                {
                    AutoSize = false,
                    Height = 30,
                    Dock = DockStyle.Bottom,
                    Text = sp.TenSp,
                    Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                };

                Label lbslTon = new Label()
                {
                    AutoSize = false,
                    Height = 30,
                    Dock = DockStyle.Bottom,
                    Text = Convert.ToString(sp.SoLuongTon),
                    Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                };
                Label lbGia = new Label()
                {
                    AutoSize = false,
                    Height = 30,
                    Dock = DockStyle.Bottom,
                    Text = sp.GiaBan.ToString("#,### vnd"),
                    Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                };

                #endregion
                pn.Controls.Add(lbtensp);
                pn.Controls.Add(lbslTon);
                pn.Controls.Add(lbGia);


                flowPanelSp.Controls.Add(pn);
            }
        }
        //them san pham vao gio
        public void addCart(Guid pID)
        {
            var p = _isanphamChiTietServices.GetsListCtSp().FirstOrDefault(x => x.ID == pID);
            var data = _HDCT.FirstOrDefault(x => x.IDSPCT == p.ID);
            if (data == null)
            {
                HoaDonCTVM hoaDonCTVM = new HoaDonCTVM()
                {
                    IDSPCT = p.ID,
                    MaSPCT = p.Ma,
                    TenSP = p.TenSp,
                    DonGia = p.GiaBan,
                    SoLuong = 1,

                };
                _HDCT.Add(hoaDonCTVM);
            }
            else
            {
                if (data.SoLuong == p.SoLuongTon)
                {
                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                }
                else
                {
                    data.SoLuong++;
                }
            }
            loadGioHang();
        }
        public void ThanhTien()
        {
            if (_HDCT != null)
            {
                decimal total = 0;
                foreach (var item in _HDCT)
                {
                    total += Convert.ToDecimal(item.DonGia) * item.SoLuong;
                }
                lb_Tongtien.Text = total.ToString("N0");
            }
            else
            {
                lb_Tongtien.Text = "";
            }
        }
        public void loadGioHang()
        {
            int stt = 0;
            dtg_GioHang.Rows.Clear();
            //var SortList = hoaDonCTVMs.OrderBy(p => p.TenSP);
            dtg_GioHang.ColumnCount = 6;
            dtg_GioHang.Columns[0].Name = "Idsp";
            dtg_GioHang.Columns[0].Visible = false;
            dtg_GioHang.Columns[1].Name = "STT";
            dtg_GioHang.Columns[2].Name = "Mã sản phẩm";
            dtg_GioHang.Columns[3].Name = "Tên sản phẩm";
            dtg_GioHang.Columns[4].Name = "Đơn giá";
            dtg_GioHang.Columns[5].Name = "Số lượng";
            dtg_GioHang.AllowUserToAddRows = false;
            foreach (var item in _HDCT)
            {

                dtg_GioHang.Rows.Add(item.IDSPCT, ++stt, item.MaSPCT, item.TenSP, item.DonGia.ToString("N0"), item.SoLuong);
            }
            ThanhTien();

        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            SanPhamCTViewModels sp = (SanPhamCTViewModels)((PictureBox)sender).Tag;
            var sanp = _isanphamChiTietServices.GetSanPhamCTByid(sp.ID).ID;
            addCart(sanp);
            loadGioHang();
        }
        public void LoadCbb()
        {
            cbb_LoaiSP.Items.Add("Tất cả");
            cbb_LoaiSP.SelectedIndex = 0;
            foreach (var item in _ilsanphamServices.GetLoaiSP())
            {
                cbb_LoaiSP.Items.Add(item.Ten);
            }
            Cbb_GiamGia.Items.Add("Tất cả");
            Cbb_GiamGia.SelectedIndex = 0;
            foreach (var item in _ikhuyenMaiServices.GetAll())
            {
                Cbb_GiamGia.Items.Add(item.Ten);
            }
            foreach (var item in _iphuongThucTTServices.GetAllThanhToan())
            {
                Cbb_LoaiTT.Items.Add(item.TenPTThanhToan);
            }
        }

        private void cbb_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_LoaiSP.SelectedIndex == 0)
            {
                List<SanPhamCTViewModels> sp = _isanphamChiTietServices.GetsListCtSp();
                LoadSp(sp);
            }
            else
            {
                Guid idloai = _ilsanphamServices.GetLoaiSP().FirstOrDefault(c => c.Ten.Contains(cbb_LoaiSP.Text)).ID;
                List<SanPhamCTViewModels> sp2 = _isanphamChiTietServices.GetsListCtSp().Where(c => c.IDLOAI == idloai).ToList();
                LoadSp(sp2);
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            flowPanelSp.Controls.Clear();
            foreach (SanPhamCTViewModels sp in _isanphamChiTietServices.GetsListCtSp().Where(c => c.TenSp.Contains(tb_TimKiem.Text)))
            {
                Panel pn = new Panel()
                {
                    Width = 180,
                    Height = 200,
                    BackColor = Color.DarkSeaGreen,

                };

                #region
                PictureBox pictureBox = new PictureBox()
                {
                    Image = Image.FromFile(sp.HinhAnh),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill,
                    Tag = sp,
                };
                //Thêm 1 hàm khi click hình ảnh
                // pictureBox.Click += PictureBox_Click; 
                pn.Controls.Add(pictureBox);

                Label lbtensp = new Label()
                {
                    AutoSize = false,
                    Height = 30,
                    Dock = DockStyle.Bottom,
                    Text = sp.TenSp,
                    Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                };
                Label lbslTon = new Label()
                {
                    AutoSize = false,
                    Height = 30,
                    Dock = DockStyle.Bottom,
                    Text = Convert.ToString(sp.SoLuongTon),
                    Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                };
                Label lbGia = new Label()
                {
                    AutoSize = false,
                    Height = 30,
                    Dock = DockStyle.Bottom,
                    Text = sp.GiaBan.ToString("#,### vnd"),
                    Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                };

                #endregion
                pn.Controls.Add(lbtensp);
                pn.Controls.Add(lbslTon);
                pn.Controls.Add(lbGia);

                flowPanelSp.Controls.Add(pn);
            }
        }

        private void dtg_GioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            _idSpct = Guid.Parse(dtg_GioHang.Rows[e.RowIndex].Cells[0].Value.ToString());

        }

        private void dtg_GioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_GioHang.Rows[e.RowIndex];
                if (int.TryParse(dtg_GioHang.Rows[r.Index].Cells[5].Value.ToString(), out int x))
                {
                    if (dtg_GioHang.Rows[r.Index].Cells[5].Value != _HDCT[r.Index].SoLuong.ToString())
                    {
                        if (Convert.ToInt32(dtg_GioHang.Rows[r.Index].Cells[5].Value) <= 0)
                        {
                            MessageBox.Show("Nhập sai số lượng");
                            dtg_GioHang.Rows[r.Index].Cells[5].Value = _HDCT[r.Index].SoLuong;
                        }
                        else
                        {
                            var p = _isanphamChiTietServices.GetsListCtSp().FirstOrDefault(x => x.ID == _HDCT[r.Index].IDSPCT);
                            if (p.SoLuongTon < Convert.ToInt32(dtg_GioHang.Rows[r.Index].Cells[5].Value))
                            {
                                MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                                dtg_GioHang.Rows[r.Index].Cells[5].Value = _HDCT[r.Index].SoLuong;

                            }
                            else
                            {
                                _HDCT[r.Index].SoLuong = Convert.ToInt32(dtg_GioHang.Rows[r.Index].Cells[5].Value);
                                ThanhTien();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai số lượng");
                    dtg_GioHang.Rows[r.Index].Cells[5].Value = _HDCT[r.Index].SoLuong;
                }
            }
        }

        private void btn_XoaSp_Click(object sender, EventArgs e)
        {
            if (_HDCT.Any())
            {
                var item = _HDCT.FirstOrDefault(x => x.IDSPCT == _idSpct);
                _HDCT.Remove(item);
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void btn_XoaGio_Click(object sender, EventArgs e)
        {
            if (_HDCT.Any())
            {
                ClearGioHang();
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void cb_KHVangLai_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_KHVangLai.Checked == true)
            {
                tb_KH.Text = "Khách vãng lai";
                tb_SDT.Text = "00-000-000";
                tb_Diem.Text = "0";

                tb_SDT.Enabled = false;
                tb_KH.Enabled = false;
                tb_Diem.Enabled = false;
            }
            else
            {
                tb_KH.Enabled = true;
                tb_SDT.Enabled = true;
                tb_KH.Text = "";
                tb_SDT.Text = "";
            }
        }
        private void ClearGioHang()
        {
            _HDCT = new List<HoaDonCTVM>();
            dtg_GioHang.Rows.Clear();
            tb_SDT.Text = "";
            tb_KH.Text = "";
            tb_Diem.Text = "";
            tb_MaHD.Text = "";
        }
        private void TaoHoaDon()
        {
            DateTime now = DateTime.Now;
            string maHoaDon = $"HD-{now.Year}-{now.Month}-{now.Day}-{now.Hour}-{now.Minute}-{now.Second}";
            var check = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(c => c.Ma == tb_MaHD.Text);
            if (check != null)
            {
                MessageBox.Show("Mã hoá đơn đã tồn tại");
            }
            else
            {
                var nv = _inhanVienServices.GetAll().FirstOrDefault(c => c.Username == Properties.Settings.Default.TKdaLogin).ID;
                _kh = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(c => c.SDT == tb_SDT.Text);
                HoaDon hd = new HoaDon()
                {
                    ID = Guid.NewGuid(),
                    Ma = maHoaDon,
                    NgayTao = DateTime.Now,
                    IDNV = nv,
                    IDKH = _kh.ID,
                    TrangThai = 0
                };
                _ihoaDonServices.AddHoaDon(hd);
                foreach (var item in _HDCT)
                {
                    HoaDonChiTiet hdct = new HoaDonChiTiet()
                    {
                        IDHD = hd.ID,
                        IDSPCT = item.IDSPCT,
                        DonGia = item.DonGia,
                        SoLuong = item.SoLuong
                    };
                    _ihoaDonCTServices.AddHDCT(hdct);
                    //cho vao sau khi thanh toan
                    //var p = _isanphamChiTietServices.GetsListCtSp().FirstOrDefault(x => x.ID == item.IDSPCT);
                    //p.SoLuongTon -= item.SoLuong;
                    //_isanphamChiTietServices.UpdateSanPhamCT(p);
                }
                tb_MaHD.Text = maHoaDon.ToString();
                MessageBox.Show($"Đã tạo hóa đơn có mã là [{hd.Ma}]");
                LoadSp(_isanphamChiTietServices.GetsListCtSp());
                LoadDonHang();
                ClearGioHang();
                cb_KHVangLai.Checked = false;
            }

        }
        private void LoadDonHang()
        {
            dtg_DonHang.Rows.Clear();
            dtg_DonHang.ColumnCount = 8;
            dtg_DonHang.Columns[0].Name = "ID";
            dtg_DonHang.Columns[0].Visible = false;
            dtg_DonHang.Columns[1].Name = "Ma HD";
            dtg_DonHang.Columns[2].Name = "NV";
            //dtg_DonHang.Columns[2].Visible = false;
            dtg_DonHang.Columns[3].Name = "SDT KH";
            dtg_DonHang.Columns[4].Name = "Tên khuyến mại";
            dtg_DonHang.Columns[5].Name = "Ngay Tao";
            dtg_DonHang.Columns[6].Name = "Ngay Thanh Toan";
            dtg_DonHang.Columns[6].Visible = false;
            dtg_DonHang.Columns[7].Name = "Trang Thai";
            foreach (var a in _ihoaDonServices.GetAllHoaDon())
            {
                dtg_DonHang.Rows.Add(a.ID, a.Ma, a.nhanvien.HoTen, a.khachhang.SDT, a.IDKM, a.NgayTao, a.NgayThanhToan, a.TrangThai == 0 ? "Chưa thanh toán" : "Đã thanh toán");
            }

        }
        private void btn_TaoHD_Click(object sender, EventArgs e)
        {
            if (_HDCT.Any())
            {
                //tim them nhan vien
                var check = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(c => c.SDT == tb_SDT.Text);
                if (check != null)
                {

                    TaoHoaDon();

                }
                else
                {
                    DialogResult dg = MessageBox.Show("Nếu muốn thêm thông tin của khách hàng thì chọn (Yes)!!", "Thong bao", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        KhachHang vkh = new KhachHang()
                        {
                            ID = new Guid(),
                            HovaTen = tb_KH.Text,
                            SDT = tb_SDT.Text,
                            TrangThai = 1,
                            Diem = 0
                        };
                        _ikhachHangServices.AddKhachHang(vkh);
                        MessageBox.Show("Thông tin khách hàng đã được thêm vào mục quản lý!! Hãy tiếp tục hành động của mình");
                        TaoHoaDon();
                    }
                }

            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void dtg_DonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_DonHang.Rows[e.RowIndex];

                _idhd = Guid.Parse(r.Cells[0].Value.ToString());
                var hD = _ihoaDonServices.GetHoaDonById(_idhd);
                tb_MaHD.Text = hD.Ma.ToString();

                var od = _ihoaDonCTServices.GetAllHDCT().Where(c => c.IDHD == _idhd);
                var cid = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(x => x.ID == _idhd).IDKH;
                var c = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(x => x.ID == cid);
                tb_SDT.Text = c.SDT;

                _HDCT = new List<HoaDonCTVM>();
                foreach (var item in od)
                {
                    var p = _isanphamChiTietServices.GetsListCtSp().FirstOrDefault(x => x.ID == item.IDSPCT);

                    HoaDonCTVM orderDetailVM = new HoaDonCTVM()
                    {
                        IDSPCT = p.ID,
                        MaSPCT = p.Ma,
                        TenSP = p.TenSp,
                        DonGia = p.GiaBan,
                        SoLuong = od.FirstOrDefault(x => x.IDSPCT == p.ID).SoLuong
                    };
                    _HDCT.Add(orderDetailVM);

                    loadGioHang();

                }
            }
        }
    }
}
