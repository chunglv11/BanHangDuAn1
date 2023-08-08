namespace _3.PL.Views
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            panelFil = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            Cbb_LocCV = new ComboBox();
            txt_TimKiem = new TextBox();
            dtg_ShowNV = new DataGridView();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            btn_LamMoi = new Button();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            rbn_KHD = new RadioButton();
            rbn_HD = new RadioButton();
            label6 = new Label();
            btn_ChonAnh = new Button();
            ptb_AVT = new PictureBox();
            label7 = new Label();
            tb_Ma = new TextBox();
            cmb_CV = new ComboBox();
            label12 = new Label();
            rbtn_Nu = new RadioButton();
            rbtn_Nam = new RadioButton();
            date_ngaySinh = new DateTimePicker();
            tb_MatKhau = new TextBox();
            tb_Email = new TextBox();
            txt_HoTen = new TextBox();
            tb_user = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelFil.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowNV).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_AVT).BeginInit();
            SuspendLayout();
            // 
            // panelFil
            // 
            panelFil.Controls.Add(panel3);
            panelFil.Controls.Add(panel2);
            panelFil.Controls.Add(panel1);
            panelFil.Dock = DockStyle.Fill;
            panelFil.Location = new Point(0, 0);
            panelFil.Name = "panelFil";
            panelFil.Size = new Size(1189, 678);
            panelFil.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(Cbb_LocCV);
            panel3.Controls.Add(txt_TimKiem);
            panel3.Controls.Add(dtg_ShowNV);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 380);
            panel3.Name = "panel3";
            panel3.Size = new Size(1189, 298);
            panel3.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(473, 10);
            label9.Name = "label9";
            label9.Size = new Size(146, 23);
            label9.TabIndex = 13;
            label9.Text = "Lọc theo chức vụ:";
            // 
            // Cbb_LocCV
            // 
            Cbb_LocCV.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbb_LocCV.FormattingEnabled = true;
            Cbb_LocCV.Location = new Point(674, 5);
            Cbb_LocCV.Name = "Cbb_LocCV";
            Cbb_LocCV.Size = new Size(151, 28);
            Cbb_LocCV.TabIndex = 14;
            Cbb_LocCV.SelectedIndexChanged += new System.EventHandler( Cbb_LocCV_SelectedIndexChanged);
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(25, 6);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.PlaceholderText = "Tìm kiếm...";
            txt_TimKiem.Size = new Size(247, 27);
            txt_TimKiem.TabIndex = 12;
            txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
            // 
            // dtg_ShowNV
            // 
            dtg_ShowNV.BackgroundColor = SystemColors.ControlLight;
            dtg_ShowNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ShowNV.Location = new Point(25, 53);
            dtg_ShowNV.Name = "dtg_ShowNV";
            dtg_ShowNV.RowHeadersWidth = 51;
            dtg_ShowNV.RowTemplate.Height = 29;
            dtg_ShowNV.Size = new Size(1097, 233);
            dtg_ShowNV.TabIndex = 0;
            dtg_ShowNV.CellClick += dtg_ShowNV_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(1189, 108);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_LamMoi);
            groupBox2.Controls.Add(btn_Xoa);
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1189, 108);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.Image = Properties.Resources.reset;
            btn_LamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_LamMoi.Location = new Point(600, 39);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(158, 42);
            btn_LamMoi.TabIndex = 3;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = true;
            btn_LamMoi.Click += btn_LamMoi_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Image = Properties.Resources.delete;
            btn_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Xoa.Location = new Point(405, 39);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(158, 42);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Image = Properties.Resources.updated;
            btn_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sua.Location = new Point(216, 39);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(158, 42);
            btn_Sua.TabIndex = 1;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.Image = Properties.Resources.add;
            btn_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Them.Location = new Point(30, 39);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(158, 42);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 272);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btn_ChonAnh);
            groupBox1.Controls.Add(ptb_AVT);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tb_Ma);
            groupBox1.Controls.Add(cmb_CV);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(rbtn_Nu);
            groupBox1.Controls.Add(rbtn_Nam);
            groupBox1.Controls.Add(date_ngaySinh);
            groupBox1.Controls.Add(tb_MatKhau);
            groupBox1.Controls.Add(tb_Email);
            groupBox1.Controls.Add(txt_HoTen);
            groupBox1.Controls.Add(tb_user);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1189, 272);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbn_KHD);
            groupBox3.Controls.Add(rbn_HD);
            groupBox3.Location = new Point(851, 171);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(309, 71);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            // 
            // rbn_KHD
            // 
            rbn_KHD.AutoSize = true;
            rbn_KHD.Location = new Point(128, 7);
            rbn_KHD.Name = "rbn_KHD";
            rbn_KHD.Size = new Size(171, 27);
            rbn_KHD.TabIndex = 22;
            rbn_KHD.TabStop = true;
            rbn_KHD.Text = "Không Hoạt Động";
            rbn_KHD.UseVisualStyleBackColor = true;
            // 
            // rbn_HD
            // 
            rbn_HD.AutoSize = true;
            rbn_HD.Location = new Point(6, 7);
            rbn_HD.Name = "rbn_HD";
            rbn_HD.Size = new Size(116, 27);
            rbn_HD.TabIndex = 21;
            rbn_HD.TabStop = true;
            rbn_HD.Text = "Hoạt Động";
            rbn_HD.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(748, 178);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 32;
            label6.Text = "Trạng thái:";
            // 
            // btn_ChonAnh
            // 
            btn_ChonAnh.Location = new Point(503, 190);
            btn_ChonAnh.Name = "btn_ChonAnh";
            btn_ChonAnh.Size = new Size(94, 29);
            btn_ChonAnh.TabIndex = 31;
            btn_ChonAnh.Text = "Chọn ảnh";
            btn_ChonAnh.UseVisualStyleBackColor = true;
            btn_ChonAnh.Click += btn_ChonAnh_Click;
            // 
            // ptb_AVT
            // 
            ptb_AVT.Image = (Image)resources.GetObject("ptb_AVT.Image");
            ptb_AVT.Location = new Point(437, 33);
            ptb_AVT.Name = "ptb_AVT";
            ptb_AVT.Size = new Size(233, 151);
            ptb_AVT.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_AVT.TabIndex = 30;
            ptb_AVT.TabStop = false;
            ptb_AVT.Click += ptb_AVT_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 36);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 29;
            label7.Text = "Mã NV:";
            // 
            // tb_Ma
            // 
            tb_Ma.Location = new Point(120, 33);
            tb_Ma.Name = "tb_Ma";
            tb_Ma.Size = new Size(226, 30);
            tb_Ma.TabIndex = 28;
            // 
            // cmb_CV
            // 
            cmb_CV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_CV.FormattingEnabled = true;
            cmb_CV.Location = new Point(851, 36);
            cmb_CV.Name = "cmb_CV";
            cmb_CV.Size = new Size(289, 31);
            cmb_CV.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(747, 36);
            label12.Name = "label12";
            label12.Size = new Size(78, 23);
            label12.TabIndex = 25;
            label12.Text = "Chức vụ:";
            // 
            // rbtn_Nu
            // 
            rbtn_Nu.AutoSize = true;
            rbtn_Nu.Location = new Point(222, 178);
            rbtn_Nu.Name = "rbtn_Nu";
            rbtn_Nu.Size = new Size(55, 27);
            rbtn_Nu.TabIndex = 21;
            rbtn_Nu.TabStop = true;
            rbtn_Nu.Text = "Nữ";
            rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nam
            // 
            rbtn_Nam.AutoSize = true;
            rbtn_Nam.Location = new Point(120, 178);
            rbtn_Nam.Name = "rbtn_Nam";
            rbtn_Nam.Size = new Size(68, 27);
            rbtn_Nam.TabIndex = 20;
            rbtn_Nam.TabStop = true;
            rbtn_Nam.Text = "Nam";
            rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // date_ngaySinh
            // 
            date_ngaySinh.Format = DateTimePickerFormat.Short;
            date_ngaySinh.Location = new Point(120, 134);
            date_ngaySinh.Name = "date_ngaySinh";
            date_ngaySinh.Size = new Size(226, 30);
            date_ngaySinh.TabIndex = 19;
            // 
            // tb_MatKhau
            // 
            tb_MatKhau.Location = new Point(851, 131);
            tb_MatKhau.Name = "tb_MatKhau";
            tb_MatKhau.Size = new Size(289, 30);
            tb_MatKhau.TabIndex = 17;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(118, 219);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(228, 30);
            tb_Email.TabIndex = 13;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(119, 81);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(227, 30);
            txt_HoTen.TabIndex = 12;
            // 
            // tb_user
            // 
            tb_user.Location = new Point(851, 81);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(289, 30);
            tb_user.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(748, 134);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 7;
            label8.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 219);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 178);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 3;
            label4.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 134);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 81);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 1;
            label2.Text = "Họ tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(748, 84);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1189, 678);
            Controls.Add(panelFil);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            panelFil.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowNV).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_AVT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFil;
        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox cmb_CV;
        private Label label12;
        private RadioButton rbtn_Nu;
        private DateTimePicker date_ngaySinh;
        private TextBox tb_MatKhau;
        private TextBox tb_Email;
        private TextBox txt_HoTen;
        private TextBox tb_user;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox tb_Ma;
        private PictureBox ptb_AVT;
        private Button btn_ChonAnh;
        private Label label6;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dtg_ShowNV;
        private GroupBox groupBox2;
        private Button btn_LamMoi;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private TextBox txt_TimKiem;
        private Label label9;
        private ComboBox Cbb_LocCV;
        private RadioButton rbtn_Nam;
        private GroupBox groupBox3;
        private RadioButton rbn_KHD;
        private RadioButton rbn_HD;
    }
}