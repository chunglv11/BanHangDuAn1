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
        public FrmDoiMK()
        {
            InitializeComponent();
        }
        //string Username = FrmQuenMK.to;

        //private void btn_Xacnhan_Click(object sender, EventArgs e)
        //{
        //    string password = tb_pass.Text;
        //    if (tb_pass.Text == tb_nhaplai.Text)
        //    {
        //        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-Q3TF2SAN\SQLEXPRESS;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True;TrustServerCertificate=True;");
        //        string q = @"UPDATE [dbo].[NhanVien] set [MatKhau]='" + password + "' where Email='" + Username + "'";

        //        SqlCommand cmd = new SqlCommand(q, conn);
        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //        conn.Close();

        //        MessageBox.Show("Mật khẩu đã được thay đổi thành công");
        //        this.Close();
        //        FrmDangNhap frmDangNhap = new FrmDangNhap();
        //        frmDangNhap.Show();

        //    }
        //    else
        //    {
        //        MessageBox.Show("Xin lỗi Mật khẩu mới và Mật khẩu xác nhận của bạn không khớp");
        //    }
        //}
    }
}
