using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _3.PL.Views
{
    public partial class FrmNhanVien : Form
    {
        public INhanVienServices _INhanVienServices;

        private Guid _ID;
        public FrmNhanVien()
        {
            _INhanVienServices = new NhanVienServices();
            LoadData();
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
            foreach (var a in _INhanVienServices.GetAll())
            {
                _ = dtg_ShowNV.Rows.Add(stt++, a.ID, a.IDCV, a.Username, a.MaNv, a.HoTen, a.GioiTinh, a.Email, a.AnhNv, a.NgaySinh, a.MatKhau, a.ChucVu, a.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }
        //public NhanVienServices GetvaluaContro()
        //{

        //    //return new NhanVienServices()
        //    //{
        //    //    MaNv = tb_Ma.Text,
        //    //    HoTen = txt_HoTen.Text,
        //    //    NgaySinh = date_ngaySinh.Value,
        //    //    GioiTinh = rbtn_Nam.Checked == true ? 1 : 0,
        //    //    Email = tb_Email.Text,
        //    //    ChucVu = cmb_CV.Text,
        //    //    Username = tb_user.Text,
        //    //    MatKhau = tb_MatKhau.Text,
        //    //    TrangThai = rbtn_HD.Checked == true ? 1 : 0,
        //    //};
        //}

        private void dtg_ShowChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dtg_ShowNV.Rows[index].Cells[1].Value.ToString());
            tb_Ma.Text = dtg_ShowNV.Rows[index].Cells[2].Value.ToString();
            txt_HoTen.Text = dtg_ShowNV.Rows[index].Cells[3].Value.ToString();
            date_ngaySinh.Value = (DateTime)dtg_ShowNV.Rows[index].Cells[4].Value;
            rbtn_Nam.Text = dtg_ShowNV.Rows[index].Cells[5].Value.ToString();
            tb_Email.Text = dtg_ShowNV.Rows[index].Cells[6].Value.ToString();
            cmb_CV.Text = dtg_ShowNV.Rows[index].Cells[7].Value.ToString();
            tb_user.Text = dtg_ShowNV.Rows[index].Cells[8].Value.ToString();
            tb_MatKhau.Text = dtg_ShowNV.Rows[index].Cells[9].Value.ToString();

            if (dtg_ShowNV.Rows[index].Cells[10].Value.ToString() == "hoạt động")
            {
                rbtn_HD.Checked = true;
                rbtn_KHD.Checked = false;
            }
            if (dtg_ShowNV.Rows[index].Cells[10].Value.ToString() == "không hoạt động")
            {
                rbtn_HD.Checked = false;
                rbtn_KHD.Checked = true;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //_ = _INhanVienServices.Them(GetvaluaContro());
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //bool thongBao = _INhanVienServices.Sua(new _1.DAL.Models.NhanVien
            //{
            //    ID = _ID,
            //    MaNv = tb_Ma.Text,
            //    HoTen = txt_HoTen.Text,
            //    NgaySinh = date_ngaySinh.Value,
            //    GioiTinh = rbtn_Nam.Checked == true ? 1 : 0,
            //    Email = tb_Email.Text,
            //    ChucVu = cmb_CV.Text,
            //    Username = tb_user.Text,
            //    MatKhau = tb_MatKhau.Text,
            //    TrangThai = rbtn_HD.Checked == true ? 1 : 0,
            //});

            //if (thongBao)
            //{
            //    _ = MessageBox.Show("Sửa thành công");
            //    LoadData();
            //}
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _INhanVienServices.Xoa(_INhanVienServices.GetAll().Find(c => c.ID == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {

        }


        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            //_ = _INhanVienServices.TimKiem(GetvaluaContro());
            LoadData();
        }
    }
}
