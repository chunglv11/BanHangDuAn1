using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;
using System.Data;
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

namespace _3.PL.Views
{
    public partial class FrmNhanVien : Form
    {
        private INhanVienServices _Inhanvien;
        private IChucVuServices _IchucVu;
        private NhanVienViewModels _nvview;
        NhanVien nhanVien;
        private Guid ID;
        public string Anh = "";

        //Mã OTP
        private const string mailAddress = "tranvantien6620@gmail.com";
        private const string fromPass = "iekmmjfguxfgtzia";
        private const string subjectMail = "OTP code";
        private int _code;
        private static int _countSteps = 0;
        private static Timer _timer;
        private static FrmNhanVien _instance;

        public FrmNhanVien()
        {
            _Inhanvien = new NhanVienServices();
            _IchucVu = new ChucVuServices();
            _nvview = new NhanVienViewModels();
            InitializeComponent();
            LoadcmbCV();
            LoadData();

        }
        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            sendOTP();
        }
        private static void timerTick(object myObject, EventArgs e)
        {
            _countSteps++;
            if (_countSteps > 60)
            {
                stopTimer();
                var confirmMessage = MessageBox.Show("Mã OTP đã hết hiệu lực\nBạn có muốn lấy lại mã OTP không?",
                    "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                if (confirmMessage == DialogResult.Retry)
                {
                    _instance.sendOTP();
                }
            }
        }
        private void sendOTP()
        {

        }
        private void confirmOTP()
        {

        }
        private static void startTimer()
        {
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += timerTick;
            _timer.Start();
            _instance.enableControl(true);
        }

        private static void stopTimer()
        {
            if (_timer != null)
            {
                _timer.Stop();
                _timer = null;
                _countSteps = 0;
            }
            _instance.enableControl(false);
        }
        private void enableControl(bool isEnable)
        {
            //       txtOTP.Enabled = btnXacNhan.Enabled = isEnable;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            confirmOTP();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void LoadData()
        {
            int stt = 1;
            dtg_ShowNV.ColumnCount = 11;
            dtg_ShowNV.Columns[0].Name = "stt";
            dtg_ShowNV.Columns[1].Name = "id";
            dtg_ShowNV.Columns[2].Name = "Username";
            dtg_ShowNV.Columns[3].Name = "MaNV";
            dtg_ShowNV.Columns[4].Name = "HoTen";
            dtg_ShowNV.Columns[5].Name = "GioiTinh";
            dtg_ShowNV.Columns[6].Name = "Email";
            dtg_ShowNV.Columns[7].Name = "NgaySinh";
            dtg_ShowNV.Columns[8].Name = "MatKhau";
            dtg_ShowNV.Columns[9].Name = "ChucVu";
            dtg_ShowNV.Columns[10].Name = "trang thai";
            dtg_ShowNV.Rows.Clear();
            dtg_ShowNV.Columns[1].Visible = true;
            //foreach (var a in _Inhanvien.GetAll())
            //{
            //    _ = dtg_ShowNV.Rows.Add(stt++, a.ID,  a.Username, a.MaNv, a.HoTen, a.GioiTinh, a.Email, a.AnhNv, a.NgaySinh, a.MatKhau, a.ChucVu, a.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            //}
            foreach (var a in _Inhanvien.GetAllView())
            {
                _ = dtg_ShowNV.Rows.Add(
                    stt++,
                    a.NhanVien.ID,
                    a.NhanVien.Username,
                    a.NhanVien.MaNv,
                    a.NhanVien.HoTen,
                    a.NhanVien.GioiTinh == 1 ? "nam" : "nữ",
                    a.NhanVien.Email,
                    a.NhanVien.NgaySinh,
                    a.NhanVien.MatKhau,
                    a.NhanVien.IDCV, // Access ChucVu property directly from NhanVien
                    a.NhanVien.TrangThai == 1 ? "hoạt động" : "Không hoạt động"
                );
            }

        }

        private void LoadcmbCV()
        {
            foreach (var a in _IchucVu.GetAll().Where(c => c.TrangThai == 1))
            {
                _ = cmb_CV.Items.Add(a.Ten);
            }
            //foreach (NhanVienViewModels a in _Inhanvien.GetAllView())
            //{
            //    _ = cmb_CV.Items.Add(a.ChucVu);
            //}
        }
        public NhanVien GetvaluaContro()
        {
            ChucVuViewModels? x = _IchucVu.GetAllView().FirstOrDefault(c => c.ChucVu.Ten == cmb_CV.Text);
            return new NhanVien()
            {

                MaNv = tb_Ma.Text,
                HoTen = txt_HoTen.Text,
                Email = tb_Email.Text,
                AnhNv = btn_ChonAnh.Text,
                MatKhau = tb_MatKhau.Text,
                NgaySinh = date_ngaySinh.Value,
                Username = tb_user.Text,
                IDCV = x.ChucVu.ID,
                GioiTinh = rbtn_Nam.Checked == true ? 1 : 0,
                TrangThai = rbn_HD.Checked == true ? 1 : 0,
                //a.NhanVien.ID,
                //a.NhanVien.Username,
                //a.NhanVien.MaNv,
                //a.NhanVien.HoTen,
                //a.NhanVien.GioiTinh == 1 ? "nam" : "nu",
                //a.NhanVien.Email,
                //a.NhanVien.AnhNv,
                //a.NhanVien.NgaySinh,
                //a.NhanVien.MatKhau,
                //a.NhanVien.ChucVu.Ten, // Access ChucVu property directly from NhanVien
                //a.NhanVien.TrangThai == 1 ? "hoạt động" : "Không hoạt động"
            };
        }
        private void dtg_ShowNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //a.Username, a.MaNv, a.HoTen, a.Email, a.GioiTinh == 1 ? "nam" : "nu", a.NgaySinh, a.AnhNv, a.MatKhau, a.ChucVu.Ten, a.TrangThai == 1 ? "hoạt động" : "Không hoạt động"
                ID = Guid.Parse(dtg_ShowNV.Rows[e.RowIndex].Cells[1].Value.ToString());
                tb_Ma.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_HoTen.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_Email.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[6].Value.ToString();
                tb_user.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_MatKhau.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[8].Value.ToString();
                date_ngaySinh.Value = (DateTime)dtg_ShowNV.Rows[e.RowIndex].Cells[7].Value;
                var cv = _Inhanvien.GetAll().FirstOrDefault(p => p.ID == ID);

                cmb_CV.Text = _IchucVu.GetAllView().FirstOrDefault(p => p.ChucVu.ID == cv.IDCV).ChucVu.Ten;
                Anh = cv.AnhNv;
                if (Anh != null && File.Exists(Anh))
                {
                    ptb_AVT.Image = Image.FromFile(Anh);
                    ptb_AVT.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                //NhanVien a = _Inhanvien.GetAll().FirstOrDefault(c => c.nhanVien.ID == ID).NhanVien;
                //cmb_CV.SelectedItem = _IQlNhanVien.GetAllView().FirstOrDefault(c => c.NhanVien.IdChucVu == a.IdChucVu).ChucVu.TenChucVu;


                if (dtg_ShowNV.Rows[e.RowIndex].Cells[5].Value.ToString() == "nam")
                {
                    rbtn_Nam.Checked = true;
                }
                else if (dtg_ShowNV.Rows[e.RowIndex].Cells[5].Value.ToString() == "nu")
                {
                    rbtn_Nu.Checked = true;
                }


                //if (dtg_ShowNV.Rows[e.RowIndex].Cells[11].Value.ToString() == "hoạt động")
                //{
                //    rbn_HD.Checked = true;
                //    rbn_KHD.Checked = false;
                //}
                //else if (dtg_ShowNV.Rows[e.RowIndex].Cells[11].Value.ToString() == "không hoạt động")
                //{
                //    rbn_HD.Checked = false;
                //    rbn_KHD.Checked = true;
                //}
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var chucvu = _IchucVu.GetAll().FirstOrDefault(c => c.Ten == cmb_CV.Text);
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm Nhân Viên Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_Inhanvien.GetAll().Any(c => c.MaNv == tb_Ma.Text))
                {
                    MessageBox.Show("Mã bị trùng");
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




                    _ = _Inhanvien.Add(GetvaluaContro());
                    LoadData();
                    MessageBox.Show("thành công");


                }
            }
            //_ = _Inhanvien.Add(GetvaluaContro());
            //LoadData();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ChucVuViewModels? x = _IchucVu.GetAllView().FirstOrDefault(c => c.ChucVu.Ten == cmb_CV.Text);
                bool thongBao = _Inhanvien.Update(new _1.DAL.Models.NhanVien()
                {
                    ID = ID,
                    MaNv = tb_Ma.Text,
                    HoTen = txt_HoTen.Text,
                    Email = tb_Email.Text,
                    AnhNv = btn_ChonAnh.Text,
                    MatKhau = tb_MatKhau.Text,
                    NgaySinh = date_ngaySinh.Value,
                    Username = tb_user.Text,
                    IDCV = x.ChucVu.ID,
                    GioiTinh = rbtn_Nam.Checked == true ? 1 : 0,
                    //TrangThai = rbn_HD.Checked == true ? 1 : 0,


                });
                if (thongBao)
                {
                    _ = MessageBox.Show("Sửa thành công");

                    LoadData();

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
                    bool deletionResult = _Inhanvien.Delete(ID);

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
            tb_Ma.Text = "";
            txt_HoTen.Text = "";
            rbn_HD.Text = "";
            rbn_KHD.Text = "";

            tb_Email.Text = " ";

            tb_MatKhau.Text = "";
            date_ngaySinh.Text = "";
            tb_user.Text = "";
            cmb_CV.Text = "";
            rbtn_Nam.Text = "";

        }



        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            dtg_ShowNV.Rows.Clear();

            foreach (var item in _Inhanvien.GetAllView().Where(c =>
    c.NhanVien.MaNv.Contains(tb_Ma.Text) ||
    c.NhanVien.HoTen.Contains(txt_HoTen.Text) ||
    c.NhanVien.Username.Contains(txt_TimKiem.Text) ||
    c.NhanVien.Email.Contains(txt_TimKiem.Text)))
            {
                dtg_ShowNV.Rows.Add(item.NhanVien.ID, item.NhanVien.MaNv, item.NhanVien.HoTen, item.NhanVien.Username, item.NhanVien.ChucVu, item.NhanVien.Email, item.NhanVien.GioiTinh, item.NhanVien.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
    }
}
