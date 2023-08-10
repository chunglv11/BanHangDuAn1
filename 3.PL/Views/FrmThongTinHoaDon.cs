using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmThongTinHoaDon : Form
    {
        private ISanPhamChiTietServices _isanphamChiTietServices;
        private IKhachHangServices _ikhachHangServices;
        private INhanVienServices _inhanVienServices;
        private IHoaDonServices _ihoaDonServices;
        private IHoaDonChiTietServices _ihoaDonCTServices;
        private Guid _ID;
        private PrintDialog printDialog;
        private PrintDocument printDocument;
        public FrmThongTinHoaDon(Guid idhd)
        {
            InitializeComponent();
            _isanphamChiTietServices = new SanPhamChiTietServices();
            _ikhachHangServices = new KhachHangServices();
            _inhanVienServices = new NhanVienServices();
            _ihoaDonServices = new HoaDonServices();
            _ihoaDonCTServices = new HoaDonChiTietServices();
            this._ID = idhd;
            this.printDialog = new PrintDialog();
            this.printDocument = new PrintDocument();
            this.printDocument.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);
        }
        public void LoadHDCT(Guid id)
        {
            _ID = id;
            dgv_Show.Rows.Clear();
            foreach (var item in _ihoaDonCTServices.GetAllHDCTVM(id))
            {
                dgv_Show.Rows.Add(item.IDSPCT, item.TenSP, item.SoLuong, item.DonGia, item.ThanhTien);
            }

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            this.printDialog.Document = this.printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void FrmThongTinHoaDon_Load(object sender, EventArgs e)
        {
            var hd = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(c => c.ID == _ID);
            var nv = _inhanVienServices.GetAll().FirstOrDefault(c => c.ID == hd.IDNV);
            var kh = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(c => c.ID == hd.IDKH);
            var hdct = _ihoaDonCTServices.GetAllHDCTVM(_ID).FirstOrDefault();
            lb_Ngaytt.Text = hd.NgayThanhToan.ToString();
            lb_MaHD.Text = hd.Ma;
            lb_MaNV.Text = nv.MaNv;
            lb_SDTkh.Text = kh.SDT;
            lb_TongTien.Text = hdct.ThanhTien.ToString();
            LoadHDCT(_ID);

        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var hd = _ihoaDonServices.GetAllHoaDon().FirstOrDefault(c => c.ID == _ID);
            var nv = _inhanVienServices.GetAll().FirstOrDefault(c => c.ID == hd.IDNV);
            var kh = _ikhachHangServices.GetAllKhachHang().FirstOrDefault(c => c.ID == hd.IDKH);
            var hdct = _ihoaDonCTServices.GetAllHDCTVM(_ID).FirstOrDefault();
            e.Graphics.DrawString("Shop quần áo nam hổ béo", new Font("Arial", 16), Brushes.Black, new Point(300, 100));
            e.Graphics.DrawString("Ngày thanh toán :", new Font("Arial", 10), Brushes.Black, new Point(300, 160));
            e.Graphics.DrawString(hd.NgayThanhToan.ToString(), new Font("Arial", 10), Brushes.Black, new Point(420, 160));
            e.Graphics.DrawString("Mã Hóa Đơn :", new Font("Arial", 10), Brushes.Black, new Point(300, 180));
            e.Graphics.DrawString(hd.Ma, new Font("Arial", 10), Brushes.Black, new Point(420, 180));
            e.Graphics.DrawString("Mã nhân viên :", new Font("Arial", 10), Brushes.Black, new Point(300, 200));
            e.Graphics.DrawString(lb_MaNV.Text, new Font("Arial", 10), Brushes.Black, new Point(420, 200));
            e.Graphics.DrawString("SDT khách hàng :", new Font("Arial", 10), Brushes.Black, new Point(300, 220));
            e.Graphics.DrawString(lb_SDTkh.Text, new Font("Arial", 10), Brushes.Black, new Point(420, 220));
            e.Graphics.DrawString("..............................................................................................", new Font("Arial", 10), Brushes.Black, new Point(300, 230));
            e.Graphics.DrawString("Sản phẩm", new Font("Arial", 10), Brushes.Black, new Point(300, 250));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 10), Brushes.Black, new Point(500, 250));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 10), Brushes.Black, new Point(600, 250));
            e.Graphics.DrawString("Thành tiền", new Font("Arial", 10), Brushes.Black, new Point(700, 250));
            int i = 0;
            foreach (var item in _ihoaDonCTServices.GetAllHDCTVM(_ID))
            {
                int x = 270;
                int y = 271;
                e.Graphics.DrawString(item.TenSP.ToString(), new Font("Arial", 10), Brushes.Black, new Point(300, x + (i * 45)));
                e.Graphics.DrawString(item.SoLuong.ToString(), new Font("Arial", 10), Brushes.Black, new Point(500, y + (i * 45)));
                e.Graphics.DrawString(item.DonGia.ToString("N0"), new Font("Arial", 10), Brushes.Black, new Point(600, y + (i * 45)));
                e.Graphics.DrawString(item.ThanhTien.ToString("N0"), new Font("Arial", 10), Brushes.Black, new Point(700, y + (i * 45)));
                i++;
            }
            int sl = _ihoaDonCTServices.GetAllHDCTVM(_ID).Count;
            e.Graphics.DrawString("Tổng Tiền", new Font("Arial", 15), Brushes.Black, new Point(300, 245 + ((sl + 1) * 45)));
            e.Graphics.DrawString(lb_TongTien.Text, new Font("Arial", 15), Brushes.Black, new Point(470, 245 + ((sl + 1) * 45)));
            e.Graphics.DrawString("CẢM ƠN QUÝ KHÁCH", new Font("Arial", 10), Brushes.Black, new Point(300, 295 + ((sl + 1) * 45)));
            e.Graphics.DrawString("HẸN GẶP LẠI!", new Font("Arial", 10), Brushes.Black, new Point(300, 315 + ((sl + 1) * 45)));


        }
    }
}
