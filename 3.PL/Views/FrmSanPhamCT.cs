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

        private ISanPhamChiTietServices iSpCt;
        private ISanPhamServices iSp;
        private IMauSacServices iMs;
        private INSXServices iNSX;
        private IKichThuocServices iSize;
        private ILoaiSanPhamServices iLoaiSp;
        private IChatLieuService iChatLieu;
        private SanPhamViewModels viewSpCt;
        private Guid _id;
        string LinkAnh = "";

        public FrmSanPhamCT()
        {
            InitializeComponent();
            iSpCt = new SanPhamChiTietServices();
            iSp = new SanPhamServices();
            iMs = new MauSacServices();
            iNSX = new NSXServices();
            iSize = new KichThuocServices();
            iLoaiSp = new LoaiSanPhamServices();
            iChatLieu = new ChatLieuService();
            viewSpCt = new SanPhamViewModels();
            LoadMs();
            LoadNsx();
            LoadSize();
            loadLoaiSp();
            loadSp();
            LoadCl();
            LoadData();
            reset();
            loctrangthai();
            _id = Guid.Empty;
        }
        public void LoadData()
        {
            int stt = 1;
            dtg_ShowSanPham.Rows.Clear();
            dtg_ShowSanPham.ColumnCount = 15;
            dtg_ShowSanPham.Columns[0].Name = "STT";
            dtg_ShowSanPham.Columns[1].Name = "ID";
            dtg_ShowSanPham.Columns[1].Visible = false;
            dtg_ShowSanPham.Columns[2].Name = "Mã";
            dtg_ShowSanPham.Columns[3].Name = "Tên Sản Phẩm";
            dtg_ShowSanPham.Columns[4].Name = "Size";
            dtg_ShowSanPham.Columns[5].Name = "Loại";
            dtg_ShowSanPham.Columns[6].Name = "Chất liệu";
            dtg_ShowSanPham.Columns[7].Name = "Màu sắc";
            dtg_ShowSanPham.Columns[8].Name = "Nhà sản xuất";
            dtg_ShowSanPham.Columns[9].Name = "SLT";
            dtg_ShowSanPham.Columns[10].Name = "Gía Nhập";
            dtg_ShowSanPham.Columns[11].Name = "Gía Bán";
            dtg_ShowSanPham.Columns[12].Name = "Mô Tả";
            dtg_ShowSanPham.Columns[13].Name = "Trạng thái";
            dtg_ShowSanPham.Columns[14].Name = "Hình ảnh";
            dtg_ShowSanPham.Rows.Clear();
            var lstSpCt = iSpCt.GetsListCtSp();
            //if (txt_TimKiem.Text != "")
            //{
            //    lstSpCt = lstSpCt.Where(x => x.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower())
            //    || x.TenSp.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            //}
            foreach (var x in lstSpCt)
            {
                if (x.SoLuongTon == 0)
                {
                    x.TrangThai = 0;
                }
                dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
            }
            dtg_ShowSanPham.AllowUserToAddRows = false;
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
                cmb_Nsx.Text = iNSX.GetNhasanxuat().FirstOrDefault(p => p.ID == CTSP.IDNSX).Ten;
                cmb_Size.Text = iSize.GetSizeAo().FirstOrDefault(p => p.ID == CTSP.IDKC).Ten;
                cmb_Cl.Text = iChatLieu.GetChatLieu().FirstOrDefault(p => p.ID == CTSP.IDCL).Ten;
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
                if (row.Cells[13].Value.ToString() == "Còn hàng")
                {
                    rdb_Con.Checked = true;
                }
                else
                {
                    rdb_Het.Checked = true;
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

            var Sp = iSp.getlsSpfromDB().FirstOrDefault(c => c.Ten == cmb_TSP.Text);
            var Ms = iMs.GetMauSac().FirstOrDefault(c => c.Ten == cmb_MS.Text);
            var Loai = iLoaiSp.GetLoaiSP().FirstOrDefault(c => c.Ten == cmb_Loai.Text);
            var Size = iSize.GetSizeAo().FirstOrDefault(c => c.Ten == cmb_Size.Text);
            var Nsx = iNSX.GetNhasanxuat().FirstOrDefault(c => c.Ten == cmb_Nsx.Text);
            var Chatlieu = iChatLieu.GetChatLieu().FirstOrDefault(c => c.Ten == cmb_Cl.Text);
            int maspct = iSpCt.GetsListCtSp().Count() + 1;
            if (string.IsNullOrEmpty(LinkAnh))
            {
                MessageBox.Show("Bạn cần thêm ảnh và điền đầy đủ thông tin", "ERR");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("bạn có muốn thêm hay không", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    //size giay

                    if (iSize.GetSizeAo().Any(c => c.Ten == cmb_Size.Text) == false)
                    {

                        MessageBox.Show("Size áo Không Hợp Lệ", "ERR");
                        return;
                    }

                    // tên sp

                    if (iSp.getlsSpfromDB().Any(c => c.Ten == cmb_TSP.Text) == false)
                    {
                        MessageBox.Show("Tên sản phẩm Không Hợp Lệ", "ERR");
                        return;
                    }
                    //Mã
                    //if (iSpCt.GetsListCtSp().Any(p => p.Ma == txt_Ma.Text))
                    //{
                    //    MessageBox.Show("Mã không được trùng", "ERR");
                    //    return;
                    //}
                    // màu sắc
                    if (iMs.GetMauSac().Any(c => c.Ten == cmb_MS.Text) == false)
                    {
                        MessageBox.Show("Tên màu sắc Không Hợp Lệ", "ERR");
                        return;
                    }
                    //loai giay

                    if (iLoaiSp.GetLoaiSP().Any(c => c.Ten == cmb_Loai.Text) == false)
                    {
                        MessageBox.Show("Tên Loại sản phẩm Không Hợp Lệ", "ERR");
                        return;
                    }
                    // nhà sản xuất

                    if (iNSX.GetNhasanxuat().Any(c => c.Ten == cmb_Nsx.Text) == false)

                    {
                        MessageBox.Show("Tên Nhà Sản Xuất Không Hợp Lệ", "ERR");
                        return;
                    }// nhà sản xuất

                    if (iChatLieu.GetChatLieu().Any(c => c.Ten == cmb_Cl.Text) == false)

                    {
                        MessageBox.Show("Tên Chất liệu Không Hợp Lệ", "ERR");
                        return;
                    }


                    if (check() == false)
                    {
                        return;
                    }
                    {
                        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                        File.Copy(LinkAnh, Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(LinkAnh)), true);
                        LinkAnh = Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(LinkAnh));
                        SanPhamCTViewModels viewSpCt = new SanPhamCTViewModels()
                        {
                            ID = Guid.NewGuid(),
                            IDSP = Sp.ID,
                            IDMS = Ms.ID,
                            IDKC = Size.ID,
                            IDLOAI = Loai.ID,
                            IDNSX = Nsx.ID,
                            IDCL = Chatlieu.ID,
                            HinhAnh = LinkAnh,
                            SoLuongTon = Convert.ToInt32(txt_SLT.Text),
                            GiaNhap = Convert.ToDecimal(txt_GiaNhap.Text),
                            GiaBan = Convert.ToDecimal(txt_GiaBan.Text),
                            MoTa = txt_Mota.Text,
                            Ma = "SpCt" + maspct.ToString(),
                            TrangThai = rdb_Con.Checked ? 1 : 0,
                        };
                        iSpCt.AddSanPhamCT(viewSpCt);
                    }
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    LoadData();
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
        }

        private void ptb_AVT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    LinkAnh = op.FileName;

                    try
                    {
                        // Sử dụng FileStream để đọc dữ liệu hình ảnh từ tệp
                        using (FileStream fs = new FileStream(op.FileName, FileMode.Open, FileAccess.Read))
                        {
                            // Tạo một đối tượng hình ảnh từ luồng dữ liệu
                            Image image = Image.FromStream(fs);

                            // Kiểm tra xem hình ảnh hợp lệ trước khi gán vào PictureBox
                            if (IsValidImage(image))
                            {
                                ptb_AVT.Image = image;
                                ptb_AVT.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                            else
                            {
                                MessageBox.Show("Hình ảnh không hợp lệ.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            // Phương thức kiểm tra hình ảnh hợp lệ


            //OpenFileDialog op = new OpenFileDialog();
            //if (op.ShowDialog() == DialogResult.OK)
            //{
            //    LinkAnh = op.FileName;
            //    ptb_AVT.Image = Image.FromFile(op.FileName);
            //    ptb_AVT.SizeMode = PictureBoxSizeMode.Zoom;
            //}
        }
        private bool IsValidImage(Image image)
        {
            return (image.Width > 0 && image.Height > 0);
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var Sp = iSp.getlsSpfromDB().FirstOrDefault(c => c.Ten == cmb_TSP.Text);
            var Ms = iMs.GetMauSac().FirstOrDefault(c => c.Ten == cmb_MS.Text);
            var Loai = iLoaiSp.GetLoaiSP().FirstOrDefault(c => c.Ten == cmb_Loai.Text);
            var size = iSize.GetSizeAo().FirstOrDefault(c => c.Ten == cmb_Size.Text);
            var nsx = iNSX.GetNhasanxuat().FirstOrDefault(c => c.Ten == cmb_Nsx.Text);
            var Chatlieu = iChatLieu.GetChatLieu().FirstOrDefault(c => c.Ten == cmb_Cl.Text);
            DialogResult dialogResult = MessageBox.Show("bạn có muốn Update hay không", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (check() == false)
                {
                    return;
                }

                {
                    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                    string sourceFilePath = "E:\\DuAn1\\BanHangDuAn1\\3.PL\\Resources\\Images\\new_image.jpg";
                    string destinationFilePath = Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(LinkAnh));

                    try
                    {
                        // Kiểm tra xem đường dẫn nguồn và đích có giống nhau không
                        if (!string.Equals(sourceFilePath, destinationFilePath, StringComparison.OrdinalIgnoreCase))
                        {
                            // Nếu đường dẫn khác nhau, đảm bảo tập tin nguồn đã được giải phóng
                            using (FileStream sourceFileStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {
                                // Đóng tập tin nguồn trước khi thực hiện sao chép
                                // Lưu ý: FileShare.Read để cho phép tiến trình khác đọc tập tin nguồn trong quá trình sao chép
                                sourceFileStream.Close();
                            }

                            // Sau khi tập tin nguồn đã được đóng, thực hiện sao chép
                            File.Copy(sourceFilePath, destinationFilePath, true);
                            Console.WriteLine("Ghi đè thành công!");
                        }
                        else
                        {
                            Console.WriteLine("Đường dẫn nguồn và đích giống nhau. Không thể sao chép.");
                        }
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }

                    //string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                    //File.Copy(LinkAnh, Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(LinkAnh)), true);
                    //LinkAnh = Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(LinkAnh));
                    SanPhamCTViewModels viewSpCt = new SanPhamCTViewModels()
                    {
                        ID = _id,
                        IDSP = Sp.ID,
                        IDMS = Ms.ID,
                        IDKC = size.ID,
                        IDLOAI = Loai.ID,
                        IDNSX = nsx.ID,
                        IDCL = Chatlieu.ID,
                        HinhAnh = LinkAnh,
                        SoLuongTon = Convert.ToInt32(txt_SLT.Text),
                        GiaNhap = Convert.ToDecimal(txt_GiaNhap.Text),
                        GiaBan = Convert.ToDecimal(txt_GiaBan.Text),
                        MoTa = txt_Mota.Text,
                        Ma = txt_Ma.Text,
                        TrangThai = rdb_Con.Checked ? 1 : 0,
                    };
                    iSpCt.UpdateSanPhamCT(viewSpCt);
                }
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
            if (iSpCt.GetSanPhamCTByid(_id) == null)
            {
                MessageBox.Show("Xoa thất bại", "Thông báo");
            }
            else
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
                    }
                    MessageBox.Show("Xoa thành công", "Thông báo");
                    LoadData();
                }
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            reset();
        }
        public void reset()
        {


            //DataGridViewRow row = dtg_ShowSanPham.Rows[1];
            //_id = Guid.Parse(row.Cells[1].Value.ToString());
            //foreach (DataGridViewRow row1 in dtg_ShowSanPham.Rows)
            //{
            //    if (row.Cells[1].Value != null)
            //    {
            //        _id = Guid.Empty;
            //    }
            //}


            if (dtg_ShowSanPham.Rows.Count > 1)
            {
                DataGridViewRow row = dtg_ShowSanPham.Rows[1];
                if (row.Cells[1].Value != null)
                {
                    _id = Guid.Parse(row.Cells[1].Value.ToString());
                }
            }
            _id = Guid.Empty;
            cmb_MS.SelectedItem = null;
            cmb_Loai.SelectedItem = null;
            cmb_Cl.SelectedItem = null;
            cmb_Nsx.SelectedItem = null;
            cmb_Size.SelectedItem = null;
            cmb_TSP.SelectedItem = null;
            cmb_loctrangthai.SelectedItem = null;
            txt_GiaBan.Text = "";
            txt_GiaNhap.Text = "";
            txt_Ma.Text = "";
            txt_Mota.Text = "";
            txt_SLT.Text = "";
            ptb_AVT.Image = null;
            ptb_QR.Image = null;
            rdb_Con.Checked = false;
            rdb_Het.Checked = false;

        }

        public bool check()
        {
            //check mã sp
            //if (string.IsNullOrEmpty(txt_Ma.Text))
            //{
            //    MessageBox.Show("mã sản phẩm không được bỏ trống", "Thông báo");
            //    return false;
            //}
            //if (Regex.IsMatch(txt_Ma.Text, @"^[a-zA-Z0-9 ]*$") == false)
            //{

            //    MessageBox.Show("Mã sản phẩm không được chứa ký tự đặc biệt", "ERR");
            //    return false;
            //}
            //if (string.IsNullOrWhiteSpace(txt_Ma.Text))
            //{
            //    MessageBox.Show("mã hàng hóa không được có khoảng trắng", "Thông báo");
            //    return false;
            //}
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
            if (string.IsNullOrEmpty(cmb_Nsx.Text))
            {
                MessageBox.Show("Nhà sản xuất không được bỏ trống", "Thông báo");
                return false;
            }
            if (string.IsNullOrEmpty(cmb_Cl.Text))
            {
                MessageBox.Show("Chất liệu không được bỏ trống", "Thông báo");
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
                MessageBox.Show("Số lượng không được âm hoặc nhỏ hơn bằng không", "Thông báo");
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
            //if (txt_Ma.Text.Length <= 3 && txt_Ma.Text.Length >= 10)
            //{
            //    MessageBox.Show("Mã hàng hóa phải trên 3 ký tự và nhỏ hơn 10 kí tự", "ERR");
            //    return false;
            //}
            //if (Regex.IsMatch(txt_Ma.Text, @"[0-9]+") == false)
            //{

            //    MessageBox.Show("Mã Hàng hóa Bắt buộc phải chứa số", "ERR");
            //    return false;
            //}
            if (Regex.IsMatch(txt_GiaBan.Text, @"^[a-zA-Z0-9 ]*$") == false)
            {

                MessageBox.Show("giá bán không được chứa ký tự đặc biệt", "ERR");
                return false;
            }

            //check trùng
            //macl

            //if (Regex.IsMatch(txt_Ma.Text, @"[0-9]+") == false)
            //{

            //    MessageBox.Show("Mã hàng hóa Bắt buộc phải chứa số", "ERR");

            //}


            //tên
            if (cmb_TSP.Text.Length <= 3)
            {
                MessageBox.Show("Tên hàng hóa phải trên 3 ký tự", "ERR");
                return false;
            }

            if (rdb_Con.Checked == false && rdb_Het.Checked == false)
            {
                MessageBox.Show("Trạng thái không được bỏ trống", "Thông báo");
                return false;
            }

            if (Regex.IsMatch(txt_SLT.Text, @"^\d+$") == false)
            {

                MessageBox.Show("số số lượng Tồn  không được chứa chữ cái", "ERR");
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

            if (Regex.IsMatch(cmb_Cl.Text, @"^[a-zA-Z]") == false)
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
                cmb_Nsx.Items.Add(x.Ten);
            }
        }
        public void LoadCl()
        {
            foreach (var x in iChatLieu.GetChatLieu().Where(c => c.TrangThai == 1))
            {
                cmb_Cl.Items.Add(x.Ten);
            }
        }

        public void LoadSize()
        {
            foreach (var x in iSize.GetSizeAo().Where(c => c.TrangThai == 1))
            {
                cmb_Size.Items.Add(x.Ten);
                //cmb_locSize.Items.Add(x.Ten);
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
            var sp = iSpCt.GetAllSanPhamCT().FirstOrDefault(c=>c.ID == _id);
            if (sp != null)
            {
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
            else
            {
                MessageBox.Show("Không có sản phẩm thì gen QrCode kiểu gì", "ERD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_SaveQr_Click(object sender, EventArgs e)
        {

            string initialDIR = @"E:\DuAn1\BanHangDuAn1\3.PL\Resources\QrCode";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDIR;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (ptb_QR.Image != null)
                {
                    ptb_QR.Image.Save(dialog.FileName);
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }

                MessageBox.Show("Không có hình ảnh để lưu", "ERD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_SLT_TextChanged(object sender, EventArgs e)
        {
            string input = txt_SLT.Text;

            // Kiểm tra từng ký tự trong input
            foreach (char c in input)
            {
                // Nếu ký tự không phải là số, loại bỏ nó khỏi input
                if (!char.IsDigit(c))
                {
                    input = input.Replace(c.ToString(), "");
                }
            }
            // Đặt lại giá trị của TextBox sau khi loại bỏ các ký tự không hợp lệ
            txt_SLT.Text = input;
            // Giới hạn số lượng chữ số được nhập vào là 5
            int maxLength = 5;

            // Kiểm tra độ dài của TextBox
            if (txt_SLT.Text.Length > maxLength)
            {
                // Nếu độ dài vượt quá giới hạn, cắt bớt dữ liệu nhập vào thành maxLength ký tự
                txt_SLT.Text = txt_SLT.Text.Substring(0, maxLength);
                // Đặt lại con trỏ (caret) vào cuối TextBox
                txt_SLT.SelectionStart = maxLength;

            }
        }

        private void txt_GiaBan_TextChanged(object sender, EventArgs e)
        {
            string input = txt_GiaBan.Text;

            // Kiểm tra từng ký tự trong input
            foreach (char c in input)
            {
                // Nếu ký tự không phải là số, loại bỏ nó khỏi input
                if (!char.IsDigit(c))
                {
                    input = input.Replace(c.ToString(), "");
                }
            }
            // Đặt lại giá trị của TextBox sau khi loại bỏ các ký tự không hợp lệ
            txt_GiaBan.Text = input;
            // Giới hạn số lượng chữ số được nhập vào là 5
            int maxLength = 10;

            // Kiểm tra độ dài của TextBox
            if (txt_GiaBan.Text.Length > maxLength)
            {
                // Nếu độ dài vượt quá giới hạn, cắt bớt dữ liệu nhập vào thành maxLength ký tự
                txt_GiaBan.Text = txt_GiaBan.Text.Substring(0, maxLength);
                // Đặt lại con trỏ (caret) vào cuối TextBox
                txt_GiaBan.SelectionStart = maxLength;

            }
        }

        private void txt_GiaNhap_TextChanged(object sender, EventArgs e)
        {
            string input = txt_GiaNhap.Text;

            // Kiểm tra từng ký tự trong input
            foreach (char c in input)
            {
                // Nếu ký tự không phải là số, loại bỏ nó khỏi input
                if (!char.IsDigit(c))
                {
                    input = input.Replace(c.ToString(), "");
                }
            }
            // Đặt lại giá trị của TextBox sau khi loại bỏ các ký tự không hợp lệ
            txt_GiaNhap.Text = input;
            // Giới hạn số lượng chữ số được nhập vào là 5
            int maxLength = 10;

            // Kiểm tra độ dài của TextBox
            if (txt_GiaNhap.Text.Length > maxLength)
            {
                // Nếu độ dài vượt quá giới hạn, cắt bớt dữ liệu nhập vào thành maxLength ký tự
                txt_GiaNhap.Text = txt_GiaNhap.Text.Substring(0, maxLength);
                // Đặt lại con trỏ (caret) vào cuối TextBox
                txt_GiaNhap.SelectionStart = maxLength;

            }
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog op = new OpenFileDialog())
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    LinkAnh = op.FileName;

                    try
                    {
                        // Sử dụng FileStream để đọc dữ liệu hình ảnh từ tệp
                        using (FileStream fs = new FileStream(op.FileName, FileMode.Open, FileAccess.Read))
                        {
                            // Tạo một đối tượng hình ảnh từ luồng dữ liệu
                            Image image = Image.FromStream(fs);

                            // Kiểm tra xem hình ảnh hợp lệ trước khi gán vào PictureBox
                            if (IsValidImage(image))
                            {
                                ptb_AVT.Image = image;
                                ptb_AVT.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                            else
                            {
                                MessageBox.Show("Hình ảnh không hợp lệ.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void cmb_loctrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_loctrangthai.Text != "")
            {
                if (cmb_loctrangthai.Text == "Còn hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 1 && p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }

                if (cmb_loctrangthai.Text == "Hết hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 0 && p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }
                if (cmb_loctrangthai.Text == "")
                {

                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }

                }
            }
            if (cmb_loctrangthai.Text == "")
            {
                if (cmb_loctrangthai.Text == "Còn hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 1 && p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }

                if (cmb_loctrangthai.Text == "Hết hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 0 && p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }
                if (cmb_loctrangthai.Text == "")
                {

                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }

                }
            }
            if (cmb_loctrangthai.Text == "Còn hàng")
            {
                if (cmb_loctrangthai.Text == "Còn hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 1 && p.Ma.Contains(txt_TimKiem.Text)   );

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }

                if (cmb_loctrangthai.Text == "Hết hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 0 && p.Ma.Contains(txt_TimKiem.Text)   );

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }
                if (cmb_loctrangthai.Text == "")
                {

                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.Ma.Contains(txt_TimKiem.Text)   );

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }

                }
            }
            if (cmb_loctrangthai.Text == "Hết hàng")
            {
                if (cmb_loctrangthai.Text == "Còn hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 1 && p.Ma.Contains(txt_TimKiem.Text)   );

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }

                if (cmb_loctrangthai.Text == "Hết hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 0 && p.Ma.Contains(txt_TimKiem.Text)   );

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }
                if (cmb_loctrangthai.Text == "")
                {

                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.Ma.Contains(txt_TimKiem.Text)   );

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }

                }
            }
        }
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cmb_loctrangthai.Text != "")
            {
                if (cmb_loctrangthai.Text == "Còn hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 1 && p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }

                if (cmb_loctrangthai.Text == "Hết hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 0 && p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }
                if (cmb_loctrangthai.Text == "")
                {

                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }

                }
            }
            if (cmb_loctrangthai.Text == "")
            {
                if (cmb_loctrangthai.Text == "Còn hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 1 && p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }

                if (cmb_loctrangthai.Text == "Hết hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 0 && p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }
                if (cmb_loctrangthai.Text == "")
                {

                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }

                }
            }
            if (cmb_loctrangthai.Text == "Còn hàng")
            {
                if (cmb_loctrangthai.Text == "Còn hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 1 && p.Ma.Contains(txt_TimKiem.Text)   );

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }

                if (cmb_loctrangthai.Text == "Hết hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 0 && p.Ma.Contains(txt_TimKiem.Text)   );

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }
                if (cmb_loctrangthai.Text == "")
                {

                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }

                }
            }
            if (cmb_loctrangthai.Text == "Hết hàng")
            {
                if (cmb_loctrangthai.Text == "Còn hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 1 && p.Ma.Contains(txt_TimKiem.Text)   );

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }

                if (cmb_loctrangthai.Text == "Hết hàng")
                {
                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.TrangThai == 0 && p.Ma.Contains(txt_TimKiem.Text)|| p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }
                }
                if (cmb_loctrangthai.Text == "")
                {

                    var timkiem = iSpCt.GetsListCtSp().Where(p => p.Ma.Contains(txt_TimKiem.Text) || p.TenSp.Contains(txt_TimKiem.Text));

                    dtg_ShowSanPham.Rows.Clear();
                    int stt = 1;
                    foreach (var x in timkiem)
                    {
                        dtg_ShowSanPham.Rows.Add(stt++, x.ID, x.Ma, x.TenSp, x.Size, x.LoaiSp, x.ChatLieu, x.MauSac, x.Nsx, x.SoLuongTon, x.GiaNhap.ToString("N0"), x.GiaBan.ToString("N0"), x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.HinhAnh);
                    }

                }
            }

        }
        public void loctrangthai()
        {
            cmb_loctrangthai.Items.Add("Còn hàng");
            cmb_loctrangthai.Items.Add("Hết hàng");
        }
    }
}

