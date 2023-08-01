namespace _3.PL.Views
{
    partial class FrmDoiMK
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_nhaplai = new TextBox();
            tb_pass = new TextBox();
            tb_email = new TextBox();
            tb_ma = new TextBox();
            btn_Xacnhan = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 223);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 28;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 161);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 27;
            label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 100);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 26;
            label2.Text = "Gmail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 39);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 25;
            label1.Text = "Mã";
            // 
            // tb_nhaplai
            // 
            tb_nhaplai.Location = new Point(185, 216);
            tb_nhaplai.Margin = new Padding(3, 4, 3, 4);
            tb_nhaplai.Name = "tb_nhaplai";
            tb_nhaplai.Size = new Size(469, 27);
            tb_nhaplai.TabIndex = 24;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(185, 154);
            tb_pass.Margin = new Padding(3, 4, 3, 4);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(469, 27);
            tb_pass.TabIndex = 23;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(185, 93);
            tb_email.Margin = new Padding(3, 4, 3, 4);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(469, 27);
            tb_email.TabIndex = 22;
            // 
            // tb_ma
            // 
            tb_ma.Location = new Point(185, 36);
            tb_ma.Margin = new Padding(3, 4, 3, 4);
            tb_ma.Name = "tb_ma";
            tb_ma.Size = new Size(469, 27);
            tb_ma.TabIndex = 21;
            // 
            // btn_Xacnhan
            // 
            btn_Xacnhan.Location = new Point(501, 299);
            btn_Xacnhan.Name = "btn_Xacnhan";
            btn_Xacnhan.Size = new Size(153, 74);
            btn_Xacnhan.TabIndex = 29;
            btn_Xacnhan.Text = "Xác nhận";
            btn_Xacnhan.UseVisualStyleBackColor = true;
            // 
            // FrmDoiMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(689, 392);
            Controls.Add(btn_Xacnhan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_nhaplai);
            Controls.Add(tb_pass);
            Controls.Add(tb_email);
            Controls.Add(tb_ma);
            Name = "FrmDoiMK";
            Text = "FrmDoiMK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_nhaplai;
        private TextBox tb_pass;
        private TextBox tb_email;
        private TextBox tb_ma;
        private Button btn_Xacnhan;
    }
}