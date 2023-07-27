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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using _1.DAL.Models;
using System.Security.Policy;
using QRCoder;

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
        private Guid _id;
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
            reset();
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
            if (txt_TimKiem.Text != "")
            {
                lstSpCt = lstSpCt.Where(x => x.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower())
                || x.TenSp.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in lstSpCt)
            {
                dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai, x.HinhAnh);
            }
        }

        private void dtg_ShowSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_ShowSanPham.Rows[e.RowIndex];
                _id = Guid.Parse(row.Cells[1].Value.ToString());
                var CTSP = iSpCt.GetAllSanPhamCT().FirstOrDefault(p => p.ID == _id);
                txt_Ma.Text = CTSP.Ma.ToString();
                cmb_TSP.Text = iSp.getlsSpfromDB().FirstOrDefault(p => p.ID == CTSP.IDSP).Ten;
                cmb_Loai.Text = iLoaiSp.GetLoaiSP().FirstOrDefault(p => p.ID == CTSP.IDLOAI).Ten;
                cmb_MS.Text = iMs.GetMauSac().FirstOrDefault(p => p.ID == CTSP.IDMS).Ten;
                cmb_Nxs.Text = iNSX.GetNhasanxuat().FirstOrDefault(p => p.ID == CTSP.IDNSX).Ten;
                cmb_Size.Text = iSize.GetSizeAo().FirstOrDefault(p => p.ID == CTSP.IDKC).Ten;
                txt_GiaBan.Text = CTSP.GiaBan.ToString("N0");
                txt_GiaNhap.Text = CTSP.GiaNhap.ToString("N0");
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
                // nhà sản xuất

                if (iNSX.GetNhasanxuat().Any(c => c.Ten == cmb_Nxs.Text) == false)

                {
                    MessageBox.Show("Tên Nhà Sản Xuất Không Hợp Lệ", "ERR");
                    return;
                }

                //size giay

                if (iSize.GetSizeAo().Any(c => c.Ten == cmb_Size.Text) == false)
                {

                    MessageBox.Show("Size áo Không Hợp Lệ", "ERR");
                    return;
                }
                //loai giay

                if (iLoaiSp.GetLoaiSP().Any(c => c.Ten == cmb_Loai.Text) == false)
                {
                    MessageBox.Show("Tên Loại sản phẩm Không Hợp Lệ", "ERR");
                    return;
                }

                // màu sắc
                if (iMs.GetMauSac().Any(c => c.Ten == cmb_MS.Text) == false)
                {
                    MessageBox.Show("Tên màu sắc Không Hợp Lệ", "ERR");
                    return;
                }

                // quốc gia

                if (iSp.getlsSpfromDB().Any(c => c.Ten == cmb_TSP.Text) == false)
                {
                    MessageBox.Show("Tên sản phẩm Không Hợp Lệ", "ERR");
                    return;
                }
                //Mã
                if (iSpCt.GetsListCtSp().Any(p => p.Ma == txt_Ma.Text))
                {
                    MessageBox.Show("Mã không được trùng", "ERR");
                    return;
                }

                if (check() == false)
                {
                    return;
                }
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
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadData();
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
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



        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var Sp = iSp.getlsSpfromDB().FirstOrDefault(c => c.Ten == cmb_TSP.Text);
            var Ms = iMs.GetMauSac().FirstOrDefault(c => c.Ten == cmb_MS.Text);
            var Loai = iLoaiSp.GetLoaiSP().FirstOrDefault(c => c.Ten == cmb_Loai.Text);
            var size = iSize.GetSizeAo().FirstOrDefault(c => c.Ten == cmb_Size.Text);
            var nsx = iNSX.GetNhasanxuat().FirstOrDefault(c => c.Ten == cmb_Nxs.Text);
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            File.Copy(LinkAnh, Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(LinkAnh)), true);
            LinkAnh = Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(LinkAnh));
            DialogResult dialogResult = MessageBox.Show("bạn có muốn Update hay không", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (check() == false)
                {
                    return;
                }

                {
                    SanPhamCTViewModels viewSpCt = new SanPhamCTViewModels()
                    {
                        ID = _id,
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
                    iSpCt.UpdateSanPhamCT(viewSpCt);
                    LoadData();
                }

                LoadData();
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có muốn Xoa hay không", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                {
                    SanPhamCTViewModels viewSpCt = new SanPhamCTViewModels()
                    {
                        ID = _id
                    };
                    iSpCt.DeleteSanPhamCT(_id);
                    LoadData();
                }
                MessageBox.Show("Xoa thành công", "Thông báo");
                LoadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            reset();
            LoadData();
        }
        public void reset()
        {
            cmb_MS.Text = "";
            cmb_Loai.Text = "";
            cmb_Nxs.Text = "";
            cmb_Size.Text = "";
            cmb_TSP.Text = "";
            txt_GiaBan.Text = "";
            txt_GiaNhap.Text = "";
            txt_Ma.Text = "";
            txt_Mota.Text = "";
            txt_SLT.Text = "";
            rdb_Con.Text = "";
            ptb_AVT.Image = null;
            ptb_QR.Image = null;
            rdb_Con.Text = "";
            rdb_Het.Text = "";



        }
        public bool check()
        {
            //check mã sp
            if (string.IsNullOrEmpty(txt_Ma.Text))
            {
                MessageBox.Show("mã sản phẩm không được bỏ trống", "Thông báo");
                return false;
            }
            if (Regex.IsMatch(txt_Ma.Text, @"^[a-zA-Z0-9 ]*$") == false)
            {

                MessageBox.Show("Mã sản phẩm không được chứa ký tự đặc biệt", "ERR");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Ma.Text))
            {
                MessageBox.Show("mã hàng hóa không được có khoảng trắng", "Thông báo");
                return false;
            }
            // check tên Sp
            if (string.IsNullOrEmpty(cmb_TSP.Text))
            {
                MessageBox.Show("Tên sản phẩm không được bỏ trống", "Thông báo");
                return false;
            }
            // check size
            if (string.IsNullOrEmpty(cmb_Size.Text))
            {
                MessageBox.Show("Size không được bỏ trống", "Thông báo");
                return false;
            }
            // check loại sp
            if (string.IsNullOrEmpty(cmb_Loai.Text))
            {
                MessageBox.Show("Loại sản phẩm không được bỏ trống", "Thông báo");
                return false;
            }
            //chekc Nsx
            if (string.IsNullOrEmpty(cmb_Nxs.Text))
            {
                MessageBox.Show("Nhà sản xuất không được bỏ trống", "Thông báo");
                return false;
            }
            if (string.IsNullOrEmpty(txt_SLT.Text))
            {
                MessageBox.Show("Số lượng không được bỏ trống", "Thông báo");
                return false;
            }
            if (Regex.IsMatch(txt_SLT.Text, @"^[a-zA-Z0-9 ]*$") == false)
            {

                MessageBox.Show("Số lượng không được chứa ký tự đặc biệt", "ERR");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_SLT.Text))
            {
                MessageBox.Show("Số lượng không được có khoảng trắng", "Thông báo");
                return false;
            }
            if (Convert.ToInt32(txt_SLT.Text) <= 0)
            {
                MessageBox.Show("Số lượng không được âm hoặc nhỏ hơn không", "Thông báo");
                return false;
            }

            if (string.IsNullOrEmpty(txt_GiaNhap.Text))
            {
                MessageBox.Show("giá nhập không được bỏ trống", "Thông báo");
                return false;
            }
            if (Regex.IsMatch(txt_GiaNhap.Text, @"^[a-zA-Z0-9 ]*$") == false)
            {

                MessageBox.Show("giá nhập không được chứa ký tự đặc biệt", "ERR");
                return false;
            }
            if (Convert.ToInt32(txt_GiaNhap.Text) > Convert.ToInt32(txt_GiaBan.Text))
            {
                MessageBox.Show("giá nhập không được lớn hơn giá bán", "ERR");
                return false;
            }
            if (Convert.ToInt32(txt_GiaNhap.Text) <= 0 && Convert.ToInt32(txt_GiaNhap.Text) < 50000000)
            {
                MessageBox.Show("giá nhập phải lơn hơn 0 và nhỏ hơn 50000000", "ERR");
                return false;
            }
            if (string.IsNullOrEmpty(txt_GiaBan.Text))
            {
                MessageBox.Show("giá bán không được bỏ trống", "Thông báo");
                return false;
            }
            if (Convert.ToInt32(txt_GiaBan.Text) <= 0 && Convert.ToInt32(txt_GiaBan.Text) < 100000000)
            {
                MessageBox.Show("giá bán phải lơn hơn 0 và nhỏ hơn 100000000", "ERR");
                return false;
            }
            //
            if (txt_Ma.Text.Length <= 3 && txt_Ma.Text.Length >= 10)
            {
                MessageBox.Show("Mã hàng hóa phải trên 3 ký tự và nhỏ hơn 10 kí tự", "ERR");
                return false;
            }
            if (Regex.IsMatch(txt_Ma.Text, @"[0-9]+") == false)
            {

                MessageBox.Show("Mã Hàng hóa Bắt buộc phải chứa số", "ERR");
                return false;
            }
            if (Regex.IsMatch(txt_GiaBan.Text, @"^[a-zA-Z0-9 ]*$") == false)
            {

                MessageBox.Show("giá bán không được chứa ký tự đặc biệt", "ERR");
                return false;
            }

            //check trùng
            //macl

            if (Regex.IsMatch(txt_Ma.Text, @"[0-9]+") == false)
            {

                MessageBox.Show("Mã hàng hóa Bắt buộc phải chứa số", "ERR");

            }


            //tên
            if (cmb_TSP.Text.Length <= 3)
            {
                MessageBox.Show("Tên hàng hóa phải trên 3 ký tự", "ERR");
                return false;
            }



            if (Regex.IsMatch(txt_SLT.Text, @"^\d+$") == false)
            {

                MessageBox.Show("số số lượng  không được chứa chữ cái", "ERR");
                return false;
            }

            if (Regex.IsMatch(txt_GiaNhap.Text, @"^\d+$") == false)
            {

                MessageBox.Show("đơn giá nhập không được chứa chữ cái", "ERR");
                return false;
            }
            if (Regex.IsMatch(txt_GiaBan.Text, @"^\d+$") == false)
            {

                MessageBox.Show("đơn giá bán không được chứa chữ cái", "ERR");
                return false;
            }
            //danh mục
            //if (cbo_danhmuc.Text.Length <= 3)
            //{
            //    MessageBox.Show("Tên danh mục phải trên 3 ký tự", "ERR");
            //    return false;
            //}
            //if (Regex.IsMatch(cbo_danhmuc.Text, @"^[a-zA-Z]") == false)
            //{

            //    MessageBox.Show("Tên danh mục không được chứa số", "ERR");
            //    return false;
            //}
            //nhà sản xuất

            if (Regex.IsMatch(cmb_Nxs.Text, @"^[a-zA-Z]") == false)
            {

                MessageBox.Show("Tên Nhà Sản Xuất không được chứa số", "ERR");
                return false;
            }
            //chất liệu

            if (Regex.IsMatch(cmb_Size.Text, @"^[a-zA-Z]") == false)
            {

                MessageBox.Show("Tên Chất Liệu  không được chứa số", "ERR");
                return false;
            }
            ////loai giay

            //if (Regex.IsMatch(cmb_Loai.Text, @"^[a-zA-Z]") == false)
            //{   

            //    MessageBox.Show("Tên loại giày không được chứa số", "ERR");
            //    return false;
            //}
            // size giay
            //if (Regex.IsMatch(cm.Text, @"^\d+$") == false)
            //{

            //    MessageBox.Show("Size giày không được chứa chữ cái", "ERR");
            //    return false;
            //}
            //quốc gia

            //if (Regex.IsMatch(cbo_tenquocgia.Text, @"^[a-zA-Z]") == false)
            //{

            //    MessageBox.Show("Tên Quốc Gia  không được chứa số", "ERR");
            //    return false;
            //}
            return true;
        }
        public void LoadMs()
        {
            foreach (var x in iMs.GetMauSac().Where(c => c.TrangThai == 1))
            {
                cmb_MS.Items.Add(x.Ten);
            }
        }
        public void LoadNsx()
        {
            foreach (var x in iNSX.GetNhasanxuat().Where(c => c.TrangThai == 1))
            {
                cmb_Nxs.Items.Add(x.Ten);
            }
        }



        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadSize()
        {
            foreach (var x in iSize.GetSizeAo().Where(c => c.TrangThai == 1))
            {
                cmb_Size.Items.Add(x.Ten);
            }
        }
        public void loadLoaiSp()
        {
            foreach (var x in iSp.getlsSpfromDB().Where(c => c.TrangThai == 1))
            {
                cmb_TSP.Items.Add(x.Ten);
            }
        }
        public void loadSp()
        {
            foreach (var x in iLoaiSp.GetLoaiSP().Where(c => c.TrangThai == 1))
            {
                cmb_Loai.Items.Add(x.Ten);
            }
        }



        private void cmb_TSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ptb_QR_Click(object sender, EventArgs e)
        {
            var sp = iSpCt.GetAllSanPhamCT().FirstOrDefault(c => c.ID == _id);
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(sp.ID.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(data);
            ptb_QR.Image = qRCode.GetGraphic(9);
            ptb_QR.SizeMode = PictureBoxSizeMode.CenterImage;

            int padding = (Math.Max(ptb_QR.Width - ptb_QR.Image.Width, 0) +
                           Math.Max(ptb_QR.Height - ptb_QR.Image.Height, 0)) / 2;
            ptb_QR.Padding = new Padding(padding);
            ptb_QR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        }
        private void btn_SaveQr_Click(object sender, EventArgs e)
        {
            string initialDIR = @"E:\DuAn1\BanHangDuAn1\3.PL\Resources\QrCode";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDIR;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ptb_QR.Image.Save(dialog.FileName);
                MessageBox.Show("Lưu thành công", "Thông báo");
            }

        }
    }
}

