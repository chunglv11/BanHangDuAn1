using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3.PL.Views
{
    public partial class FrmQuenMK : Form
    {
        string randomcode;
        public static string to;
        public FrmQuenMK()
        {
            InitializeComponent();
        }

        //private string GenerateRandomOTP(int iOTPLength, string[] saAllowedCharacters)

        //{

        //    string sOTP = String.Empty;

        //    string sTempChars = String.Empty;

        //    Random rand = new Random();

        //    for (int i = 0; i < iOTPLength; i++)

        //    {

        //        int p = rand.Next(0, saAllowedCharacters.Length);

        //        sTempChars = saAllowedCharacters[rand.Next(0, saAllowedCharacters.Length)];

        //        sOTP += sTempChars;

        //    }

        //    return sOTP;

        //}
        //Random random = new Random();
        //string otp = "";

        private void btn_LayMa_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (tb_Gmail.Text).ToString();
            from = "laichung2003@gmail.com";
            pass = "mqmpwffahlvuwygg";
            messagebody = $" mã otp của bạn là {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = " mã đổi mật khẩu ";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show(" mã đã được gửi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }










            //try
            //{
            //    string[] saAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            //    string sRandomOTP = GenerateRandomOTP(8, saAllowedCharacters);
            //    otp = sRandomOTP;
            //    var formAddress = new MailAddress("tranbach241203@gmail.com");
            //    var toAddress = new MailAddress(tb_Gmail.ToString());
            //    const string passMail = "Bach24122003";
            //    const string subject = "OTP Code";
            //    string body = sRandomOTP.ToString();
            //    var smtp = new SmtpClient()
            //    {
            //        Host = "smtp.gmail.com",
            //        Port = 587,
            //        EnableSsl = true, //smtp.EnableSsl có nghĩa là gửi có bảo mật 
            //        DeliveryMethod = SmtpDeliveryMethod.Network,
            //        UseDefaultCredentials = false,  // sử dụng thông tin đăng nhập mặc định
            //        Credentials = new NetworkCredential(formAddress.Address, passMail),
            //        Timeout = 20000
            //    };
            //    using (var mess = new MailMessage(formAddress, toAddress)
            //    {
            //        Subject = subject,
            //        Body = body,
            //    })
            //    {
            //        smtp.Send(mess);
            //    }
            //    MessageBox.Show("OTP đã được gửi qua mail của bạn \n Vui Lòng Kiểm Tra Mail của bạn ");

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (randomcode == (tbOTP.Text).ToString())
            {
                to = tb_Gmail.Text;
                MessageBox.Show("Xác Thực Thành Công");
                this.Hide();
                FrmDoiMK frmLayLaiMK = new FrmDoiMK();
                frmLayLaiMK.ShowDialog();
            }
            else MessageBox.Show("Mã OTP không chính xác");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap frmdangnhap = new FrmDangNhap();
            frmdangnhap.ShowDialog();
        }

        //private void tbOTP_TextChanged(object sender, EventArgs e)
        //{
        //    if (otp.ToString().Equals(tbOTP.Text))
        //    {
        //        to = tb_Gmail.Text;
        //        MessageBox.Show("Xác Thực Thành Công");
        //        this.Hide();
        //        FrmDoiMK frmDoiMK = new FrmDoiMK();
        //        frmDoiMK.ShowDialog();
        //    }
        //    else MessageBox.Show("Mã OTP không chính xác");
        //}
    }
}
