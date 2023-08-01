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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmKichCo : Form
    {
        private IKichThuocServices kichThuocServices;
        private KichThuocViewModels kichThuocViewModels;
        public FrmKichCo()
        {
            InitializeComponent();
            kichThuocViewModels = new KichThuocViewModels();
            kichThuocServices = new KichThuocServices();
            LoadData();

        }
        public void LoadData()
        {

            dtg_ShowKichCo.Rows.Clear();
            dtg_ShowKichCo.ColumnCount = 4;
            dtg_ShowKichCo.Columns[0].Name = "ID";
            dtg_ShowKichCo.Columns[0].Visible = false;
            dtg_ShowKichCo.Columns[1].Name = "Mã";
            dtg_ShowKichCo.Columns[2].Name = "Tên";
            dtg_ShowKichCo.Columns[3].Name = "Trạng thái";
            var lstsz = kichThuocServices.GetSizeAo();
            if (txt_TimKiem.Text != "")
            {
                lstsz = lstsz.Where(x => x.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower())
                || x.Ten.ToString().Contains(txt_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var item in lstsz)
            {
                dtg_ShowKichCo.Rows.Add(item.ID, item.Ma, item.Ten, item.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
            }
            dtg_ShowKichCo.AllowUserToAddRows = false;
        }

        private void dtg_ShowKichCo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvr = dtg_ShowKichCo.Rows[e.RowIndex];
                kichThuocViewModels = kichThuocServices.GetSizeAo().FirstOrDefault(x => x.ID == Guid.Parse(dgvr.Cells[0].Value.ToString()));
                txt_Ma.Text = kichThuocViewModels.Ma;
                txt_Ten.Text = kichThuocViewModels.Ten;
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
                int MaZise = kichThuocServices.GetSizeAo().Count() + 1;
                if (kichThuocServices.GetSizeAo().Any(c => c.Ma == txt_Ten.Text))
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
                    KichThuocViewModels sz = new KichThuocViewModels()
                    {
                        ID = Guid.NewGuid(),
                        Ma = "KT"+MaZise.ToString(),
                        Ten = txt_Ten.Text,
                        TrangThai = rbtn_HD.Checked ? 1 : 0
                    };
                    MessageBox.Show(kichThuocServices.add(sz));
                    LoadData();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Sửa Size Không?", "Thông Báo", MessageBoxButtons.YesNo);
            //if (DialogResult.Yes == DialogResult)
            //{
            //    kichThuocViewModels.Ma = txt_Ma.Text;
            //    kichThuocViewModels.Ten = txt_Ten.Text;
            //    kichThuocViewModels.TrangThai = rbtn_HD.Checked ? 1 : 0;
            //    MessageBox.Show(kichThuocServices.update(kichThuocViewModels));
            //    LoadData();
            //}




            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Sửa Size Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == DialogResult)
            {
                kichThuocViewModels.Ma = txt_Ma.Text;
                kichThuocViewModels.Ten = txt_Ten.Text;
                kichThuocViewModels.TrangThai = rbtn_HD.Checked ? 1 : 0;
                MessageBox.Show(kichThuocServices.update(kichThuocViewModels));
                LoadData();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thêm Size Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (kichThuocViewModels == null)
                {
                    MessageBox.Show("bạn chưa chọn size");
                }
                else
                {
                    MessageBox.Show(kichThuocServices.remove(kichThuocViewModels));
                    LoadData();
                }
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Guid _id = Guid.Empty;
            DataGridViewRow row = dtg_ShowKichCo.Rows[0];
            _id = Guid.Parse(row.Cells[0].Value.ToString());
            foreach (DataGridViewRow row1 in dtg_ShowKichCo.Rows)
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
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
