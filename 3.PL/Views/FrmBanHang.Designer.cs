﻿namespace _3.PL.Views
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
            tb_TenSPQuet = new TextBox();
            tb_MaSPQuet = new TextBox();
            tb_TimKiem = new TextBox();
            cbb_LoaiSP = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_Them = new Button();
            btn_Stop = new Button();
            lb_Thanhtien = new Label();
            label14 = new Label();
            btn_XoaGio = new Button();
            btn_XoaSp = new Button();
            cbb_Cam = new ComboBox();
            btn_QuetMa = new Button();
            dtg_GioHang = new DataGridView();
            ptb_QR = new PictureBox();
            groupBox1 = new GroupBox();
            btn_CapNhatHD = new Button();
            dtg_DonHang = new DataGridView();
            panelPhai = new Panel();
            groupBox5 = new GroupBox();
            button1 = new Button();
            lb_TongTienTT = new Label();
            lbTienThua = new Label();
            label16 = new Label();
            lb_GiamGiaDiem = new Label();
            lb_Tenkh = new Label();
            label8 = new Label();
            lb_Diem = new Label();
            label15 = new Label();
            tb_Diem = new TextBox();
            label12 = new Label();
            btn_HuyDon = new Button();
            btn_ThanhToan = new Button();
            Cbb_LoaiTT = new ComboBox();
            label11 = new Label();
            tb_TTOnline = new TextBox();
            label10 = new Label();
            tb_TienKhachDua = new TextBox();
            label9 = new Label();
            Cbb_GiamGia = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            tb_MaHD = new TextBox();
            btn_TaoHD = new Button();
            tb_DiaChi = new RichTextBox();
            tb_SDT = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox6 = new GroupBox();
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
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // panelFil
            // 
            panelFil.Controls.Add(panelTrai);
            panelFil.Controls.Add(panelPhai);
            panelFil.Dock = DockStyle.Fill;
            panelFil.Location = new Point(0, 0);
            panelFil.Name = "panelFil";
            panelFil.Size = new Size(1639, 922);
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
            panelTrai.Size = new Size(1235, 922);
            panelTrai.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowPanelSp);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 564);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1235, 358);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // flowPanelSp
            // 
            flowPanelSp.AutoScroll = true;
            flowPanelSp.Dock = DockStyle.Fill;
            flowPanelSp.Location = new Point(3, 23);
            flowPanelSp.Name = "flowPanelSp";
            flowPanelSp.Size = new Size(1229, 332);
            flowPanelSp.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(tb_TimKiem);
            groupBox4.Controls.Add(cbb_LoaiSP);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 489);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1235, 75);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // tb_TenSPQuet
            // 
            tb_TenSPQuet.Enabled = false;
            tb_TenSPQuet.Location = new Point(199, 27);
            tb_TenSPQuet.Name = "tb_TenSPQuet";
            tb_TenSPQuet.PlaceholderText = "Tên sản phẩm";
            tb_TenSPQuet.Size = new Size(159, 27);
            tb_TenSPQuet.TabIndex = 5;
            // 
            // tb_MaSPQuet
            // 
            tb_MaSPQuet.Enabled = false;
            tb_MaSPQuet.Location = new Point(6, 27);
            tb_MaSPQuet.Name = "tb_MaSPQuet";
            tb_MaSPQuet.PlaceholderText = "Mã sản phẩm";
            tb_MaSPQuet.Size = new Size(159, 27);
            tb_MaSPQuet.TabIndex = 4;
            // 
            // tb_TimKiem
            // 
            tb_TimKiem.Location = new Point(449, 33);
            tb_TimKiem.Name = "tb_TimKiem";
            tb_TimKiem.PlaceholderText = "Nhập tên sản phẩm";
            tb_TimKiem.Size = new Size(261, 27);
            tb_TimKiem.TabIndex = 3;
            tb_TimKiem.TextChanged += tb_TimKiem_TextChanged;
            // 
            // cbb_LoaiSP
            // 
            cbb_LoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_LoaiSP.FormattingEnabled = true;
            cbb_LoaiSP.Location = new Point(161, 32);
            cbb_LoaiSP.Name = "cbb_LoaiSP";
            cbb_LoaiSP.Size = new Size(172, 28);
            cbb_LoaiSP.TabIndex = 2;
            cbb_LoaiSP.SelectedIndexChanged += cbb_LoaiSP_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 38);
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
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Controls.Add(btn_Stop);
            groupBox2.Controls.Add(lb_Thanhtien);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(btn_XoaGio);
            groupBox2.Controls.Add(btn_XoaSp);
            groupBox2.Controls.Add(cbb_Cam);
            groupBox2.Controls.Add(btn_QuetMa);
            groupBox2.Controls.Add(dtg_GioHang);
            groupBox2.Controls.Add(ptb_QR);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1235, 269);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng";
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.FromArgb(255, 192, 128);
            btn_Them.Location = new Point(12, 219);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(117, 37);
            btn_Them.TabIndex = 78;
            btn_Them.Text = "Thêm vào giỏ";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Stop
            // 
            btn_Stop.Location = new Point(1129, 133);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(94, 29);
            btn_Stop.TabIndex = 77;
            btn_Stop.Text = "Dừng";
            btn_Stop.UseVisualStyleBackColor = true;
            btn_Stop.Click += btn_Stop_Click;
            // 
            // lb_Thanhtien
            // 
            lb_Thanhtien.AutoSize = true;
            lb_Thanhtien.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Thanhtien.Location = new Point(599, 224);
            lb_Thanhtien.Name = "lb_Thanhtien";
            lb_Thanhtien.Size = new Size(44, 32);
            lb_Thanhtien.TabIndex = 76;
            lb_Thanhtien.Text = ".....";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(449, 224);
            label14.Name = "label14";
            label14.Size = new Size(131, 32);
            label14.TabIndex = 75;
            label14.Text = "Thành tiền";
            // 
            // btn_XoaGio
            // 
            btn_XoaGio.BackColor = Color.FromArgb(255, 192, 128);
            btn_XoaGio.Location = new Point(306, 220);
            btn_XoaGio.Name = "btn_XoaGio";
            btn_XoaGio.Size = new Size(117, 37);
            btn_XoaGio.TabIndex = 74;
            btn_XoaGio.Text = "Xoá giỏ hàng";
            btn_XoaGio.UseVisualStyleBackColor = false;
            btn_XoaGio.Click += btn_XoaGio_Click;
            // 
            // btn_XoaSp
            // 
            btn_XoaSp.BackColor = Color.FromArgb(255, 192, 128);
            btn_XoaSp.Location = new Point(161, 220);
            btn_XoaSp.Name = "btn_XoaSp";
            btn_XoaSp.Size = new Size(117, 37);
            btn_XoaSp.TabIndex = 73;
            btn_XoaSp.Text = "Xoá sản phẩm";
            btn_XoaSp.UseVisualStyleBackColor = false;
            btn_XoaSp.Click += btn_XoaSp_Click;
            // 
            // cbb_Cam
            // 
            cbb_Cam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_Cam.FormattingEnabled = true;
            cbb_Cam.Location = new Point(925, 15);
            cbb_Cam.Name = "cbb_Cam";
            cbb_Cam.Size = new Size(198, 28);
            cbb_Cam.TabIndex = 71;
            // 
            // btn_QuetMa
            // 
            btn_QuetMa.Location = new Point(978, 234);
            btn_QuetMa.Name = "btn_QuetMa";
            btn_QuetMa.Size = new Size(94, 29);
            btn_QuetMa.TabIndex = 72;
            btn_QuetMa.Text = "Quét mã";
            btn_QuetMa.UseVisualStyleBackColor = true;
            btn_QuetMa.Click += btn_QuetMa_Click;
            // 
            // dtg_GioHang
            // 
            dtg_GioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_GioHang.BackgroundColor = SystemColors.ControlLight;
            dtg_GioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_GioHang.Location = new Point(12, 25);
            dtg_GioHang.Name = "dtg_GioHang";
            dtg_GioHang.RowHeadersWidth = 51;
            dtg_GioHang.RowTemplate.Height = 29;
            dtg_GioHang.Size = new Size(800, 185);
            dtg_GioHang.TabIndex = 1;
            dtg_GioHang.CellClick += dtg_GioHang_CellClick;
            dtg_GioHang.CellValueChanged += dtg_GioHang_CellValueChanged;
            // 
            // ptb_QR
            // 
            ptb_QR.BackColor = Color.SeaShell;
            ptb_QR.BorderStyle = BorderStyle.FixedSingle;
            ptb_QR.Location = new Point(925, 49);
            ptb_QR.Name = "ptb_QR";
            ptb_QR.Size = new Size(198, 179);
            ptb_QR.TabIndex = 1;
            ptb_QR.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_CapNhatHD);
            groupBox1.Controls.Add(dtg_DonHang);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1235, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách đơn hàng";
            // 
            // btn_CapNhatHD
            // 
            btn_CapNhatHD.BackColor = Color.FromArgb(255, 192, 128);
            btn_CapNhatHD.Location = new Point(991, 71);
            btn_CapNhatHD.Name = "btn_CapNhatHD";
            btn_CapNhatHD.Size = new Size(154, 63);
            btn_CapNhatHD.TabIndex = 75;
            btn_CapNhatHD.Text = "Cập nhật HD";
            btn_CapNhatHD.UseVisualStyleBackColor = false;
            btn_CapNhatHD.Click += btn_CapNhatHD_Click;
            // 
            // dtg_DonHang
            // 
            dtg_DonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_DonHang.BackgroundColor = SystemColors.ControlLight;
            dtg_DonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DonHang.Location = new Point(12, 26);
            dtg_DonHang.Name = "dtg_DonHang";
            dtg_DonHang.RowHeadersWidth = 51;
            dtg_DonHang.RowTemplate.Height = 29;
            dtg_DonHang.Size = new Size(942, 185);
            dtg_DonHang.TabIndex = 0;
            dtg_DonHang.CellClick += dtg_DonHang_CellClick;
            // 
            // panelPhai
            // 
            panelPhai.Controls.Add(groupBox5);
            panelPhai.Dock = DockStyle.Right;
            panelPhai.Location = new Point(1235, 0);
            panelPhai.Name = "panelPhai";
            panelPhai.Size = new Size(404, 922);
            panelPhai.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(lb_TongTienTT);
            groupBox5.Controls.Add(lbTienThua);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(lb_GiamGiaDiem);
            groupBox5.Controls.Add(lb_Tenkh);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(lb_Diem);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(tb_Diem);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(btn_HuyDon);
            groupBox5.Controls.Add(btn_ThanhToan);
            groupBox5.Controls.Add(Cbb_LoaiTT);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(tb_TTOnline);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(tb_TienKhachDua);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(Cbb_GiamGia);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(tb_MaHD);
            groupBox5.Controls.Add(btn_TaoHD);
            groupBox5.Controls.Add(tb_DiaChi);
            groupBox5.Controls.Add(tb_SDT);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label3);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(404, 922);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Location = new Point(345, 64);
            button1.Name = "button1";
            button1.Size = new Size(32, 37);
            button1.TabIndex = 79;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lb_TongTienTT
            // 
            lb_TongTienTT.AutoSize = true;
            lb_TongTienTT.Location = new Point(150, 490);
            lb_TongTienTT.Name = "lb_TongTienTT";
            lb_TongTienTT.Size = new Size(30, 23);
            lb_TongTienTT.TabIndex = 84;
            lb_TongTienTT.Text = ".....";
            // 
            // lbTienThua
            // 
            lbTienThua.AutoSize = true;
            lbTienThua.Location = new Point(150, 685);
            lbTienThua.Name = "lbTienThua";
            lbTienThua.Size = new Size(19, 23);
            lbTienThua.TabIndex = 83;
            lbTienThua.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(9, 685);
            label16.Name = "label16";
            label16.Size = new Size(83, 23);
            label16.TabIndex = 82;
            label16.Text = "Tiền thừa";
            // 
            // lb_GiamGiaDiem
            // 
            lb_GiamGiaDiem.AutoSize = true;
            lb_GiamGiaDiem.Location = new Point(261, 439);
            lb_GiamGiaDiem.Name = "lb_GiamGiaDiem";
            lb_GiamGiaDiem.Size = new Size(87, 23);
            lb_GiamGiaDiem.TabIndex = 81;
            lb_GiamGiaDiem.Text = "(Tối đa: 0)";
            // 
            // lb_Tenkh
            // 
            lb_Tenkh.AutoSize = true;
            lb_Tenkh.Location = new Point(147, 26);
            lb_Tenkh.Name = "lb_Tenkh";
            lb_Tenkh.Size = new Size(72, 23);
            lb_Tenkh.TabIndex = 80;
            lb_Tenkh.Text = "Tên kh...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 490);
            label8.Name = "label8";
            label8.Size = new Size(106, 23);
            label8.TabIndex = 61;
            label8.Text = "Tổng tiền TT";
            // 
            // lb_Diem
            // 
            lb_Diem.AutoSize = true;
            lb_Diem.Location = new Point(152, 111);
            lb_Diem.Name = "lb_Diem";
            lb_Diem.Size = new Size(62, 23);
            lb_Diem.TabIndex = 79;
            lb_Diem.Text = "Điểm...";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(10, 111);
            label15.Name = "label15";
            label15.Size = new Size(85, 23);
            label15.TabIndex = 75;
            label15.Text = "Điểm(KH)";
            // 
            // tb_Diem
            // 
            tb_Diem.Location = new Point(146, 436);
            tb_Diem.Name = "tb_Diem";
            tb_Diem.Size = new Size(109, 30);
            tb_Diem.TabIndex = 78;
            tb_Diem.TextChanged += tb_Diem_TextChanged;
            tb_Diem.KeyPress += tb_Diem_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 439);
            label12.Name = "label12";
            label12.Size = new Size(117, 23);
            label12.TabIndex = 77;
            label12.Text = "Điểm(Nếu có)";
            // 
            // btn_HuyDon
            // 
            btn_HuyDon.BackColor = Color.Red;
            btn_HuyDon.ForeColor = SystemColors.ButtonHighlight;
            btn_HuyDon.Location = new Point(19, 725);
            btn_HuyDon.Name = "btn_HuyDon";
            btn_HuyDon.Size = new Size(343, 56);
            btn_HuyDon.TabIndex = 70;
            btn_HuyDon.Text = "Huỷ đơn";
            btn_HuyDon.UseVisualStyleBackColor = false;
            btn_HuyDon.Click += btn_HuyDon_Click;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = Color.FromArgb(255, 192, 128);
            btn_ThanhToan.Location = new Point(19, 802);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(343, 56);
            btn_ThanhToan.TabIndex = 69;
            btn_ThanhToan.Text = "Thanh toán";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // Cbb_LoaiTT
            // 
            Cbb_LoaiTT.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbb_LoaiTT.FormattingEnabled = true;
            Cbb_LoaiTT.Location = new Point(152, 632);
            Cbb_LoaiTT.Name = "Cbb_LoaiTT";
            Cbb_LoaiTT.Size = new Size(240, 31);
            Cbb_LoaiTT.TabIndex = 68;
            Cbb_LoaiTT.SelectedIndexChanged += Cbb_LoaiTT_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 635);
            label11.Name = "label11";
            label11.Size = new Size(142, 23);
            label11.TabIndex = 67;
            label11.Text = "Thanh toán bằng";
            // 
            // tb_TTOnline
            // 
            tb_TTOnline.Location = new Point(150, 583);
            tb_TTOnline.Name = "tb_TTOnline";
            tb_TTOnline.Size = new Size(242, 30);
            tb_TTOnline.TabIndex = 66;
            tb_TTOnline.TextChanged += tb_TTOnline_TextChanged;
            tb_TTOnline.KeyPress += tb_TTOnline_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 590);
            label10.Name = "label10";
            label10.Size = new Size(123, 23);
            label10.TabIndex = 65;
            label10.Text = "Tiền trả Online";
            // 
            // tb_TienKhachDua
            // 
            tb_TienKhachDua.Location = new Point(150, 534);
            tb_TienKhachDua.Name = "tb_TienKhachDua";
            tb_TienKhachDua.Size = new Size(242, 30);
            tb_TienKhachDua.TabIndex = 64;
            tb_TienKhachDua.TextChanged += tb_TienKhachDua_TextChanged;
            tb_TienKhachDua.KeyPress += tb_TienKhachDua_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 541);
            label9.Name = "label9";
            label9.Size = new Size(128, 23);
            label9.TabIndex = 63;
            label9.Text = "Tiền khách đưa";
            // 
            // Cbb_GiamGia
            // 
            Cbb_GiamGia.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbb_GiamGia.FormattingEnabled = true;
            Cbb_GiamGia.Location = new Point(148, 392);
            Cbb_GiamGia.Name = "Cbb_GiamGia";
            Cbb_GiamGia.Size = new Size(244, 31);
            Cbb_GiamGia.TabIndex = 60;
            Cbb_GiamGia.SelectedIndexChanged += Cbb_GiamGia_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 395);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 59;
            label7.Text = "Giảm giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 353);
            label6.Name = "label6";
            label6.Size = new Size(104, 23);
            label6.TabIndex = 58;
            label6.Text = "Mã hoá đơn";
            // 
            // tb_MaHD
            // 
            tb_MaHD.Enabled = false;
            tb_MaHD.Location = new Point(146, 346);
            tb_MaHD.Name = "tb_MaHD";
            tb_MaHD.Size = new Size(246, 30);
            tb_MaHD.TabIndex = 57;
            tb_MaHD.TextChanged += tb_MaHD_TextChanged;
            // 
            // btn_TaoHD
            // 
            btn_TaoHD.BackColor = Color.FromArgb(255, 192, 128);
            btn_TaoHD.Location = new Point(31, 269);
            btn_TaoHD.Name = "btn_TaoHD";
            btn_TaoHD.Size = new Size(346, 56);
            btn_TaoHD.TabIndex = 56;
            btn_TaoHD.Text = "Tạo hoá đơn";
            btn_TaoHD.UseVisualStyleBackColor = false;
            btn_TaoHD.Click += btn_TaoHD_Click;
            // 
            // tb_DiaChi
            // 
            tb_DiaChi.Location = new Point(150, 161);
            tb_DiaChi.Name = "tb_DiaChi";
            tb_DiaChi.Size = new Size(227, 59);
            tb_DiaChi.TabIndex = 54;
            tb_DiaChi.Text = "";
            // 
            // tb_SDT
            // 
            tb_SDT.Location = new Point(147, 68);
            tb_SDT.Name = "tb_SDT";
            tb_SDT.Size = new Size(184, 30);
            tb_SDT.TabIndex = 4;
            tb_SDT.TextChanged += tb_SDT_TextChanged;
            tb_SDT.KeyPress += tb_SDT_KeyPress;
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
            label4.Location = new Point(12, 164);
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
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tb_TenSPQuet);
            groupBox6.Controls.Add(tb_MaSPQuet);
            groupBox6.Location = new Point(765, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(430, 63);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Thông tin sản phẩm quét";
            // 
            // FrmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1639, 922);
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
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_GioHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_QR).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_DonHang).EndInit();
            panelPhai.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btn_TaoHD;
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
        private Label label8;
        private Button btn_HuyDon;
        private Button btn_ThanhToan;
        private ComboBox cbb_Cam;
        private Button btn_QuetMa;
        private Button btn_XoaSp;
        private Button btn_XoaGio;
        private Button btn_CapNhatHD;
        private Label lb_Thanhtien;
        private Label label14;
        private TextBox tb_Diem;
        private Label label12;
        private Label lb_Diem;
        private Label label15;
        private Label lb_Tenkh;
        private Label lb_GiamGiaDiem;
        private Label label16;
        private Label lbTienThua;
        private Label lb_TongTienTT;
        private Button btn_Stop;
        private TextBox tb_MaSPQuet;
        private Button btn_Them;
        private TextBox tb_TenSPQuet;
        private Button button1;
        private GroupBox groupBox6;
    }
}