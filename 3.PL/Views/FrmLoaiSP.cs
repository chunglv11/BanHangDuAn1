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

namespace _3.PL.Views
{
    public partial class FrmLoaiSP : Form
    {
        private ILoaiSanPhamServices iLoaiSp;
        private PhanLoaiSpViewModels viewPhanLoai;
        public FrmLoaiSP()
        {
            InitializeComponent();
            iLoaiSp = new LoaiSanPhamServices();
            viewPhanLoai = new PhanLoaiSpViewModels();
            LoadData();
        }
        public void LoadData()
        {
            dtg_ShowLoaiSp.Rows.Clear();
            dtg_ShowLoaiSp.ColumnCount = 5;
            dtg_ShowLoaiSp.Columns[0].Name = "ID";
            dtg_ShowLoaiSp.Columns[0].Visible = false;
            dtg_ShowLoaiSp.Columns[1].Name = "Mã";
            dtg_ShowLoaiSp.Columns[2].Name = "Tên sản phẩm";
            dtg_ShowLoaiSp.Columns[3].Name = "Trạng thái";
            var LstLoaiSP = iLoaiSp.GetLoaiSP();
            if (txt_TimKiem.Text != "")
            {
                LstLoaiSP = LstLoaiSP.Where(x => x.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower())
                || x.Ten.ToString().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var item in LstLoaiSP)
            {
                dtg_ShowLoaiSp.Rows.Add(item.ID, item.Ma, item.Ten, item.TrangThai == 1 ? "Còn hàng" : "Ngừng hết hàng");
            }
            dtg_ShowLoaiSp.AllowUserToAddRows = false;
        }

        private void dtg_ShowLoaiSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvr = dtg_ShowLoaiSp.Rows[e.RowIndex];
                viewPhanLoai = iLoaiSp.GetLoaiSP().FirstOrDefault(x => x.ID == Guid.Parse(dgvr.Cells[0].Value.ToString()));
                txt_Ma.Text = viewPhanLoai.Ma;
                txt_Ten.Text = viewPhanLoai.Ten;
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

        private void dtg_ShowLoaiSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvr = dtg_ShowLoaiSp.Rows[e.RowIndex];
                viewPhanLoai = iLoaiSp.GetLoaiSP().FirstOrDefault(x => x.ID == Guid.Parse(dgvr.Cells[0].Value.ToString()));
                txt_Ma.Text = viewPhanLoai.Ma;
                txt_Ten.Text = viewPhanLoai.Ten;
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm Size Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int MaLoaiSp = iLoaiSp.GetLoaiSP().Count() + 1;
                if (iLoaiSp.GetLoaiSP().Any(c => c.Ma == txt_Ma.Text))
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
                    PhanLoaiSpViewModels x = new PhanLoaiSpViewModels()
                    {
                        ID = Guid.NewGuid(),
                        Ma = "LSP" + MaLoaiSp.ToString(),
                        Ten = txt_Ten.Text,
                        TrangThai = rbtn_HD.Checked ? 1 : 0
                    };
                    MessageBox.Show(iLoaiSp.add(x));
                    LoadData();

                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn sửa loại sản phẩm Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                viewPhanLoai.Ma = txt_Ma.Text;
                viewPhanLoai.Ten = txt_Ten.Text;
                viewPhanLoai.TrangThai = rbtn_HD.Checked ? 1 : 0;
                MessageBox.Show(iLoaiSp.update(viewPhanLoai));
                LoadData();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa loại sản phẩm Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (viewPhanLoai == null)
                {
                    MessageBox.Show("bạn chưa chọn loại");
                }
                else
                {
                    MessageBox.Show(iLoaiSp.remove(viewPhanLoai));
                    LoadData();
                }
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Guid _id = Guid.Empty;
            DataGridViewRow row = dtg_ShowLoaiSp.Rows[1];
            _id = Guid.Parse(row.Cells[1].Value.ToString());
            foreach (DataGridViewRow row1 in dtg_ShowLoaiSp.Rows)
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
