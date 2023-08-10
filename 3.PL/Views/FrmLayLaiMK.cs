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

namespace _3.PL.Views
{
    public partial class FrmLayLaiMK : Form
    {
        public FrmLayLaiMK()
        {
            InitializeComponent();
        }
        string email = FrmQuenMK.to;



        private void button1_Click(object sender, EventArgs e)
        {
            string password = tb_pass.Text;
            if (password == tb_nhaplai.Text)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AKSDRER\MOMO;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True;TrustServerCertificate=True;");
                string q = @"UPDATE [dbo].[NhanVien] set [MatKhau]='" + password + "' where Email='" + email + "'";

                SqlCommand cmd = new SqlCommand(q, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Mật khẩu đã được thay đổi thành công");
                this.Close();
                FrmDangNhap frmDangNhap = new FrmDangNhap();
                frmDangNhap.Show();

            }
            else
            {
                MessageBox.Show("Xin lỗi Mật khẩu mới và Mật khẩu xác nhận của bạn không khớp");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuenMK frmquenmk = new FrmQuenMK();
            frmquenmk.ShowDialog();
        }

        private void FrmLayLaiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
