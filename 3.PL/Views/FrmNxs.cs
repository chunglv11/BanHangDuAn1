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
    public partial class FrmNxs : Form
    {
        private INSXServices insx;
        private NsxViewModels viewnsx;
        public FrmNxs()
        {
            InitializeComponent();
            insx = new NSXServices();
            viewnsx = new NsxViewModels();
            loadData();
        }
        public void loadData()
        {
            dtg_ShowNsx.Rows.Clear();
            dtg_ShowNsx.ColumnCount = 4;
            dtg_ShowNsx.Columns[0].Name = "ID";
            dtg_ShowNsx.Columns[0].Visible = false;
            dtg_ShowNsx.Columns[1].Name = "Mã";
            dtg_ShowNsx.Columns[2].Name = "Tên nhà sản xuất";
            dtg_ShowNsx.Columns[3].Name = "Trạng thái";
            var lstnssx = insx.GetNhasanxuat();
            if (txt_TimKiem.Text != "")
            {
                lstnssx = lstnssx.Where(x => x.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower())
                || x.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var item in lstnssx)
            {
                dtg_ShowNsx.Rows.Add(item.ID, item.Ma, item.Ten, item.TrangThai == 1 ? "Còn sản xuất" : "Ngừng sản xuất");
            }
            dtg_ShowNsx.AllowUserToAddRows = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm Size Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int MaNsx = insx.GetNhasanxuat().Count() + 1;
                if (insx.GetNhasanxuat().Any(c => c.Ma == txt_Ma.Text))
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
                    NsxViewModels x = new NsxViewModels()
                    {
                        ID = Guid.NewGuid(),
                        Ma = "NSX"+MaNsx.ToString(),
                        Ten = txt_Ten.Text,
                        TrangThai = rbtn_HD.Checked ? 1 : 0
                    };
                    MessageBox.Show(insx.add(x));
                    loadData();
                }
            }
        }

        private void dtg_ShowNsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvr = dtg_ShowNsx.Rows[e.RowIndex];
                viewnsx = insx.GetNhasanxuat().FirstOrDefault(x => x.ID == Guid.Parse(dgvr.Cells[0].Value.ToString()));
                txt_Ma.Text = viewnsx.Ma;
                txt_Ten.Text = viewnsx.Ten;
                if (dgvr.Cells[3].Value.ToString() == "Còn sản xuất")
                {
                    rbtn_HD.Checked = true;
                }
                else
                {
                    rbtn_KHD.Checked = true;
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Sửa Nhà Sản Xuất Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                viewnsx.Ma = txt_Ma.Text;
                viewnsx.Ten = txt_Ten.Text;
                viewnsx.TrangThai = rbtn_HD.Checked ? 1 : 0;
                MessageBox.Show(insx.update(viewnsx));
                loadData();
            }
        }



        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Nhà Sản Xuất Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (viewnsx == null)
                {
                    MessageBox.Show("bạn chưa chọn nsx");
                }
                else
                {
                    MessageBox.Show(insx.remove(viewnsx));
                    loadData();
                }
            }
        }
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Guid _id = Guid.Empty;
            DataGridViewRow row = dtg_ShowNsx.Rows[0];
            _id = Guid.Parse(row.Cells[0].Value.ToString());
            foreach (DataGridViewRow row1 in dtg_ShowNsx.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    _id = Guid.Empty;
                }
            }

            txt_Ma.Text="";
            txt_Ten.Text="";
            txt_TimKiem.Text="";
            rbtn_HD.Checked = false;
            rbtn_KHD.Checked = false;
        }
    }
}
