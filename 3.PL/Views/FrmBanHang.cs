using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
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
        public FrmBanHang()
        {
            InitializeComponent();
            _isanphamChiTietServices = new SanPhamChiTietServices();
            List<SanPhamChiTiet> sanPhamChiTiets = _isanphamChiTietServices.GetAllSanPhamCT();
            LoadSp(sanPhamChiTiets);

        }
        public void LoadSp(List<SanPhamChiTiet> list)
        {
            flowPanelSp.Controls.Clear();
            foreach (SanPhamChiTiet sp in list)
            {
                Panel pn = new Panel()
                {
                    Width = 180,
                    Height = 200,
                    BackColor = Color.DarkSeaGreen,
                };
                #region
                //PictureBox pictureBox = new PictureBox()
                //{
                //    Image = Image.FromFile(sp.HinhAnh),
                //    SizeMode = PictureBoxSizeMode.StretchImage,
                //    Dock = DockStyle.Fill,
                //    Tag = sp,
                //};
                ////Thêm 1 hàm khi click hình ảnh
                //// pictureBox.Click += PictureBox_Click; 
                //pn.Controls.Add(pictureBox);
                Label lbtensp = new Label()
                {
                    AutoSize = false,
                    Height = 30,
                    Dock = DockStyle.Bottom,
                    Text = sp.MoTa,
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
                    Text = Convert.ToString(sp.GiaBan),
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
    }
}
