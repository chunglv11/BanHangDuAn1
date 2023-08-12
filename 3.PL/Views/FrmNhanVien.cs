using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace _3.PL.Views
{
    public partial class FrmNhanVien : Form
    {
        private INhanVienServices _Inhanvien;
        private IChucVuServices _IchucVu;
        private NhanVienViewModels _nvview;
        NhanVien nhanVien;
        private Guid _ID;
        public string linkanh = "";

        public FrmNhanVien()
        {
            _Inhanvien = new NhanVienServices();
            _IchucVu = new ChucVuServices();
            _nvview = new NhanVienViewModels();

            InitializeComponent();
            LoadcmbCV();
            LoadData();
            LoadLocCV();

        }


        private void LoadData()
        {
            int stt = 1;
            dtg_ShowNV.ColumnCount = 12;
            dtg_ShowNV.Columns[0].Name = "ID";
            dtg_ShowNV.Columns[0].Visible = false;
            dtg_ShowNV.Columns[1].Name = "STT";
            dtg_ShowNV.Columns[2].Name = "Username";
            dtg_ShowNV.Columns[3].Name = "MaNV";
            dtg_ShowNV.Columns[4].Name = "HoTen";
            dtg_ShowNV.Columns[5].Name = "GioiTinh";
            dtg_ShowNV.Columns[6].Name = "Email";
            dtg_ShowNV.Columns[7].Name = "NgaySinh";
            dtg_ShowNV.Columns[8].Name = "MatKhau";
            dtg_ShowNV.Columns[8].Visible = false;
            dtg_ShowNV.Columns[9].Name = "Anh";
            dtg_ShowNV.Columns[10].Name = "ChucVu";
            dtg_ShowNV.Columns[11].Name = "trang thai";
            dtg_ShowNV.Rows.Clear();
            dtg_ShowNV.Columns[1].Visible = true;
            var lstnv = _Inhanvien.GetAllView();
            if (txt_TimKiem.Text != "")
            {
                lstnv = lstnv.Where(x => x.MaNv.ToLower().Contains(txt_TimKiem.Text.ToLower())
                || x.HoTen.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var a in lstnv)
            {
                _ = dtg_ShowNV.Rows.Add(
                    a.ID,
                    stt++,
                    a.Username,
                    a.MaNv,
                    a.HoTen,
                    a.GioiTinh == 1 ? "nam" : "nữ",
                    a.Email,
                    a.NgaySinh,
                    a.MatKhau,
                    a.AnhNv,
                    a.Ten, // Access ChucVu property directly from NhanVien
                    a.TrangThai == 1 ? "hoạt động" : "Không hoạt động"
                    );
            }

        }

        private void LoadcmbCV()
        {
            foreach (var a in _IchucVu.GetAll().Where(c => c.TrangThai == 1))
            {
                _ = cmb_CV.Items.Add(a.Ten);
            }

        }
        private void LoadLocCV()
        {
            foreach (var a in _IchucVu.GetAll().Where(c => c.TrangThai == 1))
            {
                _ = Cbb_LocCV.Items.Add(a.Ten);
            }

        }

        private void dtg_ShowNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                _ID = Guid.Parse(dtg_ShowNV.Rows[e.RowIndex].Cells[0].Value.ToString());
                nhanVien = _Inhanvien.GetAll().FirstOrDefault(p => p.ID == _ID);
                tb_Ma.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_HoTen.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_Email.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[6].Value.ToString();
                tb_user.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_MatKhau.Text = "*" /*dtg_ShowNV.Rows[e.RowIndex].Cells[8].Value.ToString()*/;
                tb_MatKhau.Enabled = false;
                date_ngaySinh.Value = (DateTime)dtg_ShowNV.Rows[e.RowIndex].Cells[7].Value;

                var cv = _Inhanvien.GetAll().FirstOrDefault(p => p.ID == _ID);
                cmb_CV.Text = _IchucVu.GetAllView().FirstOrDefault(p => p.ID == cv.IDCV).Ten;
                if (e.RowIndex >= 0 && e.RowIndex < dtg_ShowNV.Rows.Count)
                {
                    // Your existing code here, with the checks for valid index

                    if (dtg_ShowNV.Rows[e.RowIndex].Cells[5].Value.ToString() == "nam")
                    {
                        rbtn_Nam.Checked = true;
                    }
                    else if (dtg_ShowNV.Rows[e.RowIndex].Cells[5].Value.ToString() == "nữ")
                    {
                        rbtn_Nu.Checked = true;
                    }

                    if (dtg_ShowNV.Rows[e.RowIndex].Cells[11].Value.ToString() == "hoạt động")
                    {
                        rbn_HD.Checked = true;
                    }
                    else if (dtg_ShowNV.Rows[e.RowIndex].Cells[11].Value.ToString() == "không hoạt động")
                    {
                        rbn_KHD.Checked = true;
                    }
                }
                linkanh = nhanVien.AnhNv;
                if (linkanh != null && File.Exists(linkanh))
                {
                    ptb_AVT.Image = Image.FromFile(linkanh);
                    ptb_AVT.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    ptb_AVT.Image = null;
                }
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)

        {

            var chucvu = _IchucVu.GetAll().FirstOrDefault(c => c.Ten == cmb_CV.Text);
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            File.Copy(linkanh, Path.Combine(projectDirectory, "Resources", "ImagesNV", Path.GetFileName(linkanh)), true);
            linkanh = Path.Combine(projectDirectory, "Resources", "ImagesNV", Path.GetFileName(linkanh));
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm Nhân Viên Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_Inhanvien.GetAll().Any(c => c.MaNv == tb_Ma.Text))
                {
                    MessageBox.Show("Mã bị trùng");
                }
                else if (_Inhanvien.GetAll().Any(c => c.Username == tb_user.Text))
                {
                    MessageBox.Show(" Username bị trùng");
                }
                else if (_Inhanvien.GetAll().Any(c => c.Email == tb_Email.Text))
                {
                    MessageBox.Show(" Email bị trùng");
                }
                else if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
                {
                    MessageBox.Show("Tên không được bỏ trống");
                }
                else if (rbn_HD.Checked == false && rbn_KHD.Checked == false)
                {

                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else if (rbtn_Nam.Checked == false && rbn_KHD.Checked == false)
                {

                    MessageBox.Show("Vui lòng chọn giới tính");
                }
                else
                {
                    NhanVien nhanVien = new NhanVien()
                    {

                        MaNv = tb_Ma.Text,
                        HoTen = txt_HoTen.Text,
                        Email = tb_Email.Text,
                        AnhNv = linkanh,
                        MatKhau = tb_MatKhau.Text,
                        NgaySinh = date_ngaySinh.Value,
                        Username = tb_user.Text,
                        IDCV = chucvu.ID,
                        GioiTinh = rbtn_Nam.Checked == true ? 1 : 0,
                        TrangThai = rbn_HD.Checked == true ? 1 : 0,
                    };
                    _Inhanvien.Add(nhanVien);
                    MessageBox.Show("Thêm Nhân Viên thành công");
                    LoadData();

                }

            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                ChucVuViewModels? x = _IchucVu.GetAllView().FirstOrDefault(c => c.Ten == cmb_CV.Text);
                bool thongBao = _Inhanvien.Update(new _1.DAL.Models.NhanVien()
                {
                    ID = _ID,
                    MaNv = tb_Ma.Text,
                    HoTen = txt_HoTen.Text,
                    Email = tb_Email.Text,
                    AnhNv = linkanh,
                    MatKhau = tb_MatKhau.Text,
                    NgaySinh = date_ngaySinh.Value,
                    Username = tb_user.Text,
                    IDCV = x.ID,
                    GioiTinh = rbtn_Nam.Checked == true ? 1 : 0,
                    TrangThai = rbn_HD.Checked == true ? 1 : 0,

                });
                if (nhanVien.AnhNv != linkanh)
                {
                    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                    File.Copy(linkanh, Path.Combine(projectDirectory, "Resources", "ImagesNV", Path.GetFileName(linkanh)), true);
                    linkanh = Path.Combine(projectDirectory, "Resources", "ImagesNV", Path.GetFileName(linkanh));
                }
                if (thongBao)
                {
                    _ = MessageBox.Show("Sửa thành công");

                    LoadData();

                }
                else
                {
                    _ = MessageBox.Show("Sửa không thành công");
                }

            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Nhân Viên Không?", "Thông Báo", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (_nvview == null)
                {
                    MessageBox.Show("bạn chưa chọn nhân viên");
                }
                else
                {
                    bool deletionResult = _Inhanvien.Delete(_ID);

                    if (deletionResult)
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            //dtg_ShowNV.Rows.Clear();
            //LoadData();
            tb_Ma.Text = "";
            txt_HoTen.Text = "";
            rbn_HD.Checked = false;
            rbn_KHD.Checked = false;
            tb_MatKhau.Enabled = true;
            tb_Email.Text = " ";
            ptb_AVT.Image = null;
            tb_MatKhau.Text = "";
            date_ngaySinh.Text = "";
            tb_user.Text = "";
            cmb_CV.Text = null;
            rbtn_Nam.Checked = false;
            rbtn_Nu.Checked = false;
            Cbb_LocCV.Text = null;
            txt_TimKiem.Text = " ";

        }





        private void Cbb_LocCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stt = 1;
            if (txt_TimKiem.Text == "")
            {
                //x => x.MaNv.ToLower().Contains(txt_TimKiem.Text.ToLower()
                var timkiem = _Inhanvien.GetAllView().Where(p => p.Ten.ToLower().Contains(Cbb_LocCV.Text.ToLower()));
                dtg_ShowNV.Rows.Clear();
                foreach (var a in timkiem)
                {
                    dtg_ShowNV.Rows.Add(
                    a.ID,
                    stt++,
                    a.Username,
                    a.MaNv,
                    a.HoTen,
                    a.GioiTinh == 1 ? "nam" : "nữ",
                    a.Email,
                    a.NgaySinh,
                    a.MatKhau,
                    a.AnhNv,
                    a.Ten, // Access ChucVu property directly from NhanVien
                    a.TrangThai == 1 ? "hoạt động" : "Không hoạt động");
                }
            }
            if (txt_TimKiem.Text != "")
            {
                var timkiem = _Inhanvien.GetAllView().Where(p => p.Ten.ToLower().Contains(Cbb_LocCV.Text.ToLower()) && p.HoTen.Contains(txt_TimKiem.Text));

                dtg_ShowNV.Rows.Clear();
                foreach (var a in timkiem)
                {
                    dtg_ShowNV.Rows.Add(
                    a.ID,
                    stt++,
                    a.Username,
                    a.MaNv,
                    a.HoTen,
                    a.GioiTinh == 1 ? "nam" : "nữ",
                    a.Email,
                    a.NgaySinh,
                    a.MatKhau,
                    a.AnhNv,
                    a.Ten, // Access ChucVu property directly from NhanVien
                    a.TrangThai == 1 ? "hoạt động" : "Không hoạt động");
                }
            }
        }


        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                linkanh = op.FileName;
                ptb_AVT.Image = Image.FromFile(op.FileName);
                ptb_AVT.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();


        }

    }

}
