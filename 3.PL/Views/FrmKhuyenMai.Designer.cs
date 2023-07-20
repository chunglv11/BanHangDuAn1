namespace _3.PL.Views
{
    partial class FrmKhuyenMai
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
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            txt_TimKiem = new TextBox();
            label8 = new Label();
            dtp_Loc = new DateTimePicker();
            dtg_ShowKM = new DataGridView();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            btn_LamMoi = new Button();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            tb_SoTienGiam = new TextBox();
            label7 = new Label();
            dtp_NgayKT = new DateTimePicker();
            dtp_NgayBD = new DateTimePicker();
            tb_PhanTramGiam = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            rbtn_KHD = new RadioButton();
            rbtn_HD = new RadioButton();
            txt_Ten = new TextBox();
            txt_Ma = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowKM).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 605);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 343);
            panel4.Name = "panel4";
            panel4.Size = new Size(961, 262);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(txt_TimKiem);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(dtp_Loc);
            panel5.Controls.Add(dtg_ShowKM);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(961, 262);
            panel5.TabIndex = 16;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(16, 10);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.PlaceholderText = "Tìm kiếm...";
            txt_TimKiem.Size = new Size(247, 27);
            txt_TimKiem.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(349, 10);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 17;
            label8.Text = "Lọc theo ngày:";
            // 
            // dtp_Loc
            // 
            dtp_Loc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtp_Loc.Format = DateTimePickerFormat.Short;
            dtp_Loc.Location = new Point(484, 6);
            dtp_Loc.Name = "dtp_Loc";
            dtp_Loc.Size = new Size(274, 27);
            dtp_Loc.TabIndex = 17;
            // 
            // dtg_ShowKM
            // 
            dtg_ShowKM.BackgroundColor = SystemColors.ControlLight;
            dtg_ShowKM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ShowKM.Location = new Point(12, 54);
            dtg_ShowKM.Name = "dtg_ShowKM";
            dtg_ShowKM.RowHeadersWidth = 51;
            dtg_ShowKM.RowTemplate.Height = 29;
            dtg_ShowKM.Size = new Size(824, 196);
            dtg_ShowKM.TabIndex = 8;
            dtg_ShowKM.CellContentClick += dtg_ShowKM_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 235);
            panel3.Name = "panel3";
            panel3.Size = new Size(961, 108);
            panel3.TabIndex = 1;
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
            groupBox2.Size = new Size(961, 108);
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
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 235);
            panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_SoTienGiam);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtp_NgayKT);
            groupBox1.Controls.Add(dtp_NgayBD);
            groupBox1.Controls.Add(tb_PhanTramGiam);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(rbtn_KHD);
            groupBox1.Controls.Add(rbtn_HD);
            groupBox1.Controls.Add(txt_Ten);
            groupBox1.Controls.Add(txt_Ma);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(961, 235);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khuyến mại";
            // 
            // tb_SoTienGiam
            // 
            tb_SoTienGiam.Location = new Point(158, 177);
            tb_SoTienGiam.Name = "tb_SoTienGiam";
            tb_SoTienGiam.Size = new Size(250, 30);
            tb_SoTienGiam.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 177);
            label7.Name = "label7";
            label7.Size = new Size(110, 23);
            label7.TabIndex = 15;
            label7.Text = "Số tiền giảm:";
            // 
            // dtp_NgayKT
            // 
            dtp_NgayKT.Format = DateTimePickerFormat.Short;
            dtp_NgayKT.Location = new Point(644, 87);
            dtp_NgayKT.Name = "dtp_NgayKT";
            dtp_NgayKT.Size = new Size(274, 30);
            dtp_NgayKT.TabIndex = 14;
            // 
            // dtp_NgayBD
            // 
            dtp_NgayBD.Format = DateTimePickerFormat.Short;
            dtp_NgayBD.Location = new Point(644, 31);
            dtp_NgayBD.Name = "dtp_NgayBD";
            dtp_NgayBD.Size = new Size(274, 30);
            dtp_NgayBD.TabIndex = 13;
            // 
            // tb_PhanTramGiam
            // 
            tb_PhanTramGiam.Location = new Point(158, 128);
            tb_PhanTramGiam.Name = "tb_PhanTramGiam";
            tb_PhanTramGiam.Size = new Size(250, 30);
            tb_PhanTramGiam.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(518, 87);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 11;
            label6.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 38);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 10;
            label4.Text = "Ngày bắt đầu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 131);
            label5.Name = "label5";
            label5.Size = new Size(137, 23);
            label5.TabIndex = 9;
            label5.Text = "Phần trăm giảm:";
            // 
            // rbtn_KHD
            // 
            rbtn_KHD.AutoSize = true;
            rbtn_KHD.Location = new Point(764, 131);
            rbtn_KHD.Name = "rbtn_KHD";
            rbtn_KHD.Size = new Size(166, 27);
            rbtn_KHD.TabIndex = 8;
            rbtn_KHD.TabStop = true;
            rbtn_KHD.Text = "Không hoạt động";
            rbtn_KHD.UseVisualStyleBackColor = true;
            // 
            // rbtn_HD
            // 
            rbtn_HD.AutoSize = true;
            rbtn_HD.Location = new Point(644, 131);
            rbtn_HD.Name = "rbtn_HD";
            rbtn_HD.Size = new Size(114, 27);
            rbtn_HD.TabIndex = 7;
            rbtn_HD.TabStop = true;
            rbtn_HD.Text = "Hoạt động";
            rbtn_HD.UseVisualStyleBackColor = true;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(158, 83);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(250, 30);
            txt_Ten.TabIndex = 5;
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(159, 38);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(249, 30);
            txt_Ma.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 128);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 41);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 1;
            label2.Text = "Mã:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 87);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên:";
            // 
            // FrmKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(961, 605);
            Controls.Add(panel1);
            Name = "FrmKhuyenMai";
            Text = "FrmKhuyenMai";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ShowKM).EndInit();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox tb_PhanTramGiam;
        private Label label6;
        private Label label4;
        private Label label5;
        private RadioButton rbtn_KHD;
        private RadioButton rbtn_HD;
        private TextBox txt_Ten;
        private TextBox txt_Ma;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_SoTienGiam;
        private Label label7;
        private DateTimePicker dtp_NgayKT;
        private DateTimePicker dtp_NgayBD;
        private GroupBox groupBox2;
        private Button btn_LamMoi;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private Panel panel5;
        private DataGridView dtg_ShowKM;
        private Label label8;
        private DateTimePicker dtp_Loc;
        private TextBox txt_TimKiem;
    }
}