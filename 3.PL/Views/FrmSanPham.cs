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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmSanPham : Form
    {
        private ISanPhamServices iSp;
        private SanPhamViewModels viewSp;
        public FrmSanPham()
        {
            InitializeComponent();
            iSp = new SanPhamServices();
            viewSp = new SanPhamViewModels();
            LoadData();
        }
        public void LoadData()
        {
            dtg_ShowSanPham.Rows.Clear();
            dtg_ShowSanPham.ColumnCount = 4;
            dtg_ShowSanPham.Columns[0].Name = "ID";
            dtg_ShowSanPham.Columns[0].Visible = false;
            dtg_ShowSanPham.Columns[1].Name = "Mã";
            dtg_ShowSanPham.Columns[2].Name = "Tên sản phẩm";
            dtg_ShowSanPham.Columns[3].Name = "Trạng thái";
            var lstSp = iSp.getlsSpfromDB();
            if (txt_TimKiem.Text != "")
            {
                lstSp = lstSp.Where(x => x.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower())
                || x.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var item in lstSp)
            {
                dtg_ShowSanPham.Rows.Add(item.ID, item.Ma, item.Ten, item.TrangThai == 1 ? "Còn sản phẩm" : "Hết sản phẩm");
            }
            dtg_ShowSanPham.AllowUserToAddRows = false;
        }

        private void dtg_ShowSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvr = dtg_ShowSanPham.Rows[e.RowIndex];
                viewSp = iSp.getlsSpfromDB().FirstOrDefault(x => x.ID == Guid.Parse(dgvr.Cells[0].Value.ToString()));
                txt_Ma.Text = viewSp.Ma;
                txt_Ten.Text = viewSp.Ten;
                if (dgvr.Cells[3].Value.ToString() == "Còn sản phẩm")
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
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm Sản Phẩm Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (iSp.getlsSpfromDB().Any(c => c.Ma == txt_Ma.Text))
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
                    SanPhamViewModels x = new SanPhamViewModels()
                    {
                        ID = Guid.NewGuid(),
                        Ma = txt_Ma.Text,
                        Ten = txt_Ten.Text,
                        TrangThai = rbtn_HD.Checked ? 1 : 0
                    };
                    MessageBox.Show(iSp.add(x));
                    LoadData();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Sửa Sản Phẩm Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                viewSp.Ma = txt_Ma.Text;
                viewSp.Ten = txt_Ten.Text;
                viewSp.TrangThai = rbtn_HD.Checked ? 1 : 0;
                MessageBox.Show(iSp.update(viewSp));
                LoadData();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Sản Phẩm Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (viewSp == null)
                {
                    MessageBox.Show("bạn chưa chọn nsx");
                }
                else
                {
                    MessageBox.Show(iSp.remove(viewSp));
                    LoadData();
                }
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtg_ShowSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvr = dtg_ShowSanPham.Rows[e.RowIndex];
                viewSp = iSp.getlsSpfromDB().FirstOrDefault(x => x.ID == Guid.Parse(dgvr.Cells[0].Value.ToString()));
                txt_Ma.Text = viewSp.Ma;
                txt_Ten.Text = viewSp.Ten;
                if (dgvr.Cells[3].Value.ToString() == "Còn sản phẩm")
                {
                    rbtn_HD.Checked = true;
                }
                else
                {
                    rbtn_KHD.Checked = true;
                }
            }
        }
    }
}
