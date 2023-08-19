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
    public partial class FrmMauSac : Form
    {

        private IMauSacServices iMauSac;
        private MauSacViewModels viewMs;
        public FrmMauSac()
        {
            InitializeComponent();
            iMauSac = new MauSacServices();
            viewMs = new MauSacViewModels();
            LoadData();
        }
        public void LoadData()
        {
            dtg_ShowMauSac.Rows.Clear();
            dtg_ShowMauSac.ColumnCount = 4;
            dtg_ShowMauSac.Columns[0].Name = "ID";
            dtg_ShowMauSac.Columns[0].Visible = false;
            dtg_ShowMauSac.Columns[1].Name = "Mã";
            dtg_ShowMauSac.Columns[2].Name = "Tên Màu sắc";
            dtg_ShowMauSac.Columns[3].Name = "Trạng thái";
            var lstnssx = iMauSac.GetMauSac();
            if (txt_TimKiem.Text != "")
            {
                lstnssx = lstnssx.Where(x => x.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower())
                || x.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var item in lstnssx)
            {
                dtg_ShowMauSac.Rows.Add(item.ID, item.Ma, item.Ten, item.TrangThai == 1 ? "Còn màu" : "Hết màu");
            }
            dtg_ShowMauSac.AllowUserToAddRows = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm Màu Sắc Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (iMauSac.GetMauSac().Any(c => c.Ma == txt_Ma.Text))
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
                    MauSacViewModels x = new MauSacViewModels()
                    {
                        ID = Guid.NewGuid(),
                        Ma = txt_Ma.Text,
                        Ten = txt_Ten.Text,
                        TrangThai = rbtn_HD.Checked ? 1 : 0
                    };
                    MessageBox.Show(iMauSac.add(x));
                    LoadData();
                }
            }
        }

        private void dtg_ShowMauSac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvr = dtg_ShowMauSac.Rows[e.RowIndex];
                viewMs = iMauSac.GetMauSac().FirstOrDefault(x => x.ID == Guid.Parse(dgvr.Cells[0].Value.ToString()));
                txt_Ma.Text = viewMs.Ma;
                txt_Ten.Text = viewMs.Ten;
                if (dgvr.Cells[3].Value.ToString() == "Còn màu")
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
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Sửa Màu Sắc Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txt_Ten.Text))
                {
                    MessageBox.Show("Tên không được bỏ trống");
                }
                else
                {
                    viewMs.Ma = txt_Ma.Text;
                    viewMs.Ten = txt_Ten.Text;
                    viewMs.TrangThai = rbtn_HD.Checked ? 1 : 0;
                    MessageBox.Show(iMauSac.update(viewMs));
                    LoadData();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Màu Sắc Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (viewMs == null)
                {
                    MessageBox.Show("bạn chưa chọn màu sắc");
                }
                else
                {
                    MessageBox.Show(iMauSac.remove(viewMs));
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
            DataGridViewRow row = dtg_ShowMauSac.Rows[0];
            _id = Guid.Parse(row.Cells[0].Value.ToString());
            foreach (DataGridViewRow row1 in dtg_ShowMauSac.Rows)
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
    }
}
