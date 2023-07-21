using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _3.PL.Views
{
    public partial class FrmNhanVien : Form
    {
        private IChucVuServices _chucVu;
        public INhanVienServices _InhanVienServices;

        private Guid _ID;
        public FrmNhanVien()
        {
            _InhanVienServices = new NhanVienServices();
            LoadData();
        }
        private void loadcmb()
        {
            foreach (var x in _chucVu.Getlst())
            {
                cmb_CV.Items.Add(x.Ten);
            }
            //cmb_Hang.SelectedIndex = 0;


        }
        private void LoadData()
        {
            int stt = 1;
            dtg_ShowNV.ColumnCount = 13;
            dtg_ShowNV.Columns[0].Name = "stt";
            dtg_ShowNV.Columns[1].Name = "id";
            dtg_ShowNV.Columns[2].Name = "IDCV";
            dtg_ShowNV.Columns[3].Name = "Username";
            dtg_ShowNV.Columns[4].Name = "MaNV";
            dtg_ShowNV.Columns[5].Name = "Hoten";
            dtg_ShowNV.Columns[6].Name = "GioiTinh";
            dtg_ShowNV.Columns[7].Name = "Email";
            dtg_ShowNV.Columns[8].Name = "Anh";
            dtg_ShowNV.Columns[9].Name = "NgaySinh";
            dtg_ShowNV.Columns[10].Name = "MatKhau";
            dtg_ShowNV.Columns[11].Name = "ChucVu";
            dtg_ShowNV.Columns[12].Name = "trang thai";
            dtg_ShowNV.Rows.Clear();
            dtg_ShowNV.Columns[1].Visible = true;
            foreach (var a in _InhanVienServices.GetAll())
            {
                _ = dtg_ShowNV.Rows.Add(stt++, a.ID, a.IDCV, a.Username, a.MaNv, a.HoTen, a.GioiTinh, a.Email, a.AnhNv, a.NgaySinh, a.MatKhau, a.ChucVu, a.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm Nhân Viên Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_InhanVienServices.GetAll().Any(c => c.MaNv == tb_Ma.Text))
                {
                    MessageBox.Show("Mã bị trùng");
                }
                else if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
                {
                    MessageBox.Show("Tên không được bỏ trống");
                }
                else if (rbtn_HD.Checked == false && rbtn_KHD.Checked == false)
                {

                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else
                {
                    NhanVienViewModels x = new NhanVienViewModels()
                    {
                        //ID = nhanVienViewModels.ID,
                        //IDCV = nhanVienViewModels.IDCV,
                        //Username = nhanVienViewModels.Username,
                        //MaNv = nhanVienViewModels.MaNv,
                        //HoTen = nhanVienViewModels.HoTen,
                        //GioiTinh = nhanVienViewModels.GioiTinh,
                        //Email = nhanVienViewModels.Email,
                        //AnhNv = nhanVienViewModels.AnhNv,
                        //NgaySinh = nhanVienViewModels.NgaySinh,
                        //MatKhau = nhanVienViewModels.MatKhau,
                        //TrangThai = nhanVienViewModels.TrangThai
                        ID = Guid.NewGuid(),
                        HoTen = txt_HoTen.Text,
                        MaNv = tb_Ma.Text,
                        Email = tb_Email.Text,
                        MatKhau = tb_MatKhau.Text,
                        Username = tb_user.Text,

                        TrangThai = rbtn_HD.Checked ? 1 : 0
                    };
                    MessageBox.Show(_InhanVienServices.Them(x));
                    LoadData();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Sửa Nhân Viên Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                NhanVienViewModels x = new NhanVienViewModels()
                {
                    //ID = nhanVienViewModels.ID,
                    //IDCV = nhanVienViewModels.IDCV,
                    //Username = nhanVienViewModels.Username,
                    //MaNv = nhanVienViewModels.MaNv,
                    //HoTen = nhanVienViewModels.HoTen,
                    //GioiTinh = nhanVienViewModels.GioiTinh,
                    //Email = nhanVienViewModels.Email,
                    //AnhNv = nhanVienViewModels.AnhNv,
                    //NgaySinh = nhanVienViewModels.NgaySinh,
                    //MatKhau = nhanVienViewModels.MatKhau,
                    //TrangThai = nhanVienViewModels.TrangThai
                    ID = Guid.NewGuid(),
                    HoTen = txt_HoTen.Text,
                    MaNv = tb_Ma.Text,
                    Email = tb_Email.Text,
                    MatKhau = tb_MatKhau.Text,
                    Username = tb_user.Text,

                    TrangThai = rbtn_HD.Checked ? 1 : 0
                };
                MessageBox.Show(_InhanVienServices.Sua(x));
                LoadData();

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Nhân Viên Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                MessageBox.Show(_InhanVienServices.Xoa(_ID));
                LoadData();

            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            tb_Ma.Text = "";
            txt_HoTen.Text = "";
            tb_Email.Text = "";
            tb_MatKhau.Text = "";
            tb_user.Text = "";

            cmb_CV.SelectedIndex = 0;
            rbtn_HD.Text = "";
            rbtn_KHD.Text = "";
        }

        private void dtg_ShowNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Guid.Parse(dtg_ShowNV.Rows[e.RowIndex].Cells[0].Value.ToString());
            tb_Ma.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_HoTen.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_Email.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_ChonAnh.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_MatKhau.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[5].Value.ToString();

            btn_ChonAnh.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[10].Value.ToString();
            tb_user.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_TimKiem.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmb_CV.Text = dtg_ShowNV.Rows[e.RowIndex].Cells[8].Value.ToString();
            object cellValue = dtg_ShowNV.Rows[e.RowIndex].Cells[9].Value;
            //dtg_ShowNV.Columns[0].Name = "stt";
            //dtg_ShowNV.Columns[1].Name = "id";
            //dtg_ShowNV.Columns[2].Name = "IDCV";
            //dtg_ShowNV.Columns[3].Name = "Username";
            //dtg_ShowNV.Columns[4].Name = "MaNV";
            //dtg_ShowNV.Columns[5].Name = "Hoten";
            //dtg_ShowNV.Columns[6].Name = "GioiTinh";
            //dtg_ShowNV.Columns[7].Name = "Email";
            //dtg_ShowNV.Columns[8].Name = "Anh";
            //dtg_ShowNV.Columns[9].Name = "NgaySinh";
            //dtg_ShowNV.Columns[10].Name = "MatKhau";
            //dtg_ShowNV.Columns[11].Name = "ChucVu";
            //dtg_ShowNV.Columns[12].Name = "trang thai";
            var dt = _InhanVienServices.GetAll().FirstOrDefault(c => c.ID == _ID);
            var chucvu = _chucVu.Getlst().FirstOrDefault(c => c.Ten == dt.HoTen);
            cmb_CV.SelectedIndex = cmb_CV.FindStringExact(chucvu.Ten);
            if (cellValue != null && cellValue is string)
            {
                string trangThai = (string)cellValue;
                rbtn_HD.Checked = trangThai == "Hoạt động";
                rbtn_KHD.Checked = trangThai == "Không hoạt động";
            }
            if (cellValue != null && cellValue is string)
            {
                string trangThai = (string)cellValue;
                rbtn_Nam.Checked = trangThai == "Nam";
                rbtn_Nu.Checked = trangThai == "Nữ";
            }
        }

        
    }
}
