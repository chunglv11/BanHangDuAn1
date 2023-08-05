namespace _3.PL.Views
{
    partial class FrmQuenMK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_Gmail = new TextBox();
            btn_LayMa = new Button();
            tbOTP = new TextBox();
            btn_XacNhan = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // tb_Gmail
            // 
            tb_Gmail.Location = new Point(55, 24);
            tb_Gmail.Name = "tb_Gmail";
            tb_Gmail.PlaceholderText = "Nhập gmail tài khoản";
            tb_Gmail.Size = new Size(591, 27);
            tb_Gmail.TabIndex = 0;
            // 
            // btn_LayMa
            // 
            btn_LayMa.Location = new Point(55, 80);
            btn_LayMa.Name = "btn_LayMa";
            btn_LayMa.Size = new Size(147, 41);
            btn_LayMa.TabIndex = 1;
            btn_LayMa.Text = "Lấy mã OTP";
            btn_LayMa.UseVisualStyleBackColor = true;
            btn_LayMa.Click += btn_LayMa_Click;
            // 
            // tbOTP
            // 
            tbOTP.Location = new Point(55, 172);
            tbOTP.Name = "tbOTP";
            tbOTP.PlaceholderText = "Điền OTP";
            tbOTP.Size = new Size(591, 27);
            tbOTP.TabIndex = 2;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Location = new Point(55, 250);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(147, 41);
            btn_XacNhan.TabIndex = 3;
            btn_XacNhan.Text = "Xác nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            btn_XacNhan.Click += btn_XacNhan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(417, 262);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Trở lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmQuenMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 358);
            Controls.Add(button1);
            Controls.Add(btn_XacNhan);
            Controls.Add(tbOTP);
            Controls.Add(btn_LayMa);
            Controls.Add(tb_Gmail);
            Name = "FrmQuenMK";
            Text = "FrmQuenMK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Gmail;
        private Button btn_LayMa;
        private TextBox tbOTP;
        private Button btn_XacNhan;
        private Button button1;
    }
}