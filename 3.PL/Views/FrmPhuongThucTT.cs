using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;

using System.Linq;

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

        }

        public void LoadData()
        {
            dtg_ShowChucVu.ColumnCount = 4;
            dtg_ShowChucVu.Columns[0].Name = "Id";
            dtg_ShowChucVu.Columns[0].Visible = false;
            dtg_ShowChucVu.Columns[1].Name = "Mã PT thanh toán";
            dtg_ShowChucVu.Columns[2].Name = "Tên PT thanh toán";
            dtg_ShowChucVu.Columns[3].Name = "Trạng thái";

            dtg_ShowChucVu.Rows.Clear();
            foreach (var item in _iPhuongThucThanhToanServices.GetAllThanhToan())
            {
                dtg_ShowChucVu.Rows.Add(item.ID, item.MaPTThanhToan, item.TenPTThanhToan, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }




        private bool checknhap()
        {
            if (txt_Ma.Text == "" || txt_Ten.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else
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

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật PTTT không?", "Chú ý", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    _phuongThucThanhToan.TenPTThanhToan = txt_Ten.Text;
                    _phuongThucThanhToan.MaPTThanhToan = txt_Ma.Text;
                    _phuongThucThanhToan.TrangThai = rbtn_HD.Checked ? 1 : 0;
                    _iPhuongThucThanhToanServices.EditThanhToan(_phuongThucThanhToan);
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                }
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
            DataGridViewRow r = dtg_ShowChucVu.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                _phuongThucThanhToan = _iPhuongThucThanhToanServices.GetAllThanhToan().FirstOrDefault(c => c.ID.ToString() == r.Cells[0].Value.ToString());
                txt_Ma.Text = dtg_ShowChucVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_Ten.Text = dtg_ShowChucVu.Rows[e.RowIndex].Cells[2].Value.ToString();
                rbtn_HD.Checked = dtg_ShowChucVu.Rows[e.RowIndex].Cells[3].Value.ToString() == "Hoạt động" ? true : false;
                rbtn_KHD.Checked = dtg_ShowChucVu.Rows[e.RowIndex].Cells[3].Value.ToString() == "Không hoạt động" ? true : false;
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
