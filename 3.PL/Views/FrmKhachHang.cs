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
                dtg_ShowKhachHang.Rows.Add(item.ID, item.HovaTen, item.Diem, item.SDT, item.TrangThai == 1 ? "Khách quen" : "Khách vãng lai");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            _khachhang = new KhachHang()
            {
                ID = Guid.NewGuid(),

                HovaTen = txb_hoten.Text,
                Diem = Convert.ToInt32(txb_diem.Text),
                SDT = txb_sdt.Text,
                TrangThai = rbtn_Vang.Checked ? 0 : 1,
            };
            if (_ikhachhang.AddKhachHang(_khachhang))
            {
                MessageBox.Show("Thêm khách hàng thành công");
                LoadData();
            }


        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật khách hàng không?", "Chú ý", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _khachhang.HovaTen = txb_hoten.Text;
                _khachhang.Diem = Convert.ToInt32(txb_diem.Text);
                _khachhang.SDT = txb_sdt.Text;
                _khachhang.TrangThai = rbtn_Quen.Checked ? 1 : 0;
                _ikhachhang.EditKhachHang(_khachhang);
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

            _id = Guid.Parse(dtg_ShowKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString());
            txb_hoten.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txb_diem.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txb_sdt.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            rbtn_Vang.Checked = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString() == "Khách vãng lai" ? true : false;
            rbtn_Quen.Checked = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString() == "Khách quen" ? true : false;

        }

    }
}




