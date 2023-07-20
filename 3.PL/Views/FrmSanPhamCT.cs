using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3.PL.Views
{
    public partial class FrmSanPhamCT : Form
    {
        string LinkAnh = "";
        private ISanPhamChiTietServices iSpCt;
        private ISanPhamServices iSp;
        private IMauSacServices iMs;
        private INSXServices iNSX;
        private IKichThuocServices iSize;
        private ILoaiSanPhamServices iLoaiSp;
        private SanPhamViewModels viewSpCt;
        public FrmSanPhamCT()
        {
            InitializeComponent();
            iSpCt = new SanPhamChiTietServices();
            iSp = new SanPhamServices();
            iMs = new MauSacServices();
            iNSX = new NSXServices();
            iSize = new KichThuocServices();
            iLoaiSp = new LoaiSanPhamServices();
            viewSpCt = new SanPhamViewModels();
            LoadMs();
            LoadNsx();
            LoadSize();
            loadLoaiSp();
            loadSp();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dtg_ShowSanPham.ColumnCount = 14;
            dtg_ShowSanPham.Columns[0].Name = "STT";
            dtg_ShowSanPham.Columns[1].Name = "ID";
            dtg_ShowSanPham.Columns[1].Visible = false;
            dtg_ShowSanPham.Columns[2].Name = "Mã";
            dtg_ShowSanPham.Columns[3].Name = "Tên Sản Phẩm";
            dtg_ShowSanPham.Columns[4].Name = "Size";
            dtg_ShowSanPham.Columns[5].Name = "Loại";
            dtg_ShowSanPham.Columns[6].Name = "Màu sắc";
            dtg_ShowSanPham.Columns[7].Name = "Nhà sản xuất";
            dtg_ShowSanPham.Columns[8].Name = "SLT";
            dtg_ShowSanPham.Columns[9].Name = "Gía Nhập";
            dtg_ShowSanPham.Columns[10].Name = "Gía Bán";
            dtg_ShowSanPham.Columns[11].Name = "Mô Tả";
            dtg_ShowSanPham.Columns[12].Name = "Trạng thái";
            dtg_ShowSanPham.Columns[13].Name = "Hinh anh";
            dtg_ShowSanPham.Rows.Clear();
            var lstSpCt = iSpCt.GetsListCtSp();
            foreach (var x in lstSpCt)
            {
                dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma,x.TenSp,x.Size,x.LoaiSp,x.MauSac,x.Nsx, x.SoLuongTon, x.GiaNhap, x.GiaBan, x.MoTa, x.TrangThai, x.HinhAnh);
            }
        }
        public void LoadMs()
        {
            foreach (var x in iMs.GetMauSac())
            {
                cmb_MS.Items.Add(x.Ten);
            }
        }
        public void LoadNsx()
        {
            foreach (var x in iNSX.GetNhasanxuat())
            {
                cmb_Nxs.Items.Add(x.Ten);
            }
        }
        public void LoadSize()
        {
            foreach (var x in iSize.GetSizeAo())
            {
                cmb_Size.Items.Add(x.Ten);
            }
        }
        public void loadLoaiSp()
        {
            foreach (var x in iSp.getlsSpfromDB())
            {
                cmb_TSP.Items.Add(x.Ten);
            }
        }
        public void loadSp()
        {
            foreach (var x in iLoaiSp.GetLoaiSP())
            {
                cmb_Loai.Items.Add(x.Ten);
            }
        }
        private Guid Sp()
        {
            SanPhamViewModels product = new SanPhamViewModels();
            product.Ma = txt_Ma.Text;
            product.Ten = cmb_TSP.Text;
            if (rdb_Con.Checked)
            {
                product.TrangThai = 1;
            }
            else
            {
                product.TrangThai = 0;
            }
            return iSpCt.IdSp(product);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

            var Sp = iSp.getlsSpfromDB().FirstOrDefault(c => c.Ten == cmb_TSP.Text);
            var Ms = iMs.GetMauSac().FirstOrDefault(c => c.Ten == cmb_MS.Text);
            var Loai = iLoaiSp.GetLoaiSP().FirstOrDefault(c => c.Ten == cmb_Loai.Text);
            var size = iSize.GetSizeAo().FirstOrDefault(c => c.Ten == cmb_Size.Text);
            var nsx = iNSX.GetNhasanxuat().FirstOrDefault(c => c.Ten == cmb_Nxs.Text);
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            File.Copy(LinkAnh, Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(LinkAnh)), true);
            LinkAnh = Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(LinkAnh));
            DialogResult dialogResult = MessageBox.Show("bạn có muốn thêm hay không", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SanPhamCTViewModels viewSpCt = new SanPhamCTViewModels()
                {
                    ID = Guid.NewGuid(),
                    IDSP = Sp.ID,
                    IDMS = Ms.ID,
                    IDKC = size.ID,
                    IDLOAI = Loai.ID,
                    IDNSX = nsx.ID,
                    HinhAnh = LinkAnh,
                    SoLuongTon = Convert.ToInt32(txt_SLT.Text),
                    GiaNhap = Convert.ToDecimal(txt_GiaNhap.Text),
                    GiaBan = Convert.ToDecimal(txt_GiaBan.Text),
                    MoTa = txt_Mota.Text,
                    Ma = txt_Ma.Text,
                    TrangThai = rdb_Con.Checked ? 1 : 0,
                };
                iSpCt.AddSanPhamCT(viewSpCt);
                LoadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void ptb_AVT_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                LinkAnh = op.FileName;
                ptb_AVT.Image = Image.FromFile(op.FileName);
                ptb_AVT.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void dtg_ShowSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_ShowSanPham.Rows[e.RowIndex];
                 var _id = Guid.Parse(dtg_ShowSanPham.Rows[e.RowIndex].Cells[1].Value.ToString());
                var CTSP = iSpCt.GetAllSanPhamCT().FirstOrDefault(p => p.ID == _id);
                txt_Ma.Text = CTSP.Ma.ToString();
                //cmb_KM.Text = _khuyenMaiServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDKM).Ten;
                cmb_TSP.Text = iSp.getlsSpfromDB().FirstOrDefault(p => p.ID == CTSP.IDSP).Ten;
                cmb_Loai.Text = iLoaiSp.GetLoaiSP().FirstOrDefault(p => p.ID == CTSP.IDLOAI).Ten;
                cmb_MS.Text = iMs.GetMauSac().FirstOrDefault(p => p.ID == CTSP.IDMS).Ten;
                cmb_Nxs.Text = iNSX.GetNhasanxuat().FirstOrDefault(p => p.ID == CTSP.IDNSX).Ten;
                cmb_Size.Text = iSize.GetSizeAo().FirstOrDefault(p => p.ID == CTSP.IDKC).Ten;
                txt_GiaBan.Text = CTSP.GiaBan.ToString();
                txt_GiaNhap.Text = CTSP.GiaNhap.ToString();
                txt_Mota.Text = CTSP.MoTa;
                LinkAnh = CTSP.HinhAnh;
                txt_SLT.Text = CTSP.SoLuongTon.ToString();
                if (LinkAnh != null && File.Exists(LinkAnh))
                {
                    ptb_AVT.Image = Image.FromFile(LinkAnh);
                    ptb_AVT.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    ptb_AVT.Image = null;
                }
                if (CTSP.TrangThai == 1)
                {
                    rdb_Con.Checked = true;
                    rdb_Het.Checked = false;
                }
                else
                {
                    rdb_Con.Checked = false;
                    rdb_Het.Checked = true;
                }
            }
        }
    }
}
