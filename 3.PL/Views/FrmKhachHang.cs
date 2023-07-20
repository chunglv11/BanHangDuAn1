using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;

using System;

using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmKhachHang : Form
    {

        IKhachHangServices _ikhachhang;
        KhachHang _khachhang;
        Guid _id;

        public FrmKhachHang()
        {
            InitializeComponent();
            _khachhang = new KhachHang();
            _ikhachhang = new KhachHangServices();
            LoadData();

        }


        public void LoadData()
        {
            dtg_ShowKhachHang.ColumnCount = 5;
            dtg_ShowKhachHang.Columns[0].Name = "Id";
            dtg_ShowKhachHang.Columns[0].Visible = false;
            dtg_ShowKhachHang.Columns[1].Name = "Họ tên";
            dtg_ShowKhachHang.Columns[2].Name = "Điểm";
            dtg_ShowKhachHang.Columns[3].Name = "Số điện thoại";
            dtg_ShowKhachHang.Columns[4].Name = "Trạng thái";

            dtg_ShowKhachHang.Rows.Clear();
            foreach (var item in _ikhachhang.GetAllKhachHang())
            {

                string trangThai = item.TrangThai != null ? item.TrangThai.ToString() : ""; // Chuyển đổi kiểu int? sang string
                dtg_ShowKhachHang.Rows.Add(item.ID, item.HovaTen, item.Diem, item.SDT, trangThai);
            }
            dtg_ShowKhachHang.CellClick += dtg_ShowKhachHang_CellClick;
        }






        private void btn_Them_Click(object sender, EventArgs e)
        {
            _khachhang = new KhachHang()
            {
                ID = Guid.NewGuid(),

                HovaTen = txb_hoten.Text,
                Diem = Convert.ToInt32(txb_diem.Text),
                SDT = txb_sdt.Text,
                TrangThai = rbtn_HD.Checked ? 0 : 1,
            };
            if (_ikhachhang.AddKhachHang(_khachhang))
            {
                MessageBox.Show("Thêm khách hàng thành công");

            }


        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (_id == Guid.Empty)
            {
                return;
            }


            _khachhang = new KhachHang()
            {
                ID = Guid.NewGuid(),
                HovaTen = txb_hoten.Text,
                Diem = Convert.ToInt32(txb_diem.Text),
                SDT = txb_sdt.Text
            };
            if (_ikhachhang.EditKhachHang(_khachhang))
            {
                MessageBox.Show("Cập nhật thành công ");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_id != Guid.Empty)
            {
                _khachhang = new KhachHang()
                {
                    ID = _id,
                    HovaTen = txb_hoten.Text,
                    Diem = Convert.ToInt32(txb_diem.Text),
                    SDT = txb_sdt.Text
                };
                if (_ikhachhang.DeleteKhachHang(_khachhang))
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

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {

            txb_diem.Text = "";
            txb_hoten.Text = "";
            txb_sdt.Text = "";

        }

        private void dtg_ShowKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_ShowKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString());
            txb_hoten.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txb_diem.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txb_sdt.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dtg_ShowKhachHang.Rows.Clear();
            foreach (var item in _ikhachhang.GetAllKhachHang().Where(c => c.HovaTen.Contains(textBox2.Text)))
            {

                dtg_ShowKhachHang.Rows.Add(item.ID, item.HovaTen, item.Diem, item.SDT, item.TrangThai);
            }
        }

        private void dtg_ShowKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtg_ShowKhachHang.Rows.Count)
            {
                _id = Guid.Parse(dtg_ShowKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString());
                txb_hoten.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txb_diem.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txb_sdt.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();

                // Kiểm tra giá trị trạng thái từ ô checkbox
                object cellValue = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[4].Value;
                if (cellValue != null && cellValue is string)
                {
                    string trangThai = (string)cellValue;
                    rbtn_HD.Checked = trangThai == "Khách quen";
                    rbtn_KHD.Checked = trangThai == "Khách vãng lai";
                }
            }
        }

        //        private void dtg_ShowKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //        {
        //            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex == dtg_ShowKhachHang.Columns["Trạng thái"].Index)
        //            {
        //                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dtg_ShowKhachHang.Rows[e.RowIndex].Cells["Trạng thái"];
        //                checkBoxCell.Value = !(bool)checkBoxCell.Value;
        //                dtg_ShowKhachHang.EndEdit();
        //            }
        //=======
        //                dtg_ShowKhachHang.Rows.Add(item.HovaTen, item.Diem, item.SDT, item.TrangThai);

        //            }
        //        }


    }
}




