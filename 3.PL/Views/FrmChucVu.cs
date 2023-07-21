using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

namespace _3.PL.Views
{
    public partial class FrmChucVu : Form
    {
        IChucVuServices _IchucVuServices;
        ChucVuViewModels _ChucVuViewModels;
        ChucVu _chucvu;
        Guid _ID;


        public FrmChucVu()
        {
            _chucvu = new ChucVu();
            _IchucVuServices = new ChucVuServices();
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            int stt = 1;
            dtg_ShowChucVu.ColumnCount = 5;
            dtg_ShowChucVu.Columns[0].Name = "stt";
            dtg_ShowChucVu.Columns[1].Name = "id";
            dtg_ShowChucVu.Columns[2].Name = "ma";
            dtg_ShowChucVu.Columns[3].Name = "ten";
            dtg_ShowChucVu.Columns[4].Name = "trang thai";
            dtg_ShowChucVu.Rows.Clear();
            dtg_ShowChucVu.Columns[1].Visible = true;
            foreach (var a in _IchucVuServices.Getlst())
            {
                _ = dtg_ShowChucVu.Rows.Add(stt++, a.ID, a.Ma, a.Ten, a.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }
            dtg_ShowChucVu.CellClick += dtg_ShowChucVu_CellClick;
        }


        //private void dtg_ShowChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int index = e.RowIndex;
        //    _ID = Guid.Parse(dtg_ShowChucVu.Rows[index].Cells[1].Value.ToString());
        //    txt_Ma.Text = dtg_ShowChucVu.Rows[index].Cells[2].Value.ToString();
        //    txt_Ten.Text = dtg_ShowChucVu.Rows[index].Cells[3].Value.ToString();
        //    if (dtg_ShowChucVu.Rows[index].Cells[4].Value.ToString() == "hoat dong")
        //    {
        //        rbtn_HD.Checked = true;
        //    }
        //    if (dtg_ShowChucVu.Rows[index].Cells[4].Value.ToString() == "khong hoat dong")
        //    {
        //        rbtn_KHD.Checked = true;
        //    }
        //}
        private void dtg_ShowChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _ID = Guid.Parse(dtg_ShowChucVu.Rows[e.RowIndex].Cells[1].Value.ToString());
                txt_Ma.Text = dtg_ShowChucVu.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_Ten.Text = dtg_ShowChucVu.Rows[e.RowIndex].Cells[3].Value.ToString();
                object cellValue = dtg_ShowChucVu.Rows[e.RowIndex].Cells[4].Value;
                if (cellValue != null && cellValue is string)
                {
                    string trangThai = (string)cellValue;
                    rbtn_HD.Checked = trangThai == "Hoạt động";
                    rbtn_KHD.Checked = trangThai == "Không hoạt động";
                }
            }
        }




        //private void btn_Xoa_Click(object sender, EventArgs e)
        //{
        //    if (_ID != Guid.Empty)
        //    {
        //        _chucvu = new ChucVu()
        //        {
        //            ID = Guid.NewGuid(),
        //            Ma = txt_Ma.Text,
        //            Ten = txt_Ten.Text,
        //            TrangThai = rbtn_HD.Checked ? 0 : 1,
        //        };
        //        if (_IchucVuServices.Xoa(_chucvu))
        //        {
        //            MessageBox.Show("Xóa thành công");
        //            LoadData();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Xóa không thành công");
        //        }

        //    }
        //}

        //private void btn_LamMoi_Click(object sender, EventArgs e)
        //{
        //    //txb_diem.Text = "";
        //    //txb_hoten.Text = "";
        //    //txb_sdt.Text = "";
        //    txt_Ma.Text = "";
        //    txt_Ten.Text = "";
        //    rbtn_HD.Text = "";
        //    rbtn_KHD.Text = "";
        //    //int stt = 1;
        //    //dtg_ShowChucVu.ColumnCount = 5;
        //    //dtg_ShowChucVu.Columns[0].Name = "";
        //    //dtg_ShowChucVu.Columns[1].Name = "";
        //    //dtg_ShowChucVu.Columns[2].Name = "";
        //    //dtg_ShowChucVu.Columns[3].Name = "";
        //    //dtg_ShowChucVu.Columns[4].Name = "";
        //    //dtg_ShowChucVu.Rows.Clear();
        //    //dtg_ShowChucVu.Columns[1].Visible = true;
        //    //foreach (var a in _IchucVuServices.GetAll())
        //    //{
        //    //    _ = dtg_ShowChucVu.Rows.Add(stt++, a.ID, a.Ma, a.Ten, a.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
        //    //}
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    dtg_ShowChucVu.Rows.Clear();

        //    foreach (var item in _IchucVuServices.GetAll().Where(c => c.Ma.Contains(textBox1.Text)))
        //    {
        //        dtg_ShowChucVu.Rows.Add(item.ID, item.Ma, item.Ten, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
        //    }
        //}

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm Chức Vụ Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_IchucVuServices.Getlst().Any(c => c.Ma == txt_Ma.Text))
                {
                    MessageBox.Show("Mã bị trùng");
                }
                else if (string.IsNullOrWhiteSpace(txt_Ten.Text))
                {
                    MessageBox.Show("Tên không được bỏ trống");
                }
                else if (rbtn_HD.Checked == false && rbtn_KHD.Checked == false)
                {

                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else
                {
                    ChucVuViewModels x = new ChucVuViewModels()
                    {
                        ID = Guid.NewGuid(),
                        Ma = txt_Ma.Text,
                        Ten = txt_Ten.Text,
                        TrangThai = rbtn_HD.Checked ? 1 : 0
                    };
                    MessageBox.Show(_IchucVuServices.Them(x));
                    LoadData();
                }
            }
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Sửa Chức Vụ Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                
                
                    ChucVuViewModels x = new ChucVuViewModels()
                    {
                        ID = _ID,
                        Ma = txt_Ma.Text,
                        Ten = txt_Ten.Text,
                        TrangThai = rbtn_HD.Checked ? 1 : 0
                    };
                    MessageBox.Show(_IchucVuServices.Sua(x));
                    LoadData();
                
            }
        }
        

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Chức Vụ Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                    MessageBox.Show(_IchucVuServices.Xoa(_ID));
                    LoadData();
                
            }
        }

        private void btn_LamMoi_Click_1(object sender, EventArgs e)
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";
            rbtn_HD.Text = "";
            rbtn_KHD.Text = "";

            //if (_ID != Guid.Empty)
            //{


            //    _chucvu = new ChucVu()
            //    {
            //        ID = Guid.NewGuid(),
            //        Ma = txt_Ma.Text,
            //        Ten = txt_Ten.Text,
            //        TrangThai = rbtn_HD.Checked ? 0 : 1,
            //    };

            //    if (_IchucVuServices.Xoa(_chucvu))
            //    {
            //        MessageBox.Show("Làm mới thành công");
            //        LoadData();
            //    }
            //}



        }

        private void dtg_ShowChucVu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            _ID = Guid.Parse(dtg_ShowChucVu.Rows[e.RowIndex].Cells[1].Value.ToString());
            txt_Ma.Text = dtg_ShowChucVu.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Ten.Text = dtg_ShowChucVu.Rows[e.RowIndex].Cells[3].Value.ToString();
            object cellValue = dtg_ShowChucVu.Rows[e.RowIndex].Cells[4].Value;
            if (cellValue != null && cellValue is string)
            {
                string trangThai = (string)cellValue;
                rbtn_HD.Checked = trangThai == "Hoạt động";
                rbtn_KHD.Checked = trangThai == "Không hoạt động";
            }
            //if (dtg_ShowChucVu.Rows[e.RowIndex].Cells[4].Value.ToString() == "hoat dong")
            //{
            //    rbtn_HD.Checked = true;
            //}
            //if (dtg_ShowChucVu.Rows[e.RowIndex].Cells[4].Value.ToString() == "khong hoat dong")
            //{
            //    rbtn_KHD.Checked = true;
            //}
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dtg_ShowChucVu.Rows.Clear();

            foreach (var item in _IchucVuServices.Getlst().Where(c => c.Ma.Contains(textBox1.Text)))
            {
                dtg_ShowChucVu.Rows.Add(item.ID, item.Ma, item.Ten, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }

        
    }
}
