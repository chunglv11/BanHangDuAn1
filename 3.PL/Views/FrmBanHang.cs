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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmBanHang : Form
    {
        private ISanPhamChiTietServices _isanphamChiTietServices;
        private ILoaiSanPhamServices _ilsanphamServices;
        public FrmBanHang()
        {
            InitializeComponent();
            _isanphamChiTietServices = new SanPhamChiTietServices();
            _ilsanphamServices = new LoaiSanPhamServices();
            List<SanPhamCTViewModels> sanPhamChiTiets = _isanphamChiTietServices.GetsListCtSp();
            LoadSp(sanPhamChiTiets);
            LoadCbb();

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
        public void LoadCbb()
        {
            cbb_LoaiSP.Items.Add("Tất cả");
            cbb_LoaiSP.SelectedIndex = 0;
            foreach (var item in _ilsanphamServices.GetLoaiSP())
            {
                cbb_LoaiSP.Items.Add(item.Ten);
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
    }
}
