using _2.BUS.IServices;
using _2.BUS.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3.PL.Views
{
    public partial class FrmDoiMK : Form
    {
        INhanVienServices _nhanVienServices;
        public FrmDoiMK()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
        }
        string email = FrmQuenMK.to;
        private void btn_Xacnhan_Click(object sender, EventArgs e)
        {
            Guid idRole = _nhanVienServices.GetAllView().FirstOrDefault(x => x.Username == Properties.Settings.Default.TKdaLogin).ID;
            var id = _nhanVienServices.GetAllView().FirstOrDefault(p => p.ID == idRole);
            if (tb_mkc.Text != id.MatKhau)
            {
                MessageBox.Show("Sai mật khẩu vui lòng nhập lại");
            }
            else if (tb_pass.Text != tb_nhaplai.Text)
            {
                MessageBox.Show("Sai mật khẩu mới vui lòng nhập lại");
            }
            else
            {
                var p = _nhanVienServices.GetAll().FirstOrDefault(p => p.ID == idRole);
                p.MatKhau = tb_pass.Text;
                _nhanVienServices.Update(p);
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }


        }

    }
}
