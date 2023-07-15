namespace _3.PL.Views
{
    partial class FrmBanHang
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
            components = new System.ComponentModel.Container();
            panelFil = new Panel();
            panelTrai = new Panel();
            groupBox3 = new GroupBox();
            flowPanelSp = new FlowLayoutPanel();
            groupBox4 = new GroupBox();
            tb_TimKiem = new TextBox();
            cbb_LoaiSP = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cbb_Cam = new ComboBox();
            btn_QuetMa = new Button();
            dtg_GioHang = new DataGridView();
            ptb_QR = new PictureBox();
            groupBox1 = new GroupBox();
            dtg_DonHang = new DataGridView();
            panelPhai = new Panel();
            groupBox5 = new GroupBox();
            btn_HuyDon = new Button();
            btn_ThanhToan = new Button();
            Cbb_LoaiTT = new ComboBox();
            label11 = new Label();
            tb_TTOnline = new TextBox();
            label10 = new Label();
            tb_TienKhachDua = new TextBox();
            label9 = new Label();
            tb_TongTien = new TextBox();
            label8 = new Label();
            Cbb_GiamGia = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            tb_MaHD = new TextBox();
            btn_TaoHD = new Button();
            cb_KHVangLai = new CheckBox();
            tb_DiaChi = new RichTextBox();
            tb_SDT = new TextBox();
            tb_KH = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelFil.SuspendLayout();
            panelTrai.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_GioHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_QR).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_DonHang).BeginInit();
            panelPhai.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // panelFil
            // 
            panelFil.Controls.Add(panelTrai);
            panelFil.Controls.Add(panelPhai);
            panelFil.Dock = DockStyle.Fill;
            panelFil.Location = new Point(0, 0);
            panelFil.Name = "panelFil";
            panelFil.Size = new Size(1482, 922);
            panelFil.TabIndex = 0;
            // 
            // panelTrai
            // 
            panelTrai.Controls.Add(groupBox3);
            panelTrai.Controls.Add(groupBox4);
            panelTrai.Controls.Add(groupBox2);
            panelTrai.Controls.Add(groupBox1);
            panelTrai.Dock = DockStyle.Fill;
            panelTrai.Location = new Point(0, 0);
            panelTrai.Name = "panelTrai";
            panelTrai.Size = new Size(1107, 922);
            panelTrai.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowPanelSp);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 564);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1107, 358);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // flowPanelSp
            // 
            flowPanelSp.Dock = DockStyle.Fill;
            flowPanelSp.Location = new Point(3, 23);
            flowPanelSp.Name = "flowPanelSp";
            flowPanelSp.Size = new Size(1101, 332);
            flowPanelSp.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tb_TimKiem);
            groupBox4.Controls.Add(cbb_LoaiSP);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 489);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1107, 75);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // tb_TimKiem
            // 
            tb_TimKiem.Location = new Point(641, 30);
            tb_TimKiem.Name = "tb_TimKiem";
            tb_TimKiem.Size = new Size(313, 27);
            tb_TimKiem.TabIndex = 3;
            // 
            // cbb_LoaiSP
            // 
            cbb_LoaiSP.FormattingEnabled = true;
            cbb_LoaiSP.Location = new Point(161, 32);
            cbb_LoaiSP.Name = "cbb_LoaiSP";
            cbb_LoaiSP.Size = new Size(293, 28);
            cbb_LoaiSP.TabIndex = 2;
            cbb_LoaiSP.SelectedIndexChanged += cbb_LoaiSP_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 35);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Danh mục sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbb_Cam);
            groupBox2.Controls.Add(btn_QuetMa);
            groupBox2.Controls.Add(dtg_GioHang);
            groupBox2.Controls.Add(ptb_QR);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1107, 269);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng";
            // 
            // cbb_Cam
            // 
            cbb_Cam.FormattingEnabled = true;
            cbb_Cam.Location = new Point(866, 18);
            cbb_Cam.Name = "cbb_Cam";
            cbb_Cam.Size = new Size(198, 28);
            cbb_Cam.TabIndex = 71;
            // 
            // btn_QuetMa
            // 
            btn_QuetMa.Location = new Point(925, 234);
            btn_QuetMa.Name = "btn_QuetMa";
            btn_QuetMa.Size = new Size(94, 29);
            btn_QuetMa.TabIndex = 72;
            btn_QuetMa.Text = "Quét mã";
            btn_QuetMa.UseVisualStyleBackColor = true;
            // 
            // dtg_GioHang
            // 
            dtg_GioHang.BackgroundColor = SystemColors.ControlLight;
            dtg_GioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_GioHang.Location = new Point(12, 25);
            dtg_GioHang.Name = "dtg_GioHang";
            dtg_GioHang.RowHeadersWidth = 51;
            dtg_GioHang.RowTemplate.Height = 29;
            dtg_GioHang.Size = new Size(800, 185);
            dtg_GioHang.TabIndex = 1;
            // 
            // ptb_QR
            // 
            ptb_QR.BackColor = Color.SeaShell;
            ptb_QR.BorderStyle = BorderStyle.FixedSingle;
            ptb_QR.Location = new Point(866, 52);
            ptb_QR.Name = "ptb_QR";
            ptb_QR.Size = new Size(198, 179);
            ptb_QR.TabIndex = 1;
            ptb_QR.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_DonHang);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1107, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách đơn hàng";
            // 
            // dtg_DonHang
            // 
            dtg_DonHang.BackgroundColor = SystemColors.ControlLight;
            dtg_DonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DonHang.Location = new Point(12, 26);
            dtg_DonHang.Name = "dtg_DonHang";
            dtg_DonHang.RowHeadersWidth = 51;
            dtg_DonHang.RowTemplate.Height = 29;
            dtg_DonHang.Size = new Size(806, 185);
            dtg_DonHang.TabIndex = 0;
            // 
            // panelPhai
            // 
            panelPhai.Controls.Add(groupBox5);
            panelPhai.Dock = DockStyle.Right;
            panelPhai.Location = new Point(1107, 0);
            panelPhai.Name = "panelPhai";
            panelPhai.Size = new Size(375, 922);
            panelPhai.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btn_HuyDon);
            groupBox5.Controls.Add(btn_ThanhToan);
            groupBox5.Controls.Add(Cbb_LoaiTT);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(tb_TTOnline);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(tb_TienKhachDua);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(tb_TongTien);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(Cbb_GiamGia);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(tb_MaHD);
            groupBox5.Controls.Add(btn_TaoHD);
            groupBox5.Controls.Add(cb_KHVangLai);
            groupBox5.Controls.Add(tb_DiaChi);
            groupBox5.Controls.Add(tb_SDT);
            groupBox5.Controls.Add(tb_KH);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label3);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(375, 922);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin";
            // 
            // btn_HuyDon
            // 
            btn_HuyDon.BackColor = Color.Red;
            btn_HuyDon.ForeColor = SystemColors.ButtonHighlight;
            btn_HuyDon.Location = new Point(16, 660);
            btn_HuyDon.Name = "btn_HuyDon";
            btn_HuyDon.Size = new Size(343, 56);
            btn_HuyDon.TabIndex = 70;
            btn_HuyDon.Text = "Huỷ hoá đơn";
            btn_HuyDon.UseVisualStyleBackColor = false;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = Color.FromArgb(255, 192, 128);
            btn_ThanhToan.Location = new Point(16, 737);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(343, 56);
            btn_ThanhToan.TabIndex = 69;
            btn_ThanhToan.Text = "Thanh toán";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // Cbb_LoaiTT
            // 
            Cbb_LoaiTT.FormattingEnabled = true;
            Cbb_LoaiTT.Location = new Point(148, 610);
            Cbb_LoaiTT.Name = "Cbb_LoaiTT";
            Cbb_LoaiTT.Size = new Size(211, 31);
            Cbb_LoaiTT.TabIndex = 68;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 613);
            label11.Name = "label11";
            label11.Size = new Size(142, 23);
            label11.TabIndex = 67;
            label11.Text = "Thanh toán bằng";
            // 
            // tb_TTOnline
            // 
            tb_TTOnline.Location = new Point(146, 561);
            tb_TTOnline.Name = "tb_TTOnline";
            tb_TTOnline.Size = new Size(213, 30);
            tb_TTOnline.TabIndex = 66;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 568);
            label10.Name = "label10";
            label10.Size = new Size(123, 23);
            label10.TabIndex = 65;
            label10.Text = "Tiền trả Online";
            // 
            // tb_TienKhachDua
            // 
            tb_TienKhachDua.Location = new Point(146, 512);
            tb_TienKhachDua.Name = "tb_TienKhachDua";
            tb_TienKhachDua.Size = new Size(213, 30);
            tb_TienKhachDua.TabIndex = 64;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 512);
            label9.Name = "label9";
            label9.Size = new Size(128, 23);
            label9.TabIndex = 63;
            label9.Text = "Tiền khách đưa";
            // 
            // tb_TongTien
            // 
            tb_TongTien.Location = new Point(146, 463);
            tb_TongTien.Name = "tb_TongTien";
            tb_TongTien.Size = new Size(213, 30);
            tb_TongTien.TabIndex = 62;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 466);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 61;
            label8.Text = "Tổng tiền";
            // 
            // Cbb_GiamGia
            // 
            Cbb_GiamGia.FormattingEnabled = true;
            Cbb_GiamGia.Location = new Point(148, 416);
            Cbb_GiamGia.Name = "Cbb_GiamGia";
            Cbb_GiamGia.Size = new Size(211, 31);
            Cbb_GiamGia.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 419);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 59;
            label7.Text = "Giảm giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 377);
            label6.Name = "label6";
            label6.Size = new Size(104, 23);
            label6.TabIndex = 58;
            label6.Text = "Mã hoá đơn";
            // 
            // tb_MaHD
            // 
            tb_MaHD.Location = new Point(146, 370);
            tb_MaHD.Name = "tb_MaHD";
            tb_MaHD.Size = new Size(213, 30);
            tb_MaHD.TabIndex = 57;
            // 
            // btn_TaoHD
            // 
            btn_TaoHD.BackColor = Color.FromArgb(255, 192, 128);
            btn_TaoHD.Location = new Point(16, 292);
            btn_TaoHD.Name = "btn_TaoHD";
            btn_TaoHD.Size = new Size(343, 56);
            btn_TaoHD.TabIndex = 56;
            btn_TaoHD.Text = "Tạo hoá đơn";
            btn_TaoHD.UseVisualStyleBackColor = false;
            // 
            // cb_KHVangLai
            // 
            cb_KHVangLai.AutoSize = true;
            cb_KHVangLai.Location = new Point(3, 223);
            cb_KHVangLai.Name = "cb_KHVangLai";
            cb_KHVangLai.Size = new Size(144, 27);
            cb_KHVangLai.TabIndex = 55;
            cb_KHVangLai.Text = "Khách vãng lai";
            cb_KHVangLai.UseVisualStyleBackColor = true;
            // 
            // tb_DiaChi
            // 
            tb_DiaChi.Location = new Point(146, 120);
            tb_DiaChi.Name = "tb_DiaChi";
            tb_DiaChi.Size = new Size(213, 82);
            tb_DiaChi.TabIndex = 54;
            tb_DiaChi.Text = "";
            // 
            // tb_SDT
            // 
            tb_SDT.Location = new Point(147, 68);
            tb_SDT.Name = "tb_SDT";
            tb_SDT.Size = new Size(212, 30);
            tb_SDT.TabIndex = 4;
            // 
            // tb_KH
            // 
            tb_KH.Location = new Point(146, 26);
            tb_KH.Name = "tb_KH";
            tb_KH.Size = new Size(213, 30);
            tb_KH.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 71);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 2;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 134);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 1;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 0;
            label3.Text = "Khách hàng";
            // 
            // FrmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1482, 922);
            Controls.Add(panelFil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmBanHang";
            Text = "FrmBanHang";
            panelFil.ResumeLayout(false);
            panelTrai.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_GioHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_QR).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_DonHang).EndInit();
            panelPhai.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.CodeDom.CodeTypeReference guna2AnimateWindow1;
        private Panel panelFil;
        private Panel panelPhai;
        private Panel panelTrai;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView dtg_DonHang;
        private DataGridView dtg_GioHang;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox4;
        private ComboBox cbb_LoaiSP;
        private Label label2;
        private Label label1;
        private TextBox tb_TimKiem;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowPanelSp;
        private PictureBox ptb_QR;
        private GroupBox groupBox5;
        private TextBox tb_SDT;
        private TextBox tb_KH;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btn_TaoHD;
        private CheckBox cb_KHVangLai;
        private RichTextBox tb_DiaChi;
        private ComboBox Cbb_GiamGia;
        private Label label7;
        private Label label6;
        private TextBox tb_MaHD;
        private ComboBox Cbb_LoaiTT;
        private Label label11;
        private TextBox tb_TTOnline;
        private Label label10;
        private TextBox tb_TienKhachDua;
        private Label label9;
        private TextBox tb_TongTien;
        private Label label8;
        private Button btn_HuyDon;
        private Button btn_ThanhToan;
        private ComboBox cbb_Cam;
        private Button btn_QuetMa;
    }
}