using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class FrmChucVu : Form
    {
        public IChucVuServices _IchucVuServices;
        private Guid _ID;


        public FrmChucVu()
        {
            _IchucVuServices = new ChucVuServices();
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            int stt = 1;
            dtg_ShowChucVu.ColumnCount = 5;
            dtg_ShowChucVu.Columns[0].Name = "stt";
            dtg_ShowChucVu.Columns[1].Name = "id";
            dtg_ShowChucVu.Columns[2].Name = "ma";
            dtg_ShowChucVu.Columns[3].Name = "ten";
            dtg_ShowChucVu.Columns[4].Name = "trang thai";
            dtg_ShowChucVu.Rows.Clear();
            dtg_ShowChucVu.Columns[1].Visible = true;
            foreach (var a in _IchucVuServices.GetAll())
            {
                _ = dtg_ShowChucVu.Rows.Add(stt++, a.ID, a.Ma, a.Ten, a.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }
        public ChucVu GetvaluaContro()
        {
            return new ChucVu()
            {
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                TrangThai = rbtn_HD.Checked == true ? 1 : 0,
            };
        }

        private void dtg_ShowChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dtg_ShowChucVu.Rows[index].Cells[1].Value.ToString());
            txt_Ma.Text = dtg_ShowChucVu.Rows[index].Cells[2].Value.ToString();
            txt_Ten.Text = dtg_ShowChucVu.Rows[index].Cells[3].Value.ToString();
            if (dtg_ShowChucVu.Rows[index].Cells[4].Value.ToString() == "hoat dong")
            {
                rbtn_HD.Checked = true;
            }
            if (dtg_ShowChucVu.Rows[index].Cells[4].Value.ToString() == "khong hoat dong")
            {
                rbtn_KHD.Checked = true;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            _ = _IchucVuServices.Them(GetvaluaContro());
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            _ = _IchucVuServices.Sua(GetvaluaContro());
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            _ = _IchucVuServices.Xoa(GetvaluaContro());
            LoadData();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            int stt = 1;
            dtg_ShowChucVu.ColumnCount = 5;
            dtg_ShowChucVu.Columns[0].Name = "";
            dtg_ShowChucVu.Columns[1].Name = "";
            dtg_ShowChucVu.Columns[2].Name = "";
            dtg_ShowChucVu.Columns[3].Name = "";
            dtg_ShowChucVu.Columns[4].Name = "";
            dtg_ShowChucVu.Rows.Clear();
            dtg_ShowChucVu.Columns[1].Visible = true;
            foreach (var a in _IchucVuServices.GetAll())
            {
                _ = dtg_ShowChucVu.Rows.Add(stt++, a.ID, a.Ma, a.Ten, a.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtg_ShowChucVu.Rows.Clear();

            foreach (var item in _IchucVuServices.GetAll().Where(c => c.Ma.Contains(textBox1.Text)))
            {
                dtg_ShowChucVu.Rows.Add(item.ID, item.Ma, item.Ten, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
    }
}
