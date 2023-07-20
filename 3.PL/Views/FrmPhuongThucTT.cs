using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
<<<<<<< Updated upstream
=======
using System.Linq;
>>>>>>> Stashed changes
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmPhuongThucTT : Form
    {
        private IPhuongThucThanhToanServices _iPhuongThucThanhToanServices;
        private PhuongThucThanhToan _phuongThucThanhToan;
        private Guid _id;

        public FrmPhuongThucTT()
        {
            InitializeComponent();
            _phuongThucThanhToan = new PhuongThucThanhToan();
            _iPhuongThucThanhToanServices = new PhuongThucThanhToanServices();
            LoadData();
<<<<<<< Updated upstream
=======
        }

        public void LoadData()
        {
            dtg_ShowChucVu.ColumnCount = 3;
            dtg_ShowChucVu.Columns[0].Name = "Id";
            dtg_ShowChucVu.Columns[0].Visible = false;
            dtg_ShowChucVu.Columns[1].Name = "Mã PT thanh toán";
            dtg_ShowChucVu.Columns[2].Name = "Tên PT thanh toán";

            dtg_ShowChucVu.Rows.Clear();
            foreach (var item in _iPhuongThucThanhToanServices.GetAllThanhToan())
            {
                dtg_ShowChucVu.Rows.Add(item.ID, item.MaPTThanhToan, item.TenPTThanhToan);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            _phuongThucThanhToan = new PhuongThucThanhToan()
            {
                ID = Guid.NewGuid(),
                MaPTThanhToan = txt_Ma.Text,
                TenPTThanhToan = txt_Ten.Text,
                TrangThai = rbtn_HD.Checked ? 0 : 1
            };

            if (_iPhuongThucThanhToanServices.AddThanhToan(_phuongThucThanhToan))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_id == Guid.Empty)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán cần chỉnh sửa");
                return;
            }

            var phuongThucThanhToan = _iPhuongThucThanhToanServices.GetAllThanhToan().FirstOrDefault(pttt => pttt.ID == _id);

            if (phuongThucThanhToan != null)
            {
                phuongThucThanhToan.MaPTThanhToan = txt_Ma.Text;
                phuongThucThanhToan.TenPTThanhToan = txt_Ten.Text;

                if (_iPhuongThucThanhToanServices.EditThanhToan(phuongThucThanhToan))
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
                MessageBox.Show("Không tìm thấy phương thức thanh toán");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá  không ?\", \"Thông báo\", MessageBoxButtons.YesNo, MessageBoxIcon.Question");
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dtg_ShowChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtg_ShowChucVu.Rows.Count)
            {
                _id = Guid.Parse(dtg_ShowChucVu.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_Ma.Text = dtg_ShowChucVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_Ten.Text = dtg_ShowChucVu.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            dtg_ShowChucVu.Rows.Clear();
            foreach (var item in _iPhuongThucThanhToanServices.GetAllThanhToan().Where(c => c.MaPTThanhToan.Contains(txt_TimKiem.Text)))
            {
                dtg_ShowChucVu.Rows.Add(item.ID, item.MaPTThanhToan, item.TenPTThanhToan);
            }
>>>>>>> Stashed changes
        }

        public void LoadData()
        {
            dtg_ShowChucVu.ColumnCount = 4;
            dtg_ShowChucVu.Columns[0].Name = "Id";
            dtg_ShowChucVu.Columns[0].Visible = false;
            dtg_ShowChucVu.Columns[1].Name = "Mã";
            dtg_ShowChucVu.Columns[2].Name = "Tên";
            dtg_ShowChucVu.Columns[3].Name = "Trạng thái";

            dtg_ShowChucVu.Rows.Clear();
            foreach (var item in _iPhuongThucThanhToanServices.GetAllThanhToan())
            {
                dtg_ShowChucVu.Rows.Add(item.ID, item.MaPTThanhToan, item.TenPTThanhToan, item.TrangThai);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            _phuongThucThanhToan = new PhuongThucThanhToan()
            {
                ID = Guid.NewGuid(),
                MaPTThanhToan = txt_Ma.Text,
                TenPTThanhToan = txt_Ten.Text,
                
            };

            if (_iPhuongThucThanhToanServices.AddThanhToan(_phuongThucThanhToan))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            _phuongThucThanhToan = new PhuongThucThanhToan()
            {
                ID = _id,
                MaPTThanhToan = txt_Ma.Text,
                TenPTThanhToan = txt_Ten.Text,
                
            };

            if (_iPhuongThucThanhToanServices.EditThanhToan(_phuongThucThanhToan))
            {
                MessageBox.Show("Cập nhật thành công");
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
                if (_iPhuongThucThanhToanServices.DeleteThanhToan(_phuongThucThanhToan))

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

        private void dtg_ShowChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _id = Guid.Parse(dtg_ShowChucVu.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_Ma.Text = dtg_ShowChucVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_Ten.Text = dtg_ShowChucVu.Rows[e.RowIndex].Cells[2].Value.ToString();
                
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            dtg_ShowChucVu.Rows.Clear();

            foreach (var item in _iPhuongThucThanhToanServices.GetAllThanhToan().Where(c => c.MaPTThanhToan.Contains(txt_TimKiem.Text)))
            {
                dtg_ShowChucVu.Rows.Add(item.ID, item.MaPTThanhToan, item.TenPTThanhToan, item.TrangThai);
            }
        }

        
    }
}
