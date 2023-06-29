namespace _3.PL.Views
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            Tb_Mk = new TextBox();
            tb_Tentk = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 391);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Tb_Mk);
            panel2.Controls.Add(tb_Tentk);
            panel2.Location = new Point(291, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 391);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(186, 287);
            button1.Name = "button1";
            button1.Size = new Size(121, 50);
            button1.TabIndex = 8;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(316, 230);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 7;
            label2.Text = "Quên mật khẩu?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 186);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 6;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(141, 23);
            label3.Name = "label3";
            label3.Size = new Size(215, 41);
            label3.TabIndex = 5;
            label3.Text = "SHOP HỔ BÉO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 111);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 3;
            label1.Text = "Tên tài khoản";
            // 
            // Tb_Mk
            // 
            Tb_Mk.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Tb_Mk.Location = new Point(141, 182);
            Tb_Mk.Name = "Tb_Mk";
            Tb_Mk.Size = new Size(313, 34);
            Tb_Mk.TabIndex = 2;
            // 
            // tb_Tentk
            // 
            tb_Tentk.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Tentk.Location = new Point(141, 110);
            tb_Tentk.Name = "tb_Tentk";
            tb_Tentk.Size = new Size(313, 34);
            tb_Tentk.TabIndex = 1;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 383);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmDangNhap";
            Text = "FrmDangNhap";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox Tb_Mk;
        private TextBox tb_Tentk;
        private Button button1;

    }
}