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
        private IPhuongThucThanhToanServices _iphuongThucTTServices;
        private IHoaDonServices _ihoaDonServices;
        private IHoaDonChiTietServices _ihoaDonCTServices;
        List<HoaDonCTVM> _HDCT;
        Guid _idSpct;
        public FrmBanHang()
        {
            InitializeComponent();
            #region load

            #endregion
            dtg_GioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_DonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _isanphamChiTietServices = new SanPhamChiTietServices();
            _ilsanphamServices = new LoaiSanPhamServices();
            _ikhuyenMaiServices = new KhuyenMaiServices();
            _iphuongThucTTServices = new PhuongThucThanhToanServices();
            _ihoaDonServices = new HoaDonServices();
            _ihoaDonCTServices = new HoaDonChiTietServices();

            _HDCT = new List<HoaDonCTVM>();

            List<SanPhamCTViewModels> sanPhamChiTiets = _isanphamChiTietServices.GetsListCtSp();
            LoadSp(sanPhamChiTiets);
            LoadCbb();
            loadGioHang(_HDCT);

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
            loadGioHang(_HDCT);
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
        public void loadGioHang(List<HoaDonCTVM> hoaDonCTVMs)
        {
            int stt = 0;
            dtg_GioHang.Rows.Clear();
            var SortList = hoaDonCTVMs.OrderBy(p => p.TenSP);
            dtg_GioHang.ColumnCount = 6;
            dtg_GioHang.Columns[0].Name = "Idsp";
            dtg_GioHang.Columns[0].Visible = false;
            dtg_GioHang.Columns[1].Name = "STT";
            dtg_GioHang.Columns[2].Name = "Mã sản phẩm";
            dtg_GioHang.Columns[3].Name = "Tên sản phẩm";
            dtg_GioHang.Columns[4].Name = "Đơn giá";
            dtg_GioHang.Columns[5].Name = "Số lượng";

            dtg_GioHang.AllowUserToAddRows = false;
            foreach (var item in SortList)
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
            loadGioHang(_HDCT);
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
            var id = Guid.Parse(dtg_GioHang.Rows[e.RowIndex].Cells[0].Value.ToString());

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
    }
}
