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
            //foreach (var item in _IchucVu.GetAll())
            //{
            //    cmb_CV.Items.Add(item.Ten);
            //}
            //rbtn_Nam.Checked = true;
            //rbtn_Nu.Checked = true;
            //foreach (var item in _IchucVu.GetAll())
            //{
            //    Cbb_LocCV.Items.Add(item.Ten);
            //}
            //cbb_locTT.Items.Add("Hoạt Động");
            //cbb_locTT.Items.Add("Không hoạt Động");
            //date_ngaySinh.CustomFormat = "dd-MM-yyyy";

            InitializeComponent();
            LoadcmbCV();
            LoadData();
            LoadLocCV();

        }
        // SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-Q3TF2SAN\\\\SQLEXPRESS;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True;TrustServerCertificate=True;");
        //private void openCon()
        // {
        //     if(con.State == ConnectionState.Closed)
        //     {
        //         con.Open();
        //     }
        // } private void closeCon()
        // {
        //     if(con.State == ConnectionState.Open)
        //     {
        //         con.Close();
        //     }
        // }
        // //private Boolean Exe(string cmd)
        // //{
        // //    openCon();
        // //    Boolean check;
        // //    try
        // //    {
        // //        SqlCommand sc = new SqlCommand(cmd, con);
        // //        sc.ExecuteNonQuery();
        // //        check = true;
        // //    }
        // //    catch (Exception ex)
        // //    {
        // //        check = false;
        // //    }

        // //}
        // private DataTable getData(string cmd)
        // {
        //     openCon();
        //     DataTable dt = new DataTable();
        //     try
        //     {
        //         SqlCommand sc = new SqlCommand(cmd,con);
        //         SqlDataAdapter da = new SqlDataAdapter(sc);
        //     }
        //     catch (Exception ex)
        //     {
        //         dt = null;
        //     }

        //     closeCon();
        //     return dt;
        // }
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
            dtg_ShowNV.ColumnCount = 12;
            dtg_ShowNV.Columns[0].Name = "stt";
            dtg_ShowNV.Columns[11].Name = "id";
            dtg_ShowNV.Columns[11].Visible = false;
            dtg_ShowNV.Columns[1].Name = "Username";
            dtg_ShowNV.Columns[2].Name = "MaNV";
            dtg_ShowNV.Columns[3].Name = "HoTen";
            dtg_ShowNV.Columns[4].Name = "GioiTinh";
            dtg_ShowNV.Columns[5].Name = "Email";
            dtg_ShowNV.Columns[6].Name = "NgaySinh";
            dtg_ShowNV.Columns[7].Name = "MatKhau";
            dtg_ShowNV.Columns[8].Name = "Anh";
            dtg_ShowNV.Columns[9].Name = "ChucVu";
            dtg_ShowNV.Columns[10].Name = "trang thai";
            dtg_ShowNV.Rows.Clear();
            dtg_ShowNV.Columns[1].Visible = true;
            var lstnv = _Inhanvien.GetAllView();
            if (txt_TimKiem.Text != "")
            {
                lstnv = lstnv.Where(x => x.MaNv.ToLower().Contains(txt_TimKiem.Text.ToLower())
                || x.HoTen.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            //foreach (var a in _Inhanvien.GetAll())
            //{
            //    _ = dtg_ShowNV.Rows.Add(stt++, a.ID,  a.Username, a.MaNv, a.HoTen, a.GioiTinh, a.Email, a.AnhNv, a.NgaySinh, a.MatKhau, a.ChucVu, a.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            //}
            foreach (var a in lstnv)
            {
                _ = dtg_ShowNV.Rows.Add(
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
                    a.TrangThai == 1 ? "hoạt động" : "Không hoạt động",
                    a.ID
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
        private void LoadLocCV()
        {
            foreach (var a in _IchucVu.GetAll().Where(c => c.TrangThai == 1))
            {
                _ = Cbb_LocCV.Items.Add(a.Ten);
            }
            //foreach (NhanVienViewModels a in _Inhanvien.GetAllView())
            //{
            //    _ = cmb_CV.Items.Add(a.ChucVu);
            //}
        }
        //public NhanVien GetvaluaContro()
        //{
        //    var chucvu = _IchucVu.GetAll().FirstOrDefault(c => c.Ten == cmb_CV.Text);
        //    //ChucVuViewModels? x = _IchucVu.GetAllView().FirstOrDefault(c => c.ChucVu.Ten == cmb_CV.Text);
        //    return new NhanVien()
        //    {

        //        MaNv = tb_Ma.Text,
        //        HoTen = txt_HoTen.Text,
        //        Email = tb_Email.Text,
        //        AnhNv = btn_ChonAnh.Text,
        //        MatKhau = tb_MatKhau.Text,
        //        NgaySinh = date_ngaySinh.Value,
        //        Username = tb_user.Text,

        //        IDCV = chucvu.ID,
        //        GioiTinh = rbtn_Nam.Checked == true ? 1 : 0,
        //        TrangThai = rbn_HD.Checked == true ? 1 : 0,
        //        //a.NhanVien.ID,
        //        //a.NhanVien.Username,
        //        //a.NhanVien.MaNv,
        //        //a.NhanVien.HoTen,
        //        //a.NhanVien.GioiTinh == 1 ? "nam" : "nu",
        //        //a.NhanVien.Email,
        //        //a.NhanVien.AnhNv,
        //        //a.NhanVien.NgaySinh,
        //        //a.NhanVien.MatKhau,
        //        //a.NhanVien.ChucVu.Ten, // Access ChucVu property directly from NhanVien
        //        //a.NhanVien.TrangThai == 1 ? "hoạt động" : "Không hoạt động"
        //    };
        //}
        private void dtg_ShowNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                //a.Username, a.MaNv, a.HoTen, a.Email, a.GioiTinh == 1 ? "nam" : "nu", a.NgaySinh, a.AnhNv, a.MatKhau, a.ChucVu.Ten, a.TrangThai == 1 ? "hoạt động" : "Không hoạt động"
                ID = Guid.Parse(dtg_ShowNV.Rows[e.RowIndex].Cells[11].Value.ToString());
                tb_Ma.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_HoTen.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_Email.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[5].Value.ToString();
                tb_user.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_MatKhau.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[7].Value.ToString();
                date_ngaySinh.Value = (DateTime)dtg_ShowNV.Rows[e.RowIndex].Cells[6].Value;
                var cv = _Inhanvien.GetAll().FirstOrDefault(p => p.ID == ID);

                cmb_CV.Text = _IchucVu.GetAllView().FirstOrDefault(p => p.ID == cv.IDCV).Ten;
                string imagePath = "C:\\Untitled.jpg"; // Replace this with the correct image path

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    try
                    {
                        // Load the image using Image.FromFile
                        ptb_AVT.Image = Image.FromFile(imagePath);
                        ptb_AVT.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        // Handle any exception that might occur during image loading
                        MessageBox.Show("Đã có lỗi khi tải hình ảnh: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ptb_AVT.Image = null; // Set the PictureBox's Image to null if loading fails
                    }
                }
                else
                {
                    ptb_AVT.Image = null; // Set the PictureBox's Image to null if the file does not exist or the path is empty
                }
                //Anh = cv.AnhNv;

                //if (Anh != null && File.Exists(Anh))
                //{
                //    ptb_AVT.Image = Image.FromFile(Anh);
                //    ptb_AVT.SizeMode = PictureBoxSizeMode.StretchImage;
                //}
                //else
                //{
                //    ptb_AVT.Image = null;
                //}



                if (e.RowIndex >= 0 && e.RowIndex < dtg_ShowNV.Rows.Count)
                {
                    // Your existing code here, with the checks for valid index

                    if (dtg_ShowNV.Rows[e.RowIndex].Cells[4].Value.ToString() == "nam")
                    {
                        rbtn_Nam.Checked = true;
                    }
                    else if (dtg_ShowNV.Rows[e.RowIndex].Cells[4].Value.ToString() == "nữ")
                    {
                        rbtn_Nu.Checked = true;
                    }

                    if (dtg_ShowNV.Rows[e.RowIndex].Cells[10].Value.ToString() == "hoạt động")
                    {
                        rbn_HD.Checked = true;
                    }
                    else if (dtg_ShowNV.Rows[e.RowIndex].Cells[10].Value.ToString() == "không hoạt động")
                    {
                        rbn_KHD.Checked = true;
                    }
                }
            }

        }
        //public bool checkInput()
        //{
        //    string email = tb_Email.Text;
        //    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,10})+)$");
        //    Match match = regex.Match(email);
        //    if (!match.Success)
        //    {
        //        MessageBox.Show("Email không hợp lệ!!!");
        //        tb_Email.Text = "";
        //        return false;
        //    }
        //    else if (txt_HoTen.Text.Length == 0)
        //    {
        //        MessageBox.Show("Bạn chưa nhập Tên nhân viên");
        //        return false;
        //    }
        //    else if (txt_HoTen.Text.Length < 8)
        //    {
        //        MessageBox.Show("Tên nhân viên phải có ít nhất 8 kí tự");
        //        return false;
        //    }

        //    else if (tb_MatKhau.Text.Length == 0)
        //    {
        //        MessageBox.Show("Bạn chưa nhập mật khẩu !");
        //        return false;
        //    }

        //    return true;
        //}
        private void btn_Them_Click(object sender, EventArgs e)
        //{
        //    var checkEmail = _Inhanvien.GetAll().FirstOrDefault(p => p.Email == tb_Email.Text);
        //    if (!checkInput())
        //    {

        //    }
        //    else
        //    {
        //        if (checkEmail != null)
        //        {
        //            MessageBox.Show("Email đã được sử dụng, hãy chọn Email khác");
        //        }
        //        else
        //        {
        //            int idss = _Inhanvien.GetAll().Count() + 1;

        //            // This will get the current PROJECT directory


        //            NhanVien nhanVien = new NhanVien()
        //            {

        //                MaNv = tb_Ma.Text,
        //                HoTen = txt_HoTen.Text,
        //                Email = tb_Email.Text,
        //                AnhNv = btn_ChonAnh.Text,
        //                MatKhau = tb_MatKhau.Text,
        //                NgaySinh = date_ngaySinh.Value,
        //                Username = tb_user.Text,
        //                IDCV = cmb_CV.Text == "Quản lý" ? 1 : 2,

        //                GioiTinh = rbtn_Nam.Checked == true ? 1 : 0,
        //                TrangThai = rbn_HD.Checked == true ? 1 : 0,
        //            };
        //            _iQLEmployee.AddEmployee(employeee);
        //            MessageBox.Show("Thêm Nhân Viên thành công");
        //            loadNhanVien();

        {

            var chucvu = _IchucVu.GetAll().FirstOrDefault(c => c.Ten == cmb_CV.Text);

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
                        AnhNv = btn_ChonAnh.Text,
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

            //_ = _Inhanvien.Add(GetvaluaContro());
            //LoadData();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                //File.Copy(Anh, Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(Anh)), true);
                //Anh = Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(Anh));
                //SanPhamCTViewModels viewSpCt = new SanPhamCTViewModels();

                ChucVuViewModels? x = _IchucVu.GetAllView().FirstOrDefault(c => c.Ten == cmb_CV.Text);
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
                    IDCV = x.ID,
                    GioiTinh = rbtn_Nam.Checked == true ? 1 : 0,
                    TrangThai = rbn_HD.Checked == true ? 1 : 0,




                });
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
            //dtg_ShowNV.Rows.Clear();
            //LoadData();
            tb_Ma.Text = "";
            txt_HoTen.Text = "";
            rbn_HD.Checked = false;
            rbn_KHD.Checked = false;

            tb_Email.Text = " ";

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

            if (txt_TimKiem.Text == "")
            {
                //x => x.MaNv.ToLower().Contains(txt_TimKiem.Text.ToLower()
                var timkiem = _Inhanvien.GetAllView().Where(p => p.Ten.ToLower().Contains(Cbb_LocCV.Text.ToLower()));
                //var timkiem = _Inhanvien.GetAll().Where(p => p.IDCV = Cbb_LocCV.SelectedIndex + 1);



                dtg_ShowNV.Rows.Clear();
                foreach (var a in timkiem)
                {

                    dtg_ShowNV.Rows.Add(
                         a.Username,
                    a.MaNv,
                    a.HoTen,
                    a.GioiTinh == 1 ? "nam" : "nữ",
                    a.Email,
                    a.NgaySinh,
                    a.MatKhau,
                    a.AnhNv,
                    a.Ten, // Access ChucVu property directly from NhanVien
                    a.TrangThai == 1 ? "hoạt động" : "Không hoạt động",
                    a.ID);
                    //item.MaNv, item.HoTen, item.MatKhau, item.Address, item.Sex == true ? "Nam" : "Nữ",
                    //     _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                    //     item.Status == true ? "Hoạt Động" : "Không hoạt động",
                    //     item.Dob.ToString("dd-MM-yyyy")
                }
            }
            if (txt_TimKiem.Text != "")
            {
                var timkiem = _Inhanvien.GetAllView().Where(p => p.Ten.ToLower().Contains(Cbb_LocCV.Text.ToLower()) && p.HoTen.Contains(txt_TimKiem.Text));

                dtg_ShowNV.Rows.Clear();
                foreach (var a in timkiem)
                {
                    dtg_ShowNV.Rows.Add(a.Username,
                    a.MaNv,
                    a.HoTen,
                    a.GioiTinh == 1 ? "nam" : "nữ",
                    a.Email,
                    a.NgaySinh,
                    a.MatKhau,
                    a.AnhNv,
                    a.Ten, // Access ChucVu property directly from NhanVien
                    a.TrangThai == 1 ? "hoạt động" : "Không hoạt động",
                    a.ID); ;
                }
            }
        }

        private void ptb_AVT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    Anh = op.FileName;

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
        private bool IsValidImage(Image image)
        {
            return (image.Width > 0 && image.Height > 0);
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog op = new OpenFileDialog())
            //{
            //    if (op.ShowDialog() == DialogResult.OK)
            //    {
            //        Anh = op.FileName;

            //        try
            //        {
            //            // Sử dụng FileStream để đọc dữ liệu hình ảnh từ tệp
            //            using (FileStream fs = new FileStream(op.FileName, FileMode.Open, FileAccess.Read))
            //            {
            //                // Tạo một đối tượng hình ảnh từ luồng dữ liệu
            //                Image image = Image.FromStream(fs);

            //                // Kiểm tra xem hình ảnh hợp lệ trước khi gán vào PictureBox
            //                if (IsValidImage(image))
            //                {
            //                    ptb_AVT.Image = image;
            //                    ptb_AVT.SizeMode = PictureBoxSizeMode.Zoom;
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Hình ảnh không hợp lệ.");
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Lỗi: " + ex.Message);
            //        }
            //    }
            //}
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                Anh = op.FileName;
                ptb_AVT.Image = Image.FromFile(op.FileName);
                ptb_AVT.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        //public void LoadGridByKeyword()
        //{ 
        //NhanVien nv = new NhanVien();
        //    dtg_ShowNV.DataSource = nv("Select * from Product where Name like '%"+txt_TimKiem+"%'");
        //}
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
            ////       Database dt = Red("SELECT * From ")
            ////       dtg_ShowNV.DataSource = getData("SELECT * FROM NhanVien WHERE Username LIKE '%" + txt_TimKiem.Text + "%'");

            ////       dtg_ShowNV.Rows.Clear();

            ////       foreach (var item in _Inhanvien.GetAllView().Where(c =>
            ////c.HoTen.Contains(txt_HoTen.Text)
            ////||
            ////c.HoTen.Contains(txt_HoTen.Text) ||
            ////c.Username.Contains(txt_TimKiem.Text) ||
            ////c.Email.Contains(txt_TimKiem.Text)
            ////))
            ////       {
            ////           dtg_ShowNV.Rows.Add(item.ID, item.MaNv, item.HoTen, item.Username, item.Ten, item.Email, item.GioiTinh, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            ////       }

        }

    }

}
