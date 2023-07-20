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
    public partial class FrmAddCart : Form
    {
        private IHoaDonChiTietServices _ihoaDonCTServices;
        private ISanPhamChiTietServices _isanphamChiTietServices;
        Guid _Id;
        List<HoaDonCTVM> _HDCT;
        public FrmAddCart(Guid id)
        {
            InitializeComponent();
            _ihoaDonCTServices = new HoaDonChiTietServices();
            _isanphamChiTietServices = new SanPhamChiTietServices();
            _HDCT = new List<HoaDonCTVM>();
            this._Id = id;

        }
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
                    SoLuong = Convert.ToInt32(tb_SoLuong.Text)

                };
                if (data.SoLuong == p.SoLuongTon)
                {
                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                }
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var sp = _isanphamChiTietServices.GetsListCtSp().FirstOrDefault(c => c.ID == _Id).ID;
            addCart(sp);


        }

    }
}
