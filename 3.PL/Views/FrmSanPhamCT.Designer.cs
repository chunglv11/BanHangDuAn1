namespace _3.PL.Views
{
    partial class FrmSanPhamCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPhamCT));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panelphai = new Panel();
            groupBox2 = new GroupBox();
            btn_Them = new Button();
            btn_LamMoi = new Button();
            btn_SaveQr = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            panelTrai = new Panel();
            cmb_Nsx = new ComboBox();
            label16 = new Label();
            label14 = new Label();
            cmb_loctrangthai = new ComboBox();
            rdb_Het = new RadioButton();
            rdb_Con = new RadioButton();
            label11 = new Label();
            txt_TimKiem = new TextBox();
            dtg_ShowSanPham = new DataGridView();
            btn_ChonAnh = new Button();
            label7 = new Label();
            txt_Mota = new RichTextBox();
            label13 = new Label();
            txt_SLT = new TextBox();
            txt_GiaNhap = new TextBox();
            txt_GiaBan = new TextBox();
            cmb_Cl = new ComboBox();
            cmb_Loai = new ComboBox();
            cmb_MS = new ComboBox();
            cmb_Size = new ComboBox();
            cmb_TSP = new ComboBox();
            txt_Ma = new TextBox();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ptb_QR = new PictureBox();
            ptb_AVT = new PictureBox();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            panelphai.SuspendLayout();
            groupBox2.SuspendLayout();
            panelTrai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_QR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_AVT).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1345, 136);
            panel1.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelphai);
            groupBox1.Controls.Add(panelTrai);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1345, 786);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản Phẩm Chi Tiết";
            // 
            // panelphai
            // 
            panelphai.Controls.Add(groupBox2);
            panelphai.Dock = DockStyle.Right;
            panelphai.Location = new Point(1099, 26);
            panelphai.Name = "panelphai";
            panelphai.Size = new Size(243, 757);
            panelphai.TabIndex = 30;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Controls.Add(btn_LamMoi);
            groupBox2.Controls.Add(btn_SaveQr);
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Xoa);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(243, 757);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_Them
            // 
            btn_Them.Image = Properties.Resources.add;
            btn_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Them.Location = new Point(27, 54);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(196, 55);
            btn_Them.TabIndex = 1;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.Image = Properties.Resources.reset;
            btn_LamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_LamMoi.Location = new Point(27, 300);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(196, 58);
            btn_LamMoi.TabIndex = 4;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = true;
            btn_LamMoi.Click += btn_LamMoi_Click;
            // 
            // btn_SaveQr
            // 
            btn_SaveQr.Location = new Point(27, 390);
            btn_SaveQr.Name = "btn_SaveQr";
            btn_SaveQr.Size = new Size(196, 58);
            btn_SaveQr.TabIndex = 62;
            btn_SaveQr.Text = "Lưu mã QR";
            btn_SaveQr.UseVisualStyleBackColor = true;
            btn_SaveQr.Click += btn_SaveQr_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Image = Properties.Resources.updated;
            btn_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sua.Location = new Point(27, 134);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(196, 55);
            btn_Sua.TabIndex = 2;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Image = Properties.Resources.delete;
            btn_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Xoa.Location = new Point(27, 218);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(196, 55);
            btn_Xoa.TabIndex = 3;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // panelTrai
            // 
            panelTrai.BackColor = Color.SeaShell;
            panelTrai.Controls.Add(cmb_Nsx);
            panelTrai.Controls.Add(label16);
            panelTrai.Controls.Add(label14);
            panelTrai.Controls.Add(cmb_loctrangthai);
            panelTrai.Controls.Add(rdb_Het);
            panelTrai.Controls.Add(rdb_Con);
            panelTrai.Controls.Add(label11);
            panelTrai.Controls.Add(txt_TimKiem);
            panelTrai.Controls.Add(dtg_ShowSanPham);
            panelTrai.Controls.Add(btn_ChonAnh);
            panelTrai.Controls.Add(label7);
            panelTrai.Controls.Add(txt_Mota);
            panelTrai.Controls.Add(label13);
            panelTrai.Controls.Add(txt_SLT);
            panelTrai.Controls.Add(txt_GiaNhap);
            panelTrai.Controls.Add(txt_GiaBan);
            panelTrai.Controls.Add(cmb_Cl);
            panelTrai.Controls.Add(cmb_Loai);
            panelTrai.Controls.Add(cmb_MS);
            panelTrai.Controls.Add(cmb_Size);
            panelTrai.Controls.Add(cmb_TSP);
            panelTrai.Controls.Add(txt_Ma);
            panelTrai.Controls.Add(label12);
            panelTrai.Controls.Add(label10);
            panelTrai.Controls.Add(label9);
            panelTrai.Controls.Add(label8);
            panelTrai.Controls.Add(label6);
            panelTrai.Controls.Add(label5);
            panelTrai.Controls.Add(label4);
            panelTrai.Controls.Add(label3);
            panelTrai.Controls.Add(label2);
            panelTrai.Controls.Add(label1);
            panelTrai.Controls.Add(ptb_QR);
            panelTrai.Controls.Add(ptb_AVT);
            panelTrai.Dock = DockStyle.Fill;
            panelTrai.Location = new Point(3, 26);
            panelTrai.Name = "panelTrai";
            panelTrai.Size = new Size(1339, 757);
            panelTrai.TabIndex = 29;
            // 
            // cmb_Nsx
            // 
            cmb_Nsx.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Nsx.FormattingEnabled = true;
            cmb_Nsx.Location = new Point(111, 300);
            cmb_Nsx.Name = "cmb_Nsx";
            cmb_Nsx.Size = new Size(208, 31);
            cmb_Nsx.TabIndex = 70;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(19, 300);
            label16.Name = "label16";
            label16.Size = new Size(47, 23);
            label16.TabIndex = 69;
            label16.Text = "NSX:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(436, 374);
            label14.Name = "label14";
            label14.Size = new Size(156, 23);
            label14.TabIndex = 66;
            label14.Text = "Lọc theo trạng thái";
            // 
            // cmb_loctrangthai
            // 
            cmb_loctrangthai.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_loctrangthai.FormattingEnabled = true;
            cmb_loctrangthai.Location = new Point(436, 400);
            cmb_loctrangthai.Name = "cmb_loctrangthai";
            cmb_loctrangthai.Size = new Size(208, 31);
            cmb_loctrangthai.TabIndex = 65;
            cmb_loctrangthai.SelectedIndexChanged += cmb_loctrangthai_SelectedIndexChanged;
            // 
            // rdb_Het
            // 
            rdb_Het.AutoSize = true;
            rdb_Het.Location = new Point(947, 78);
            rdb_Het.Name = "rdb_Het";
            rdb_Het.Size = new Size(103, 27);
            rdb_Het.TabIndex = 64;
            rdb_Het.TabStop = true;
            rdb_Het.Text = "Hết hàng";
            rdb_Het.UseVisualStyleBackColor = true;
            // 
            // rdb_Con
            // 
            rdb_Con.AutoSize = true;
            rdb_Con.Location = new Point(827, 78);
            rdb_Con.Name = "rdb_Con";
            rdb_Con.Size = new Size(106, 27);
            rdb_Con.TabIndex = 63;
            rdb_Con.TabStop = true;
            rdb_Con.Text = "Còn hàng";
            rdb_Con.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 476);
            label11.Name = "label11";
            label11.Size = new Size(80, 23);
            label11.TabIndex = 61;
            label11.Text = "Tìm kiếm";
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(110, 473);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(207, 30);
            txt_TimKiem.TabIndex = 60;
            txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
            // 
            // dtg_ShowSanPham
            // 
            dtg_ShowSanPham.BackgroundColor = SystemColors.ControlLight;
            dtg_ShowSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ShowSanPham.GridColor = Color.FromArgb(255, 224, 192);
            dtg_ShowSanPham.Location = new Point(20, 524);
            dtg_ShowSanPham.Name = "dtg_ShowSanPham";
            dtg_ShowSanPham.RowHeadersWidth = 51;
            dtg_ShowSanPham.RowTemplate.Height = 29;
            dtg_ShowSanPham.Size = new Size(1057, 224);
            dtg_ShowSanPham.TabIndex = 58;
            dtg_ShowSanPham.CellClick += dtg_ShowSanPham_CellClick;
            // 
            // btn_ChonAnh
            // 
            btn_ChonAnh.Location = new Point(436, 329);
            btn_ChonAnh.Name = "btn_ChonAnh";
            btn_ChonAnh.Size = new Size(234, 29);
            btn_ChonAnh.TabIndex = 57;
            btn_ChonAnh.Text = "Chọn ảnh";
            btn_ChonAnh.UseVisualStyleBackColor = true;
            btn_ChonAnh.Click += btn_ChonAnh_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(812, 473);
            label7.Name = "label7";
            label7.Size = new Size(150, 23);
            label7.TabIndex = 56;
            label7.Text = "Click để lấy mã Qr";
            // 
            // txt_Mota
            // 
            txt_Mota.Location = new Point(111, 400);
            txt_Mota.Name = "txt_Mota";
            txt_Mota.Size = new Size(208, 56);
            txt_Mota.TabIndex = 53;
            txt_Mota.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 408);
            label13.Name = "label13";
            label13.Size = new Size(60, 23);
            label13.TabIndex = 52;
            label13.Text = "Mô tả:";
            // 
            // txt_SLT
            // 
            txt_SLT.Location = new Point(110, 349);
            txt_SLT.Name = "txt_SLT";
            txt_SLT.Size = new Size(208, 30);
            txt_SLT.TabIndex = 51;
            txt_SLT.TextChanged += txt_SLT_TextChanged;
            // 
            // txt_GiaNhap
            // 
            txt_GiaNhap.Location = new Point(827, 17);
            txt_GiaNhap.Name = "txt_GiaNhap";
            txt_GiaNhap.Size = new Size(223, 30);
            txt_GiaNhap.TabIndex = 50;
            txt_GiaNhap.TextChanged += txt_GiaNhap_TextChanged;
            // 
            // txt_GiaBan
            // 
            txt_GiaBan.Location = new Point(446, 17);
            txt_GiaBan.Name = "txt_GiaBan";
            txt_GiaBan.Size = new Size(224, 30);
            txt_GiaBan.TabIndex = 48;
            txt_GiaBan.TextChanged += txt_GiaBan_TextChanged;
            // 
            // cmb_Cl
            // 
            cmb_Cl.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Cl.FormattingEnabled = true;
            cmb_Cl.Location = new Point(111, 251);
            cmb_Cl.Name = "cmb_Cl";
            cmb_Cl.Size = new Size(208, 31);
            cmb_Cl.TabIndex = 47;
            // 
            // cmb_Loai
            // 
            cmb_Loai.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Loai.FormattingEnabled = true;
            cmb_Loai.Location = new Point(111, 203);
            cmb_Loai.Name = "cmb_Loai";
            cmb_Loai.Size = new Size(208, 31);
            cmb_Loai.TabIndex = 45;
            // 
            // cmb_MS
            // 
            cmb_MS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MS.FormattingEnabled = true;
            cmb_MS.Location = new Point(111, 158);
            cmb_MS.Name = "cmb_MS";
            cmb_MS.Size = new Size(208, 31);
            cmb_MS.TabIndex = 44;
            // 
            // cmb_Size
            // 
            cmb_Size.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Size.FormattingEnabled = true;
            cmb_Size.Location = new Point(110, 113);
            cmb_Size.Name = "cmb_Size";
            cmb_Size.Size = new Size(209, 31);
            cmb_Size.TabIndex = 43;
            // 
            // cmb_TSP
            // 
            cmb_TSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TSP.FormattingEnabled = true;
            cmb_TSP.Location = new Point(111, 67);
            cmb_TSP.Name = "cmb_TSP";
            cmb_TSP.Size = new Size(208, 31);
            cmb_TSP.TabIndex = 42;
            cmb_TSP.SelectedIndexChanged += cmb_TSP_SelectedIndexChanged;
            // 
            // txt_Ma
            // 
            txt_Ma.Enabled = false;
            txt_Ma.Location = new Point(110, 17);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(209, 30);
            txt_Ma.TabIndex = 41;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(717, 80);
            label12.Name = "label12";
            label12.Size = new Size(91, 23);
            label12.TabIndex = 40;
            label12.Text = "Trạng thái:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(725, 20);
            label10.Name = "label10";
            label10.Size = new Size(83, 23);
            label10.TabIndex = 38;
            label10.Text = "Giá nhập:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(354, 20);
            label9.Name = "label9";
            label9.Size = new Size(73, 23);
            label9.TabIndex = 37;
            label9.Text = "Giá bán:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 352);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 36;
            label8.Text = "SL tồn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 251);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 34;
            label6.Text = "Chất liệu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 203);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 33;
            label5.Text = "Loại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 158);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 32;
            label4.Text = "Màu sắc:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 116);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 31;
            label3.Text = "Size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 70);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 30;
            label2.Text = "Tên SP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 22);
            label1.Name = "label1";
            label1.Size = new Size(39, 23);
            label1.TabIndex = 29;
            label1.Text = "Mã:";
            // 
            // ptb_QR
            // 
            ptb_QR.BackColor = Color.FromArgb(255, 255, 192);
            ptb_QR.BorderStyle = BorderStyle.FixedSingle;
            ptb_QR.Location = new Point(725, 112);
            ptb_QR.Name = "ptb_QR";
            ptb_QR.Size = new Size(325, 336);
            ptb_QR.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_QR.TabIndex = 26;
            ptb_QR.TabStop = false;
            ptb_QR.Click += ptb_QR_Click;
            // 
            // ptb_AVT
            // 
            ptb_AVT.BackColor = Color.MistyRose;
            ptb_AVT.Location = new Point(436, 67);
            ptb_AVT.Name = "ptb_AVT";
            ptb_AVT.Size = new Size(234, 254);
            ptb_AVT.TabIndex = 0;
            ptb_AVT.TabStop = false;
            ptb_AVT.Click += ptb_AVT_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1345, 786);
            panel2.TabIndex = 22;
            // 
            // FrmSanPhamCT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1345, 922);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmSanPhamCT";
            Text = "FrmSanPhamCT";
            groupBox1.ResumeLayout(false);
            panelphai.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panelTrai.ResumeLayout(false);
            panelTrai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_QR).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_AVT).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panelphai;
        private Panel panelTrai;
        private Label label13;
        private TextBox txt_SLT;
        private TextBox txt_GiaNhap;
        private TextBox txt_GiaBan;
        private ComboBox cmb_Cl;
        private ComboBox cmb_Loai;
        private ComboBox cmb_MS;
        private ComboBox cmb_Size;
        private ComboBox cmb_TSP;
        private TextBox txt_Ma;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox ptb_QR;
        private PictureBox ptb_AVT;
        private Panel panel2;
        private RichTextBox txt_Mota;
        private Button btn_ChonAnh;
        private Label label7;
        private DataGridView dtg_ShowSanPham;
        private Label label11;
        private TextBox txt_TimKiem;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private GroupBox groupBox2;
        private Button btn_LamMoi;
        private Button btn_SaveQr;
        private RadioButton rdb_Con;
        private RadioButton rdb_Het;
        private Label label14;
        private ComboBox cmb_loctrangthai;
        private ComboBox cmb_Nsx;
        private Label label16;
    }
}