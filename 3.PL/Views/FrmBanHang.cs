using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private IChiTietTTService _ichiTietTTService;
        private readonly Guid idThanhToanOnline;
        private readonly Guid idThanhToanOffline;
        List<HoaDonCTVM> _HDCT;
        Guid _idSpct;
        Guid _idhd;
        FilterInfoCollection FilterCam;
        VideoCaptureDevice Videocam;
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
            _ichiTietTTService = new ChiTietTTService();
            idThanhToanOffline = _iphuongThucTTServices.GetAllThanhToan().FirstOrDefault(c => c.MaPTThanhToan == "Offline").ID;
            idThanhToanOnline = _iphuongThucTTServices.GetAllThanhToan().FirstOrDefault(c => c.MaPTThanhToan == "Online").ID;

            _ihoaDonServices = new HoaDonServices();
            _ihoaDonCTServices = new HoaDonChiTietServices();
            _HDCT = new List<HoaDonCTVM>();
            _kh = new KhachHang();
            List<SanPhamCTViewModels> sanPhamChiTiets = _isanphamChiTietServices.GetsListCtSp();
            LoadSp(sanPhamChiTiets);
            LoadCbb();
            loadGioHang();
            LoadDonHang();
            loadCam();

        }

        public void LoadSp(List<SanPhamCTViewModels> list)
        {

            flowPanelSp.Controls.Clear();
            foreach (SanPhamCTViewModels sp in list.Where(c => c.TrangThai == 1 && c.SoLuongTon > 0))
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
        //khi cập nhật chọn số lượng chỉ +1,chưa cộng số lượng mình nhập

        public void addCart(Guid pID)
        {
            var p = _isanphamChiTietServices.GetsListCtSp().FirstOrDefault(x => x.ID == pID);
            var data = _HDCT.FirstOrDefault(x => x.IDSPCT == p.ID);
            string content = Interaction.InputBox("Mời Bạn Nhập Số Lượng Muốn Thêm", "Thêm Vào Giỏ Hàng", "", 500, 300);
            #region check nhập
            if (Regex.IsMatch(content, @"^[a-zA-Z0-9 ]*$") == false)
            {
                MessageBox.Show("Số Lượng không được chứa ký tự đặc biệt", "ERR");
                return;
            }
            //if (Regex.IsMatch(content, @"^\d+$") == false)
            //{

            //    MessageBox.Show("Số Lượng không được chứa chữ cái", "ERR");
            //    return;
            //}
            if (content.Length > 6)
            {
                MessageBox.Show("Số Lượng Không Cho Phép", "ERR");
                return;
            }
            if (Convert.ToInt32(content) < 0)
            {
                MessageBox.Show("Số Lượng Không Cho Phép Âm", "ERR");
                return;
            }
            #endregion
            if (content.Length > 0 && content != "0" && content.Length < 6)
            {
                if (Convert.ToInt32(content) <= Convert.ToInt32(_isanphamChiTietServices.GetsListCtSp().Where(c => c.ID == p.ID).Select(c => c.SoLuongTon).FirstOrDefault()))
                {
                    if (data == null)
                    {
                        HoaDonCTVM hoaDonCTVM = new HoaDonCTVM()
                        {
                            IDSPCT = p.ID,
                            MaSPCT = p.Ma,
                            TenSP = p.TenSp,
                            DonGia = p.GiaBan,
                            SoLuong = Convert.ToInt32(content),

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

                }
                else
                {

                    MessageBox.Show("Sản Phẩm Không Đủ Để Thêm", "Thông báo");

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
                lb_Thanhtien.Text = total.ToString("N0");
                lb_TongTienTT.Text = total.ToString("N0");
            }
            else
            {
                lb_Thanhtien.Text = "";
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
            //lấy ra id sp
            var sanp = _isanphamChiTietServices.GetSanPhamCTByid(sp.ID).ID;
            addCart(sanp);
            //string content = Interaction.InputBox("Mời Bạn Nhập Số Lượng Muốn Thêm", "Thêm Vào Giỏ Hàng", "", 500, 300);
            //#region check nhập
            //if (Regex.IsMatch(content, @"^[a-zA-Z0-9 ]*$") == false)
            //{
            //    MessageBox.Show("Số Lượng không được chứa ký tự đặc biệt", "ERR");
            //    return;
            //}
            //if (Regex.IsMatch(content, @"^\d+$") == false)
            //{

            //    MessageBox.Show("Số Lượng không được chứa chữ cái", "ERR");
            //    return;
            //}
            //if (content.Length > 6)
            //{
            //    MessageBox.Show("Số Lượng Không Cho Phép", "ERR");
            //    return;
            //}
            //if (Convert.ToInt32(content) < 0)
            //{
            //    MessageBox.Show("Số Lượng Không Cho Phép Âm", "ERR");
            //    return;
            //}
            //#endregion
            //if (content.Length > 0 && content != "0" && content.Length < 6)
            //{
            //    if (Convert.ToInt32(content) <= Convert.ToInt32(_isanphamChiTietServices.GetsListCtSp().Where(c => c.ID == sanp).Select(c => c.SoLuongTon).FirstOrDefault()))
            //    {
            //        var p = _isanphamChiTietServices.GetsListCtSp().FirstOrDefault(x => x.ID == sanp);
            //        var data = _HDCT.FirstOrDefault(x => x.IDSPCT == p.ID);
            //        if (data == null)
            //        {
            //            HoaDonCTVM hoaDonCTVM = new HoaDonCTVM()
            //            {
            //                IDSPCT = p.ID,
            //                MaSPCT = p.Ma,
            //                TenSP = p.TenSp,
            //                DonGia = p.GiaBan,
            //                SoLuong = Convert.ToInt32(content),

            //            };
            //            _HDCT.Add(hoaDonCTVM);
            //        }
            //        else
            //        {
            //            if (data.SoLuong == p.SoLuongTon)
            //            {
            //                MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
            //            }
            //            else
            //            {
            //                data.SoLuong++;
            //            }
            //        }

            //    }
            //    else
            //    {

            //        MessageBox.Show("Sản Phẩm Không Đủ Để Thêm", "Thông báo");

            //    }
            //}
            //loadGioHang();
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
            foreach (var item in _ikhuyenMaiServices.GetAll().Where(c => c.TrangThai == 1 && c.NgayKetThuc >= DateTime.Now))
            {
                Cbb_GiamGia.Items.Add(item.Ten);
            }
            Cbb_LoaiTT.Items.Add("Chuyển khoản + Tiền mặt");
            Cbb_LoaiTT.SelectedIndex = 0;
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


        private void ClearGioHang()
        {
            _HDCT = new List<HoaDonCTVM>();
            dtg_GioHang.Rows.Clear();
            tb_SDT.Text = "";
            lb_Tenkh.Text = "";
            tb_Diem.Text = "";
            tb_MaHD.Text = "";
            lb_Thanhtien.Text = "";
            lb_TongTienTT.Text = "";
        }
        private void LoadDonHang()
        {
            int stt = 0;
            dtg_DonHang.Rows.Clear();
            dtg_DonHang.ColumnCount = 8;
            dtg_DonHang.Columns[0].Name = "ID";
            dtg_DonHang.Columns[0].Visible = false;
            dtg_DonHang.Columns[1].Name = "STT";
            dtg_DonHang.Columns[2].Name = "Ma HD";
            dtg_DonHang.Columns[3].Name = "NV";
            //dtg_DonHang.Columns[2].Visible = false;
            dtg_DonHang.Columns[4].Name = "SDT KH";
            dtg_DonHang.Columns[5].Name = "Ngay Tao";
            dtg_DonHang.Columns[6].Name = "Ngay Thanh Toan";
            dtg_DonHang.Columns[6].Visible = false;
            dtg_DonHang.Columns[7].Name = "Trang Thai";
            dtg_DonHang.AllowUserToAddRows = false;

            foreach (var a in _ihoaDonServices.GetAllHoaDon().Where(c => c.TrangThai == 0))
            {
                dtg_DonHang.Rows.Add(a.ID, ++stt, a.Ma, a.nhanvien.HoTen, a.khachhang.SDT, a.NgayTao, a.NgayThanhToan, a.TrangThai == 0 ? "Chưa thanh toán" : "Đã thanh toán");
            }

        }
        //Số lượng tồn bị âm nếu tạo 2 hoá đơn mà có cùng 1 sản phẩm(sản phẩm bị hết nếu hoá đơn thanh toán trước)
        private void btn_TaoHD_Click(object sender, EventArgs e)
        {
            if (_HDCT.Any())
            {
                decimal total = 0;
                foreach (var item in _HDCT)
                {
                    total += item.DonGia * item.SoLuong;
                }
                if (_idhd == Guid.Empty)
                {
                    var nv = _inhanVienServices.GetAll().FirstOrDefault(c => c.Username == Properties.Settings.Default.TKdaLogin).ID;
                    _kh = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(c => c.SDT == tb_SDT.Text);
                    if (_kh != null)
                    {

                        string maHoaDon = "HD" + DateTime.Now.Ticks;
                        //int maHoaDon = _ihoaDonServices.GetAllHoaDon().Count() + 1;//tạo hoá đơn lúc được lú không được OẢI :))
                        //trùng mã hoá đơn nếu 1 mã đã thanh toán và 1 mã chưa thanh toán
                        HoaDon hd = new HoaDon()
                        {
                            ID = Guid.NewGuid(),
                            IDNV = nv,
                            Ma =/* "HD" +*/ maHoaDon.ToString(),
                            IDKH = _kh.ID,
                            IDKM = Cbb_GiamGia.SelectedIndex == 0 ? null : _ikhuyenMaiServices.GetKhuyenByName(Cbb_GiamGia.Text).ID,
                            NgayTao = DateTime.Now,
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

                            tb_MaHD.Text = maHoaDon.ToString();
                            //lb_TongTienTT.Text = total.ToString("N0");
                            tb_SDT.Text = "";
                            lb_Thanhtien.Text = "";
                            LoadSp(_isanphamChiTietServices.GetsListCtSp());
                            LoadDonHang();
                            ClearGioHang();

                        }
                        MessageBox.Show($"Đã tạo hóa đơn có mã là [{hd.Ma}]");
                        //_idhd = Guid.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập thông tin khách hàng");
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
                var hD = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(c => c.ID == _idhd);
                tb_MaHD.Text = hD.Ma.ToString();

                var od = _ihoaDonCTServices.GetAllHDCT().Where(c => c.IDHD == _idhd);
                var cid = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(x => x.ID == _idhd).IDKH;// ko thay id hoadon qua id kh/đã sửa
                var c = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(x => x.ID == cid);
                tb_SDT.Text = c.SDT;
                lb_Tenkh.Text = c.HovaTen;
                //if (hD.IDKM == null)
                //{
                //    Cbb_GiamGia.SelectedIndex = 0;
                //}
                //else
                //{
                //    Cbb_GiamGia.Text = _ikhuyenMaiServices.GetKhuyenByName(Cbb_GiamGia.Text).ID.ToString();
                //}
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

        private void tb_SDT_TextChanged(object sender, EventArgs e)
        {
            _kh = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(c => c.SDT == tb_SDT.Text);
            if (_kh != null)
            {
                lb_Tenkh.Text = _kh.HovaTen;
                lb_Diem.Text = _kh.Diem.ToString();
            }
            else
            {
                lb_Tenkh.Text = "";
                lb_Diem.Text = "";
            }
        }

        private void btn_CapNhatHD_Click(object sender, EventArgs e)
        {
            if (_idhd != null)
            {
                if (_HDCT.Any())
                {
                    decimal total = 0;
                    _kh = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(x => x.SDT == tb_SDT.Text);
                    if (_kh != null)
                    {
                        var order = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(x => x.ID == _idhd);
                        var odd = _ihoaDonCTServices.GetAllHDCT().Where(x => x.IDHD == _idhd);
                        foreach (var item in odd)
                        {
                            _ihoaDonCTServices.DeleteHDCT(item);
                        }


                        foreach (var item in _HDCT)
                        {
                            HoaDonChiTiet od = new HoaDonChiTiet()
                            {
                                IDHD = _idhd,
                                IDSPCT = item.IDSPCT,
                                DonGia = item.DonGia,
                                SoLuong = item.SoLuong
                            };
                            total += Convert.ToDecimal(item.DonGia * item.SoLuong);
                            _ihoaDonCTServices.AddHDCT(od);
                        }

                        var eID = _inhanVienServices.GetAll().FirstOrDefault(x => x.Username == Properties.Settings.Default.TKdaLogin).ID;
                        order.NgayTao = DateTime.Now;

                        order.IDNV = eID;
                        order.IDKH = _kh.ID;
                        // order.IDKM = _ikhuyenMaiServices.GetByMa(Cbb_GiamGia.Text).ID;
                        _ihoaDonServices.UpdateHoaDon(order);


                        lb_TongTienTT.Text = total.ToString();
                        tb_SDT.Text = "";
                        lb_Thanhtien.Text = "";
                        MessageBox.Show($"Cập nhật hóa đơn thành công. Mã: {order.Ma}");
                        _idhd = Guid.Empty;
                        LoadSp(_isanphamChiTietServices.GetsListCtSp());
                        LoadDonHang();
                        dtg_GioHang.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập khách hàng");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
                }
            }
        }
        //tìm điểm kh theo mã hd
        private void tb_MaHD_TextChanged(object sender, EventArgs e)
        {
            HoaDon o = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(x => x.Ma == tb_MaHD.Text && x.TrangThai == 0);
            if (o != null)
            {


                var customer = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(x => x.ID == o.IDKH);
                lb_GiamGiaDiem.Text = $"(Tối đa : {customer.Diem})";
            }
            else
            {
                lb_TongTienTT.Text = "0";
                lb_GiamGiaDiem.Text = "(Tối đa : 0)";
            }
        }
        //tiền thừa <0 vẫn thanh toán đc. Cần check lại
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            HoaDon hd = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(a => a.Ma == tb_MaHD.Text && a.TrangThai == 0);
            var Khach = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(c => c.ID == hd.IDKH);
            int x;
            if (tb_Diem.Text == "" || Convert.ToInt32(tb_Diem.Text) > Khach.Diem || Convert.ToDecimal(lbTienThua.Text) < 0 || tb_TienKhachDua.Text == "" || Convert.ToDecimal(tb_TienKhachDua.Text) < 0 || Convert.ToDecimal(lb_TongTienTT.Text) < 0)
            {
                MessageBox.Show("Kiểm tra lại giá trị đầu vào");
            }
            else
            {
                if (hd != null && hd.TrangThai is not 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        #region Hoá đơn
                        hd.TrangThai = 1;
                        hd.NgayThanhToan = DateTime.Now;
                        hd.IDKM = Cbb_GiamGia.SelectedIndex == 0 ? null : _ikhuyenMaiServices.GetKhuyenByName(Cbb_GiamGia.Text).ID;
                        //hd.IDKM = Cbb_GiamGia.SelectedIndex == 0 ? null : _ikhuyenMaiServices.GetKhuyenByName(Cbb_GiamGia.Text).ID;
                        _ichiTietTTService.AddCTTT(new ChiTietThanhToan() { IdHoaDon = hd.ID, IdPhuongThucThanhToan = idThanhToanOnline, SoTienThanhToan = Convert.ToDecimal(tb_TTOnline.Text.Trim()) });
                        _ichiTietTTService.AddCTTT(new ChiTietThanhToan() { IdHoaDon = hd.ID, IdPhuongThucThanhToan = idThanhToanOffline, SoTienThanhToan = Convert.ToDecimal(tb_TienKhachDua.Text.Trim()) });
                        _ihoaDonServices.UpdateHoaDon(hd);
                        #endregion
                        #region Điểm Khách hàng
                        //tinh tỏng tien ơ hdct là tính dc điểm hoặc thêm tt tônge tiền ở hoá đơn
                        decimal total = 0;
                        foreach (var item in _HDCT)
                        {
                            total += item.DonGia * item.SoLuong;
                        }
                        if (tb_TienKhachDua.Text == "0" && Convert.ToDecimal(tb_Diem.Text) > total)
                        {
                            lbTienThua.Text = "0";
                            Khach.Diem -= Convert.ToInt32(total);
                        }
                        else
                        {
                            //Cần thêm nếu là khách vãng lai thì không cộng điểm
                            if (Khach.SDT.ToString() == "0")
                            {
                                Khach.Diem = 0;
                            }
                            else if (tb_Diem.Text != "")
                            {
                                //Nếu dùng điểm thì trừ đi số điểm dùng và cộng thêm điểm khi mua hàng
                                Khach.Diem = Khach.Diem + (Convert.ToInt32(total) / 100) - (Convert.ToInt32(tb_Diem.Text)); //Lỗi ko convert dc
                            }
                            else
                            {
                                //không dùng điểm thì cộng dồn điểm
                                Khach.Diem += (Convert.ToInt32(total) / 100);
                            }
                        }
                        _ikhachHangServices.EditKhachHang(Khach);
                        #endregion
                        //tet lai
                        foreach (var hdct in _HDCT)
                        {
                            HoaDonChiTiet whdct = new HoaDonChiTiet()
                            {
                                IDHD = hd.ID,
                                DonGia = hdct.DonGia,
                                SoLuong = hdct.SoLuong,
                            };
                            _ihoaDonCTServices.AddHDCT(whdct);
                            var sp = _isanphamChiTietServices.GetsListCtSp().FirstOrDefault(c => c.ID == hdct.IDSPCT);
                            sp.SoLuongTon = sp.SoLuongTon - hdct.SoLuong;
                            _isanphamChiTietServices.UpdateSanPhamCT(sp);
                            LoadSp(_isanphamChiTietServices.GetsListCtSp());
                        }
                        MessageBox.Show("Thanh toán thành công");
                        var idhdd = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(c => c.Ma == tb_MaHD.Text).ID;
                        FrmThongTinHoaDon frmThongTin = new FrmThongTinHoaDon(idhdd);
                        frmThongTin.ShowDialog();
                        LoadDonHang();
                        ClearGioHang();

                    }



                }
            }
        }
        //Chonj phương thức thanh toán
        private void Cbb_LoaiTT_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Cbb_LoaiTT.SelectedItem.ToString() == "Chuyển khoản + Tiền mặt")
            {
                tb_TienKhachDua.Enabled = true;
                tb_TTOnline.Enabled = true;


            }
            else if (Cbb_LoaiTT.SelectedItem.ToString() == "Tiền mặt")
            {
                tb_TienKhachDua.Enabled = true;
                tb_TTOnline.Enabled = false;
                tb_TTOnline.Text = "0";
            }
            else if (Cbb_LoaiTT.SelectedItem.ToString() == "Chuyển khoản")
            {
                tb_TienKhachDua.Enabled = false;
                tb_TTOnline.Enabled = true;
                tb_TienKhachDua.Text = "0";
            }
        }
        public void loadTienThua()
        {
            if (!(tb_TienKhachDua.Text == "" && tb_Diem.Text == ""))
            {
                if (tb_Diem.Text == "")
                {
                    if (decimal.TryParse(tb_TienKhachDua.Text, out decimal x) && decimal.TryParse(tb_TTOnline.Text, out decimal y))
                    {
                        decimal tienthua = Convert.ToDecimal(tb_TienKhachDua.Text) + Convert.ToDecimal(tb_TTOnline.Text) - Convert.ToDecimal(lb_TongTienTT.Text);
                        lbTienThua.Text = tienthua.ToString();
                    }
                }
                else
                {
                    if (decimal.TryParse(tb_TienKhachDua.Text, out decimal x) && decimal.TryParse(tb_Diem.Text, out decimal y) && decimal.TryParse(tb_TTOnline.Text, out decimal z))
                    {
                        lbTienThua.Text = (Convert.ToDecimal(tb_TienKhachDua.Text) + Convert.ToDecimal(tb_TTOnline.Text) - Convert.ToDecimal(lb_TongTienTT.Text) + Convert.ToDecimal(tb_Diem.Text)).ToString();
                    }
                }
            }
        }
        public void loadTienThuaON()
        {
            if (!(tb_TTOnline.Text == "" && tb_Diem.Text == ""))
            {
                if (tb_Diem.Text == "")
                {
                    if (decimal.TryParse(tb_TTOnline.Text, out decimal x) && decimal.TryParse(tb_TienKhachDua.Text, out decimal y))//thêm dòng này nếu bị lỗi convert
                    {
                        lbTienThua.Text = (Convert.ToDecimal(tb_TTOnline.Text) + Convert.ToDecimal(tb_TienKhachDua.Text) - Convert.ToDecimal(lb_TongTienTT.Text)).ToString();
                    }
                }
                else
                {
                    if (decimal.TryParse(tb_TTOnline.Text, out decimal x) && decimal.TryParse(tb_Diem.Text, out decimal y) && decimal.TryParse(tb_TienKhachDua.Text, out decimal z))
                    {
                        lbTienThua.Text = (Convert.ToDecimal(tb_TTOnline.Text) + Convert.ToDecimal(tb_TienKhachDua.Text) - Convert.ToDecimal(lb_TongTienTT.Text) + Convert.ToDecimal(tb_Diem.Text)).ToString();
                    }
                }
            }
        }
        //them 1 hàm tt tien onl
        private void tb_TTOnline_TextChanged(object sender, EventArgs e)
        {
            //decimal thanhToanOnline;
            ////try
            ////{
            //thanhToanOnline = Convert.ToDecimal(tb_TTOnline.Text.ToString());
            ////}
            ////catch (Exception)
            ////{
            ////    thanhToanOnline = 0;
            ////}
            ////xoa .trim di van vay

            //lbTienThua.Text = (Convert.ToDecimal(tb_TienKhachDua.Text.ToString()) + thanhToanOnline - Convert.ToDecimal(lb_TongTienTT.Text.ToString())).ToString();
            loadTienThuaON();
        }

        private void tb_TienKhachDua_TextChanged(object sender, EventArgs e)
        {
            //decimal tienKhachDua;
            ////try
            ////{
            //tienKhachDua = Convert.ToDecimal(tb_TienKhachDua.Text.ToString());
            ////}
            ////catch (Exception)
            ////{
            ////    tienKhachDua = 0;
            ////}

            //lbTienThua.Text = (Convert.ToDecimal(tb_TTOnline.Text.ToString()) + tienKhachDua - Convert.ToDecimal(tb_TongTien.Text.ToString())).ToString();
            loadTienThua();
        }
        #region//Chỉ được nhập số
        //-kiểm tra xem phím vừa nhập vào textbox có phải là ký tự số hay không
        //-kiểm tra xem phím vừa nhập vào textbox có phải là các ký tự điều khiển hay k
        private void tb_Diem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_TienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_TTOnline_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm

        }

        private void tb_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }
        #endregion


        //phải nhập lại điểm hoặc tiền khách đưa mới tính được tiền thừa
        //hoặc làm từ trên xuống dưới km-điểm-nhập tiền
        private void Cbb_GiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (var item in _HDCT)
            {
                total += item.DonGia * item.SoLuong;
            }
            KhuyenMai km = _ikhuyenMaiServices.GetKhuyenByName(Cbb_GiamGia.Text);
            if (!(Cbb_GiamGia.SelectedIndex == 0))
            {
                if (!(km.SoTienGiam == 0))
                {
                    lb_TongTienTT.Text = (Convert.ToDouble(total) - km.SoTienGiam).ToString();
                }
                else
                {
                    int tong = Convert.ToInt32(total);
                    lb_TongTienTT.Text = (tong / 100 * (100 - km.PhanTramGiam)).ToString();
                }
                HoaDon hd = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(a => a.Ma == tb_MaHD.Text);
                //var Khach = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(c => c.ID == hd.IDKH);
                if (!(tb_TienKhachDua.Text == ""))
                {
                    if (decimal.TryParse(tb_TienKhachDua.Text, out decimal x) && decimal.TryParse(tb_TTOnline.Text, out decimal y))
                    {
                        lbTienThua.Text = (Convert.ToDecimal(tb_TienKhachDua.Text) + Convert.ToDecimal(tb_TTOnline.Text) - Convert.ToDecimal(lb_TongTienTT.Text)).ToString();
                    }

                }
                else
                {
                    if (decimal.TryParse(tb_TienKhachDua.Text, out decimal x))
                    {
                        lbTienThua.Text = (0 - Convert.ToDouble(lb_TongTienTT.Text)).ToString();
                    }

                }
            }
            else
            {
                lb_TongTienTT.Text = lb_Thanhtien.Text;
                if (!(tb_TienKhachDua.Text == ""))
                {
                    if (decimal.TryParse(tb_TienKhachDua.Text, out decimal x))
                    {
                        lbTienThua.Text = (Convert.ToDouble(tb_TienKhachDua.Text) + (Convert.ToDouble(tb_TTOnline.Text) - Convert.ToDouble(lb_TongTienTT.Text))).ToString();
                    }

                }
                else
                {
                    //khi khuyen mai giảm hhêt tien trong hoa don
                    if (decimal.TryParse(tb_TienKhachDua.Text, out decimal x))//thêm dòng này mới k bị lỗi convert
                    {
                        lbTienThua.Text = (0 - Convert.ToDouble(lb_TongTienTT.Text)).ToString();
                    }

                }
            }
        }

        private void btn_HuyDon_Click(object sender, EventArgs e)
        {
            HoaDon hd = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(a => a.Ma == tb_MaHD.Text);
            var Khach = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(c => c.ID == hd.IDKH);
            try
            {
                if (hd != null)
                {
                    if (hd.TrangThai is not 1 and not (-1))
                    {
                        hd.TrangThai = -1;
                        _ihoaDonServices.UpdateHoaDon(hd);
                        MessageBox.Show("Đã hủy hóa đơn");
                        LoadDonHang();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tb_Diem_TextChanged(object sender, EventArgs e)
        {
            HoaDon hd = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(a => a.Ma == tb_MaHD.Text);
            var Khach = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(c => c.ID == hd.IDKH);
            if (int.TryParse(tb_Diem.Text, out int y))
            {
                if (Convert.ToInt32(tb_Diem.Text) > Khach.Diem)
                {
                    MessageBox.Show($"Số điểm bạn nhập vướt quá số điểm khách hàng có: {Khach.Diem}");
                }

            }

        }

        public void loadCam()
        {
            FilterCam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in FilterCam)
            {
                cbb_Cam.Items.Add(device.Name);
            }
            cbb_Cam.SelectedIndex = 0;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ptb_QR.Image != null)
                {
                    BarcodeReader reader = new BarcodeReader();
                    Result result = reader.Decode((Bitmap)ptb_QR.Image);
                    if (result != null)
                    {
                        var idsp = Guid.Parse(result.ToString());
                        addCart(idsp);


                    }
                }
                else MessageBox.Show("sản phẩm không tồn tại");

            }
            catch (Exception)
            {

                throw new Exception("Looi");
            }


        }


        private void btn_QuetMa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Mở Camera Hay Không ?", "Thông Báo", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Videocam = new VideoCaptureDevice(FilterCam[cbb_Cam.SelectedIndex].MonikerString);
                    Videocam.NewFrame += VideoCaptureDevice_NewFrame;
                    Videocam.Start();
                    timer1.Start();
                    MessageBox.Show("Mở cam thành công");
                };

                if (dialogResult == DialogResult.No)
                {

                    MessageBox.Show("Mở cam thất bại");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Liên Hệ Với Bé Mỡ để sửa lỗi");
                return;

            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ptb_QR.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (ptb_QR.Image != null)
            {

                ptb_QR.Image = null;
                ptb_QR.ImageLocation = null;

                ptb_QR.Update();
            }
        }
    }
}
