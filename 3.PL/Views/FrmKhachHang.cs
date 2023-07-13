using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmKhachHang : Form
    {
        private IKhachHangServices _ikhachhang;
        private KhachHang _khachhang;
        private Guid _id;

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
                HovaTen = txt_Ma.Text,
                Diem = Convert.ToInt32(txt_Diem.Text),
                SDT = txt_sdt.Text,
                TrangThai = rbtn_HD.Checked ? 0 : 1,
            };
            if (_ikhachhang.AddKhachHang(_khachhang))
            {
                MessageBox.Show("Thêm khách hàng thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng không thành công");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_id == Guid.Empty)
            {
                return;
            }

            var khachHangs = _ikhachhang.GetAllKhachHang();
            var khachHang = khachHangs.FirstOrDefault(kh => kh.ID == _id);

            if (khachHang != null)
            {
                khachHang.HovaTen = txt_Ma.Text;
                khachHang.Diem = Convert.ToInt32(txt_Diem.Text);
                khachHang.SDT = txt_sdt.Text;

                if (_ikhachhang.EditKhachHang(khachHang))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_id != Guid.Empty)
            {
                _khachhang = new KhachHang()
                {
                    ID = _id,
                    HovaTen = txt_Ma.Text,
                    Diem = Convert.ToInt32(txt_Diem.Text),
                    SDT = txt_sdt.Text
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
            txt_Diem.Text = "";
            txt_Ma.Text = "";
            txt_sdt.Text = "";
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
                txt_Ma.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_Diem.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_sdt.Text = dtg_ShowKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();

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

        private void dtg_ShowKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex == dtg_ShowKhachHang.Columns["Trạng thái"].Index)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dtg_ShowKhachHang.Rows[e.RowIndex].Cells["Trạng thái"];
                checkBoxCell.Value = !(bool)checkBoxCell.Value;
                dtg_ShowKhachHang.EndEdit();
            }
        }
    }
}
