namespace _3.PL.Views
{
    partial class FrmMain
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
            Button btn_BanHang;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panel1 = new Panel();
            btn_TaiKhoan = new Button();
            btn_Out = new Button();
            panel4 = new Panel();
            btn_TK = new Button();
            btn_HD = new Button();
            btn_Sp = new Button();
            btn_NhanVien = new Button();
            btn_KH = new Button();
            panel2 = new Panel();
            label1 = new Label();
            lb_TenCV = new Label();
            label2 = new Label();
            lb_TenNV = new Label();
            ptb_avt = new PictureBox();
            PanelForm = new Panel();
            panel3 = new Panel();
            btn_BanHang = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_avt).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_BanHang
            // 
            btn_BanHang.BackColor = Color.SeaShell;
            btn_BanHang.Dock = DockStyle.Top;
            btn_BanHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_BanHang.ForeColor = Color.Black;
            btn_BanHang.Image = (Image)resources.GetObject("btn_BanHang.Image");
            btn_BanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_BanHang.Location = new Point(0, 0);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.Size = new Size(246, 58);
            btn_BanHang.TabIndex = 2;
            btn_BanHang.Text = "Bán hàng";
            btn_BanHang.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(btn_TaiKhoan);
            panel1.Controls.Add(btn_Out);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ptb_avt);
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 943);
            panel1.TabIndex = 3;
            // 
            // btn_TaiKhoan
            // 
            btn_TaiKhoan.BackColor = Color.SeaShell;
            btn_TaiKhoan.Dock = DockStyle.Bottom;
            btn_TaiKhoan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TaiKhoan.Image = (Image)resources.GetObject("btn_TaiKhoan.Image");
            btn_TaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TaiKhoan.Location = new Point(0, 844);
            btn_TaiKhoan.Name = "btn_TaiKhoan";
            btn_TaiKhoan.Size = new Size(246, 49);
            btn_TaiKhoan.TabIndex = 16;
            btn_TaiKhoan.Text = "Tài khoản";
            btn_TaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btn_Out
            // 
            btn_Out.BackColor = Color.SeaShell;
            btn_Out.Dock = DockStyle.Bottom;
            btn_Out.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Out.Image = (Image)resources.GetObject("btn_Out.Image");
            btn_Out.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Out.Location = new Point(0, 893);
            btn_Out.Name = "btn_Out";
            btn_Out.Size = new Size(246, 50);
            btn_Out.TabIndex = 15;
            btn_Out.Text = "Đăng xuất";
            btn_Out.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_TK);
            panel4.Controls.Add(btn_HD);
            panel4.Controls.Add(btn_Sp);
            panel4.Controls.Add(btn_NhanVien);
            panel4.Controls.Add(btn_KH);
            panel4.Controls.Add(btn_BanHang);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 233);
            panel4.Name = "panel4";
            panel4.Size = new Size(246, 347);
            panel4.TabIndex = 14;
            // 
            // btn_TK
            // 
            btn_TK.BackColor = Color.SeaShell;
            btn_TK.Dock = DockStyle.Top;
            btn_TK.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TK.Image = (Image)resources.GetObject("btn_TK.Image");
            btn_TK.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TK.Location = new Point(0, 279);
            btn_TK.Name = "btn_TK";
            btn_TK.Size = new Size(246, 57);
            btn_TK.TabIndex = 7;
            btn_TK.Text = "Thống kê";
            btn_TK.UseVisualStyleBackColor = false;
            // 
            // btn_HD
            // 
            btn_HD.BackColor = Color.SeaShell;
            btn_HD.Dock = DockStyle.Top;
            btn_HD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_HD.Image = (Image)resources.GetObject("btn_HD.Image");
            btn_HD.ImageAlign = ContentAlignment.MiddleLeft;
            btn_HD.Location = new Point(0, 225);
            btn_HD.Name = "btn_HD";
            btn_HD.Size = new Size(246, 54);
            btn_HD.TabIndex = 6;
            btn_HD.Text = "Hóa đơn";
            btn_HD.UseVisualStyleBackColor = false;
            // 
            // btn_Sp
            // 
            btn_Sp.BackColor = Color.SeaShell;
            btn_Sp.Dock = DockStyle.Top;
            btn_Sp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sp.Image = (Image)resources.GetObject("btn_Sp.Image");
            btn_Sp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sp.Location = new Point(0, 170);
            btn_Sp.Name = "btn_Sp";
            btn_Sp.Size = new Size(246, 55);
            btn_Sp.TabIndex = 5;
            btn_Sp.Text = "Sản phẩm";
            btn_Sp.UseVisualStyleBackColor = false;
            // 
            // btn_NhanVien
            // 
            btn_NhanVien.BackColor = Color.SeaShell;
            btn_NhanVien.Dock = DockStyle.Top;
            btn_NhanVien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_NhanVien.Image = (Image)resources.GetObject("btn_NhanVien.Image");
            btn_NhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NhanVien.Location = new Point(0, 113);
            btn_NhanVien.Name = "btn_NhanVien";
            btn_NhanVien.Size = new Size(246, 57);
            btn_NhanVien.TabIndex = 4;
            btn_NhanVien.Text = "Nhân viên";
            btn_NhanVien.UseVisualStyleBackColor = false;
            // 
            // btn_KH
            // 
            btn_KH.BackColor = Color.SeaShell;
            btn_KH.Dock = DockStyle.Top;
            btn_KH.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_KH.Image = (Image)resources.GetObject("btn_KH.Image");
            btn_KH.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KH.Location = new Point(0, 58);
            btn_KH.Name = "btn_KH";
            btn_KH.Size = new Size(246, 55);
            btn_KH.TabIndex = 3;
            btn_KH.Text = "Khách hàng";
            btn_KH.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lb_TenCV);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lb_TenNV);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 82);
            panel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 9;
            label1.Text = "Xin chào: ";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lb_TenCV
            // 
            lb_TenCV.AutoSize = true;
            lb_TenCV.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_TenCV.Location = new Point(87, 46);
            lb_TenCV.Name = "lb_TenCV";
            lb_TenCV.Size = new Size(22, 23);
            lb_TenCV.TabIndex = 12;
            lb_TenCV.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 46);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 10;
            label2.Text = "Chức vụ: ";
            // 
            // lb_TenNV
            // 
            lb_TenNV.AutoSize = true;
            lb_TenNV.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_TenNV.Location = new Point(87, 12);
            lb_TenNV.Name = "lb_TenNV";
            lb_TenNV.Size = new Size(22, 23);
            lb_TenNV.TabIndex = 11;
            lb_TenNV.Text = "...";
            // 
            // ptb_avt
            // 
            ptb_avt.BackColor = Color.MistyRose;
            ptb_avt.BackgroundImageLayout = ImageLayout.Center;
            ptb_avt.Dock = DockStyle.Top;
            ptb_avt.Location = new Point(0, 0);
            ptb_avt.Name = "ptb_avt";
            ptb_avt.Size = new Size(246, 151);
            ptb_avt.TabIndex = 0;
            ptb_avt.TabStop = false;
            // 
            // PanelForm
            // 
            PanelForm.BackColor = Color.SeaShell;
            PanelForm.Dock = DockStyle.Fill;
            PanelForm.Location = new Point(0, 0);
            PanelForm.Name = "PanelForm";
            PanelForm.Size = new Size(1673, 958);
            PanelForm.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(PanelForm);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1673, 958);
            panel3.TabIndex = 5;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1673, 958);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            Text = "FrmMain";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_avt).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.PictureBox ptb_avt;
        private System.Windows.Forms.Panel panel3;
        private Label lb_TenCV;
        private Label lb_TenNV;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Button btn_TK;
        private Button btn_HD;
        private Button btn_Sp;
        private Button btn_NhanVien;
        private Button btn_KH;
        private Button btn_TaiKhoan;
        private Button btn_Out;
    }
}