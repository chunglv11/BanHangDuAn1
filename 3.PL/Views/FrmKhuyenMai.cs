using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System.Data;

namespace _3.PL.Views
{
    public partial class FrmKhuyenMai : Form
    {
        public IKhuyenMaiServices _iKmServices;
        public IHoaDonServices _iHoaDonServices;

        private Guid _ID;
        public FrmKhuyenMai()
        {
            InitializeComponent();
            _iKmServices = new KhuyenMaiServices();
            _iHoaDonServices = new HoaDonServices();
            tb_PhanTramGiam.Text = "0";
            tb_SoTienGiam.Text = "0";
            LoadData(_iKmServices.GetAllView());
        }
        public void LoadData(List<KhuyenMaiVM> khuyenMaiVMs)
        {
            int stt = 1;
            dtg_ShowKM.ColumnCount = 9;
            dtg_ShowKM.ColumnCount = 9;
            dtg_ShowKM.Columns[0].Name = "stt";
            dtg_ShowKM.Columns[1].Name = "id";
            dtg_ShowKM.Columns[2].Name = "mã khuyến mãi";
            dtg_ShowKM.Columns[3].Name = "tên  ";
            dtg_ShowKM.Columns[4].Name = "% giảm giá";
            dtg_ShowKM.Columns[5].Name = "số tiền giảm";
            dtg_ShowKM.Columns[6].Name = "ngày bắt đầu";
            dtg_ShowKM.Columns[7].Name = "ngày kết thúc";
            dtg_ShowKM.Columns[8].Name = "trạng thái";
            dtg_ShowKM.Rows.Clear();
            dtg_ShowKM.Columns[1].Visible = false;
            foreach (KhuyenMaiVM a in khuyenMaiVMs)
            {
                _ = dtg_ShowKM.Rows.Add(stt++, a.KhuyenMai.ID, a.KhuyenMai.Ma, a.KhuyenMai.Ten, a.KhuyenMai.PhanTramGiam,
                    a.KhuyenMai.SoTienGiam, a.KhuyenMai.NgayBatDau, a.KhuyenMai.NgayKetThuc,
                    a.KhuyenMai.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }
        }

        public KhuyenMai GetvaluaContro()
        {
            return new KhuyenMai()
            {
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                PhanTramGiam = int.Parse(tb_PhanTramGiam.Text),
                SoTienGiam = float.Parse(tb_SoTienGiam.Text),
                NgayBatDau = dtp_NgayBD.Value,
                NgayKetThuc = dtp_NgayKT.Value,
                TrangThai = rbtn_HD.Checked == true ? 1 : 0,
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                float giamGia = Convert.ToSingle(tb_PhanTramGiam.Text);
                float tienKhachDua = Convert.ToSingle(tb_SoTienGiam.Text);
                ;
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                return;
            }

            try
            {
                if (dtp_NgayKT.Value < dtp_NgayBD.Value)
                {
                    _ = MessageBox.Show("Kiểm tra lại lịch");
                    return;
                }


                if (int.Parse(tb_PhanTramGiam.Text) is < 0 or > 100)
                {
                    _ = MessageBox.Show("Kiểm tra lại số %");
                    return;
                }

                if (txt_Ma.Text == null || txt_Ten.Text == null || tb_PhanTramGiam.Text == null || tb_SoTienGiam.Text == null)
                {
                    _ = MessageBox.Show("Kiểm tra lại thong tin nhập");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {


                    _ = _iKmServices.Add(GetvaluaContro());
                    LoadData(_iKmServices.GetAllView());

                }
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Đã tồn tại hãy kiểm tra lại");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtp_NgayKT.Value < dtp_NgayBD.Value)
                {
                    _ = MessageBox.Show("Kiểm tra lại lịch");
                    return;
                }
                if (int.Parse(tb_PhanTramGiam.Text) is < 0 or > 100)
                {
                    _ = MessageBox.Show("Kiểm tra lại số %");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool thongBao = _iKmServices.Update(new _1.DAL.Models.KhuyenMai()
                    {
                        ID = _ID,
                        Ma = txt_Ma.Text,
                        Ten = txt_Ten.Text,
                        PhanTramGiam = int.Parse(tb_PhanTramGiam.Text),
                        SoTienGiam = float.Parse(tb_SoTienGiam.Text),
                        NgayBatDau = dtp_NgayBD.Value,
                        NgayKetThuc = dtp_NgayKT.Value,
                        TrangThai = rbtn_HD.Checked == true ? 1 : 0
                    });
                    if (thongBao)
                    {
                        _ = MessageBox.Show("Sửa thành công");
                        LoadData(_iKmServices.GetAllView());
                    }
                }
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool thongBao = _iKmServices.Delete(_iKmServices.GetAll().Find(c => c.ID == _ID));

                    if (thongBao)
                    {
                        _ = MessageBox.Show("Xóa thành công");
                        LoadData(_iKmServices.GetAllView());
                    }
                }
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            dtg_ShowKM.Rows.Clear();
            LoadData(_iKmServices.GetAllView());
        }

        private void dtg_ShowKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                _ID = Guid.Parse(dtg_ShowKM.Rows[index].Cells[1].Value.ToString());
                txt_Ma.Text = dtg_ShowKM.Rows[index].Cells[2].Value.ToString();
                txt_Ten.Text = dtg_ShowKM.Rows[index].Cells[3].Value.ToString();
                tb_PhanTramGiam.Text = dtg_ShowKM.Rows[index].Cells[4].Value.ToString();
                tb_SoTienGiam.Text = dtg_ShowKM.Rows[index].Cells[5].Value.ToString();
                dtp_NgayBD.Value = DateTime.Parse(dtg_ShowKM.Rows[index].Cells[6].Value.ToString());
                dtp_NgayKT.Value = DateTime.Parse(dtg_ShowKM.Rows[index].Cells[7].Value.ToString());
                if (dtg_ShowKM.Rows[index].Cells[8].Value.ToString() == "hoat dong")
                {
                    rbtn_HD.Checked = true;
                }
                if (dtg_ShowKM.Rows[index].Cells[8].Value.ToString() == "khong hoat dong")
                {
                    rbtn_KHD.Checked = true;
                }
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(_iKmServices.GetAllView().Where(c => c.KhuyenMai.Ma.ToLower().Contains(txt_TimKiem.Text.ToLower()) ||
                    c.KhuyenMai.Ten.ToLower().Contains(txt_TimKiem.Text.ToLower())).ToList());
        }

        private void dtp_Loc_ValueChanged(object sender, EventArgs e)
        {
            LoadData(_iKmServices.GetAllView().FindAll(c => c.KhuyenMai.NgayKetThuc == dtp_Loc.Value ||
                    c.KhuyenMai.NgayBatDau == dtp_Loc.Value).ToList());
        }
    }
}
