using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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
    public partial class FrmChatLieu : Form
    {
        private IChatLieuService _chatLieuService;
        private ChatLieuViewModels _chatLieuViewModels;
        public FrmChatLieu()
        {
            InitializeComponent();
            _chatLieuService = new ChatLieuService();
            _chatLieuViewModels = new ChatLieuViewModels();
            LoadData();
        }
        public void LoadData()
        {

            dtg_ShowCL.Rows.Clear();
            dtg_ShowCL.ColumnCount = 4;
            dtg_ShowCL.Columns[0].Name = "ID";
            dtg_ShowCL.Columns[0].Visible = false;
            dtg_ShowCL.Columns[1].Name = "Mã";
            dtg_ShowCL.Columns[2].Name = "Tên";
            dtg_ShowCL.Columns[3].Name = "Trạng thái";
            var lstsz = _chatLieuService.GetChatLieu();
            if (tb_Timkiem.Text != "")
            {
                lstsz = lstsz.Where(x => x.Ma.ToLower().Contains(tb_Timkiem.Text.ToLower())
                || x.Ten.ToString().Contains(tb_Timkiem.Text.ToLower())).ToList();
            }
            foreach (var item in lstsz)
            {
                dtg_ShowCL.Rows.Add(item.ID, item.Ma, item.Ten, item.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
            }
            dtg_ShowCL.AllowUserToAddRows = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm chất liệu Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int MaZise = _chatLieuService.GetChatLieu().Count() + 1;
                if (_chatLieuService.GetChatLieu().Any(c => c.Ma == txt_Ten.Text))
                {
                    MessageBox.Show("Mã bị trùng");
                }
                else if (string.IsNullOrWhiteSpace(txt_Ten.Text))
                {
                    MessageBox.Show("Tên size không được bỏ trống");
                }
                else if (rbtn_HD.Checked == false && rbtn_KHD.Checked == false)
                {

                    MessageBox.Show("Vui lòng chọn trạng thái");
                }
                else
                {
                    ChatLieuViewModels sz = new ChatLieuViewModels()
                    {
                        ID = Guid.NewGuid(),
                        Ma = "CL" + MaZise.ToString(),
                        Ten = txt_Ten.Text,
                        TrangThai = rbtn_HD.Checked ? 1 : 0
                    };
                    MessageBox.Show(_chatLieuService.add(sz));
                    LoadData();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn sửa chất liệu Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_Ten.Text))
                {
                    MessageBox.Show("Tên không được bỏ trống");
                }
                else
                {
                    _chatLieuViewModels.Ma = txt_Ma.Text;
                    _chatLieuViewModels.Ten = txt_Ten.Text;
                    _chatLieuViewModels.TrangThai = rbtn_HD.Checked ? 1 : 0;
                    MessageBox.Show(_chatLieuService.update(_chatLieuViewModels));
                    LoadData();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm chất liệu Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_chatLieuViewModels == null)
                {
                    MessageBox.Show("bạn chưa chọn chất liệu");
                }
                else
                {
                    MessageBox.Show(_chatLieuService.remove(_chatLieuViewModels));
                    LoadData();
                }
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Guid _id = Guid.Empty;
            DataGridViewRow row = dtg_ShowCL.Rows[0];
            _id = Guid.Parse(row.Cells[0].Value.ToString());
            foreach (DataGridViewRow row1 in dtg_ShowCL.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    _id = Guid.Empty;
                }
            }

            txt_Ma.Text = "";
            txt_Ten.Text = "";
            txt_TimKiem.Text = "";
            rbtn_HD.Checked = false;
            rbtn_KHD.Checked = false;
        }

        private void dtg_ShowCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvr = dtg_ShowCL.Rows[e.RowIndex];
                _chatLieuViewModels = _chatLieuService.GetChatLieu().FirstOrDefault(x => x.ID == Guid.Parse(dgvr.Cells[0].Value.ToString()));
                txt_Ma.Text = _chatLieuViewModels.Ma;
                txt_Ten.Text = _chatLieuViewModels.Ten;
                if (dgvr.Cells[3].Value.ToString() == "Còn hàng")
                {
                    rbtn_HD.Checked = true;
                }
                else
                {
                    rbtn_KHD.Checked = true;
                }
            }
        }

        private void tb_Timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
